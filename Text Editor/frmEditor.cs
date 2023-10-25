﻿/*
 * Programmer: Hunter Johnson
 * Name: Rich Text Editor
 * Date: November 1, 2016 
 */
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Text_Editor
{
    public partial class frmEditor : Form
    {
        string filenamee;    // file opened inside of RTB

        public frmEditor()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(32, 32, 32);
            richTextBox1.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void frmEditor_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            richTextBox1.AllowDrop = true;     // to allow drag and drop to the RichTextBox
            richTextBox1.AcceptsTab = true;    // allow tab
            richTextBox1.ShortcutsEnabled = true;    // allow shortcuts
            richTextBox1.DetectUrls = true;    // allow detect url
            fontDialog1.ShowColor = true;
            fontDialog1.ShowApply = true;
            fontDialog1.ShowHelp = true;
            leftAlignStripButton.Checked = true;
            centerAlignStripButton.Checked = false;
            rightAlignStripButton.Checked = false;
            rightAlignStripButton.Checked = false;
            MinimizeBox = false;
            MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            // fill zoomDropDownButton item list
            zoomDropDownButton.DropDown.Items.Add("20%");
            zoomDropDownButton.DropDown.Items.Add("50%");
            zoomDropDownButton.DropDown.Items.Add("70%");
            zoomDropDownButton.DropDown.Items.Add("100%");
            zoomDropDownButton.DropDown.Items.Add("150%");
            zoomDropDownButton.DropDown.Items.Add("200%");
            zoomDropDownButton.DropDown.Items.Add("300%");
            zoomDropDownButton.DropDown.Items.Add("400%");
            zoomDropDownButton.DropDown.Items.Add("500%");

            this.ResumeLayout();

            this.ucToolbar1.boldStripButton.Click += new System.EventHandler(this.boldStripButton3_Click);
            this.ucToolbar1.italicStripButton.Click += new System.EventHandler(this.italicStripButton_Click);
            this.ucToolbar1.underlineStripButton.Click += new System.EventHandler(this.underlineStripButton_Click);
            this.ucToolbar1.colorStripDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.colorStripDropDownButton_DropDownItemClicked);
            this.ucToolbar1.clearFormattingStripButton.Click += new System.EventHandler(this.clearFormattingStripButton_Click);
            this.ucToolbar1.blistToolStripMenuItem.Click += bulletListStripButton_Click;
            this.ucToolbar1.textToolStripMenuItem.Click += textListStripButton_Click;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();     // select all text
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // clear
            richTextBox1.Clear();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();     // paste text
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();      // copy text
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();     // cut text
        }

        private void boldStripButton3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                return;
            }

            // create fontStyle object
            FontStyle style = richTextBox1.SelectionFont.Style;

            // determines the font style
            if (richTextBox1.SelectionFont.Bold)
            {
                style &= ~FontStyle.Bold; 
            }
            else
            {
                style |= FontStyle.Bold;

            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);     // sets the font style
        }

        private void underlineStripButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                return;
            }

            // create fontStyle object
            FontStyle style = richTextBox1.SelectionFont.Style;

            // determines the font style
            if (richTextBox1.SelectionFont.Underline)
            {
                style &= ~FontStyle.Underline;
            }
            else
            {
                style |= FontStyle.Underline;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);    // sets the font style
        }

        private void italicStripButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                return;
            }
            // create fontStyle object
            FontStyle style = richTextBox1.SelectionFont.Style;

            // determines font style
            if (richTextBox1.SelectionFont.Italic)
            {
                style &= ~FontStyle.Italic;
            }
            else
            {
                style |= FontStyle.Italic;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);    // sets the font style
        }

        private void fontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                return;
            }
            // sets the font size when changed
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,Convert.ToInt32(fontSizeComboBox.Text),richTextBox1.SelectionFont.Style);
        }

        private void saveStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                string file;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filename = saveFileDialog1.FileName;
                    // save the contents of the rich text box
                    richTextBox1.SaveFile(filename, RichTextBoxStreamType.RichText);
                    file = Path.GetFileName(filename);    // get name of file
                    MessageBox.Show("File " + file + " was saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void openFileStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filenamee = openFileDialog1.FileName;
                // load the file into the richTextBox
                richTextBox1.LoadFile(filenamee, RichTextBoxStreamType.RichText);    // loads it in regular text format
                // richTextBox1.LoadFile(filename, RichTextBoxStreamType.RichText);    // loads it in RTB format
            }
        }

            private void colorStripDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // creates a KnownColor object
            KnownColor selectedColor;
            selectedColor = (KnownColor)System.Enum.Parse(typeof(KnownColor), e.ClickedItem.Text);    // converts it to a Color Structure
            richTextBox1.SelectionColor = Color.FromKnownColor(selectedColor);    // sets the selected color
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.SelectedText))
            {
                var charPos = richTextBox1.GetPositionFromCharIndex(richTextBox1.SelectionStart);
                int finalX = richTextBox1.Location.X+ charPos.X - 12;
                int finalY = richTextBox1.Location.Y + charPos.Y - 30;
                if (finalX + ucToolbar1.Width > richTextBox1.Location.X + richTextBox1.Width)
                    finalX = richTextBox1.Location.X + richTextBox1.Width - ucToolbar1.Width;

                ucToolbar1.Location = new Point(finalX, finalY);
                ucToolbar1.DelayVisible(true, 200);
            }
            else
            {
                ucToolbar1.DelayVisible(false, 1000);
            }
        }

        private void leftAlignStripButton_Click(object sender, EventArgs e)
        {
            // set properties
            centerAlignStripButton.Checked = false;
            rightAlignStripButton.Checked = false;
            if(leftAlignStripButton.Checked == false)
            {
                leftAlignStripButton.Checked = true;    // LEFT ALIGN is active
            }
            else if(leftAlignStripButton.Checked == true)
            {
                leftAlignStripButton.Checked = false;    // LEFT ALIGN is not active
            }
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;    // selects left alignment
        }

        private void centerAlignStripButton_Click(object sender, EventArgs e)
        {
            // set properties
            leftAlignStripButton.Checked = false;
            rightAlignStripButton.Checked = false;
            if (centerAlignStripButton.Checked == false)
            {
                centerAlignStripButton.Checked = true;    // CENTER ALIGN is active
            }
            else if (centerAlignStripButton.Checked == true)
            {
                centerAlignStripButton.Checked = false;    // CENTER ALIGN is not active
            }
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;     // selects center alignment
        }

        private void rightAlignStripButton_Click(object sender, EventArgs e)
        { 
            // set properties
            leftAlignStripButton.Checked = false;
            centerAlignStripButton.Checked = false;

            if (rightAlignStripButton.Checked == false)
            {
                rightAlignStripButton.Checked = true;    // RIGHT ALIGN is active
            }
            else if (rightAlignStripButton.Checked == true)
            {
                rightAlignStripButton.Checked = false;    // RIGHT ALIGN is not active
            }
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;    // selects right alignment
        }

        private void bulletListStripButton_Click(object sender, EventArgs e)
        {
            // 判断当前行的第一个字符是否是 "x"
            if (!IsLineMyBullet(out int currentLineIndex))
            {
                // 如果不是 "x"，在当前行的开头插入 "x"
                richTextBox1.SelectionStart = richTextBox1.GetFirstCharIndexFromLine(currentLineIndex);
                richTextBox1.SelectionLength = 0;
                richTextBox1.SelectedText = bulletMarker[richTextBox1.SelectionIndent / 60].ToString() + " ";
            }
        }

        private void textListStripButton_Click(object sender, EventArgs e)
        {
            // 判断当前行的第一个字符是否是 "x"
            if (IsLineMyBullet(out int currentLineIndex))
            {
                // 如果是 "x"，选中并删除它
                richTextBox1.Select(richTextBox1.GetFirstCharIndexFromLine(currentLineIndex), 1);
                richTextBox1.SelectedText = "";

                richTextBox1.Select(richTextBox1.GetFirstCharIndexFromLine(currentLineIndex), 1);
                if(string.IsNullOrWhiteSpace(richTextBox1.SelectedText))
                    richTextBox1.SelectedText = "";
            }
        }

        private void increaseStripButton_Click(object sender, EventArgs e)
        {
            string fontSizeNum = fontSizeComboBox.Text;    // variable to hold selected size         
            try
            {
                int size = Convert.ToInt32(fontSizeNum) + 1;    // convert (fontSizeNum + 1)
                if (richTextBox1.SelectionFont == null)
                {
                    return;
                }
                // sets the updated font size
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,size,richTextBox1.SelectionFont.Style);
                fontSizeComboBox.Text = size.ToString();    // update font size
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Information", MessageBoxButtons.OK, MessageBoxIcon.Warning); // show error message
            }
        }

        private void decreaseStripButton_Click(object sender, EventArgs e)
        {
            string fontSizeNum = fontSizeComboBox.Text;    // variable to hold selected size            
            try
            {
                int size = Convert.ToInt32(fontSizeNum) - 1;    // convert (fontSizeNum - 1)
                if (richTextBox1.SelectionFont == null)
                {
                    return;
                }
                // sets the updated font size
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,size,richTextBox1.SelectionFont.Style);
                fontSizeComboBox.Text = size.ToString();    // update font size
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Information", MessageBoxButtons.OK, MessageBoxIcon.Warning); // show error message
            }
        }

        //*********************************************************************************************
        // richTextBox1_DragEnter - Custom Event. Copies text being dragged into the richTextBox      *
        //*********************************************************************************************
        private void richTextBox1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;    // copies data to the RTB
            else
                e.Effect = DragDropEffects.None;    // doesn't accept data into RTB
        }
        //***************************************************************************************************
        // richTextBox1_DragEnter - Custom Event. Drops the copied text being dragged onto the richTextBox  *
        //***************************************************************************************************
        private void richTextBox1_DragDrop(object sender,System.Windows.Forms.DragEventArgs e)
        {
            // variables
            int i;
            String s;

            // Get start position to drop the text.
            i = richTextBox1.SelectionStart;
            s = richTextBox1.Text.Substring(i);
            richTextBox1.Text = richTextBox1.Text.Substring(0, i);

            // Drop the text on to the RichTextBox.
            richTextBox1.Text += e.Data.GetData(DataFormats.Text).ToString();
            richTextBox1.Text += s;
        }

        private void undoStripButton_Click(object sender, EventArgs e)
        {           
            richTextBox1.Undo();     // undo move
        }

        private void redoStripButton_Click(object sender, EventArgs e)
        {            
            richTextBox1.Redo();    // redo move
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.Close();     // close the form
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            richTextBox1.Undo();     // undo move
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            richTextBox1.Redo();     // redo move
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {            
            richTextBox1.Cut();     // cut text
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Copy();     // copy text
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {           
            richTextBox1.Paste();    // paste text
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {            
            richTextBox1.SelectAll();    // select all text
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // clear the rich text box
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // delete selected text
            richTextBox1.SelectedText = "";
            richTextBox1.Focus();
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                // richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);  // loads the file in RTB format
            }
        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            
            if (richTextBox1.Text != string.Empty)    // RTB has contents - prompt user to save changes
            {
               // save changes message
               DialogResult result =  MessageBox.Show("Would you like to save your changes? Editor is not empty.", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if(result == DialogResult.Yes)
                {
                    // save the RTB contents if user selected yes
                    saveFileDialog1.ShowDialog();    // show the dialog
                    string file;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string filename = saveFileDialog1.FileName;
                        // save the contents of the rich text box
                        richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
                        file = Path.GetFileName(filename); // get name of file
                        MessageBox.Show("File " + file + " was saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // finally - clear the contents of the RTB 
                    richTextBox1.ResetText();
                    richTextBox1.Focus();
                }
                else if(result == DialogResult.No)
                {
                    // clear the contents of the RTB 
                    richTextBox1.ResetText();
                    richTextBox1.Focus();
                }               
            }
            else // RTB has no contents
            {
                // clear the contents of the RTB 
                richTextBox1.ResetText();
                richTextBox1.Focus();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();    // show the dialog
            string file; 

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                // save the contents of the rich text box
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
            }
            file = Path.GetFileName(filenamee);    // get name of file
            MessageBox.Show("File " + file + " was saved successfully.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void zoomDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            float zoomPercent = Convert.ToSingle(e.ClickedItem.Text.Trim('%')); // convert
            richTextBox1.ZoomFactor = zoomPercent / 100;    // set zoom factor

            if(e.ClickedItem.Image == null)
            {
                // sets all the image properties to null - incase one is already selected beforehand
                for (int i = 0; i < zoomDropDownButton.DropDownItems.Count; i++)
                {
                    zoomDropDownButton.DropDownItems[i].Image = null;
                }

                // draw bmp in image property of selected item, while its active
                Bitmap bmp = new Bitmap(5, 5);
                using (Graphics gfx = Graphics.FromImage(bmp))
                {
                    gfx.FillEllipse(Brushes.Black, 1, 1, 3, 3);
                }
                e.ClickedItem.Image = bmp;    // draw ellipse in image property
            }
            else
            {
                e.ClickedItem.Image = null;
                richTextBox1.ZoomFactor = 1.0f;    // set back to NO ZOOM
            }
        }

        private void uppercaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToUpper();    // text to CAPS
        }

        private void lowercaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower();    // text to lowercase
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // draw bmp in image property of selected item, while its active
            Bitmap bmp = new Bitmap(5, 5);
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.FillEllipse(Brushes.Black, 1, 1, 3, 3);
            }

            if (richTextBox1.WordWrap == false)
            {
                richTextBox1.WordWrap = true;    // WordWrap is active
                wordWrapToolStripMenuItem.Image = bmp;    // draw ellipse in image property
            }
            else if(richTextBox1.WordWrap == true)
            {
                richTextBox1.WordWrap = false;    // WordWrap is not active
                wordWrapToolStripMenuItem.Image = null;    // clear image property
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                fontDialog1.ShowDialog();    // show the Font Dialog
                System.Drawing.Font oldFont = this.Font;    // gets current font

                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    fontDialog1_Apply(richTextBox1, new System.EventArgs());
                }
                // set back to the recent font
                else if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    // set current font back to the old font
                    this.Font = oldFont;

                    // sets the old font for the controls inside richTextBox1
                    foreach (Control containedControl in richTextBox1.Controls)
                    {
                        containedControl.Font = oldFont;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Information", MessageBoxButtons.OK, MessageBoxIcon.Warning); // error
            }
        }

        private void fontDialog1_HelpRequest(object sender, EventArgs e)
        {
            // display HelpRequest message
            MessageBox.Show("Please choose a font and any other attributes; then hit Apply and OK.", "Font Dialog Help Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            fontDialog1.FontMustExist = true;    // error if font doesn't exist
            
            richTextBox1.Font = fontDialog1.Font;    // set selected font (Includes: FontFamily, Size, and, Effect. No need to set them separately)
            richTextBox1.ForeColor = fontDialog1.Color;    // set selected font color
            
            // sets the font for the controls inside richTextBox1
            foreach (Control containedControl in richTextBox1.Controls)
            {
                containedControl.Font = fontDialog1.Font;
            }
        }

        private void deleteStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = ""; // delete selected text
        }

        private void clearFormattingStripButton_Click(object sender, EventArgs e)
        {
            ClearFormat();
        }

        private void ClearFormat()
        {
            if (richTextBox1.SelectionFont == null)
            {
                return;
            }
            // create fontStyle object
            FontStyle style = richTextBox1.SelectionFont.Style;

            style &= ~FontStyle.Underline;
            style &= ~FontStyle.Bold;
            style &= ~FontStyle.Italic;

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void imgStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImageDlg = new OpenFileDialog();
            openImageDlg.Filter = "所有图片(*.bmp,*.gif,*.jpg)|*.bmp;*.gif;*jpg";
            openImageDlg.Title = "选择图片";
            Bitmap bmp;
            if (openImageDlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = openImageDlg.FileName;
                if (null == fileName || fileName.Trim().Length == 0)
                    return;
                try
                {
                    bmp = new Bitmap(fileName);
                    Clipboard.SetDataObject(bmp);
                    DataFormats.Format dataFormat =
                        DataFormats.GetFormat(DataFormats.Bitmap);
                    if (richTextBox1.CanPaste(dataFormat))
                        richTextBox1.Paste(dataFormat);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("图片插入失败。" + exc.Message, "提示",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        string bulletMarker = "●◆◇▷▪";
        private bool IsLineMyBullet(out int currentLineIndex)
        {
            // 获取当前行的索引
            currentLineIndex = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);

            // 获取当前行的文本
            string currentLineText = richTextBox1.Lines[currentLineIndex];

            // 判断当前行的第一个字符是否是 "x"
            if (currentLineText.Length == 0 || bulletMarker.Contains(currentLineText[0]))
                return true;
            return false;
        }

        //****************************************************************************************************************************************
        // richTextBox1_KeyUp - Determines which key was released and gets the line and column numbers of the current cursor position in the RTB *
        //**************************************************************************************************************************************** 
        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            // determine key released
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (IsLineMyBullet(out int currentLineIndex))
                    {
                        richTextBox1.SelectionStart = richTextBox1.GetFirstCharIndexFromLine(currentLineIndex);
                        richTextBox1.SelectionLength = 0;
                        richTextBox1.SelectedText = bulletMarker[richTextBox1.SelectionIndent / 60].ToString() + " ";
                    }
                    ClearFormat(); //格式不带到下一行
                    break;
                case Keys.Tab:
                    if (e.Shift)
                        richTextBox1.SelectionIndent = Math.Max(0, richTextBox1.SelectionIndent - 60);
                    else
                        richTextBox1.SelectionIndent = Math.Min(240, richTextBox1.SelectionIndent + 60);
                    if(IsLineMyBullet(out int lineIndex))
                    {
                        richTextBox1.SelectionStart = richTextBox1.GetFirstCharIndexFromLine(lineIndex);
                        richTextBox1.SelectionLength = 2;
                        richTextBox1.SelectedText = bulletMarker[richTextBox1.SelectionIndent / 60].ToString() + " ";
                    }
                    break;
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;// 阻止 Tab 键的默认行为
            }
        }

        //****************************************************************************************************************************
        // richTextBox1_MouseDown - Gets the line and column numbers of the cursor position in the RTB when the mouse clicks an area *
        //****************************************************************************************************************************
        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int pos = richTextBox1.SelectionStart;    // get starting point
            int line = richTextBox1.GetLineFromCharIndex(pos);    // get line number
            int column = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexFromLine(line);    // get column number
        }

        int previousScrollPos = 0;
        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            int currentScrollPos = richTextBox1.GetPositionFromCharIndex(0).Y;

            if (currentScrollPos != previousScrollPos)
            {
                pictureBoxLeftS.Visible = false; // 滚动后，隐藏操作图标
            }

            previousScrollPos = currentScrollPos;
        }

        int lastRowId = -1;
        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            var charIndex = richTextBox1.GetCharIndexFromPosition(e.Location);
            int rowIndex = richTextBox1.GetLineFromCharIndex(charIndex);

            if (lastRowId != rowIndex)
            {
                pictureBoxLeftS.Visible = true;

                var charPos = richTextBox1.GetPositionFromCharIndex(charIndex);
                pictureBoxLeftS.Location = new Point(20, charPos.Y + richTextBox1.Location.Y);
                lastRowId = rowIndex;
            }
        }

    }
}
