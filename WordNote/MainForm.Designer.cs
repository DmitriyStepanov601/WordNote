namespace WordNote
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pageParameters = new System.Windows.Forms.ToolStripMenuItem();
            this.print = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.undo = new System.Windows.Forms.ToolStripMenuItem();
            this.redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cut = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.findReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.go = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.giveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.timeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.format = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.font = new System.Windows.Forms.ToolStripMenuItem();
            this.color = new System.Windows.Forms.ToolStripMenuItem();
            this.view = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLab1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLinesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLab2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusWordsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLab3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCharSpaceCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLab4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCharCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelTools = new System.Windows.Forms.ToolStrip();
            this.FontFamily = new System.Windows.Forms.ToolStripComboBox();
            this.FontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.wordnote = new System.Windows.Forms.RichTextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.BoldStyle = new System.Windows.Forms.ToolStripButton();
            this.ItalicStyle = new System.Windows.Forms.ToolStripButton();
            this.UnderlineStyle = new System.Windows.Forms.ToolStripButton();
            this.incFontSize = new System.Windows.Forms.ToolStripButton();
            this.decFontSize = new System.Windows.Forms.ToolStripButton();
            this.lefttextalign = new System.Windows.Forms.ToolStripButton();
            this.centertextalign = new System.Windows.Forms.ToolStripButton();
            this.righttextalign = new System.Windows.Forms.ToolStripButton();
            this.Wordcase = new System.Windows.Forms.ToolStripSplitButton();
            this.Lowercase = new System.Windows.Forms.ToolStripMenuItem();
            this.Uppercase = new System.Windows.Forms.ToolStripMenuItem();
            this.FontColor = new System.Windows.Forms.ToolStripButton();
            this.HighlightColor = new System.Windows.Forms.ToolStripButton();
            this.ClearFormat = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panelTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.edit,
            this.format,
            this.view});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenu";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile,
            this.open,
            this.save,
            this.saveAs,
            this.toolStripSeparator1,
            this.pageParameters,
            this.print,
            this.toolStripSeparator2,
            this.exit});
            this.file.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(35, 20);
            this.file.Text = "File";
            // 
            // newFile
            // 
            this.newFile.Name = "newFile";
            this.newFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFile.Size = new System.Drawing.Size(187, 22);
            this.newFile.Text = "New File";
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open.Size = new System.Drawing.Size(187, 22);
            this.open.Text = "Open ...";
            // 
            // save
            // 
            this.save.Name = "save";
            this.save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save.Size = new System.Drawing.Size(187, 22);
            this.save.Text = "Save";
            // 
            // saveAs
            // 
            this.saveAs.Name = "saveAs";
            this.saveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAs.Size = new System.Drawing.Size(187, 22);
            this.saveAs.Text = "Save as ...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // pageParameters
            // 
            this.pageParameters.Name = "pageParameters";
            this.pageParameters.Size = new System.Drawing.Size(187, 22);
            this.pageParameters.Text = "Page parameters";
            // 
            // print
            // 
            this.print.Name = "print";
            this.print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.print.Size = new System.Drawing.Size(187, 22);
            this.print.Text = "Print";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exit.Size = new System.Drawing.Size(187, 22);
            this.exit.Text = "Exit";
            // 
            // edit
            // 
            this.edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undo,
            this.redo,
            this.toolStripSeparator3,
            this.cut,
            this.copy,
            this.paste,
            this.delete,
            this.toolStripSeparator4,
            this.findReplace,
            this.go,
            this.toolStripSeparator5,
            this.giveAll,
            this.timeDate});
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(37, 20);
            this.edit.Text = "Edit";
            // 
            // undo
            // 
            this.undo.Name = "undo";
            this.undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undo.Size = new System.Drawing.Size(201, 22);
            this.undo.Text = "Undo";
            // 
            // redo
            // 
            this.redo.Name = "redo";
            this.redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redo.Size = new System.Drawing.Size(201, 22);
            this.redo.Text = "Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(198, 6);
            // 
            // cut
            // 
            this.cut.Name = "cut";
            this.cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cut.Size = new System.Drawing.Size(201, 22);
            this.cut.Text = "Cut";
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copy.Size = new System.Drawing.Size(201, 22);
            this.copy.Text = "Copy";
            // 
            // paste
            // 
            this.paste.Name = "paste";
            this.paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.paste.Size = new System.Drawing.Size(201, 22);
            this.paste.Text = "Paste";
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.delete.Size = new System.Drawing.Size(201, 22);
            this.delete.Text = "Delete";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(198, 6);
            // 
            // findReplace
            // 
            this.findReplace.Name = "findReplace";
            this.findReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findReplace.Size = new System.Drawing.Size(201, 22);
            this.findReplace.Text = "Find and replace";
            // 
            // go
            // 
            this.go.Name = "go";
            this.go.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.go.Size = new System.Drawing.Size(201, 22);
            this.go.Text = "Go ...";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(198, 6);
            // 
            // giveAll
            // 
            this.giveAll.Name = "giveAll";
            this.giveAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.giveAll.Size = new System.Drawing.Size(201, 22);
            this.giveAll.Text = "Give All";
            // 
            // timeDate
            // 
            this.timeDate.Name = "timeDate";
            this.timeDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.timeDate.Size = new System.Drawing.Size(201, 22);
            this.timeDate.Text = "Time and Date";
            // 
            // format
            // 
            this.format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrap,
            this.font,
            this.color});
            this.format.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(51, 20);
            this.format.Text = "Format";
            // 
            // wordWrap
            // 
            this.wordWrap.CheckOnClick = true;
            this.wordWrap.Name = "wordWrap";
            this.wordWrap.Size = new System.Drawing.Size(132, 22);
            this.wordWrap.Text = "Word wrap";
            // 
            // font
            // 
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(132, 22);
            this.font.Text = "Font";
            // 
            // color
            // 
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(132, 22);
            this.color.Text = "Color";
            // 
            // view
            // 
            this.view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.view.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(42, 20);
            this.view.Text = "View";
            // 
            // statusBar
            // 
            this.statusBar.Checked = true;
            this.statusBar.CheckOnClick = true;
            this.statusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(126, 22);
            this.statusBar.Text = "Status Bar";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLab1,
            this.statusLinesCount,
            this.statusLab2,
            this.statusWordsCount,
            this.statusLab3,
            this.statusCharSpaceCount,
            this.statusLab4,
            this.statusCharCount});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLab1
            // 
            this.statusLab1.Name = "statusLab1";
            this.statusLab1.Size = new System.Drawing.Size(67, 17);
            this.statusLab1.Text = "CountLines";
            // 
            // statusLinesCount
            // 
            this.statusLinesCount.Name = "statusLinesCount";
            this.statusLinesCount.Size = new System.Drawing.Size(23, 17);
            this.statusLinesCount.Text = "\"0\"";
            // 
            // statusLab2
            // 
            this.statusLab2.Name = "statusLab2";
            this.statusLab2.Size = new System.Drawing.Size(74, 17);
            this.statusLab2.Text = "CountWords";
            // 
            // statusWordsCount
            // 
            this.statusWordsCount.Name = "statusWordsCount";
            this.statusWordsCount.Size = new System.Drawing.Size(23, 17);
            this.statusWordsCount.Text = "\"0\"";
            // 
            // statusLab3
            // 
            this.statusLab3.Name = "statusLab3";
            this.statusLab3.Size = new System.Drawing.Size(96, 17);
            this.statusLab3.Text = "CountCharSpace";
            // 
            // statusCharSpaceCount
            // 
            this.statusCharSpaceCount.Name = "statusCharSpaceCount";
            this.statusCharSpaceCount.Size = new System.Drawing.Size(23, 17);
            this.statusCharSpaceCount.Text = "\"0\"";
            // 
            // statusLab4
            // 
            this.statusLab4.Name = "statusLab4";
            this.statusLab4.Size = new System.Drawing.Size(65, 17);
            this.statusLab4.Text = "CountChar";
            // 
            // statusCharCount
            // 
            this.statusCharCount.Name = "statusCharCount";
            this.statusCharCount.Size = new System.Drawing.Size(23, 17);
            this.statusCharCount.Text = "\"0\"";
            // 
            // panelTools
            // 
            this.panelTools.BackColor = System.Drawing.SystemColors.Control;
            this.panelTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontFamily,
            this.FontSize,
            this.toolStripSeparator6,
            this.BoldStyle,
            this.ItalicStyle,
            this.UnderlineStyle,
            this.toolStripSeparator7,
            this.incFontSize,
            this.decFontSize,
            this.toolStripSeparator8,
            this.lefttextalign,
            this.centertextalign,
            this.righttextalign,
            this.toolStripSeparator9,
            this.Wordcase,
            this.FontColor,
            this.HighlightColor,
            this.ClearFormat});
            this.panelTools.Location = new System.Drawing.Point(0, 24);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(800, 25);
            this.panelTools.TabIndex = 2;
            this.panelTools.Text = "panelTools";
            // 
            // FontFamily
            // 
            this.FontFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FontFamily.Name = "FontFamily";
            this.FontFamily.Size = new System.Drawing.Size(121, 25);
            // 
            // FontSize
            // 
            this.FontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // wordnote
            // 
            this.wordnote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordnote.Location = new System.Drawing.Point(0, 49);
            this.wordnote.Name = "wordnote";
            this.wordnote.Size = new System.Drawing.Size(800, 379);
            this.wordnote.TabIndex = 3;
            this.wordnote.Text = "";
            // 
            // BoldStyle
            // 
            this.BoldStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldStyle.Image = global::WordNote.Properties.Resources.boldstyle;
            this.BoldStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldStyle.Name = "BoldStyle";
            this.BoldStyle.Size = new System.Drawing.Size(23, 22);
            this.BoldStyle.Text = "Bold";
            this.BoldStyle.ToolTipText = "Bold";
            // 
            // ItalicStyle
            // 
            this.ItalicStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalicStyle.Image = global::WordNote.Properties.Resources.italicstyle;
            this.ItalicStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicStyle.Name = "ItalicStyle";
            this.ItalicStyle.Size = new System.Drawing.Size(23, 22);
            this.ItalicStyle.Text = "Italic";
            // 
            // UnderlineStyle
            // 
            this.UnderlineStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderlineStyle.Image = global::WordNote.Properties.Resources.underlinestyle;
            this.UnderlineStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderlineStyle.Name = "UnderlineStyle";
            this.UnderlineStyle.Size = new System.Drawing.Size(23, 22);
            this.UnderlineStyle.Text = "Underline";
            // 
            // incFontSize
            // 
            this.incFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.incFontSize.Image = ((System.Drawing.Image)(resources.GetObject("incFontSize.Image")));
            this.incFontSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.incFontSize.Name = "incFontSize";
            this.incFontSize.Size = new System.Drawing.Size(23, 22);
            this.incFontSize.Text = "increase";
            // 
            // decFontSize
            // 
            this.decFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decFontSize.Image = ((System.Drawing.Image)(resources.GetObject("decFontSize.Image")));
            this.decFontSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decFontSize.Name = "decFontSize";
            this.decFontSize.Size = new System.Drawing.Size(23, 22);
            this.decFontSize.Text = "decrease";
            // 
            // lefttextalign
            // 
            this.lefttextalign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lefttextalign.Image = global::WordNote.Properties.Resources.textalignleft;
            this.lefttextalign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lefttextalign.Name = "lefttextalign";
            this.lefttextalign.Size = new System.Drawing.Size(23, 22);
            this.lefttextalign.Text = "left";
            // 
            // centertextalign
            // 
            this.centertextalign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.centertextalign.Image = global::WordNote.Properties.Resources.textaligncenter;
            this.centertextalign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.centertextalign.Name = "centertextalign";
            this.centertextalign.Size = new System.Drawing.Size(23, 22);
            this.centertextalign.Text = "center";
            // 
            // righttextalign
            // 
            this.righttextalign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.righttextalign.Image = global::WordNote.Properties.Resources.textalignright;
            this.righttextalign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.righttextalign.Name = "righttextalign";
            this.righttextalign.Size = new System.Drawing.Size(23, 22);
            this.righttextalign.Text = "right";
            // 
            // Wordcase
            // 
            this.Wordcase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Wordcase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lowercase,
            this.Uppercase});
            this.Wordcase.Image = global::WordNote.Properties.Resources.Wordcase;
            this.Wordcase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Wordcase.Name = "Wordcase";
            this.Wordcase.Size = new System.Drawing.Size(32, 22);
            this.Wordcase.Text = "wordcase";
            // 
            // Lowercase
            // 
            this.Lowercase.Name = "Lowercase";
            this.Lowercase.Size = new System.Drawing.Size(137, 22);
            this.Lowercase.Text = "lowercase";
            // 
            // Uppercase
            // 
            this.Uppercase.Name = "Uppercase";
            this.Uppercase.Size = new System.Drawing.Size(137, 22);
            this.Uppercase.Text = "UPPERCASE";
            // 
            // FontColor
            // 
            this.FontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontColor.Image = global::WordNote.Properties.Resources.FontForecolor;
            this.FontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(23, 22);
            this.FontColor.Text = "font color";
            // 
            // HighlightColor
            // 
            this.HighlightColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HighlightColor.Image = global::WordNote.Properties.Resources.HighlightedColor;
            this.HighlightColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HighlightColor.Name = "HighlightColor";
            this.HighlightColor.Size = new System.Drawing.Size(23, 22);
            this.HighlightColor.Text = "highlight color";
            // 
            // ClearFormat
            // 
            this.ClearFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearFormat.Image = global::WordNote.Properties.Resources.eraser;
            this.ClearFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearFormat.Name = "ClearFormat";
            this.ClearFormat.Size = new System.Drawing.Size(23, 22);
            this.ClearFormat.Text = "clear";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wordnote);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem newFile;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pageParameters;
        private System.Windows.Forms.ToolStripMenuItem print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem undo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cut;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.ToolStripMenuItem paste;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem giveAll;
        private System.Windows.Forms.ToolStripMenuItem timeDate;
        private System.Windows.Forms.ToolStripMenuItem wordWrap;
        private System.Windows.Forms.ToolStripMenuItem font;
        private System.Windows.Forms.ToolStripMenuItem statusBar;
        private System.Windows.Forms.ToolStripMenuItem color;
        private System.Windows.Forms.ToolStripStatusLabel statusLab1;
        private System.Windows.Forms.ToolStripStatusLabel statusLinesCount;
        private System.Windows.Forms.ToolStripStatusLabel statusLab2;
        private System.Windows.Forms.ToolStripStatusLabel statusWordsCount;
        private System.Windows.Forms.ToolStripStatusLabel statusLab3;
        private System.Windows.Forms.ToolStripStatusLabel statusCharSpaceCount;
        private System.Windows.Forms.ToolStripStatusLabel statusLab4;
        private System.Windows.Forms.ToolStripStatusLabel statusCharCount;
        private System.Windows.Forms.ToolStrip panelTools;
        private System.Windows.Forms.ToolStripComboBox FontSize;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        public System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.FontDialog fontDialog;
        public System.Windows.Forms.ToolStripMenuItem edit;
        public System.Windows.Forms.ToolStripMenuItem file;
        public System.Windows.Forms.ToolStripMenuItem format;
        public System.Windows.Forms.ToolStripMenuItem view;
        public System.Windows.Forms.MenuStrip mainMenu;
        public System.Windows.Forms.ToolStripMenuItem findReplace;
        public System.Windows.Forms.ToolStripMenuItem go;
        public System.Windows.Forms.RichTextBox wordnote;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripComboBox FontFamily;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton BoldStyle;
        private System.Windows.Forms.ToolStripButton ItalicStyle;
        private System.Windows.Forms.ToolStripButton UnderlineStyle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem redo;
        private System.Windows.Forms.ToolStripButton lefttextalign;
        private System.Windows.Forms.ToolStripButton centertextalign;
        private System.Windows.Forms.ToolStripButton righttextalign;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton incFontSize;
        private System.Windows.Forms.ToolStripButton decFontSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSplitButton Wordcase;
        private System.Windows.Forms.ToolStripButton FontColor;
        private System.Windows.Forms.ToolStripButton HighlightColor;
        public System.Windows.Forms.ToolStripMenuItem Lowercase;
        public System.Windows.Forms.ToolStripMenuItem Uppercase;
        private System.Windows.Forms.ToolStripButton ClearFormat;
    }
}

