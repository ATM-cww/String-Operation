namespace 自動隔行
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.everyLineCheckBox = new System.Windows.Forms.CheckBox();
            this.linesSeparate = new System.Windows.Forms.MaskedTextBox();
            this.replaceSeparate = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toNewLinePage = new System.Windows.Forms.TabPage();
            this.newLineArg_t = new System.Windows.Forms.RadioButton();
            this.newLineArg_n = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.interlaced = new Guna.UI2.WinForms.Guna2TextBox();
            this.toNewLineButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.replacePage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.replaceButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.replaceOut = new Guna.UI2.WinForms.Guna2TextBox();
            this.replaceIn = new Guna.UI2.WinForms.Guna2TextBox();
            this.deletPage = new System.Windows.Forms.TabPage();
            this.rebuildAsOneLineButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.deletLineButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.deletButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.deletEmptyLinesButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.deletSubPage = new System.Windows.Forms.TabControl();
            this.deletFromIndexPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.deletCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.deletStartIndex = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deletFromIndexToEndPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.deletFromIndexToEndPage_startIndex = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.deletFromIndexToEndPage_starting = new System.Windows.Forms.TextBox();
            this.deletFormStringPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deletEndStringSelection_ToEnd = new System.Windows.Forms.RadioButton();
            this.deletStartString = new System.Windows.Forms.TextBox();
            this.deletEndStringSelection_Index = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.deletEndStringSelection_String = new System.Windows.Forms.RadioButton();
            this.deletEndString = new System.Windows.Forms.TextBox();
            this.deletRepeatItemPage = new System.Windows.Forms.TabPage();
            this.deletRepeatItem_eachWord = new System.Windows.Forms.RadioButton();
            this.deletRepeatItem_eachLine = new System.Windows.Forms.RadioButton();
            this.addIndexPage = new System.Windows.Forms.TabPage();
            this.rebuildModeButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label11 = new System.Windows.Forms.Label();
            this.addIndex_frontString = new Guna.UI2.WinForms.Guna2TextBox();
            this.usingIndex = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addIndex_rearString = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addIndex_startFrom = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.addIndexButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.interpolatedPage = new System.Windows.Forms.TabPage();
            this.interpolated_GenerateButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.interpolated_Format = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.interpolated_ValuesBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.interpolated_KeysBox = new System.Windows.Forms.ListBox();
            this.settingPage = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.settingPage_emptyLineAutoRemove = new System.Windows.Forms.CheckBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.allTextLengthNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.allTextLineCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.allTextPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.undoListCountLayout = new System.Windows.Forms.ToolStripStatusLabel();
            this.box = new System.Windows.Forms.RichTextBox();
            this.boxMenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.boxMenu_ToUpper = new System.Windows.Forms.ToolStripMenuItem();
            this.boxMenu_ToLower = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lockForm = new System.Windows.Forms.ToolStripMenuItem();
            this.boxTextChangeTimer = new System.Windows.Forms.Timer(this.components);
            this.textChange_selected = new Guna.UI2.WinForms.Guna2RadioButton();
            this.textChange_all = new Guna.UI2.WinForms.Guna2RadioButton();
            this.tabControl1.SuspendLayout();
            this.toNewLinePage.SuspendLayout();
            this.replacePage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.deletPage.SuspendLayout();
            this.deletSubPage.SuspendLayout();
            this.deletFromIndexPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletStartIndex)).BeginInit();
            this.deletFromIndexToEndPage.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletFromIndexToEndPage_startIndex)).BeginInit();
            this.deletFormStringPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.deletRepeatItemPage.SuspendLayout();
            this.addIndexPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addIndex_startFrom)).BeginInit();
            this.interpolatedPage.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.settingPage.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.boxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.label4.Location = new System.Drawing.Point(3, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 72);
            this.label4.TabIndex = 5;
            this.label4.Text = "取代 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // everyLineCheckBox
            // 
            this.everyLineCheckBox.AutoSize = true;
            this.everyLineCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.everyLineCheckBox.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.everyLineCheckBox.Location = new System.Drawing.Point(3, 4);
            this.everyLineCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.everyLineCheckBox.Name = "everyLineCheckBox";
            this.everyLineCheckBox.Size = new System.Drawing.Size(106, 63);
            this.everyLineCheckBox.TabIndex = 9;
            this.everyLineCheckBox.Text = "每一行一次";
            this.everyLineCheckBox.UseVisualStyleBackColor = true;
            this.everyLineCheckBox.CheckedChanged += new System.EventHandler(this.everyLineCheckBox_CheckedChanged);
            // 
            // linesSeparate
            // 
            this.linesSeparate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linesSeparate.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.linesSeparate.Location = new System.Drawing.Point(895, 8);
            this.linesSeparate.Margin = new System.Windows.Forms.Padding(17, 4, 3, 4);
            this.linesSeparate.Mask = "C";
            this.linesSeparate.Name = "linesSeparate";
            this.linesSeparate.Size = new System.Drawing.Size(38, 47);
            this.linesSeparate.TabIndex = 13;
            // 
            // replaceSeparate
            // 
            this.replaceSeparate.Dock = System.Windows.Forms.DockStyle.Right;
            this.replaceSeparate.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.replaceSeparate.Location = new System.Drawing.Point(888, 4);
            this.replaceSeparate.Margin = new System.Windows.Forms.Padding(25, 4, 3, 4);
            this.replaceSeparate.Mask = "C";
            this.replaceSeparate.Name = "replaceSeparate";
            this.replaceSeparate.Size = new System.Drawing.Size(38, 47);
            this.replaceSeparate.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.toNewLinePage);
            this.tabControl1.Controls.Add(this.replacePage);
            this.tabControl1.Controls.Add(this.deletPage);
            this.tabControl1.Controls.Add(this.addIndexPage);
            this.tabControl1.Controls.Add(this.interpolatedPage);
            this.tabControl1.Controls.Add(this.settingPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 15, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(943, 196);
            this.tabControl1.TabIndex = 16;
            // 
            // toNewLinePage
            // 
            this.toNewLinePage.Controls.Add(this.newLineArg_t);
            this.toNewLinePage.Controls.Add(this.newLineArg_n);
            this.toNewLinePage.Controls.Add(this.label9);
            this.toNewLinePage.Controls.Add(this.interlaced);
            this.toNewLinePage.Controls.Add(this.toNewLineButton);
            this.toNewLinePage.Controls.Add(this.linesSeparate);
            this.toNewLinePage.Location = new System.Drawing.Point(4, 41);
            this.toNewLinePage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toNewLinePage.Name = "toNewLinePage";
            this.toNewLinePage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toNewLinePage.Size = new System.Drawing.Size(935, 151);
            this.toNewLinePage.TabIndex = 0;
            this.toNewLinePage.Text = "隔行";
            this.toNewLinePage.UseVisualStyleBackColor = true;
            // 
            // newLineArg_t
            // 
            this.newLineArg_t.AutoSize = true;
            this.newLineArg_t.Location = new System.Drawing.Point(379, 86);
            this.newLineArg_t.Name = "newLineArg_t";
            this.newLineArg_t.Size = new System.Drawing.Size(53, 34);
            this.newLineArg_t.TabIndex = 19;
            this.newLineArg_t.Text = "\\t";
            this.newLineArg_t.UseVisualStyleBackColor = true;
            // 
            // newLineArg_n
            // 
            this.newLineArg_n.AutoSize = true;
            this.newLineArg_n.Checked = true;
            this.newLineArg_n.Location = new System.Drawing.Point(288, 86);
            this.newLineArg_n.Name = "newLineArg_n";
            this.newLineArg_n.Size = new System.Drawing.Size(59, 34);
            this.newLineArg_n.TabIndex = 18;
            this.newLineArg_n.TabStop = true;
            this.newLineArg_n.Text = "\\n";
            this.newLineArg_n.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 30);
            this.label9.TabIndex = 17;
            this.label9.Text = "新行：";
            // 
            // interlaced
            // 
            this.interlaced.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interlaced.BorderRadius = 22;
            this.interlaced.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.interlaced.DefaultText = "";
            this.interlaced.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.interlaced.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.interlaced.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.interlaced.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.interlaced.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.interlaced.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interlaced.ForeColor = System.Drawing.Color.Black;
            this.interlaced.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.interlaced.Location = new System.Drawing.Point(8, 7);
            this.interlaced.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.interlaced.Name = "interlaced";
            this.interlaced.PasswordChar = '\0';
            this.interlaced.PlaceholderText = "";
            this.interlaced.SelectedText = "";
            this.interlaced.Size = new System.Drawing.Size(867, 45);
            this.interlaced.TabIndex = 16;
            // 
            // toNewLineButton
            // 
            this.toNewLineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toNewLineButton.Animated = true;
            this.toNewLineButton.BorderRadius = 25;
            this.toNewLineButton.Font = new System.Drawing.Font("Microsoft JhengHei", 14F);
            this.toNewLineButton.ForeColor = System.Drawing.Color.White;
            this.toNewLineButton.Location = new System.Drawing.Point(709, 88);
            this.toNewLineButton.Name = "toNewLineButton";
            this.toNewLineButton.Size = new System.Drawing.Size(220, 50);
            this.toNewLineButton.TabIndex = 15;
            this.toNewLineButton.Text = "分爲新行";
            // 
            // replacePage
            // 
            this.replacePage.Controls.Add(this.tableLayoutPanel2);
            this.replacePage.Location = new System.Drawing.Point(4, 41);
            this.replacePage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.replacePage.Name = "replacePage";
            this.replacePage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.replacePage.Size = new System.Drawing.Size(935, 151);
            this.replacePage.TabIndex = 1;
            this.replacePage.Text = "取代";
            this.replacePage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.replaceButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.replaceOut, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.replaceIn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.everyLineCheckBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.replaceSeparate, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(929, 143);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // replaceButton
            // 
            this.replaceButton.Animated = true;
            this.replaceButton.BorderRadius = 22;
            this.replaceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replaceButton.Font = new System.Drawing.Font("Microsoft JhengHei", 16F);
            this.replaceButton.ForeColor = System.Drawing.Color.White;
            this.replaceButton.Location = new System.Drawing.Point(734, 86);
            this.replaceButton.Margin = new System.Windows.Forms.Padding(15);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(180, 42);
            this.replaceButton.TabIndex = 19;
            this.replaceButton.Text = "取代";
            // 
            // replaceOut
            // 
            this.replaceOut.BorderRadius = 21;
            this.replaceOut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.replaceOut.DefaultText = "";
            this.replaceOut.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.replaceOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.replaceOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.replaceOut.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.replaceOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replaceOut.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.replaceOut.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceOut.ForeColor = System.Drawing.Color.Black;
            this.replaceOut.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.replaceOut.Location = new System.Drawing.Point(132, 86);
            this.replaceOut.Margin = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.replaceOut.Name = "replaceOut";
            this.replaceOut.PasswordChar = '\0';
            this.replaceOut.PlaceholderText = "";
            this.replaceOut.SelectedText = "";
            this.replaceOut.Size = new System.Drawing.Size(567, 42);
            this.replaceOut.TabIndex = 16;
            // 
            // replaceIn
            // 
            this.replaceIn.BorderRadius = 21;
            this.replaceIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.replaceIn.DefaultText = "";
            this.replaceIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.replaceIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.replaceIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.replaceIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.replaceIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replaceIn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.replaceIn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceIn.ForeColor = System.Drawing.Color.Black;
            this.replaceIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.replaceIn.Location = new System.Drawing.Point(132, 15);
            this.replaceIn.Margin = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.replaceIn.Name = "replaceIn";
            this.replaceIn.PasswordChar = '\0';
            this.replaceIn.PlaceholderText = "";
            this.replaceIn.SelectedText = "";
            this.replaceIn.Size = new System.Drawing.Size(567, 41);
            this.replaceIn.TabIndex = 0;
            // 
            // deletPage
            // 
            this.deletPage.Controls.Add(this.rebuildAsOneLineButton);
            this.deletPage.Controls.Add(this.deletLineButton);
            this.deletPage.Controls.Add(this.deletButton);
            this.deletPage.Controls.Add(this.deletEmptyLinesButton);
            this.deletPage.Controls.Add(this.deletSubPage);
            this.deletPage.Location = new System.Drawing.Point(4, 41);
            this.deletPage.Name = "deletPage";
            this.deletPage.Padding = new System.Windows.Forms.Padding(3);
            this.deletPage.Size = new System.Drawing.Size(935, 151);
            this.deletPage.TabIndex = 2;
            this.deletPage.Text = "刪除";
            this.deletPage.UseVisualStyleBackColor = true;
            // 
            // rebuildAsOneLineButton
            // 
            this.rebuildAsOneLineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rebuildAsOneLineButton.Animated = true;
            this.rebuildAsOneLineButton.BorderRadius = 25;
            this.rebuildAsOneLineButton.Font = new System.Drawing.Font("Microsoft JhengHei", 16F);
            this.rebuildAsOneLineButton.ForeColor = System.Drawing.Color.White;
            this.rebuildAsOneLineButton.Location = new System.Drawing.Point(229, 92);
            this.rebuildAsOneLineButton.Name = "rebuildAsOneLineButton";
            this.rebuildAsOneLineButton.Size = new System.Drawing.Size(220, 50);
            this.rebuildAsOneLineButton.TabIndex = 21;
            this.rebuildAsOneLineButton.Text = "重整為一列";
            // 
            // deletLineButton
            // 
            this.deletLineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletLineButton.Animated = true;
            this.deletLineButton.BorderRadius = 25;
            this.deletLineButton.Font = new System.Drawing.Font("Microsoft JhengHei", 16F);
            this.deletLineButton.ForeColor = System.Drawing.Color.White;
            this.deletLineButton.Location = new System.Drawing.Point(486, 92);
            this.deletLineButton.Name = "deletLineButton";
            this.deletLineButton.Size = new System.Drawing.Size(220, 50);
            this.deletLineButton.TabIndex = 20;
            this.deletLineButton.Text = "移除整行";
            // 
            // deletButton
            // 
            this.deletButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletButton.Animated = true;
            this.deletButton.BorderRadius = 25;
            this.deletButton.Font = new System.Drawing.Font("Microsoft JhengHei", 16F);
            this.deletButton.ForeColor = System.Drawing.Color.White;
            this.deletButton.Location = new System.Drawing.Point(712, 92);
            this.deletButton.Name = "deletButton";
            this.deletButton.Size = new System.Drawing.Size(220, 50);
            this.deletButton.TabIndex = 19;
            this.deletButton.Text = "刪除";
            // 
            // deletEmptyLinesButton
            // 
            this.deletEmptyLinesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deletEmptyLinesButton.Animated = true;
            this.deletEmptyLinesButton.BorderRadius = 25;
            this.deletEmptyLinesButton.Font = new System.Drawing.Font("Microsoft JhengHei", 16F);
            this.deletEmptyLinesButton.ForeColor = System.Drawing.Color.White;
            this.deletEmptyLinesButton.Location = new System.Drawing.Point(3, 92);
            this.deletEmptyLinesButton.Name = "deletEmptyLinesButton";
            this.deletEmptyLinesButton.Size = new System.Drawing.Size(220, 50);
            this.deletEmptyLinesButton.TabIndex = 11;
            this.deletEmptyLinesButton.Text = "移除空行";
            // 
            // deletSubPage
            // 
            this.deletSubPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deletSubPage.Controls.Add(this.deletFromIndexPage);
            this.deletSubPage.Controls.Add(this.deletFromIndexToEndPage);
            this.deletSubPage.Controls.Add(this.deletFormStringPage);
            this.deletSubPage.Controls.Add(this.deletRepeatItemPage);
            this.deletSubPage.Location = new System.Drawing.Point(6, -4);
            this.deletSubPage.Name = "deletSubPage";
            this.deletSubPage.SelectedIndex = 0;
            this.deletSubPage.Size = new System.Drawing.Size(921, 86);
            this.deletSubPage.TabIndex = 18;
            // 
            // deletFromIndexPage
            // 
            this.deletFromIndexPage.Controls.Add(this.tableLayoutPanel3);
            this.deletFromIndexPage.Location = new System.Drawing.Point(4, 38);
            this.deletFromIndexPage.Name = "deletFromIndexPage";
            this.deletFromIndexPage.Padding = new System.Windows.Forms.Padding(3);
            this.deletFromIndexPage.Size = new System.Drawing.Size(913, 44);
            this.deletFromIndexPage.TabIndex = 0;
            this.deletFromIndexPage.Text = "從 Index";
            this.deletFromIndexPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.deletCount, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.deletStartIndex, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(907, 38);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // deletCount
            // 
            this.deletCount.BackColor = System.Drawing.Color.Transparent;
            this.deletCount.BorderRadius = 16;
            this.deletCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.deletCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.deletCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.deletCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.deletCount.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.deletCount.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.deletCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.deletCount.Font = new System.Drawing.Font("Microsoft JhengHei", 14F);
            this.deletCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.deletCount.Location = new System.Drawing.Point(606, 5);
            this.deletCount.Margin = new System.Windows.Forms.Padding(10, 5, 10, 4);
            this.deletCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.deletCount.Name = "deletCount";
            this.deletCount.Size = new System.Drawing.Size(243, 29);
            this.deletCount.TabIndex = 17;
            this.deletCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // deletStartIndex
            // 
            this.deletStartIndex.BackColor = System.Drawing.Color.Transparent;
            this.deletStartIndex.BorderRadius = 16;
            this.deletStartIndex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.deletStartIndex.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.deletStartIndex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.deletStartIndex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.deletStartIndex.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.deletStartIndex.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.deletStartIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletStartIndex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.deletStartIndex.Font = new System.Drawing.Font("Microsoft JhengHei", 14F);
            this.deletStartIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.deletStartIndex.Location = new System.Drawing.Point(112, 5);
            this.deletStartIndex.Margin = new System.Windows.Forms.Padding(10, 5, 10, 4);
            this.deletStartIndex.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.deletStartIndex.Name = "deletStartIndex";
            this.deletStartIndex.Size = new System.Drawing.Size(243, 29);
            this.deletStartIndex.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 16F);
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "從每行";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 16F);
            this.label3.Location = new System.Drawing.Point(862, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "個";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 16F);
            this.label2.Location = new System.Drawing.Point(368, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "index 開始，刪除";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deletFromIndexToEndPage
            // 
            this.deletFromIndexToEndPage.Controls.Add(this.tableLayoutPanel5);
            this.deletFromIndexToEndPage.Location = new System.Drawing.Point(4, 38);
            this.deletFromIndexToEndPage.Name = "deletFromIndexToEndPage";
            this.deletFromIndexToEndPage.Padding = new System.Windows.Forms.Padding(3);
            this.deletFromIndexToEndPage.Size = new System.Drawing.Size(913, 44);
            this.deletFromIndexToEndPage.TabIndex = 3;
            this.deletFromIndexToEndPage.Text = "從 Index 到 End";
            this.deletFromIndexToEndPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.label14, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.deletFromIndexToEndPage_startIndex, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.deletFromIndexToEndPage_starting, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(907, 38);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei", 16F);
            this.label14.Location = new System.Drawing.Point(753, 5);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 33);
            this.label14.TabIndex = 17;
            this.label14.Text = "開始的整行";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei", 16F);
            this.label13.Location = new System.Drawing.Point(230, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(225, 33);
            this.label13.TabIndex = 15;
            this.label13.Text = "index 起，刪除從";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deletFromIndexToEndPage_startIndex
            // 
            this.deletFromIndexToEndPage_startIndex.BackColor = System.Drawing.Color.Transparent;
            this.deletFromIndexToEndPage_startIndex.BorderRadius = 16;
            this.deletFromIndexToEndPage_startIndex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.deletFromIndexToEndPage_startIndex.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.deletFromIndexToEndPage_startIndex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.deletFromIndexToEndPage_startIndex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.deletFromIndexToEndPage_startIndex.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.deletFromIndexToEndPage_startIndex.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.deletFromIndexToEndPage_startIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletFromIndexToEndPage_startIndex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.deletFromIndexToEndPage_startIndex.Font = new System.Drawing.Font("Microsoft JhengHei", 14F);
            this.deletFromIndexToEndPage_startIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.deletFromIndexToEndPage_startIndex.Location = new System.Drawing.Point(112, 5);
            this.deletFromIndexToEndPage_startIndex.Margin = new System.Windows.Forms.Padding(10, 5, 10, 4);
            this.deletFromIndexToEndPage_startIndex.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.deletFromIndexToEndPage_startIndex.Name = "deletFromIndexToEndPage_startIndex";
            this.deletFromIndexToEndPage_startIndex.Size = new System.Drawing.Size(105, 29);
            this.deletFromIndexToEndPage_startIndex.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei", 16F);
            this.label12.Location = new System.Drawing.Point(3, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 33);
            this.label12.TabIndex = 13;
            this.label12.Text = "從每行";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deletFromIndexToEndPage_starting
            // 
            this.deletFromIndexToEndPage_starting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletFromIndexToEndPage_starting.Location = new System.Drawing.Point(461, 3);
            this.deletFromIndexToEndPage_starting.Name = "deletFromIndexToEndPage_starting";
            this.deletFromIndexToEndPage_starting.Size = new System.Drawing.Size(286, 39);
            this.deletFromIndexToEndPage_starting.TabIndex = 16;
            // 
            // deletFormStringPage
            // 
            this.deletFormStringPage.Controls.Add(this.tableLayoutPanel1);
            this.deletFormStringPage.Location = new System.Drawing.Point(4, 38);
            this.deletFormStringPage.Name = "deletFormStringPage";
            this.deletFormStringPage.Padding = new System.Windows.Forms.Padding(3);
            this.deletFormStringPage.Size = new System.Drawing.Size(913, 44);
            this.deletFormStringPage.TabIndex = 1;
            this.deletFormStringPage.Text = "從 String";
            this.deletFormStringPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.deletEndStringSelection_ToEnd, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.deletStartString, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deletEndStringSelection_Index, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.deletEndStringSelection_String, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.deletEndString, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 38);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // deletEndStringSelection_ToEnd
            // 
            this.deletEndStringSelection_ToEnd.AutoSize = true;
            this.deletEndStringSelection_ToEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletEndStringSelection_ToEnd.Font = new System.Drawing.Font("Microsoft JhengHei", 12F);
            this.deletEndStringSelection_ToEnd.Location = new System.Drawing.Point(805, 3);
            this.deletEndStringSelection_ToEnd.Name = "deletEndStringSelection_ToEnd";
            this.deletEndStringSelection_ToEnd.Size = new System.Drawing.Size(99, 32);
            this.deletEndStringSelection_ToEnd.TabIndex = 5;
            this.deletEndStringSelection_ToEnd.Text = "To End";
            this.deletEndStringSelection_ToEnd.UseVisualStyleBackColor = true;
            this.deletEndStringSelection_ToEnd.CheckedChanged += new System.EventHandler(this.deletEndStringSelection_ToEnd_CheckedChanged);
            // 
            // deletStartString
            // 
            this.deletStartString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletStartString.Location = new System.Drawing.Point(3, 3);
            this.deletStartString.Name = "deletStartString";
            this.deletStartString.Size = new System.Drawing.Size(296, 39);
            this.deletStartString.TabIndex = 0;
            // 
            // deletEndStringSelection_Index
            // 
            this.deletEndStringSelection_Index.AutoSize = true;
            this.deletEndStringSelection_Index.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletEndStringSelection_Index.Font = new System.Drawing.Font("Microsoft JhengHei", 12F);
            this.deletEndStringSelection_Index.Location = new System.Drawing.Point(702, 3);
            this.deletEndStringSelection_Index.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.deletEndStringSelection_Index.Name = "deletEndStringSelection_Index";
            this.deletEndStringSelection_Index.Size = new System.Drawing.Size(85, 32);
            this.deletEndStringSelection_Index.TabIndex = 4;
            this.deletEndStringSelection_Index.Text = "Index";
            this.deletEndStringSelection_Index.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(305, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "→";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deletEndStringSelection_String
            // 
            this.deletEndStringSelection_String.AutoSize = true;
            this.deletEndStringSelection_String.Checked = true;
            this.deletEndStringSelection_String.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletEndStringSelection_String.Font = new System.Drawing.Font("Microsoft JhengHei", 12F);
            this.deletEndStringSelection_String.Location = new System.Drawing.Point(596, 3);
            this.deletEndStringSelection_String.Margin = new System.Windows.Forms.Padding(50, 3, 15, 3);
            this.deletEndStringSelection_String.Name = "deletEndStringSelection_String";
            this.deletEndStringSelection_String.Size = new System.Drawing.Size(88, 32);
            this.deletEndStringSelection_String.TabIndex = 3;
            this.deletEndStringSelection_String.TabStop = true;
            this.deletEndStringSelection_String.Text = "String";
            this.deletEndStringSelection_String.UseVisualStyleBackColor = true;
            // 
            // deletEndString
            // 
            this.deletEndString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletEndString.Location = new System.Drawing.Point(348, 3);
            this.deletEndString.Name = "deletEndString";
            this.deletEndString.Size = new System.Drawing.Size(195, 39);
            this.deletEndString.TabIndex = 2;
            // 
            // deletRepeatItemPage
            // 
            this.deletRepeatItemPage.Controls.Add(this.deletRepeatItem_eachWord);
            this.deletRepeatItemPage.Controls.Add(this.deletRepeatItem_eachLine);
            this.deletRepeatItemPage.Location = new System.Drawing.Point(4, 38);
            this.deletRepeatItemPage.Name = "deletRepeatItemPage";
            this.deletRepeatItemPage.Padding = new System.Windows.Forms.Padding(3);
            this.deletRepeatItemPage.Size = new System.Drawing.Size(913, 44);
            this.deletRepeatItemPage.TabIndex = 2;
            this.deletRepeatItemPage.Text = "重複項目";
            this.deletRepeatItemPage.UseVisualStyleBackColor = true;
            // 
            // deletRepeatItem_eachWord
            // 
            this.deletRepeatItem_eachWord.AutoSize = true;
            this.deletRepeatItem_eachWord.Location = new System.Drawing.Point(316, 6);
            this.deletRepeatItem_eachWord.Name = "deletRepeatItem_eachWord";
            this.deletRepeatItem_eachWord.Size = new System.Drawing.Size(208, 34);
            this.deletRepeatItem_eachWord.TabIndex = 1;
            this.deletRepeatItem_eachWord.Text = "每個字為 1 Item";
            this.deletRepeatItem_eachWord.UseVisualStyleBackColor = true;
            // 
            // deletRepeatItem_eachLine
            // 
            this.deletRepeatItem_eachLine.AutoSize = true;
            this.deletRepeatItem_eachLine.Checked = true;
            this.deletRepeatItem_eachLine.Location = new System.Drawing.Point(6, 3);
            this.deletRepeatItem_eachLine.Name = "deletRepeatItem_eachLine";
            this.deletRepeatItem_eachLine.Size = new System.Drawing.Size(184, 34);
            this.deletRepeatItem_eachLine.TabIndex = 0;
            this.deletRepeatItem_eachLine.TabStop = true;
            this.deletRepeatItem_eachLine.Text = "每行為 1 Item";
            this.deletRepeatItem_eachLine.UseVisualStyleBackColor = true;
            // 
            // addIndexPage
            // 
            this.addIndexPage.Controls.Add(this.rebuildModeButton);
            this.addIndexPage.Controls.Add(this.label11);
            this.addIndexPage.Controls.Add(this.addIndex_frontString);
            this.addIndexPage.Controls.Add(this.usingIndex);
            this.addIndexPage.Controls.Add(this.label8);
            this.addIndexPage.Controls.Add(this.addIndex_rearString);
            this.addIndexPage.Controls.Add(this.label7);
            this.addIndexPage.Controls.Add(this.label6);
            this.addIndexPage.Controls.Add(this.addIndex_startFrom);
            this.addIndexPage.Controls.Add(this.addIndexButton);
            this.addIndexPage.Location = new System.Drawing.Point(4, 41);
            this.addIndexPage.Name = "addIndexPage";
            this.addIndexPage.Padding = new System.Windows.Forms.Padding(3);
            this.addIndexPage.Size = new System.Drawing.Size(935, 151);
            this.addIndexPage.TabIndex = 3;
            this.addIndexPage.Text = "添加索引";
            this.addIndexPage.UseVisualStyleBackColor = true;
            // 
            // rebuildModeButton
            // 
            this.rebuildModeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rebuildModeButton.Animated = true;
            this.rebuildModeButton.BorderRadius = 16;
            this.rebuildModeButton.Font = new System.Drawing.Font("Microsoft JhengHei", 14F);
            this.rebuildModeButton.ForeColor = System.Drawing.Color.White;
            this.rebuildModeButton.Location = new System.Drawing.Point(763, 20);
            this.rebuildModeButton.Name = "rebuildModeButton";
            this.rebuildModeButton.Size = new System.Drawing.Size(159, 35);
            this.rebuildModeButton.TabIndex = 29;
            this.rebuildModeButton.Text = "合并模式";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 30);
            this.label11.TabIndex = 28;
            this.label11.Text = "Index 後方子串：";
            // 
            // addIndex_frontString
            // 
            this.addIndex_frontString.BorderRadius = 17;
            this.addIndex_frontString.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addIndex_frontString.DefaultText = "";
            this.addIndex_frontString.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addIndex_frontString.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addIndex_frontString.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addIndex_frontString.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addIndex_frontString.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addIndex_frontString.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.addIndex_frontString.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addIndex_frontString.Location = new System.Drawing.Point(250, 74);
            this.addIndex_frontString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addIndex_frontString.Name = "addIndex_frontString";
            this.addIndex_frontString.PasswordChar = '\0';
            this.addIndex_frontString.PlaceholderText = "";
            this.addIndex_frontString.SelectedText = "";
            this.addIndex_frontString.Size = new System.Drawing.Size(399, 35);
            this.addIndex_frontString.TabIndex = 27;
            // 
            // usingIndex
            // 
            this.usingIndex.AutoSize = true;
            this.usingIndex.Checked = true;
            this.usingIndex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.usingIndex.Location = new System.Drawing.Point(568, 18);
            this.usingIndex.Name = "usingIndex";
            this.usingIndex.Size = new System.Drawing.Size(152, 34);
            this.usingIndex.TabIndex = 26;
            this.usingIndex.Text = "使用 Index";
            this.usingIndex.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 30);
            this.label8.TabIndex = 25;
            this.label8.Text = "Index 前方子串：";
            // 
            // addIndex_rearString
            // 
            this.addIndex_rearString.BorderRadius = 17;
            this.addIndex_rearString.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addIndex_rearString.DefaultText = ". ";
            this.addIndex_rearString.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addIndex_rearString.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addIndex_rearString.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addIndex_rearString.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addIndex_rearString.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addIndex_rearString.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.addIndex_rearString.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addIndex_rearString.Location = new System.Drawing.Point(250, 111);
            this.addIndex_rearString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addIndex_rearString.Name = "addIndex_rearString";
            this.addIndex_rearString.PasswordChar = '\0';
            this.addIndex_rearString.PlaceholderText = "";
            this.addIndex_rearString.SelectedText = "";
            this.addIndex_rearString.SelectionStart = 2;
            this.addIndex_rearString.Size = new System.Drawing.Size(399, 35);
            this.addIndex_rearString.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 30);
            this.label7.TabIndex = 23;
            this.label7.Text = "開始";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 30);
            this.label6.TabIndex = 22;
            this.label6.Text = "由 Index";
            // 
            // addIndex_startFrom
            // 
            this.addIndex_startFrom.BackColor = System.Drawing.Color.Transparent;
            this.addIndex_startFrom.BorderRadius = 20;
            this.addIndex_startFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addIndex_startFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addIndex_startFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addIndex_startFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addIndex_startFrom.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.addIndex_startFrom.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.addIndex_startFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addIndex_startFrom.Font = new System.Drawing.Font("Microsoft JhengHei", 14F);
            this.addIndex_startFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.addIndex_startFrom.Location = new System.Drawing.Point(144, 15);
            this.addIndex_startFrom.Margin = new System.Windows.Forms.Padding(10, 5, 10, 4);
            this.addIndex_startFrom.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.addIndex_startFrom.Name = "addIndex_startFrom";
            this.addIndex_startFrom.Size = new System.Drawing.Size(253, 40);
            this.addIndex_startFrom.TabIndex = 21;
            this.addIndex_startFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addIndexButton
            // 
            this.addIndexButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addIndexButton.Animated = true;
            this.addIndexButton.BorderRadius = 25;
            this.addIndexButton.Font = new System.Drawing.Font("Microsoft JhengHei", 16F);
            this.addIndexButton.ForeColor = System.Drawing.Color.White;
            this.addIndexButton.Location = new System.Drawing.Point(702, 89);
            this.addIndexButton.Name = "addIndexButton";
            this.addIndexButton.Size = new System.Drawing.Size(220, 50);
            this.addIndexButton.TabIndex = 20;
            this.addIndexButton.Text = "添加";
            // 
            // interpolatedPage
            // 
            this.interpolatedPage.Controls.Add(this.interpolated_GenerateButton);
            this.interpolatedPage.Controls.Add(this.interpolated_Format);
            this.interpolatedPage.Controls.Add(this.tableLayoutPanel4);
            this.interpolatedPage.Location = new System.Drawing.Point(4, 41);
            this.interpolatedPage.Name = "interpolatedPage";
            this.interpolatedPage.Padding = new System.Windows.Forms.Padding(3);
            this.interpolatedPage.Size = new System.Drawing.Size(935, 151);
            this.interpolatedPage.TabIndex = 4;
            this.interpolatedPage.Text = "Interpolated string";
            this.interpolatedPage.UseVisualStyleBackColor = true;
            // 
            // interpolated_GenerateButton
            // 
            this.interpolated_GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.interpolated_GenerateButton.Animated = true;
            this.interpolated_GenerateButton.BorderRadius = 22;
            this.interpolated_GenerateButton.Font = new System.Drawing.Font("Microsoft JhengHei", 16F);
            this.interpolated_GenerateButton.ForeColor = System.Drawing.Color.White;
            this.interpolated_GenerateButton.Location = new System.Drawing.Point(758, 103);
            this.interpolated_GenerateButton.Name = "interpolated_GenerateButton";
            this.interpolated_GenerateButton.Size = new System.Drawing.Size(171, 45);
            this.interpolated_GenerateButton.TabIndex = 21;
            this.interpolated_GenerateButton.Text = "生成";
            // 
            // interpolated_Format
            // 
            this.interpolated_Format.AllowDrop = true;
            this.interpolated_Format.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interpolated_Format.BorderRadius = 22;
            this.interpolated_Format.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.interpolated_Format.DefaultText = "";
            this.interpolated_Format.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.interpolated_Format.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.interpolated_Format.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.interpolated_Format.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.interpolated_Format.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.interpolated_Format.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interpolated_Format.ForeColor = System.Drawing.Color.Black;
            this.interpolated_Format.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.interpolated_Format.Location = new System.Drawing.Point(3, 103);
            this.interpolated_Format.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.interpolated_Format.Name = "interpolated_Format";
            this.interpolated_Format.PasswordChar = '\0';
            this.interpolated_Format.PlaceholderText = "";
            this.interpolated_Format.SelectedText = "";
            this.interpolated_Format.Size = new System.Drawing.Size(748, 45);
            this.interpolated_Format.TabIndex = 17;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel4.Controls.Add(this.interpolated_ValuesBox, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.interpolated_KeysBox, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(929, 92);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // interpolated_ValuesBox
            // 
            this.interpolated_ValuesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interpolated_ValuesBox.Location = new System.Drawing.Point(488, 3);
            this.interpolated_ValuesBox.Name = "interpolated_ValuesBox";
            this.interpolated_ValuesBox.Size = new System.Drawing.Size(438, 86);
            this.interpolated_ValuesBox.TabIndex = 0;
            this.interpolated_ValuesBox.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(445, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 92);
            this.label10.TabIndex = 1;
            this.label10.Text = "→";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // interpolated_KeysBox
            // 
            this.interpolated_KeysBox.AllowDrop = true;
            this.interpolated_KeysBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.interpolated_KeysBox.FormattingEnabled = true;
            this.interpolated_KeysBox.ItemHeight = 29;
            this.interpolated_KeysBox.Items.AddRange(new object[] {
            "$1"});
            this.interpolated_KeysBox.Location = new System.Drawing.Point(3, 3);
            this.interpolated_KeysBox.Name = "interpolated_KeysBox";
            this.interpolated_KeysBox.Size = new System.Drawing.Size(436, 86);
            this.interpolated_KeysBox.TabIndex = 2;
            this.interpolated_KeysBox.SelectedIndexChanged += new System.EventHandler(this.interpolated_KeysBox_SelectedIndexChanged);
            this.interpolated_KeysBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.interpolated_KeysBox_DragDrop);
            this.interpolated_KeysBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.interpolated_KeysBox_DragEnter);
            this.interpolated_KeysBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.interpolated_KeysBox_KeyDown);
            // 
            // settingPage
            // 
            this.settingPage.Controls.Add(this.label15);
            this.settingPage.Controls.Add(this.settingPage_emptyLineAutoRemove);
            this.settingPage.Location = new System.Drawing.Point(4, 41);
            this.settingPage.Name = "settingPage";
            this.settingPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingPage.Size = new System.Drawing.Size(935, 151);
            this.settingPage.TabIndex = 5;
            this.settingPage.Text = "|Setting|";
            this.settingPage.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 30);
            this.label15.TabIndex = 1;
            this.label15.Text = "F7 開始錄製";
            // 
            // settingPage_emptyLineAutoRemove
            // 
            this.settingPage_emptyLineAutoRemove.AutoSize = true;
            this.settingPage_emptyLineAutoRemove.Location = new System.Drawing.Point(8, 20);
            this.settingPage_emptyLineAutoRemove.Name = "settingPage_emptyLineAutoRemove";
            this.settingPage_emptyLineAutoRemove.Size = new System.Drawing.Size(375, 34);
            this.settingPage_emptyLineAutoRemove.TabIndex = 0;
            this.settingPage_emptyLineAutoRemove.Text = "運算後 自動移除空行 (部分支援)";
            this.settingPage_emptyLineAutoRemove.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.allTextLengthNumber,
            this.toolStripStatusLabel2,
            this.allTextLineCount,
            this.toolStripStatusLabel3,
            this.allTextPosition,
            this.toolStripStatusLabel4,
            this.undoListCountLayout});
            this.statusStrip.Location = new System.Drawing.Point(0, 612);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1028, 32);
            this.statusStrip.TabIndex = 18;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 1);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 29);
            this.toolStripStatusLabel1.Text = "總共字數 :";
            // 
            // allTextLengthNumber
            // 
            this.allTextLengthNumber.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.allTextLengthNumber.Margin = new System.Windows.Forms.Padding(0, 2, 0, 1);
            this.allTextLengthNumber.Name = "allTextLengthNumber";
            this.allTextLengthNumber.Size = new System.Drawing.Size(24, 29);
            this.allTextLengthNumber.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(150, 4, 0, 3);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(72, 25);
            this.toolStripStatusLabel2.Text = "行數：";
            // 
            // allTextLineCount
            // 
            this.allTextLineCount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.allTextLineCount.Name = "allTextLineCount";
            this.allTextLineCount.Size = new System.Drawing.Size(24, 26);
            this.allTextLineCount.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.toolStripStatusLabel3.Margin = new System.Windows.Forms.Padding(150, 4, 0, 3);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(72, 25);
            this.toolStripStatusLabel3.Text = "位置：";
            // 
            // allTextPosition
            // 
            this.allTextPosition.Name = "allTextPosition";
            this.allTextPosition.Size = new System.Drawing.Size(24, 26);
            this.allTextPosition.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Margin = new System.Windows.Forms.Padding(150, 4, 0, 3);
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(92, 25);
            this.toolStripStatusLabel4.Text = "可撤銷：";
            // 
            // undoListCountLayout
            // 
            this.undoListCountLayout.Name = "undoListCountLayout";
            this.undoListCountLayout.Size = new System.Drawing.Size(24, 26);
            this.undoListCountLayout.Text = "0";
            // 
            // box
            // 
            this.box.AcceptsTab = true;
            this.box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box.AutoWordSelection = true;
            this.box.ContextMenuStrip = this.boxMenu;
            this.box.Location = new System.Drawing.Point(12, 201);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(1016, 418);
            this.box.TabIndex = 14;
            this.box.Text = "";
            this.box.WordWrap = false;
            this.box.TextChanged += new System.EventHandler(this.box_TextChanged);
            this.box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.box_KeyDown);
            // 
            // boxMenu
            // 
            this.boxMenu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.boxMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.boxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boxMenu_ToUpper,
            this.boxMenu_ToLower,
            this.toolStripSeparator1,
            this.lockForm});
            this.boxMenu.Name = "boxMenu";
            this.boxMenu.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.boxMenu.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.boxMenu.RenderStyle.ColorTable = null;
            this.boxMenu.RenderStyle.RoundedEdges = true;
            this.boxMenu.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.boxMenu.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(128)))), ((int)(((byte)(251)))));
            this.boxMenu.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.boxMenu.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.boxMenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.boxMenu.Size = new System.Drawing.Size(165, 100);
            // 
            // boxMenu_ToUpper
            // 
            this.boxMenu_ToUpper.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.boxMenu_ToUpper.Name = "boxMenu_ToUpper";
            this.boxMenu_ToUpper.Size = new System.Drawing.Size(164, 30);
            this.boxMenu_ToUpper.Text = "Upper";
            this.boxMenu_ToUpper.Click += new System.EventHandler(this.boxMenu_ToUpper_Click);
            // 
            // boxMenu_ToLower
            // 
            this.boxMenu_ToLower.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.boxMenu_ToLower.Name = "boxMenu_ToLower";
            this.boxMenu_ToLower.Size = new System.Drawing.Size(164, 30);
            this.boxMenu_ToLower.Text = "Lower";
            this.boxMenu_ToLower.Click += new System.EventHandler(this.boxMenu_ToLower_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // lockForm
            // 
            this.lockForm.Name = "lockForm";
            this.lockForm.Size = new System.Drawing.Size(164, 30);
            this.lockForm.Text = "鎖定視窗";
            this.lockForm.Click += new System.EventHandler(this.lockForm_Click);
            // 
            // boxTextChangeTimer
            // 
            this.boxTextChangeTimer.Enabled = true;
            this.boxTextChangeTimer.Interval = 10;
            this.boxTextChangeTimer.Tick += new System.EventHandler(this.boxTextChangeTimer_Tick);
            // 
            // textChange_selected
            // 
            this.textChange_selected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textChange_selected.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textChange_selected.CheckedState.BorderThickness = 0;
            this.textChange_selected.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textChange_selected.CheckedState.InnerColor = System.Drawing.Color.White;
            this.textChange_selected.CheckedState.InnerOffset = -4;
            this.textChange_selected.Location = new System.Drawing.Point(961, 109);
            this.textChange_selected.Name = "textChange_selected";
            this.textChange_selected.Size = new System.Drawing.Size(67, 85);
            this.textChange_selected.TabIndex = 19;
            this.textChange_selected.Text = "選擇";
            this.textChange_selected.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.textChange_selected.UncheckedState.BorderThickness = 2;
            this.textChange_selected.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.textChange_selected.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // textChange_all
            // 
            this.textChange_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textChange_all.Checked = true;
            this.textChange_all.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textChange_all.CheckedState.BorderThickness = 0;
            this.textChange_all.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textChange_all.CheckedState.InnerColor = System.Drawing.Color.White;
            this.textChange_all.CheckedState.InnerOffset = -4;
            this.textChange_all.Location = new System.Drawing.Point(961, 12);
            this.textChange_all.Name = "textChange_all";
            this.textChange_all.Size = new System.Drawing.Size(67, 85);
            this.textChange_all.TabIndex = 20;
            this.textChange_all.TabStop = true;
            this.textChange_all.Text = "全部";
            this.textChange_all.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.textChange_all.UncheckedState.BorderThickness = 2;
            this.textChange_all.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.textChange_all.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 644);
            this.Controls.Add(this.textChange_all);
            this.Controls.Add(this.textChange_selected);
            this.Controls.Add(this.box);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "自動隔行    v 3.8.3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.toNewLinePage.ResumeLayout(false);
            this.toNewLinePage.PerformLayout();
            this.replacePage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.deletPage.ResumeLayout(false);
            this.deletSubPage.ResumeLayout(false);
            this.deletFromIndexPage.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletStartIndex)).EndInit();
            this.deletFromIndexToEndPage.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletFromIndexToEndPage_startIndex)).EndInit();
            this.deletFormStringPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.deletRepeatItemPage.ResumeLayout(false);
            this.deletRepeatItemPage.PerformLayout();
            this.addIndexPage.ResumeLayout(false);
            this.addIndexPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addIndex_startFrom)).EndInit();
            this.interpolatedPage.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.settingPage.ResumeLayout(false);
            this.settingPage.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.boxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox everyLineCheckBox;
        private System.Windows.Forms.MaskedTextBox linesSeparate;
        private System.Windows.Forms.MaskedTextBox replaceSeparate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage toNewLinePage;
        private System.Windows.Forms.TabPage replacePage;
        private System.Windows.Forms.TabPage deletPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel allTextLengthNumber;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel allTextLineCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel allTextPosition;
        private System.Windows.Forms.TabControl deletSubPage;
        private System.Windows.Forms.TabPage deletFromIndexPage;
        private System.Windows.Forms.TabPage deletFormStringPage;
        private System.Windows.Forms.RadioButton deletEndStringSelection_Index;
        private System.Windows.Forms.RadioButton deletEndStringSelection_String;
        private System.Windows.Forms.TextBox deletEndString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox deletStartString;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2TextBox replaceIn;
        private Guna.UI2.WinForms.Guna2TextBox replaceOut;
        private System.Windows.Forms.RichTextBox box;
        private Guna.UI2.WinForms.Guna2GradientButton toNewLineButton;
        private Guna.UI2.WinForms.Guna2TextBox interlaced;
        private Guna.UI2.WinForms.Guna2GradientButton replaceButton;
        private Guna.UI2.WinForms.Guna2GradientButton deletButton;
        private Guna.UI2.WinForms.Guna2GradientButton deletEmptyLinesButton;
        private Guna.UI2.WinForms.Guna2NumericUpDown deletStartIndex;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2NumericUpDown deletCount;
        private System.Windows.Forms.TabPage deletRepeatItemPage;
        private System.Windows.Forms.RadioButton deletRepeatItem_eachWord;
        private System.Windows.Forms.RadioButton deletRepeatItem_eachLine;
        private System.Windows.Forms.Timer boxTextChangeTimer;
        private System.Windows.Forms.TabPage addIndexPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2NumericUpDown addIndex_startFrom;
        private Guna.UI2.WinForms.Guna2GradientButton addIndexButton;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox addIndex_rearString;
        private Guna.UI2.WinForms.Guna2RadioButton textChange_selected;
        private Guna.UI2.WinForms.Guna2RadioButton textChange_all;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel undoListCountLayout;
        private System.Windows.Forms.RadioButton newLineArg_t;
        private System.Windows.Forms.RadioButton newLineArg_n;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip boxMenu;
        private System.Windows.Forms.ToolStripMenuItem boxMenu_ToUpper;
        private System.Windows.Forms.ToolStripMenuItem boxMenu_ToLower;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem lockForm;
        private Guna.UI2.WinForms.Guna2GradientButton deletLineButton;
        private System.Windows.Forms.RadioButton deletEndStringSelection_ToEnd;
        private System.Windows.Forms.CheckBox usingIndex;
        private Guna.UI2.WinForms.Guna2GradientButton rebuildAsOneLineButton;
        private System.Windows.Forms.TabPage interpolatedPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RichTextBox interpolated_ValuesBox;
        private Guna.UI2.WinForms.Guna2TextBox interpolated_Format;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox interpolated_KeysBox;
        private Guna.UI2.WinForms.Guna2GradientButton interpolated_GenerateButton;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox addIndex_frontString;
        private System.Windows.Forms.TabPage deletFromIndexToEndPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2NumericUpDown deletFromIndexToEndPage_startIndex;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox deletFromIndexToEndPage_starting;
        private System.Windows.Forms.TabPage settingPage;
        private System.Windows.Forms.CheckBox settingPage_emptyLineAutoRemove;
        private Guna.UI2.WinForms.Guna2GradientButton rebuildModeButton;
        private System.Windows.Forms.Label label15;
    }
}

