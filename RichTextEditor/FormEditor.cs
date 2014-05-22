using System;
using System.Windows.Forms;
using System.Drawing;

namespace SimpleEditor
{
    public partial class RichTextEditor : Form
    {
        DataFormats.Format rtf = DataFormats.GetFormat(DataFormats.Rtf);

        public RichTextEditor()
        {
            InitializeComponent();
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
        }

        private void cmdAlignCenter_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void cmdAlignRight_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }
    }
}
