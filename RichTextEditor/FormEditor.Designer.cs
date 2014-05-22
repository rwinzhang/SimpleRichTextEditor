namespace SimpleEditor
{
    partial class RichTextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RichTextEditor));
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.cmdOpen = new System.Windows.Forms.ToolStripButton();
            this.cmdSave = new System.Windows.Forms.ToolStripButton();
            this.cmdUndo = new System.Windows.Forms.ToolStripButton();
            this.cmdRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdCopy = new System.Windows.Forms.ToolStripButton();
            this.cmdCut = new System.Windows.Forms.ToolStripButton();
            this.cmdPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdBold = new System.Windows.Forms.ToolStripButton();
            this.cmdItalic = new System.Windows.Forms.ToolStripButton();
            this.cmdUnderline = new System.Windows.Forms.ToolStripButton();
            this.cmdStrikeout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdFont = new System.Windows.Forms.ToolStripButton();
            this.cmdBackColor = new System.Windows.Forms.ToolStripButton();
            this.cmdTextColor = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.cmdAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.cmdAlignCenter = new System.Windows.Forms.ToolStripButton();
            this.cmdAlignRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.AcceptsTab = true;
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Location = new System.Drawing.Point(12, 28);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(760, 521);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdOpen,
            this.cmdSave,
            this.cmdUndo,
            this.cmdRedo,
            this.toolStripSeparator1,
            this.cmdCopy,
            this.cmdCut,
            this.cmdPaste,
            this.toolStripSeparator2,
            this.cmdBold,
            this.cmdItalic,
            this.cmdUnderline,
            this.cmdStrikeout,
            this.toolStripSeparator3,
            this.cmdFont,
            this.cmdBackColor,
            this.cmdTextColor,
            this.toolStripSeparator4,
            this.cmdAlignLeft,
            this.cmdAlignCenter,
            this.cmdAlignRight,
            this.toolStripSeparator5});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(784, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // cmdOpen
            // 
            this.cmdOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdOpen.Image = ((System.Drawing.Image)(resources.GetObject("cmdOpen.Image")));
            this.cmdOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(23, 22);
            this.cmdOpen.Text = "Open";
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdSave.Image")));
            this.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(23, 22);
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdUndo
            // 
            this.cmdUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdUndo.Image = ((System.Drawing.Image)(resources.GetObject("cmdUndo.Image")));
            this.cmdUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdUndo.Name = "cmdUndo";
            this.cmdUndo.Size = new System.Drawing.Size(23, 22);
            this.cmdUndo.Text = "Undo";
            this.cmdUndo.Click += new System.EventHandler(this.cmdUndo_Click);
            // 
            // cmdRedo
            // 
            this.cmdRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdRedo.Image = ((System.Drawing.Image)(resources.GetObject("cmdRedo.Image")));
            this.cmdRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdRedo.Name = "cmdRedo";
            this.cmdRedo.Size = new System.Drawing.Size(23, 22);
            this.cmdRedo.Text = "Redo";
            this.cmdRedo.Click += new System.EventHandler(this.cmdRedo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cmdCopy
            // 
            this.cmdCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdCopy.Image = ((System.Drawing.Image)(resources.GetObject("cmdCopy.Image")));
            this.cmdCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(23, 22);
            this.cmdCopy.Text = "Copy";
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // cmdCut
            // 
            this.cmdCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdCut.Image = ((System.Drawing.Image)(resources.GetObject("cmdCut.Image")));
            this.cmdCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdCut.Name = "cmdCut";
            this.cmdCut.Size = new System.Drawing.Size(23, 22);
            this.cmdCut.Text = "Cut";
            this.cmdCut.Click += new System.EventHandler(this.cmdCut_Click);
            // 
            // cmdPaste
            // 
            this.cmdPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdPaste.Image = ((System.Drawing.Image)(resources.GetObject("cmdPaste.Image")));
            this.cmdPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPaste.Name = "cmdPaste";
            this.cmdPaste.Size = new System.Drawing.Size(23, 22);
            this.cmdPaste.Text = "Paste";
            this.cmdPaste.Click += new System.EventHandler(this.cmdPaste_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cmdBold
            // 
            this.cmdBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdBold.Image = ((System.Drawing.Image)(resources.GetObject("cmdBold.Image")));
            this.cmdBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdBold.Name = "cmdBold";
            this.cmdBold.Size = new System.Drawing.Size(23, 22);
            this.cmdBold.Text = "Bold";
            this.cmdBold.Click += new System.EventHandler(this.cmdBold_Click);
            // 
            // cmdItalic
            // 
            this.cmdItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdItalic.Image = ((System.Drawing.Image)(resources.GetObject("cmdItalic.Image")));
            this.cmdItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdItalic.Name = "cmdItalic";
            this.cmdItalic.Size = new System.Drawing.Size(23, 22);
            this.cmdItalic.Text = "Italic";
            this.cmdItalic.Click += new System.EventHandler(this.cmdItalic_Click);
            // 
            // cmdUnderline
            // 
            this.cmdUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdUnderline.Image = ((System.Drawing.Image)(resources.GetObject("cmdUnderline.Image")));
            this.cmdUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdUnderline.Name = "cmdUnderline";
            this.cmdUnderline.Size = new System.Drawing.Size(23, 22);
            this.cmdUnderline.Text = "Underline";
            this.cmdUnderline.Click += new System.EventHandler(this.cmdUnderline_Click);
            // 
            // cmdStrikeout
            // 
            this.cmdStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdStrikeout.Image = ((System.Drawing.Image)(resources.GetObject("cmdStrikeout.Image")));
            this.cmdStrikeout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdStrikeout.Name = "cmdStrikeout";
            this.cmdStrikeout.Size = new System.Drawing.Size(23, 22);
            this.cmdStrikeout.Text = "Strikeout";
            this.cmdStrikeout.Click += new System.EventHandler(this.cmdStrikeout_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // cmdFont
            // 
            this.cmdFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdFont.Image = ((System.Drawing.Image)(resources.GetObject("cmdFont.Image")));
            this.cmdFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdFont.Name = "cmdFont";
            this.cmdFont.Size = new System.Drawing.Size(23, 22);
            this.cmdFont.Text = "Font";
            this.cmdFont.Click += new System.EventHandler(this.cmdFont_Click);
            // 
            // cmdBackColor
            // 
            this.cmdBackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdBackColor.Image = ((System.Drawing.Image)(resources.GetObject("cmdBackColor.Image")));
            this.cmdBackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdBackColor.Name = "cmdBackColor";
            this.cmdBackColor.Size = new System.Drawing.Size(23, 22);
            this.cmdBackColor.Text = "Back Color";
            this.cmdBackColor.Click += new System.EventHandler(this.cmdBackColor_Click);
            // 
            // cmdTextColor
            // 
            this.cmdTextColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdTextColor.Image = ((System.Drawing.Image)(resources.GetObject("cmdTextColor.Image")));
            this.cmdTextColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdTextColor.Name = "cmdTextColor";
            this.cmdTextColor.Size = new System.Drawing.Size(23, 22);
            this.cmdTextColor.Text = "Text Color";
            this.cmdTextColor.Click += new System.EventHandler(this.cmdTextColor_Click);
            // 
            // cmdAlignLeft
            // 
            this.cmdAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("cmdAlignLeft.Image")));
            this.cmdAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAlignLeft.Name = "cmdAlignLeft";
            this.cmdAlignLeft.Size = new System.Drawing.Size(23, 22);
            this.cmdAlignLeft.Text = "Align Left";
            this.cmdAlignLeft.Click += new System.EventHandler(this.cmdAlignLeft_Click);
            // 
            // cmdAlignCenter
            // 
            this.cmdAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("cmdAlignCenter.Image")));
            this.cmdAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAlignCenter.Name = "cmdAlignCenter";
            this.cmdAlignCenter.Size = new System.Drawing.Size(23, 22);
            this.cmdAlignCenter.Text = "Align Center";
            this.cmdAlignCenter.Click += new System.EventHandler(this.cmdAlignCenter_Click);
            // 
            // cmdAlignRight
            // 
            this.cmdAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("cmdAlignRight.Image")));
            this.cmdAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAlignRight.Name = "cmdAlignRight";
            this.cmdAlignRight.Size = new System.Drawing.Size(23, 22);
            this.cmdAlignRight.Text = "Align Right";
            this.cmdAlignRight.Click += new System.EventHandler(this.cmdAlignRight_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // RichTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.richTextBox);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "RichTextEditor";
            this.Text = "Simple Rich Text Editor";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton cmdOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cmdBold;
        private System.Windows.Forms.ToolStripButton cmdItalic;
        private System.Windows.Forms.ToolStripButton cmdUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cmdCopy;
        private System.Windows.Forms.ToolStripButton cmdCut;
        private System.Windows.Forms.ToolStripButton cmdPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripButton cmdUndo;
        private System.Windows.Forms.ToolStripButton cmdRedo;
        private System.Windows.Forms.ToolStripButton cmdSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripButton cmdFont;
        private System.Windows.Forms.ToolStripButton cmdBackColor;
        private System.Windows.Forms.ToolStripButton cmdTextColor;
        private System.Windows.Forms.ToolStripButton cmdStrikeout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton cmdAlignLeft;
        private System.Windows.Forms.ToolStripButton cmdAlignCenter;
        private System.Windows.Forms.ToolStripButton cmdAlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

