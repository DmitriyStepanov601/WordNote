using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Globalization;

namespace WordNote
{
    public partial class MainForm : Form
    {
        bool tbChange = false;
        string docPath = "";
        bool isTextChangedHandlerRunning = false;

        public MainForm()
        {
            InitializeComponent();
            this.Text = Properties.Settings.Default.newDocName + " - " + Properties.Settings.Default.programmName;

            wordnote.SelectionChanged += (s, a) =>
            {
                UpdateFontToolbar();
            };

            // Выбор шрифта
            FontFamily.SelectedIndexChanged += (s, a) =>
            {
                wordnote.SelectionFont = new Font((string)FontFamily.SelectedItem, wordnote.SelectionFont.Size, wordnote.SelectionFont.Style);
            };

            // Размер шрифта
            FontSize.TextChanged += (s, a) =>
            {
                float emSize = wordnote.SelectionFont.Size;
                if (!float.TryParse(FontSize.Text, out emSize)) return;
                wordnote.SelectionFont = new Font(wordnote.SelectionFont.FontFamily, emSize, wordnote.SelectionFont.Style);
            };

            // Полужирный шрифт
            BoldStyle.Click += (s, a) =>
            {
                wordnote.SelectionFont = new Font(wordnote.SelectionFont, wordnote.SelectionFont.Style ^ FontStyle.Bold);
            };

            // Наклонный шрифт
            ItalicStyle.Click += (s, a) =>
            {
                wordnote.SelectionFont = new Font(wordnote.SelectionFont, wordnote.SelectionFont.Style ^ FontStyle.Italic);
            };

            // Подчёркивание
            UnderlineStyle.Click += (s, a) =>
            {
                wordnote.SelectionFont = new Font(wordnote.SelectionFont, wordnote.SelectionFont.Style ^ FontStyle.Underline);
            };

            FillFont();
            UpdateFontToolbar();

            wordnote.TextChanged += (s, a) =>
            {
                tbChange = true;                // Индикатор изменения текста
                TextWork.EditEnableds(ref wordnote, ref copy, ref cut, ref delete, ref findReplace, ref go);
                TextWork.StatusAnalize(ref wordnote, ref statusLinesCount, ref statusWordsCount, ref statusCharSpaceCount, ref statusCharCount);
            };

            // увеличение размера шрифта
            incFontSize.Click += (s, a) =>
            {
                float NewFontSize = wordnote.SelectionFont.SizeInPoints + 1;
                wordnote.SelectionFont = new Font(wordnote.SelectionFont.Name, NewFontSize, wordnote.SelectionFont.Style);
            };

            // уменьшение размера шрифта
            decFontSize.Click += (s, a) =>
            {
                float NewFontSize = wordnote.SelectionFont.SizeInPoints - 1;
                wordnote.SelectionFont = new Font(wordnote.SelectionFont.Name, NewFontSize, wordnote.SelectionFont.Style);
            };

            // нижний регистр
            Lowercase.Click += (s, a) =>
            {
                wordnote.SelectedText = wordnote.SelectedText.ToLower();
            };

            // верхний регистр
            Uppercase.Click += (s, a) =>
            {
                wordnote.SelectedText = wordnote.SelectedText.ToUpper();
            };

            // цвет шрифта
            FontColor.Click += (s, a) =>
            {
                if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    wordnote.SelectionColor = colorDialog.Color;
                }
            };

