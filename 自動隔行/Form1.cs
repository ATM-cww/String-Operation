using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 自動隔行
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            DialogResult result;
            if ((ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                if (MousePosition.X > SystemInformation.VirtualScreen.Width / 2)
                    result = DialogResult.No;
                else
                    result = DialogResult.Yes;
            }
            else
                result = MessageBox.Show("使用 Word ?", "選擇", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
                Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Office\Microsoft Office Word 2007.lnk" + result.ToString());
            if (result != DialogResult.No)
                Environment.Exit(0);

            InitializeComponent();
            addInterpolatedItem("$1");
            interpolated_KeysBox.DataSource = InterpolatedItems;
            interpolated_KeysBox.DisplayMember = "Key";

            foreach (var pair in new Dictionary<Control, Action<object, EventArgs>>()
            {
                { toNewLineButton, toNewLineButton_Click},
                { replaceButton, replaceButton_Click },
                { deletEmptyLinesButton, deletEmptyLinesButton_Click },
                { deletLineButton, deletLineButton_Click },
                { deletButton, deletButton_Click },
                { addIndexButton, addIndexButton_Click },
                { rebuildAsOneLineButton, rebuildAsOneLineButton_Click },
                { interpolated_GenerateButton, generateButton_Click },
                { rebuildModeButton, rebuildModeButton_Click }
            })
            {
                pair.Key.Click += saveText_Click;
                pair.Key.Click += new EventHandler(pair.Value);
                pair.Key.Click += boxFocus_Click;
            }
        }

        List<interpolatedItem> InterpolatedItems = new List<interpolatedItem>();
        class interpolatedItem
        {
            public string Key { get; set; }
            public List<string> Values { get; set; }
            public interpolatedItem(string key)
            {
                Key = key;
                Values = new List<string>();
            }
        }

        bool actionRecord = false;
        int interpolated_ValuesBox_SelectedIndex;

        string BoxText
        {
            get
            {
                if (textChange_selected.Checked)
                    return box.SelectedText;
                return box.Text;
            }
            set
            {
                if (textChange_selected.Checked)
                    box.Text = box.Text.Remove(box.SelectionStart, box.SelectionLength).Insert(box.SelectionStart, value);
                else
                    box.Text = value;
            }
        }
        string[] BoxLines
        {
            get
            {
                if (textChange_selected.Checked)
                    return box.SelectedText.Split('\n');
                return box.Lines;
            }
            set
            {
                if (textChange_selected.Checked)
                    box.Text = box.Text.Remove(box.SelectionStart, box.SelectionLength).Insert(box.SelectionStart, string.Join("\n", value));
                else
                    box.Lines = value;
            }
        }



        #region Functions
        void boxTextChangeAWhile(bool saveText)
        {
            if (!textFromPop && saveText && (undoList.Count == 0 || box.Text != undoList.Peek()))
            {
                undoList.Push(box.Text);
                redoList.Clear();
            }

            string s = box.TextLength.ToString();
            if (box.SelectionLength > 0)
                allTextLengthNumber.Text = $"{box.SelectionLength}/{s}";                // 1
            else
                allTextLengthNumber.Text = s;

            int index = box.GetFirstCharIndexOfCurrentLine();
            int line = box.GetLineFromCharIndex(index);                                 // 2     
            allTextLineCount.Text = $"{line + 1}/{box.Lines.Length}";

            int column = box.SelectionStart - index;                                    // 3
            int allColumnCount = box.Lines.Length > line ? box.Lines[line].Length : 0;  // 4
            allTextPosition.Text = $"{column}/{allColumnCount}";

            undoListCountLayout.Text = $"{undoList.Count}/{undoList.Count + redoList.Count}";
        }

        void addInterpolatedItem(string key)
        {
            InterpolatedItems.Add(new interpolatedItem(key));
            ((CurrencyManager)interpolated_KeysBox.BindingContext[InterpolatedItems]).Refresh();
        }

        void foreachLines(Func<string, string> line)
        {
            List<string> lines = new List<string>();
            foreach (var l in BoxLines)
            {
                string str = line(l);
                if (settingPage_emptyLineAutoRemove.Checked && string.IsNullOrEmpty(str))
                    continue;
                lines.Add(str);
            }
            BoxLines = lines.ToArray();
        }
        #endregion



        #region Algorithm Button

        private void toNewLineButton_Click(object sender, EventArgs e)
        {
            string add;
            if (newLineArg_t.Checked)
                add = "\t";
            else
                add = "\n";
            string[] all = string.IsNullOrEmpty(linesSeparate.Text) ? new string[] { interlaced.Text } : interlaced.Text.Split(Convert.ToChar(linesSeparate.Text));
            if (all.Length <= 1 && all[0] == "")
            {
                string text = "";
                foreach (string s in BoxLines)
                    text += s + add;
                BoxText = text;
            }
            else
                foreach (string s in all)
                    BoxText = BoxText.Replace(s, add);
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            string replaceIn = this.replaceIn.Text.Replace("\\n", "\n").Replace("\\t", "\t");
            string[] all = string.IsNullOrEmpty(replaceSeparate.Text) ? new string[] { replaceIn } : replaceIn.Split(Convert.ToChar(replaceSeparate.Text));
            if (replaceIn.Length <= 0)
            {
                List<string> lines = new List<string>();
                foreach (string line in BoxLines)
                {
                    if (everyLineCheckBox.Checked)
                        lines.Add(replaceOut.Text.Replace(' ', ' ') + line);
                    else
                        lines.Add(string.Join(replaceOut.Text, line.ToArray()));
                }
                BoxLines = lines.ToArray();
            }
            else if (everyLineCheckBox.Checked)
            {
                List<string> replaced = new List<string>();
                for (int i = 0; i < BoxLines.Length; i++)
                {
                    if (BoxLines[i].Contains(replaceIn))
                    {
                        int index = BoxLines[i].IndexOf(replaceIn);
                        replaced.Add(BoxLines[i].Remove(index, replaceIn.Length).Insert(index, replaceOut.Text));
                        continue;
                    }
                    else
                        replaced.Add(BoxLines[i]);
                }
                BoxLines = replaced.ToArray();
            }
            else
                foreach (string s in all)
                    BoxText = BoxText.Replace(s, replaceOut.Text);
        }

        private void deletEmptyLinesButton_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>(BoxLines);
            foreach (string line in BoxLines.ToList())
                if (string.IsNullOrEmpty(line))
                    lines.Remove(line);
            BoxLines = lines.ToArray();

        }

        private void deletLineButton_Click(object sender, EventArgs e) => BoxLines = BoxLines.Select(s => s.Contains(deletStartString.Text) ? "" : s).ToArray();

        private void deletButton_Click(object sender, EventArgs e)
        {
            switch (deletSubPage.SelectedIndex)
            {
                case 0:
                    foreachLines(l => l.Length >= deletStartIndex.Value + deletCount.Value ?
                        l.Remove((int)deletStartIndex.Value, (int)deletCount.Value) : "");
                    break;
                case 1:
                    foreachLines(l => l.Remove(0, (int)deletFromIndexToEndPage_startIndex.Value).StartsWith(
                        deletFromIndexToEndPage_starting.Text) ? "" : l);
                    break;
                case 2:
                    int deletEndIndex = -1;
                    try
                    {
                        deletEndIndex = Convert.ToInt32(deletEndString.Text);
                    }
                    catch
                    {
                        if (deletEndStringSelection_Index.Checked)
                        {
                            MessageBox.Show("您輸入的數字不能轉換為 Index", "輸入錯誤");
                            return;
                        }
                    }
                    foreachLines(l =>
                    {
                        int start = l.IndexOf(deletStartString.Text);
                        if (start < 0)
                            return l;

                        if (deletEndStringSelection_String.Checked)
                            return l.Remove(start, l.LastIndexOf(deletEndString.Text));
                        else if (deletEndStringSelection_Index.Checked)
                            return l.Remove(start, start + deletEndIndex);
                        else if (deletEndStringSelection_ToEnd.Checked)
                            return l.Remove(start);
                        return "";
                    });
                    break;
                case 3:
                    List<string> lines = new List<string>();
                    if (deletRepeatItem_eachLine.Checked)
                        foreach (string line in BoxLines)
                        {
                            if (lines.Contains(line))
                                continue;
                            lines.Add(line);
                        }
                    else if (deletRepeatItem_eachWord.Checked)
                        foreach (string line in BoxLines)
                            foreach (char c in line)
                            {
                                if (lines.Contains(c.ToString()))
                                    continue;
                                lines.Add(c.ToString());
                            }
                    BoxLines = lines.ToArray();
                    break;
            }
        }

        private void addIndexButton_Click(object sender, EventArgs e)
        {
            string[] boxLines = BoxLines;
            int index = (int)addIndex_startFrom.Value;
            for (int i = 0; i < boxLines.Length; i++, index++)
                boxLines[i] = $"{addIndex_frontString.Text}{(usingIndex.Checked ? index.ToString() : "")}{addIndex_rearString.Text}{boxLines[i]}";
            BoxLines = boxLines;
        }

        private void rebuildModeButton_Click(object sender, EventArgs e)
        {
            usingIndex.Checked = false;
            addIndex_rearString.Text = ", ";
        }

        private void rebuildAsOneLineButton_Click(object sender, EventArgs e) => BoxLines = new string[] { string.Join("", BoxLines) };

        private void generateButton_Click(object sender, EventArgs e)
        {
            interpolated_KeysBox_SelectedIndexChanged(null, null);
            BoxText = "";
            var lines = new List<string>();
            var items = new List<interpolatedItem>(InterpolatedItems);
            items.Sort((x, y) => x.Values.Count.CompareTo(y.Values.Count));
            for (int valuesIndex = 0; valuesIndex < items[0].Values.Count; valuesIndex++)
            {
                string format = interpolated_Format.Text;
                for (int keyIndex = 0; keyIndex < items.Count; keyIndex++)
                    if (format.Contains(InterpolatedItems[keyIndex].Key))
                        format = format.Replace(InterpolatedItems[keyIndex].Key, InterpolatedItems[keyIndex].Values[valuesIndex]);
                lines.Add(format);
            }
            BoxLines = lines.ToArray();
        }

        void actionRecord_InputChanged<T>(object sender)
        {
            T obj = (T)sender;
        }

        #endregion



        #region Form

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && box.Focused)
            {
                if (e.KeyCode == Keys.Oemplus)
                    box.Font = new Font(box.Font.FontFamily, box.Font.Size + 1);
                if (e.KeyCode == Keys.OemMinus)
                    box.Font = new Font(box.Font.FontFamily, box.Font.Size - 1);
                if (e.KeyCode == Keys.Q && string.IsNullOrEmpty(box.SelectedText))
                {
                    int charIndex = box.GetFirstCharIndexOfCurrentLine();
                    var lines = BoxLines.ToList();
                    lines.RemoveAt(box.GetLineFromCharIndex(charIndex));
                    BoxLines = lines.ToArray();

                    if (charIndex > box.TextLength)
                        box.Select(box.TextLength, 0);
                    else
                        box.Select(charIndex, 0);
                    box.Select();
                }
            }
            switch (e.KeyCode)
            {
                case Keys.F1:
                    Process.Start(Environment.CurrentDirectory);
                    break;
                case Keys.F7:
                    List<Type> allInputClass = new List<Type>
                    {
                        typeof(CheckBox),
                        typeof(ListBox),
                        typeof(TextBox),
                        typeof(RadioButton),
                        typeof(MaskedTextBox),
                        typeof(Guna.UI2.WinForms.Guna2TextBox),
                        typeof(Guna.UI2.WinForms.Guna2NumericUpDown),
                    };
                    statusStrip.BackColor = (actionRecord = !actionRecord) ? Color.LightSalmon : SystemColors.Control;

                    break;
                case Keys.S when e.Control:
                    save();
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!lockForm.Checked)
                return;
            e.Cancel = true;
            switch (MessageBox.Show("視窗已被鎖定，是否解除鎖定？\n\n按 <否> 將會自動儲存内容", "視窗關閉中", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes:
                    lockForm.Checked = false;
                    break;
                case DialogResult.No:
                    save();
                    break;
            }
        }

        void save()
        {
            string path = $"自動儲存 [{box.Lines[0]}].txt";
            using (StreamWriter writer = new StreamWriter(path))
                writer.Write(box.Text);
            if (MessageBox.Show($"資料已成功儲存於\n{path}\n\n是否開啓？", "資料儲存", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Process.Start(path);
        }

        #endregion



        #region Form Control 

        private void everyLineCheckBox_CheckedChanged(object sender, EventArgs e) => replaceSeparate.Enabled = !everyLineCheckBox.Checked;

        private void deletEndStringSelection_ToEnd_CheckedChanged(object sender, EventArgs e)
        {
            deletEndString.Enabled = !deletEndStringSelection_ToEnd.Checked;
        }

        private void interpolated_KeysBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete when
                interpolated_KeysBox.SelectedIndex > 0 &&
                MessageBox.Show("確認刪除", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK:
                    interpolated_KeysBox.Items.RemoveAt(interpolated_KeysBox.SelectedIndex);
                    break;
                /**
            case (Keys)187 when (ModifierKeys & Keys.Shift) == Keys.Shift:
            case (Keys)107:
                //InterpolatedItems.Add(new interpolatedItem())
                break;
            case Keys.Enter:

                break;
                */
                case Keys.C when (ModifierKeys & Keys.Control) == Keys.Control:
                    Clipboard.SetText(InterpolatedItems[interpolated_KeysBox.SelectedIndex].Key);
                    break;
            }
        }

        private void interpolated_KeysBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InterpolatedItems[interpolated_ValuesBox_SelectedIndex].Values = interpolated_ValuesBox.Lines.ToList();
            interpolated_ValuesBox.Lines = InterpolatedItems[interpolated_ValuesBox_SelectedIndex = interpolated_KeysBox.SelectedIndex].Values.ToArray();
        }


        #region box

        Stack<string> undoList = new Stack<string>();
        Stack<string> redoList = new Stack<string>();
        bool shouldSaveText = false, textFromPop = false;
        int saveTextAccumulation = 1;

        private void box_KeyDown(object sender, KeyEventArgs e)
        {
            textFromPop = false;
            if (!e.Control || !(e.KeyCode == Keys.Z || e.KeyCode == Keys.Y))
                return;

            int boxSelection = box.SelectionStart;
            if (e.KeyCode == Keys.Z && undoList.Count > 0)
            {
                string popped;
                do
                {
                    popped = undoList.Pop();
                    redoList.Push(popped);
                } while (popped == box.Text && undoList.Count > 0);
                box.Text = popped;
                textFromPop = true;
            }
            else if (e.KeyCode == Keys.Y && redoList.Count > 0)
            {
                string popped;
                do
                {
                    popped = redoList.Pop();
                    undoList.Push(popped);
                } while (popped == box.Text && redoList.Count > 0);
                box.Text = popped;
                textFromPop = true;
            }
            box.Select(boxSelection, 0);
            box.Select();
        }

        private void saveText_Click(object sender, EventArgs e)
        {
            boxTextChangeAWhile(true);
            boxTextChangeTimer.Enabled = false;
        }

        private void boxFocus_Click(object sender, EventArgs e)
        {
            box.Focus();
            boxTextChangeTimer.Enabled = true;
        }

        private void box_TextChanged(object sender, EventArgs e) => shouldSaveText = true;

        private void boxMenu_ToUpper_Click(object sender, EventArgs e) => box.SelectedText = box.SelectedText.ToUpper();

        private void boxMenu_ToLower_Click(object sender, EventArgs e) => box.SelectedText = box.SelectedText.ToLower();

        private void lockForm_Click(object sender, EventArgs e) => lockForm.Checked = !lockForm.Checked;

        private void interpolated_KeysBox_DragDrop(object sender, DragEventArgs e) => addInterpolatedItem(e.Data.GetData(DataFormats.Text).ToString());

        private void interpolated_KeysBox_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.All;

        private void boxTextChangeTimer_Tick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                return;
            if (shouldSaveText && saveTextAccumulation >= 25)
            {
                boxTextChangeAWhile(true);
                shouldSaveText = false;
                saveTextAccumulation = 0;
            }
            boxTextChangeAWhile(saveTextAccumulation == 0);
            if (saveTextAccumulation < 100000)
                saveTextAccumulation++;
        }

        #endregion

        #endregion
    }
}
