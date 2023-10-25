namespace Text_Editor
{
    partial class frmEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditor));
            this.richContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveStripButton = new System.Windows.Forms.ToolStripButton();
            this.openFileStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.undoStripButton = new System.Windows.Forms.ToolStripButton();
            this.redoStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fontSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.increaseStripButton = new System.Windows.Forms.ToolStripButton();
            this.decreaseStripButton = new System.Windows.Forms.ToolStripButton();
            this.colorStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.changeCaseDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.lowercaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uppercaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.imgStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.leftAlignStripButton = new System.Windows.Forms.ToolStripButton();
            this.centerAlignStripButton = new System.Windows.Forms.ToolStripButton();
            this.rightAlignStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pictureBoxLeftS = new System.Windows.Forms.PictureBox();
            this.ucToolbar1 = new Text_Editor.UCToolbar();
            this.richTextBox1 = new Text_Editor.RichTextBoxEx();
            this.richContextStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftS)).BeginInit();
            this.SuspendLayout();
            // 
            // richContextStrip
            // 
            this.richContextStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.richContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.richContextStrip.Name = "richContextStrip";
            this.richContextStrip.Size = new System.Drawing.Size(212, 184);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteStripMenuItem
            // 
            this.deleteStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteStripMenuItem.Image")));
            this.deleteStripMenuItem.Name = "deleteStripMenuItem";
            this.deleteStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.deleteStripMenuItem.Text = "Delete";
            this.deleteStripMenuItem.Click += new System.EventHandler(this.deleteStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectAllToolStripMenuItem.Image")));
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearToolStripMenuItem.Image")));
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.clearToolStripMenuItem.Text = "Clear All";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 832);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1372, 6);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 8);
            this.panel1.TabIndex = 14;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveStripButton,
            this.openFileStripButton,
            this.toolStripSeparator10,
            this.undoStripButton,
            this.redoStripButton,
            this.toolStripSeparator1,
            this.fontSizeComboBox,
            this.increaseStripButton,
            this.decreaseStripButton,
            this.colorStripDropDownButton,
            this.changeCaseDropDownButton,
            this.toolStripSeparator9,
            this.imgStripButton,
            this.toolStripSeparator2,
            this.leftAlignStripButton,
            this.centerAlignStripButton,
            this.rightAlignStripButton,
            this.toolStripSeparator4,
            this.zoomDropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 34);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1372, 31);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveStripButton
            // 
            this.saveStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveStripButton.Image")));
            this.saveStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveStripButton.Name = "saveStripButton";
            this.saveStripButton.Size = new System.Drawing.Size(29, 28);
            this.saveStripButton.Text = "Save File";
            this.saveStripButton.Click += new System.EventHandler(this.saveStripButton_Click);
            // 
            // openFileStripButton
            // 
            this.openFileStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFileStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openFileStripButton.Image")));
            this.openFileStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileStripButton.Name = "openFileStripButton";
            this.openFileStripButton.Size = new System.Drawing.Size(29, 28);
            this.openFileStripButton.Text = "Open File";
            this.openFileStripButton.Click += new System.EventHandler(this.openFileStripButton_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 31);
            // 
            // undoStripButton
            // 
            this.undoStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoStripButton.Image = ((System.Drawing.Image)(resources.GetObject("undoStripButton.Image")));
            this.undoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoStripButton.Name = "undoStripButton";
            this.undoStripButton.Size = new System.Drawing.Size(29, 28);
            this.undoStripButton.Text = "Undo Move";
            this.undoStripButton.Click += new System.EventHandler(this.undoStripButton_Click);
            // 
            // redoStripButton
            // 
            this.redoStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoStripButton.Image = ((System.Drawing.Image)(resources.GetObject("redoStripButton.Image")));
            this.redoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoStripButton.Name = "redoStripButton";
            this.redoStripButton.Size = new System.Drawing.Size(29, 28);
            this.redoStripButton.Text = "Redo Move";
            this.redoStripButton.Click += new System.EventHandler(this.redoStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.AutoSize = false;
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(96, 28);
            this.fontSizeComboBox.Text = "Font Size";
            this.fontSizeComboBox.ToolTipText = "Font Size";
            this.fontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.fontSizeComboBox_SelectedIndexChanged);
            // 
            // increaseStripButton
            // 
            this.increaseStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.increaseStripButton.Image = ((System.Drawing.Image)(resources.GetObject("increaseStripButton.Image")));
            this.increaseStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.increaseStripButton.Name = "increaseStripButton";
            this.increaseStripButton.Size = new System.Drawing.Size(29, 28);
            this.increaseStripButton.Text = "Increase Font Size";
            this.increaseStripButton.Click += new System.EventHandler(this.increaseStripButton_Click);
            // 
            // decreaseStripButton
            // 
            this.decreaseStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decreaseStripButton.Image = ((System.Drawing.Image)(resources.GetObject("decreaseStripButton.Image")));
            this.decreaseStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decreaseStripButton.Name = "decreaseStripButton";
            this.decreaseStripButton.Size = new System.Drawing.Size(29, 28);
            this.decreaseStripButton.Text = "Decrease Font Size";
            this.decreaseStripButton.Click += new System.EventHandler(this.decreaseStripButton_Click);
            // 
            // colorStripDropDownButton
            // 
            this.colorStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("colorStripDropDownButton.Image")));
            this.colorStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorStripDropDownButton.Name = "colorStripDropDownButton";
            this.colorStripDropDownButton.Size = new System.Drawing.Size(38, 28);
            this.colorStripDropDownButton.Text = "Font Color";
            this.colorStripDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.colorStripDropDownButton_DropDownItemClicked);
            // 
            // changeCaseDropDownButton
            // 
            this.changeCaseDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.changeCaseDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowercaseToolStripMenuItem,
            this.uppercaseToolStripMenuItem});
            this.changeCaseDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("changeCaseDropDownButton.Image")));
            this.changeCaseDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changeCaseDropDownButton.Name = "changeCaseDropDownButton";
            this.changeCaseDropDownButton.Size = new System.Drawing.Size(38, 28);
            this.changeCaseDropDownButton.Text = "Change Case";
            // 
            // lowercaseToolStripMenuItem
            // 
            this.lowercaseToolStripMenuItem.Name = "lowercaseToolStripMenuItem";
            this.lowercaseToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.lowercaseToolStripMenuItem.Text = "&lowercase";
            this.lowercaseToolStripMenuItem.Click += new System.EventHandler(this.lowercaseToolStripMenuItem_Click);
            // 
            // uppercaseToolStripMenuItem
            // 
            this.uppercaseToolStripMenuItem.Name = "uppercaseToolStripMenuItem";
            this.uppercaseToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.uppercaseToolStripMenuItem.Text = "&UPPERCASE";
            this.uppercaseToolStripMenuItem.Click += new System.EventHandler(this.uppercaseToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 31);
            // 
            // imgStripButton
            // 
            this.imgStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imgStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imgStripButton.Image")));
            this.imgStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imgStripButton.Name = "imgStripButton";
            this.imgStripButton.Size = new System.Drawing.Size(29, 28);
            this.imgStripButton.Text = "Clear All Formatting";
            this.imgStripButton.Click += new System.EventHandler(this.imgStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // leftAlignStripButton
            // 
            this.leftAlignStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftAlignStripButton.Image = ((System.Drawing.Image)(resources.GetObject("leftAlignStripButton.Image")));
            this.leftAlignStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftAlignStripButton.Name = "leftAlignStripButton";
            this.leftAlignStripButton.Size = new System.Drawing.Size(29, 28);
            this.leftAlignStripButton.Text = "Left Align";
            this.leftAlignStripButton.Click += new System.EventHandler(this.leftAlignStripButton_Click);
            // 
            // centerAlignStripButton
            // 
            this.centerAlignStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.centerAlignStripButton.Image = ((System.Drawing.Image)(resources.GetObject("centerAlignStripButton.Image")));
            this.centerAlignStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.centerAlignStripButton.Name = "centerAlignStripButton";
            this.centerAlignStripButton.Size = new System.Drawing.Size(29, 28);
            this.centerAlignStripButton.Text = "Center Align";
            this.centerAlignStripButton.Click += new System.EventHandler(this.centerAlignStripButton_Click);
            // 
            // rightAlignStripButton
            // 
            this.rightAlignStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rightAlignStripButton.Image = ((System.Drawing.Image)(resources.GetObject("rightAlignStripButton.Image")));
            this.rightAlignStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightAlignStripButton.Name = "rightAlignStripButton";
            this.rightAlignStripButton.Size = new System.Drawing.Size(29, 28);
            this.rightAlignStripButton.Text = "Right Align";
            this.rightAlignStripButton.Click += new System.EventHandler(this.rightAlignStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // zoomDropDownButton
            // 
            this.zoomDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomDropDownButton.Image")));
            this.zoomDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomDropDownButton.Name = "zoomDropDownButton";
            this.zoomDropDownButton.Size = new System.Drawing.Size(38, 28);
            this.zoomDropDownButton.Text = "Zoom Factor";
            this.zoomDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.zoomDropDownButton_DropDownItemClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.rtf";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "rtf文件|*.rtf";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 8);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1372, 26);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.OpenMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator11,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newMenuItem
            // 
            this.newMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newMenuItem.Image")));
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newMenuItem.Text = "&New";
            this.newMenuItem.Click += new System.EventHandler(this.newMenuItem_Click);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenMenuItem.Image")));
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(181, 26);
            this.OpenMenuItem.Text = "&Open";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(178, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator6,
            this.cutToolStripMenuItem1,
            this.copyToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.selectAllToolStripMenuItem1,
            this.clearAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(214, 6);
            // 
            // cutToolStripMenuItem1
            // 
            this.cutToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem1.Image")));
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.cutToolStripMenuItem1.Text = "&Cut";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.cutToolStripMenuItem1_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem1.Image")));
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.copyToolStripMenuItem1.Text = "C&opy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem1.Image")));
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.pasteToolStripMenuItem1.Text = "&Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem1
            // 
            this.selectAllToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("selectAllToolStripMenuItem1.Image")));
            this.selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            this.selectAllToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.selectAllToolStripMenuItem1.Text = "&Select All";
            this.selectAllToolStripMenuItem1.Click += new System.EventHandler(this.selectAllToolStripMenuItem1_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearAllToolStripMenuItem.Image")));
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.clearAllToolStripMenuItem.Text = "C&lear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrapToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.formatToolStripMenuItem.Text = "Fo&rmat";
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.wordWrapToolStripMenuItem.Text = "&WordWrap";
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.fontToolStripMenuItem.Text = "&Font...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.rtf";
            this.saveFileDialog1.Filter = "rtf文件|*.rtf";
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            this.fontDialog1.HelpRequest += new System.EventHandler(this.fontDialog1_HelpRequest);
            // 
            // pictureBoxLeftS
            // 
            this.pictureBoxLeftS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLeftS.Image = global::Text_Editor.Properties.Resources._2023_10_25_194154;
            this.pictureBoxLeftS.Location = new System.Drawing.Point(25, 362);
            this.pictureBoxLeftS.Name = "pictureBoxLeftS";
            this.pictureBoxLeftS.Size = new System.Drawing.Size(24, 37);
            this.pictureBoxLeftS.TabIndex = 21;
            this.pictureBoxLeftS.TabStop = false;
            this.pictureBoxLeftS.Visible = false;
            // 
            // ucToolbar1
            // 
            this.ucToolbar1.BackColor = System.Drawing.Color.Black;
            this.ucToolbar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucToolbar1.Location = new System.Drawing.Point(652, 347);
            this.ucToolbar1.Name = "ucToolbar1";
            this.ucToolbar1.Size = new System.Drawing.Size(389, 34);
            this.ucToolbar1.TabIndex = 20;
            this.ucToolbar1.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ContextMenuStrip = this.richContextStrip;
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.richTextBox1.Location = new System.Drawing.Point(52, 68);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1320, 770);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.richTextBox1_DragDrop);
            this.richTextBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.richTextBox1_DragEnter);
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.VScroll += new System.EventHandler(this.richTextBox1_VScroll);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            this.richTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyUp);
            this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDown);
            this.richTextBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseMove);
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1372, 838);
            this.Controls.Add(this.pictureBoxLeftS);
            this.Controls.Add(this.ucToolbar1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rich Text Editor";
            this.Load += new System.EventHandler(this.frmEditor_Load);
            this.richContextStrip.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBoxEx richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip richContextStrip;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveStripButton;
        private System.Windows.Forms.ToolStripButton openFileStripButton;
        private System.Windows.Forms.ToolStripComboBox fontSizeComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton colorStripDropDownButton;
        private System.Windows.Forms.ToolStripButton leftAlignStripButton;
        private System.Windows.Forms.ToolStripButton centerAlignStripButton;
        private System.Windows.Forms.ToolStripButton rightAlignStripButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton increaseStripButton;
        private System.Windows.Forms.ToolStripButton decreaseStripButton;
        private System.Windows.Forms.ToolStripButton undoStripButton;
        private System.Windows.Forms.ToolStripButton redoStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripDropDownButton changeCaseDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem lowercaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uppercaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripDropDownButton zoomDropDownButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton imgStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private UCToolbar ucToolbar1;
        private System.Windows.Forms.PictureBox pictureBoxLeftS;
    }
}