            // цвет выделения текста
            HighlightColor.Click += (s, a) =>
            {
                colorDialog.FullOpen = true;                      // расширенное окно для выбора цвета
                if (colorDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                wordnote.SelectionBackColor = colorDialog.Color;                       // установка цвета формы 
            };

            // выравнивание по левому краю
            lefttextalign.Click += (s, a) =>
            {
                wordnote.SelectionAlignment = HorizontalAlignment.Left;
            };

            // выравнивание по центру
            centertextalign.Click += (s, a) =>
            {
                wordnote.SelectionAlignment = HorizontalAlignment.Center;
            };
             
            // выравнивание по правому краю
            righttextalign.Click += (s, a) =>
            {
                wordnote.SelectionAlignment = HorizontalAlignment.Right;
            };

            ClearFormat.Click += (s, a) =>
            {
                if (isTextChangedHandlerRunning)
                    return;
                isTextChangedHandlerRunning = true;
                int saveStart = wordnote.SelectionStart;
                int saveLength = wordnote.SelectionLength;
                wordnote.SelectAll();
                wordnote.SelectionBackColor = SystemColors.Window;
                wordnote.SelectionColor = SystemColors.WindowText;
                wordnote.SelectionFont = SystemFonts.MenuFont;
                wordnote.SelectionStart = saveStart;
                wordnote.SelectionLength = saveLength;
                isTextChangedHandlerRunning = false;
            };

            // -----------------------  Меню File -----------------------------------------------
            newFile.Click += (s, a) =>
            {
                if (tbChange == true)
                {
                    DialogResult message = MessageBox.Show("Сохранить текущий документ перед созданием нового?", "Создание документа", MessageBoxButtons.YesNoCancel);
                    if (message == DialogResult.Yes)
                    {
                        if (docPath != "")
                        {
                            FileWork.SaveFile(ref wordnote, ref tbChange, ref docPath);
                            FileWork.CreateFile(ref wordnote, ref tbChange, ref docPath);
                        }
                        else if (docPath == "")
                        {
                            FileWork.SaveAsFile(ref wordnote, ref tbChange, ref docPath);
                            FileWork.CreateFile(ref wordnote, ref tbChange, ref docPath);
                        }
                    }
                    else if (message == DialogResult.No)
                    {
                        FileWork.CreateFile(ref wordnote, ref tbChange, ref docPath);
                    }
                }
                else
                {
                    FileWork.CreateFile(ref wordnote, ref tbChange, ref docPath);
                }
            };

            open.Click += (s, a) =>
            {
                if (tbChange == true)
                {
                    DialogResult message = MessageBox.Show("Сохранить текущий документ перед открытием нового?", "Открытие документа", MessageBoxButtons.YesNoCancel);
                    if (message == DialogResult.Yes)
                    {
                        if (docPath != "")
                        {
                            FileWork.SaveFile(ref wordnote, ref tbChange, ref docPath);
                            FileWork.OpenFile(ref wordnote, ref tbChange, ref docPath);
                        }
                        else if (docPath == "")
                        {
                            FileWork.SaveAsFile(ref wordnote, ref tbChange, ref docPath);
                            FileWork.OpenFile(ref wordnote, ref tbChange, ref docPath);
                        }
                    }
                    else if (message == DialogResult.No)
                    {
                        FileWork.OpenFile(ref wordnote, ref tbChange, ref docPath);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    FileWork.OpenFile(ref wordnote, ref tbChange, ref docPath);
                }
            };

            save.Click += (s, a) =>
            {
                if (docPath != "")
                {
                    FileWork.SaveFile(ref wordnote, ref tbChange, ref docPath);
                }
                else
                {
                    FileWork.SaveAsFile(ref wordnote, ref tbChange, ref docPath);
                }
            };

            saveAs.Click += (s, a) => { FileWork.SaveAsFile(ref wordnote, ref tbChange, ref docPath); };

            pageParameters.Click += (s, a) =>
            {
                if (pageSetupDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
                }
            };

            print.Click += (s, a) =>
            {
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        printDocument.Print();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка параметров печати.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            };

            // Отправка документа на печать
            printDocument.PrintPage += (s, a) => { a.Graphics.DrawString(wordnote.Text, wordnote.Font, Brushes.Black, 10, 10); };
            exit.Click += (s, a) => { Application.Exit(); };

            // -----------------------  Меню Edit -----------------------------------------------
            undo.Click += (s, a) => { wordnote.Undo(); };
            redo.Click += (s, a) => { wordnote.Redo(); };
            cut.Click += (s, a) => { if (wordnote.SelectionLength > 0) { wordnote.Cut(); } };
            copy.Click += (s, a) => { if (wordnote.SelectionLength > 0) { wordnote.Copy(); } };
            paste.Click += (s, a) => { wordnote.Paste(); };
            delete.Click += (s, a) => { if (wordnote.SelectionLength > 0) { wordnote.SelectedText = ""; } };

            findReplace.Click += (s, a) =>
            {
                SearchForm findText = new SearchForm
                {
                    Owner = this
                };
                findText.Show();
            };

            go.Click += (s, a) =>
            {
                GoToForm gotoform = new GoToForm
                {
                    Owner = this
                };
                gotoform.tbLineNum.Minimum = 0;
                gotoform.tbLineNum.Maximum = wordnote.Lines.Count();
                gotoform.ShowDialog();
            };

            giveAll.Click += (s, a) => { wordnote.SelectAll(); };
            timeDate.Click += (s, a) => { wordnote.AppendText(Environment.NewLine + Convert.ToString(System.DateTime.Now)); };

            // -----------------------  Меню Format -----------------------------------------------
            wordWrap.Click += (s, a) => {
                if (wordWrap.CheckState == CheckState.Checked)
                {
                    wordnote.WordWrap = true;
                    wordnote.ScrollBars = RichTextBoxScrollBars.Vertical;
                    go.Enabled = false;
                    statusLab1.Visible = false;
                    statusLinesCount.Visible = false;
                }
                else
                {
                    wordnote.WordWrap = false;
                    wordnote.ScrollBars = RichTextBoxScrollBars.Both;
                    go.Enabled = true;
                    statusLab1.Visible = true;
                    statusLinesCount.Visible = true;
                }
            };

            font.Click += (s, a) => {
                fontDialog.Font = wordnote.Font;
                DialogResult = fontDialog.ShowDialog();
                if (DialogResult == DialogResult.OK) { wordnote.SelectionFont = fontDialog.Font; }
            };

            color.Click += (s, a) => {
                colorDialog.Color = wordnote.ForeColor;
                DialogResult = colorDialog.ShowDialog();
                if (DialogResult == DialogResult.OK) { wordnote.SelectionColor = colorDialog.Color; }
            };

            // -----------------------  Меню View -----------------------------------------------
            statusBar.Click += (s, a) => {
                if (statusBar.CheckState == CheckState.Checked) { statusBar.Visible = true; }
                else { statusBar.Visible = false; }
            };
        }

        public MainForm(string fileName)         // Открытие программы документом
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
            {
                try
                {
                    string programmName = Properties.Settings.Default.programmName;
                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(file, Encoding.Default);
                    wordnote.Text = reader.ReadToEnd();
                    reader.Close();
                    docPath = fileName;
                    tbChange = false;
                    this.Text = Path.GetFileName(fileName) + " — " + programmName;
                    wordnote.Select(0, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            //Задаем сохраненные (или стандартные) настройки
            this.Width = Properties.Settings.Default.formWidth;
            this.Height = Properties.Settings.Default.formHeight;
            wordnote.Font = Properties.Settings.Default.textFont;
            if (Properties.Settings.Default.statusBarVisible == true)
            { statusBar.CheckState = CheckState.Checked; }
            else
            { statusBar.CheckState = CheckState.Unchecked; }
            if (Properties.Settings.Default.textWordWrap == true)
            { wordWrap.CheckState = CheckState.Checked; }
            else
            { wordWrap.CheckState = CheckState.Unchecked; }
        }

        void MainForm_FormClosing(object sender, FormClosingEventArgs e) // Событие ДО выхода из программы
        {
            Properties.Settings.Default.formWidth = this.Width;
            Properties.Settings.Default.formHeight = this.Height;
            Properties.Settings.Default.textWordWrap = wordnote.WordWrap;
            Properties.Settings.Default.textFont = wordnote.Font;
            Properties.Settings.Default.statusBarVisible = statusBar.Visible;
            Properties.Settings.Default.Save();
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед выходом?", "Выход из программы", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        FileWork.SaveFile(ref wordnote, ref tbChange, ref docPath);
                        Application.Exit();
                    }
                    else if (docPath == "")
                    {
                        FileWork.SaveAsFile(ref wordnote, ref tbChange, ref docPath);
                        Application.Exit();
                    }
                }
                else if (message == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        void UpdateFontToolbar()
        {
            BoldStyle.Checked = wordnote.SelectionFont.Style.HasFlag(FontStyle.Bold);
            ItalicStyle.Checked = wordnote.SelectionFont.Style.HasFlag(FontStyle.Italic);
            UnderlineStyle.Checked = wordnote.SelectionFont.Style.HasFlag(FontStyle.Underline);
            FontFamily.SelectedItem = wordnote.SelectionFont.FontFamily.Name;
            FontSize.Text = wordnote.SelectionFont.Size.ToString();
        }

        void FillFont()
        {
            FontFamily.Items.AddRange((new System.Drawing.Text.InstalledFontCollection()).Families.Select(f => f.Name).ToArray());
            FontSize.Items.AddRange(new object[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 });
        }
    }
}
