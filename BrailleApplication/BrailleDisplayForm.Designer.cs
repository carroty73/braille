namespace BrailleApplication
{
    partial class BrailleDisplayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.brailleListView = new System.Windows.Forms.ListView();
            this.BrailleDisplaySplitContainer = new System.Windows.Forms.SplitContainer();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.BrailleDisplaySplitContainer.Panel1.SuspendLayout();
            this.BrailleDisplaySplitContainer.Panel2.SuspendLayout();
            this.BrailleDisplaySplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // brailleListView
            // 
            this.brailleListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brailleListView.Location = new System.Drawing.Point(0, 0);
            this.brailleListView.Name = "brailleListView";
            this.brailleListView.Size = new System.Drawing.Size(656, 509);
            this.brailleListView.TabIndex = 0;
            this.brailleListView.UseCompatibleStateImageBehavior = false;
            // 
            // BrailleDisplaySplitContainer
            // 
            this.BrailleDisplaySplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrailleDisplaySplitContainer.Location = new System.Drawing.Point(0, 0);
            this.BrailleDisplaySplitContainer.Name = "BrailleDisplaySplitContainer";
            this.BrailleDisplaySplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // BrailleDisplaySplitContainer.Panel1
            // 
            this.BrailleDisplaySplitContainer.Panel1.Controls.Add(this.brailleListView);
            // 
            // BrailleDisplaySplitContainer.Panel2
            // 
            this.BrailleDisplaySplitContainer.Panel2.Controls.Add(this.logRichTextBox);
            this.BrailleDisplaySplitContainer.Size = new System.Drawing.Size(656, 603);
            this.BrailleDisplaySplitContainer.SplitterDistance = 509;
            this.BrailleDisplaySplitContainer.TabIndex = 2;
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.Size = new System.Drawing.Size(656, 90);
            this.logRichTextBox.TabIndex = 2;
            this.logRichTextBox.Text = "";
            // 
            // BrailleDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 603);
            this.Controls.Add(this.BrailleDisplaySplitContainer);
            this.Name = "BrailleDisplayForm";
            this.Text = "Braille Display";
            this.BrailleDisplaySplitContainer.Panel1.ResumeLayout(false);
            this.BrailleDisplaySplitContainer.Panel2.ResumeLayout(false);
            this.BrailleDisplaySplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView brailleListView;
        private System.Windows.Forms.SplitContainer BrailleDisplaySplitContainer;
        private System.Windows.Forms.RichTextBox logRichTextBox;

    }
}