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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RichTextEditor));
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxCut = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.cmdOpen = new System.Windows.Forms.ToolStripButton();
            this.cmdNew = new System.Windows.Forms.ToolStripButton();
            this.cmdSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdUndo = new System.Windows.Forms.ToolStripButton();
            this.cmdRedo = new System.Windows.Forms.ToolStripButton();
            this.cmdSelectAll = new System.Windows.Forms.ToolStripButton();
            this.cmdDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdCut = new System.Windows.Forms.ToolStripButton();
            this.cmdCopy = new System.Windows.Forms.ToolStripButton();
            this.cmdPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdBold = new System.Windows.Forms.ToolStripButton();
            this.cmdItalic = new System.Windows.Forms.ToolStripButton();
            this.cmdUnderline = new System.Windows.Forms.ToolStripButton();
            this.cmdStrikeout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdFont = new System.Windows.Forms.ToolStripButton();
            this.cmdBackColor = new System.Windows.Forms.ToolStripButton();
            this.cmdTextColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.cmdAlignCenter = new System.Windows.Forms.ToolStripButton();
            this.cmdAlignRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdBullets = new System.Windows.Forms.ToolStripButton();
            this.cmdIndent = new System.Windows.Forms.ToolStripButton();
            this.cmdUnindent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdAbout = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.AcceptsTab = true;
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.ContextMenuStrip = this.contextMenuStrip;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(0, 36);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ShowSelectionMargin = true;
            this.richTextBox.Size = new System.Drawing.Size(784, 500);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.SelectionChanged += new System.EventHandler(this.richTextBox_SelectionChanged);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxCut,
            this.ctxCopy,
            this.ctxPaste,
            this.toolStripSeparator7,
            this.ctxSelectAll,
            this.ctxDelete});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(123, 120);
            // 
            // ctxCut
            // 
            this.ctxCut.Image = ((System.Drawing.Image)(resources.GetObject("ctxCut.Image")));
            this.ctxCut.Name = "ctxCut";
            this.ctxCut.Size = new System.Drawing.Size(122, 22);
            this.ctxCut.Text = "Cut";
            this.ctxCut.Click += new System.EventHandler(this.cmdCut_Click);
            // 
            // ctxCopy
            // 
            this.ctxCopy.Image = global::SimpleEditor.Properties.Resources.copy;
            this.ctxCopy.Name = "ctxCopy";
            this.ctxCopy.Size = new System.Drawing.Size(122, 22);
            this.ctxCopy.Text = "Copy";
            this.ctxCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // ctxPaste
            // 
            this.ctxPaste.Image = global::SimpleEditor.Properties.Resources.paste;
            this.ctxPaste.Name = "ctxPaste";
            this.ctxPaste.Size = new System.Drawing.Size(122, 22);
            this.ctxPaste.Text = "Paste";
            this.ctxPaste.Click += new System.EventHandler(this.cmdPaste_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(119, 6);
            // 
            // ctxSelectAll
            // 
            this.ctxSelectAll.Image = global::SimpleEditor.Properties.Resources.select_all;
            this.ctxSelectAll.Name = "ctxSelectAll";
            this.ctxSelectAll.Size = new System.Drawing.Size(122, 22);
            this.ctxSelectAll.Text = "Select All";
            this.ctxSelectAll.Click += new System.EventHandler(this.cmdSelectAll_Click);
            // 
            // ctxDelete
            // 
            this.ctxDelete.Image = global::SimpleEditor.Properties.Resources.delete;
            this.ctxDelete.Name = "ctxDelete";
            this.ctxDelete.Size = new System.Drawing.Size(122, 22);
            this.ctxDelete.Text = "Delete";
            this.ctxDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdOpen,
            this.cmdNew,
            this.cmdSave,
            this.toolStripSeparator1,
            this.cmdUndo,
            this.cmdRedo,
            this.cmdSelectAll,
            this.cmdDelete,
            this.toolStripSeparator2,
            this.cmdCut,
            this.cmdCopy,
            this.cmdPaste,
            this.toolStripSeparator3,
            this.cmdBold,
            this.cmdItalic,
            this.cmdUnderline,
            this.cmdStrikeout,
            this.toolStripSeparator4,
            this.cmdFont,
            this.cmdBackColor,
            this.cmdTextColor,
            this.toolStripSeparator5,
            this.cmdAlignLeft,
            this.cmdAlignCenter,
            this.cmdAlignRight,
            this.toolStripSeparator6,
            this.cmdBullets,
            this.cmdIndent,
            this.cmdUnindent,
            this.toolStripSeparator8,
            this.cmdAbout});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip.Size = new System.Drawing.Size(784, 33);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // cmdOpen
            // 
            this.cmdOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdOpen.Image = global::SimpleEditor.Properties.Resources.open;
            this.cmdOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(23, 20);
            this.cmdOpen.Text = "Open";
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // cmdNew
            // 
            this.cmdNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdNew.Image = global::SimpleEditor.Properties.Resources.new_file;
            this.cmdNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(23, 20);
            this.cmdNew.Text = "New";
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdSave.Image = global::SimpleEditor.Properties.Resources.save;
            this.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(23, 20);
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // cmdUndo
            // 
            this.cmdUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdUndo.Image = global::SimpleEditor.Properties.Resources.undo;
            this.cmdUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdUndo.Name = "cmdUndo";
            this.cmdUndo.Size = new System.Drawing.Size(23, 20);
            this.cmdUndo.Text = "Undo";
            this.cmdUndo.Click += new System.EventHandler(this.cmdUndo_Click);
            // 
            // cmdRedo
            // 
            this.cmdRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdRedo.Image = global::SimpleEditor.Properties.Resources.redo;
            this.cmdRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdRedo.Name = "cmdRedo";
            this.cmdRedo.Size = new System.Drawing.Size(23, 20);
            this.cmdRedo.Text = "Redo";
            this.cmdRedo.Click += new System.EventHandler(this.cmdRedo_Click);
            // 
            // cmdSelectAll
            // 
            this.cmdSelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdSelectAll.Image = global::SimpleEditor.Properties.Resources.select_all;
            this.cmdSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSelectAll.Name = "cmdSelectAll";
            this.cmdSelectAll.Size = new System.Drawing.Size(23, 20);
            this.cmdSelectAll.Text = "Select All";
            this.cmdSelectAll.Click += new System.EventHandler(this.cmdSelectAll_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdDelete.Image = global::SimpleEditor.Properties.Resources.delete;
            this.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(23, 20);
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // cmdCut
            // 
            this.cmdCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdCut.Image = global::SimpleEditor.Properties.Resources.cut;
            this.cmdCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdCut.Name = "cmdCut";
            this.cmdCut.Size = new System.Drawing.Size(23, 20);
            this.cmdCut.Text = "Cut";
            this.cmdCut.Click += new System.EventHandler(this.cmdCut_Click);
            // 
            // cmdCopy
            // 
            this.cmdCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdCopy.Image = global::SimpleEditor.Properties.Resources.copy;
            this.cmdCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(23, 20);
            this.cmdCopy.Text = "Copy";
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // cmdPaste
            // 
            this.cmdPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdPaste.Image = global::SimpleEditor.Properties.Resources.paste;
            this.cmdPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPaste.Name = "cmdPaste";
            this.cmdPaste.Size = new System.Drawing.Size(23, 20);
            this.cmdPaste.Text = "Paste";
            this.cmdPaste.Click += new System.EventHandler(this.cmdPaste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // cmdBold
            // 
            this.cmdBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdBold.Image = global::SimpleEditor.Properties.Resources.text_bold;
            this.cmdBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdBold.Name = "cmdBold";
            this.cmdBold.Size = new System.Drawing.Size(23, 20);
            this.cmdBold.Text = "Bold";
            this.cmdBold.Click += new System.EventHandler(this.cmdBold_Click);
            // 
            // cmdItalic
            // 
            this.cmdItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdItalic.Image = global::SimpleEditor.Properties.Resources.text_italic;
            this.cmdItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdItalic.Name = "cmdItalic";
            this.cmdItalic.Size = new System.Drawing.Size(23, 20);
            this.cmdItalic.Text = "Italic";
            this.cmdItalic.Click += new System.EventHandler(this.cmdItalic_Click);
            // 
            // cmdUnderline
            // 
            this.cmdUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdUnderline.Image = global::SimpleEditor.Properties.Resources.text_underline;
            this.cmdUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdUnderline.Name = "cmdUnderline";
            this.cmdUnderline.Size = new System.Drawing.Size(23, 20);
            this.cmdUnderline.Text = "Underline";
            this.cmdUnderline.Click += new System.EventHandler(this.cmdUnderline_Click);
            // 
            // cmdStrikeout
            // 
            this.cmdStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdStrikeout.Image = global::SimpleEditor.Properties.Resources.text_strikethrough;
            this.cmdStrikeout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdStrikeout.Name = "cmdStrikeout";
            this.cmdStrikeout.Size = new System.Drawing.Size(23, 20);
            this.cmdStrikeout.Text = "Strikeout";
            this.cmdStrikeout.Click += new System.EventHandler(this.cmdStrikeout_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // cmdFont
            // 
            this.cmdFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdFont.Image = global::SimpleEditor.Properties.Resources.font;
            this.cmdFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdFont.Name = "cmdFont";
            this.cmdFont.Size = new System.Drawing.Size(23, 20);
            this.cmdFont.Text = "Font";
            this.cmdFont.Click += new System.EventHandler(this.cmdFont_Click);
            // 
            // cmdBackColor
            // 
            this.cmdBackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdBackColor.Image = global::SimpleEditor.Properties.Resources.text_back_color;
            this.cmdBackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdBackColor.Name = "cmdBackColor";
            this.cmdBackColor.Size = new System.Drawing.Size(23, 20);
            this.cmdBackColor.Text = "Back Color";
            this.cmdBackColor.Click += new System.EventHandler(this.cmdBackColor_Click);
            // 
            // cmdTextColor
            // 
            this.cmdTextColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdTextColor.Image = global::SimpleEditor.Properties.Resources.text_color;
            this.cmdTextColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdTextColor.Name = "cmdTextColor";
            this.cmdTextColor.Size = new System.Drawing.Size(23, 20);
            this.cmdTextColor.Text = "Text Color";
            this.cmdTextColor.Click += new System.EventHandler(this.cmdTextColor_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // cmdAlignLeft
            // 
            this.cmdAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdAlignLeft.Image = global::SimpleEditor.Properties.Resources.text_align_left;
            this.cmdAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAlignLeft.Name = "cmdAlignLeft";
            this.cmdAlignLeft.Size = new System.Drawing.Size(23, 20);
            this.cmdAlignLeft.Text = "Align Left";
            this.cmdAlignLeft.Click += new System.EventHandler(this.cmdAlignLeft_Click);
            // 
            // cmdAlignCenter
            // 
            this.cmdAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdAlignCenter.Image = global::SimpleEditor.Properties.Resources.text_align_center;
            this.cmdAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAlignCenter.Name = "cmdAlignCenter";
            this.cmdAlignCenter.Size = new System.Drawing.Size(23, 20);
            this.cmdAlignCenter.Text = "Align Center";
            this.cmdAlignCenter.Click += new System.EventHandler(this.cmdAlignCenter_Click);
            // 
            // cmdAlignRight
            // 
            this.cmdAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdAlignRight.Image = global::SimpleEditor.Properties.Resources.text_align_right;
            this.cmdAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAlignRight.Name = "cmdAlignRight";
            this.cmdAlignRight.Size = new System.Drawing.Size(23, 20);
            this.cmdAlignRight.Text = "Align Right";
            this.cmdAlignRight.Click += new System.EventHandler(this.cmdAlignRight_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 23);
            // 
            // cmdBullets
            // 
            this.cmdBullets.CheckOnClick = true;
            this.cmdBullets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdBullets.Image = global::SimpleEditor.Properties.Resources.text_list_bullets;
            this.cmdBullets.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdBullets.Name = "cmdBullets";
            this.cmdBullets.Size = new System.Drawing.Size(23, 20);
            this.cmdBullets.Text = "Bullets";
            this.cmdBullets.Click += new System.EventHandler(this.cmdBullets_Click);
            // 
            // cmdIndent
            // 
            this.cmdIndent.CheckOnClick = true;
            this.cmdIndent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdIndent.Image = global::SimpleEditor.Properties.Resources.text_indent;
            this.cmdIndent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdIndent.Name = "cmdIndent";
            this.cmdIndent.Size = new System.Drawing.Size(23, 20);
            this.cmdIndent.Text = "Indent";
            this.cmdIndent.Click += new System.EventHandler(this.cmdIndent_Click);
            // 
            // cmdUnindent
            // 
            this.cmdUnindent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdUnindent.Image = global::SimpleEditor.Properties.Resources.text_indent_remove;
            this.cmdUnindent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdUnindent.Name = "cmdUnindent";
            this.cmdUnindent.Size = new System.Drawing.Size(23, 20);
            this.cmdUnindent.Text = "Unindent";
            this.cmdUnindent.Click += new System.EventHandler(this.cmdUnindent_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 23);
            // 
            // cmdAbout
            // 
            this.cmdAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdAbout.Image = global::SimpleEditor.Properties.Resources.info;
            this.cmdAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAbout.Name = "cmdAbout";
            this.cmdAbout.Size = new System.Drawing.Size(23, 20);
            this.cmdAbout.Text = "About";
            this.cmdAbout.Click += new System.EventHandler(this.cmdAbout_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(91, 17);
            this.statusLabel.Text = "Baris 1, Kolom 1";
            // 
            // RichTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.richTextBox);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "RichTextEditor";
            this.Text = "Simple Rich Text Editor";
            this.contextMenuStrip.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton cmdBullets;
        private System.Windows.Forms.ToolStripButton cmdIndent;
        private System.Windows.Forms.ToolStripButton cmdUnindent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton cmdDelete;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ctxCut;
        private System.Windows.Forms.ToolStripMenuItem ctxCopy;
        private System.Windows.Forms.ToolStripMenuItem ctxPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem ctxSelectAll;
        private System.Windows.Forms.ToolStripMenuItem ctxDelete;
        private System.Windows.Forms.ToolStripButton cmdSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton cmdAbout;
        private System.Windows.Forms.ToolStripButton cmdNew;
    }
}

