namespace BrailleApplication
{
    partial class Frame
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translateGroupBox = new System.Windows.Forms.GroupBox();
            this.clearTextboxButton = new System.Windows.Forms.Button();
            this.extractButton = new System.Windows.Forms.Button();
            this.languageGroupBox = new System.Windows.Forms.GroupBox();
            this.langKorRadioButton = new System.Windows.Forms.RadioButton();
            this.langEngRadioButton = new System.Windows.Forms.RadioButton();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삽입ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.text2BraileSplitContainer = new System.Windows.Forms.SplitContainer();
            this.showUnicodeButton = new System.Windows.Forms.Button();
            this.settingSplitContainer = new System.Windows.Forms.SplitContainer();
            this.optionGroupBox = new System.Windows.Forms.GroupBox();
            this.autoRadioButton = new System.Windows.Forms.RadioButton();
            this.manualRadioButton = new System.Windows.Forms.RadioButton();
            this.samepleDisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.이중삼중모음Button = new System.Windows.Forms.Button();
            this.받침자음Button = new System.Windows.Forms.Button();
            this.모음Button = new System.Windows.Forms.Button();
            this.첫소리자음Button = new System.Windows.Forms.Button();
            this.InformationGroupBox = new System.Windows.Forms.GroupBox();
            this.showBrailleImageButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.translateGroupBox.SuspendLayout();
            this.languageGroupBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.text2BraileSplitContainer.Panel1.SuspendLayout();
            this.text2BraileSplitContainer.Panel2.SuspendLayout();
            this.text2BraileSplitContainer.SuspendLayout();
            this.settingSplitContainer.Panel1.SuspendLayout();
            this.settingSplitContainer.Panel2.SuspendLayout();
            this.settingSplitContainer.SuspendLayout();
            this.optionGroupBox.SuspendLayout();
            this.samepleDisplayGroupBox.SuspendLayout();
            this.InformationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(638, 123);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            //this.richTextBox1.Enter += new System.EventHandler(this.richTextBox1_Enter);
            this.richTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyUp);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(845, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // translateGroupBox
            // 
            this.translateGroupBox.Controls.Add(this.clearTextboxButton);
            this.translateGroupBox.Controls.Add(this.extractButton);
            this.translateGroupBox.Location = new System.Drawing.Point(4, 3);
            this.translateGroupBox.Name = "translateGroupBox";
            this.translateGroupBox.Size = new System.Drawing.Size(175, 107);
            this.translateGroupBox.TabIndex = 4;
            this.translateGroupBox.TabStop = false;
            this.translateGroupBox.Text = "변환";
            // 
            // clearTextboxButton
            // 
            this.clearTextboxButton.Location = new System.Drawing.Point(26, 74);
            this.clearTextboxButton.Name = "clearTextboxButton";
            this.clearTextboxButton.Size = new System.Drawing.Size(126, 23);
            this.clearTextboxButton.TabIndex = 5;
            this.clearTextboxButton.Text = "Clear";
            this.clearTextboxButton.UseVisualStyleBackColor = true;
            this.clearTextboxButton.Click += new System.EventHandler(this.clearTextboxButton_Click_1);
            // 
            // extractButton
            // 
            this.extractButton.Location = new System.Drawing.Point(26, 20);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(126, 48);
            this.extractButton.TabIndex = 4;
            this.extractButton.Text = "점자변환";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click_1);
            // 
            // languageGroupBox
            // 
            this.languageGroupBox.Controls.Add(this.langKorRadioButton);
            this.languageGroupBox.Controls.Add(this.langEngRadioButton);
            this.languageGroupBox.Location = new System.Drawing.Point(4, 116);
            this.languageGroupBox.Name = "languageGroupBox";
            this.languageGroupBox.Size = new System.Drawing.Size(175, 64);
            this.languageGroupBox.TabIndex = 8;
            this.languageGroupBox.TabStop = false;
            this.languageGroupBox.Text = "언어선택";
            // 
            // langKorRadioButton
            // 
            this.langKorRadioButton.AutoSize = true;
            this.langKorRadioButton.Location = new System.Drawing.Point(26, 42);
            this.langKorRadioButton.Name = "langKorRadioButton";
            this.langKorRadioButton.Size = new System.Drawing.Size(59, 16);
            this.langKorRadioButton.TabIndex = 1;
            this.langKorRadioButton.TabStop = true;
            this.langKorRadioButton.Text = "한국어";
            this.langKorRadioButton.UseVisualStyleBackColor = true;
            // 
            // langEngRadioButton
            // 
            this.langEngRadioButton.AutoSize = true;
            this.langEngRadioButton.Location = new System.Drawing.Point(26, 20);
            this.langEngRadioButton.Name = "langEngRadioButton";
            this.langEngRadioButton.Size = new System.Drawing.Size(47, 16);
            this.langEngRadioButton.TabIndex = 0;
            this.langEngRadioButton.TabStop = true;
            this.langEngRadioButton.Text = "영어";
            this.langEngRadioButton.UseVisualStyleBackColor = true;
            this.langEngRadioButton.CheckedChanged += new System.EventHandler(this.langEngRadioButton_CheckedChanged);
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.보기ToolStripMenuItem.Text = "보기";
            // 
            // 삽입ToolStripMenuItem
            // 
            this.삽입ToolStripMenuItem.Name = "삽입ToolStripMenuItem";
            this.삽입ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.삽입ToolStripMenuItem.Text = "설정";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.삽입ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(845, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip3";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(845, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(638, 395);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // text2BraileSplitContainer
            // 
            this.text2BraileSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text2BraileSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.text2BraileSplitContainer.Name = "text2BraileSplitContainer";
            this.text2BraileSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // text2BraileSplitContainer.Panel1
            // 
            this.text2BraileSplitContainer.Panel1.Controls.Add(this.richTextBox1);
            // 
            // text2BraileSplitContainer.Panel2
            // 
            this.text2BraileSplitContainer.Panel2.Controls.Add(this.richTextBox2);
            this.text2BraileSplitContainer.Size = new System.Drawing.Size(638, 522);
            this.text2BraileSplitContainer.SplitterDistance = 123;
            this.text2BraileSplitContainer.TabIndex = 11;
            // 
            // showUnicodeButton
            // 
            this.showUnicodeButton.Location = new System.Drawing.Point(25, 20);
            this.showUnicodeButton.Name = "showUnicodeButton";
            this.showUnicodeButton.Size = new System.Drawing.Size(126, 23);
            this.showUnicodeButton.TabIndex = 6;
            this.showUnicodeButton.Text = "유니코드값보기";
            this.showUnicodeButton.UseVisualStyleBackColor = true;
            // 
            // settingSplitContainer
            // 
            this.settingSplitContainer.Location = new System.Drawing.Point(12, 52);
            this.settingSplitContainer.Name = "settingSplitContainer";
            // 
            // settingSplitContainer.Panel1
            // 
            this.settingSplitContainer.Panel1.Controls.Add(this.text2BraileSplitContainer);
            // 
            // settingSplitContainer.Panel2
            // 
            this.settingSplitContainer.Panel2.Controls.Add(this.optionGroupBox);
            this.settingSplitContainer.Panel2.Controls.Add(this.samepleDisplayGroupBox);
            this.settingSplitContainer.Panel2.Controls.Add(this.InformationGroupBox);
            this.settingSplitContainer.Panel2.Controls.Add(this.translateGroupBox);
            this.settingSplitContainer.Panel2.Controls.Add(this.languageGroupBox);
            this.settingSplitContainer.Size = new System.Drawing.Size(828, 522);
            this.settingSplitContainer.SplitterDistance = 638;
            this.settingSplitContainer.TabIndex = 12;
            // 
            // optionGroupBox
            // 
            this.optionGroupBox.Controls.Add(this.autoRadioButton);
            this.optionGroupBox.Controls.Add(this.manualRadioButton);
            this.optionGroupBox.Location = new System.Drawing.Point(4, 187);
            this.optionGroupBox.Name = "optionGroupBox";
            this.optionGroupBox.Size = new System.Drawing.Size(175, 61);
            this.optionGroupBox.TabIndex = 11;
            this.optionGroupBox.TabStop = false;
            this.optionGroupBox.Text = "변환옵션";
            // 
            // autoRadioButton
            // 
            this.autoRadioButton.AutoSize = true;
            this.autoRadioButton.Location = new System.Drawing.Point(26, 39);
            this.autoRadioButton.Name = "autoRadioButton";
            this.autoRadioButton.Size = new System.Drawing.Size(47, 16);
            this.autoRadioButton.TabIndex = 1;
            this.autoRadioButton.Text = "자동";
            this.autoRadioButton.UseVisualStyleBackColor = true;
            // 
            // manualRadioButton
            // 
            this.manualRadioButton.AutoSize = true;
            this.manualRadioButton.Location = new System.Drawing.Point(26, 21);
            this.manualRadioButton.Name = "manualRadioButton";
            this.manualRadioButton.Size = new System.Drawing.Size(47, 16);
            this.manualRadioButton.TabIndex = 0;
            this.manualRadioButton.TabStop = true;
            this.manualRadioButton.Text = "수동";
            this.manualRadioButton.UseVisualStyleBackColor = true;
            this.manualRadioButton.CheckedChanged += new System.EventHandler(this.manualRadioButton_CheckedChanged);
            // 
            // samepleDisplayGroupBox
            // 
            this.samepleDisplayGroupBox.Controls.Add(this.이중삼중모음Button);
            this.samepleDisplayGroupBox.Controls.Add(this.받침자음Button);
            this.samepleDisplayGroupBox.Controls.Add(this.모음Button);
            this.samepleDisplayGroupBox.Controls.Add(this.첫소리자음Button);
            this.samepleDisplayGroupBox.Location = new System.Drawing.Point(4, 254);
            this.samepleDisplayGroupBox.Name = "samepleDisplayGroupBox";
            this.samepleDisplayGroupBox.Size = new System.Drawing.Size(175, 141);
            this.samepleDisplayGroupBox.TabIndex = 10;
            this.samepleDisplayGroupBox.TabStop = false;
            this.samepleDisplayGroupBox.Text = "샘플출력";
            // 
            // 이중삼중모음Button
            // 
            this.이중삼중모음Button.Location = new System.Drawing.Point(26, 81);
            this.이중삼중모음Button.Name = "이중삼중모음Button";
            this.이중삼중모음Button.Size = new System.Drawing.Size(125, 23);
            this.이중삼중모음Button.TabIndex = 3;
            this.이중삼중모음Button.Text = "이중삼중모음";
            this.이중삼중모음Button.UseVisualStyleBackColor = true;
            this.이중삼중모음Button.Click += new System.EventHandler(this.이중삼중모음Button_Click);
            // 
            // 받침자음Button
            // 
            this.받침자음Button.Location = new System.Drawing.Point(26, 110);
            this.받침자음Button.Name = "받침자음Button";
            this.받침자음Button.Size = new System.Drawing.Size(125, 23);
            this.받침자음Button.TabIndex = 2;
            this.받침자음Button.Text = "받침자음";
            this.받침자음Button.UseVisualStyleBackColor = true;
            this.받침자음Button.Click += new System.EventHandler(this.받침자음Button_Click);
            // 
            // 모음Button
            // 
            this.모음Button.Location = new System.Drawing.Point(25, 51);
            this.모음Button.Name = "모음Button";
            this.모음Button.Size = new System.Drawing.Size(126, 23);
            this.모음Button.TabIndex = 1;
            this.모음Button.Text = "모음";
            this.모음Button.UseVisualStyleBackColor = true;
            this.모음Button.Click += new System.EventHandler(this.모음Button_Click);
            // 
            // 첫소리자음Button
            // 
            this.첫소리자음Button.Location = new System.Drawing.Point(26, 21);
            this.첫소리자음Button.Name = "첫소리자음Button";
            this.첫소리자음Button.Size = new System.Drawing.Size(125, 23);
            this.첫소리자음Button.TabIndex = 0;
            this.첫소리자음Button.Text = "첫소리자음";
            this.첫소리자음Button.UseVisualStyleBackColor = true;
            this.첫소리자음Button.Click += new System.EventHandler(this.첫소리자음Button_Click);
            // 
            // InformationGroupBox
            // 
            this.InformationGroupBox.Controls.Add(this.showBrailleImageButton);
            this.InformationGroupBox.Controls.Add(this.showUnicodeButton);
            this.InformationGroupBox.Location = new System.Drawing.Point(4, 401);
            this.InformationGroupBox.Name = "InformationGroupBox";
            this.InformationGroupBox.Size = new System.Drawing.Size(175, 118);
            this.InformationGroupBox.TabIndex = 9;
            this.InformationGroupBox.TabStop = false;
            this.InformationGroupBox.Text = "개발정보";
            // 
            // showBrailleImageButton
            // 
            this.showBrailleImageButton.Location = new System.Drawing.Point(25, 49);
            this.showBrailleImageButton.Name = "showBrailleImageButton";
            this.showBrailleImageButton.Size = new System.Drawing.Size(126, 23);
            this.showBrailleImageButton.TabIndex = 8;
            this.showBrailleImageButton.Text = "점자 이미지 보기";
            this.showBrailleImageButton.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 599);
            this.Controls.Add(this.settingSplitContainer);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frame";
            this.Text = "Text To Braille Translator";
            this.translateGroupBox.ResumeLayout(false);
            this.languageGroupBox.ResumeLayout(false);
            this.languageGroupBox.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.text2BraileSplitContainer.Panel1.ResumeLayout(false);
            this.text2BraileSplitContainer.Panel2.ResumeLayout(false);
            this.text2BraileSplitContainer.ResumeLayout(false);
            this.settingSplitContainer.Panel1.ResumeLayout(false);
            this.settingSplitContainer.Panel2.ResumeLayout(false);
            this.settingSplitContainer.ResumeLayout(false);
            this.optionGroupBox.ResumeLayout(false);
            this.optionGroupBox.PerformLayout();
            this.samepleDisplayGroupBox.ResumeLayout(false);
            this.InformationGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox translateGroupBox;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.GroupBox languageGroupBox;
        private System.Windows.Forms.RadioButton langKorRadioButton;
        private System.Windows.Forms.RadioButton langEngRadioButton;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삽입ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Button clearTextboxButton;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.SplitContainer text2BraileSplitContainer;
        private System.Windows.Forms.Button showUnicodeButton;
        private System.Windows.Forms.SplitContainer settingSplitContainer;
        private System.Windows.Forms.GroupBox InformationGroupBox;
        private System.Windows.Forms.Button showBrailleImageButton;
        private System.Windows.Forms.GroupBox samepleDisplayGroupBox;
        private System.Windows.Forms.Button 받침자음Button;
        private System.Windows.Forms.Button 모음Button;
        private System.Windows.Forms.Button 첫소리자음Button;
        private System.Windows.Forms.Button 이중삼중모음Button;
        private System.Windows.Forms.GroupBox optionGroupBox;
        private System.Windows.Forms.RadioButton autoRadioButton;
        private System.Windows.Forms.RadioButton manualRadioButton;
        private System.Windows.Forms.Timer timer1;
    }
}

