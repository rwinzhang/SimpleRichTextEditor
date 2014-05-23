using System;
using System.Windows.Forms;
using System.Drawing;
using System.Text;

namespace SimpleEditor
{
    public partial class RichTextEditor : Form
    {
        DataFormats.Format rtf = DataFormats.GetFormat(DataFormats.Rtf);
        int indentSize = 30;

        public RichTextEditor()
        {
            InitializeComponent();
            enableSelectionCtrlView(false);
            toggleAlignView();
        }

        private void enableSelectionCtrlView(bool status = true)
        {
            cmdCopy.Enabled = status;
            ctxCopy.Enabled = status;
            cmdCut.Enabled = status;
            ctxCut.Enabled = status;
            cmdDelete.Enabled = status;
            ctxDelete.Enabled = status;
        }

        private void toggleAlignView()
        {
            switch (richTextBox.SelectionAlignment)
            {
                case HorizontalAlignment.Left:
                    cmdAlignLeft.Checked = true;
                    cmdAlignCenter.Checked = false;
                    cmdAlignRight.Checked = false;
                    break;
                case HorizontalAlignment.Center:
                    cmdAlignLeft.Checked = false;
                    cmdAlignCenter.Checked = true;
                    cmdAlignRight.Checked = false;
                    break;
                case HorizontalAlignment.Right:
                    cmdAlignLeft.Checked = false;
                    cmdAlignCenter.Checked = false;
                    cmdAlignRight.Checked = true;
                    break;
            }
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "File Teks Berformat (*.rtf)|*.rtf|File Teks (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK && !String.IsNullOrWhiteSpace(openFileDialog.FileName))
            {
                if (openFileDialog.FilterIndex == 1)
                {
                    richTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "File Teks Berformat (*.rtf)|*.rtf|File Teks (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && !String.IsNullOrWhiteSpace(saveFileDialog.FileName))
            {
                if (saveFileDialog.FilterIndex == 1)
                {
                    richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void cmdUndo_Click(object sender, EventArgs e)
        {
            if (richTextBox.CanUndo)
            {
                richTextBox.Undo();
                richTextBox.ClearUndo();
            }
        }

        private void cmdRedo_Click(object sender, EventArgs e)
        {
            if (richTextBox.CanRedo)
            {
                richTextBox.Redo();
            }
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.Copy();
            }
        }

        private void cmdCut_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.Cut();
            }
        }

        private void cmdPaste_Click(object sender, EventArgs e)
        {
            if (richTextBox.CanPaste(rtf))
            {
                richTextBox.Paste(rtf);
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.SelectedRtf = "";
            }
        }

        private void cmdSelectAll_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void cmdBold_Click(object sender, EventArgs e)
        {
            var newStyle = richTextBox.SelectionFont.Style;
            if (richTextBox.SelectionFont.Bold)
            {
                newStyle &= ~FontStyle.Bold;
            }
            else
            {
                newStyle |= FontStyle.Bold;
            }
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, newStyle);
            cmdBold.Checked = true;
        }

        private void cmdItalic_Click(object sender, EventArgs e)
        {
            var newStyle = richTextBox.SelectionFont.Style;
            if (richTextBox.SelectionFont.Italic)
            {
                newStyle &= ~FontStyle.Italic;
            }
            else
            {
                newStyle |= FontStyle.Italic;
            }
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, newStyle);
            cmdItalic.Checked = true;
        }

        private void cmdUnderline_Click(object sender, EventArgs e)
        {
            var newStyle = richTextBox.SelectionFont.Style;
            if (richTextBox.SelectionFont.Underline)
            {
                newStyle &= ~FontStyle.Underline;
            }
            else
            {
                newStyle |= FontStyle.Underline;
            }
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, newStyle);
            cmdUnderline.Checked = true;
        }

        private void cmdStrikeout_Click(object sender, EventArgs e)
        {
            var newStyle = richTextBox.SelectionFont.Style;
            if (richTextBox.SelectionFont.Strikeout)
            {
                newStyle &= ~FontStyle.Strikeout;
            }
            else
            {
                newStyle |= FontStyle.Strikeout;
            }
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, newStyle);
            cmdStrikeout.Checked = true;
        }

        private void cmdFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionFont = fontDialog.Font;
            }
        }

        private void cmdBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionBackColor = colorDialog.Color;
            }
        }

        private void cmdTextColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SelectionColor = colorDialog.Color;
            }
        }

        private void cmdAlignLeft_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;
            cmdAlignLeft.Checked = true;
        }

        private void cmdAlignCenter_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            cmdAlignCenter.Checked = true;
        }

        private void cmdAlignRight_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
            cmdAlignRight.Checked = true;
        }

        private void cmdBullets_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionBullet = !richTextBox.SelectionBullet;
        }

        private void cmdIndent_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionIndent += indentSize;
        }

        private void cmdUnindent_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionIndent -= indentSize;
        }

        private void richTextBox_SelectionChanged(object sender, EventArgs e)
        {
            toggleAlignView();
            toggleBulletView();
            toggleFontView();

            var status = new StringBuilder();

            if (richTextBox.SelectionLength > 0)
            {
                enableSelectionCtrlView();
                int lines = richTextBox.GetLineFromCharIndex(richTextBox.SelectionStart + richTextBox.SelectionLength) -
                    richTextBox.GetLineFromCharIndex(richTextBox.SelectionStart) + 1;

                status.Append(lines)
                    .Append(" Baris, ");

                status.Append(richTextBox.SelectionLength)
                    .Append(" Karakter Terseleksi");
            }
            else
            {
                enableSelectionCtrlView(false);
                status.Append("Baris ")
                    .Append(richTextBox.GetLineFromCharIndex(richTextBox.GetFirstCharIndexOfCurrentLine()) + 1)
                    .Append(", Kolom ")
                    .Append(richTextBox.SelectionStart - richTextBox.GetFirstCharIndexOfCurrentLine() + 1);
            }
            statusLabel.Text = status.ToString();
        }

        private void toggleFontView()
        {
            if (richTextBox.SelectionFont.Bold)
            {
                cmdBold.Checked = true;
            }
            else
            {
                cmdBold.Checked = false;
            }

            if (richTextBox.SelectionFont.Italic)
            {
                cmdItalic.Checked = true;
            }
            else
            {
                cmdItalic.Checked = false;
            }

            if (richTextBox.SelectionFont.Underline)
            {
                cmdUnderline.Checked = true;
            }
            else
            {
                cmdUnderline.Checked = false;
            }

            if (richTextBox.SelectionFont.Strikeout)
            {
                cmdStrikeout.Checked = true;
            }
            else
            {
                cmdStrikeout.Checked = false;
            }
        }

        private void toggleBulletView()
        {
            if (richTextBox.SelectionBullet)
            {
                cmdBullets.Checked = true;
            }
            else
            {
                cmdBullets.Checked = false;
            }
        }

        private void cmdAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ERWIN (11 111 0882)", "Author");
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }
    }
}
