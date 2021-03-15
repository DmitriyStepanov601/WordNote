using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordNote
{
    public partial class SearchForm : Form
    {
        int findCutLength = 0; // На сколько символов обрезаем текст для поиска

        public SearchForm()
        {
            InitializeComponent();
            tbFind.TextChanged += (s, a) => { findCutLength = 0; };
            tbReplace.TextChanged += (s, a) => { findCutLength = 0; };
            cbReg.CheckStateChanged += (s, a) => { findCutLength = 0; };

            btFind.Click += (s, a) => {
                if (this.Owner is MainForm main)
                {
                    if (cbReg.CheckState == CheckState.Checked)
                    {
#pragma warning disable CS0197 // Использование поля класса с маршалингом по ссылке в виде значения ref или out или получение его адреса может вызвать исключение времени выполнения
                        TextWork.FindTextBox(wordnote: ref main.wordnote, findText: tbFind.Text, findCutLength: ref findCutLength, register: true);
#pragma warning restore CS0197 // Использование поля класса с маршалингом по ссылке в виде значения ref или out или получение его адреса может вызвать исключение времени выполнения
                    }
                    else
                    {
#pragma warning disable CS0197 // Использование поля класса с маршалингом по ссылке в виде значения ref или out или получение его адреса может вызвать исключение времени выполнения
                        TextWork.FindTextBox(wordnote: ref main.wordnote, findText: tbFind.Text, findCutLength: ref findCutLength, register: false);
#pragma warning restore CS0197 // Использование поля класса с маршалингом по ссылке в виде значения ref или out или получение его адреса может вызвать исключение времени выполнения
                    }
                }
            };

            btReplace.Click += (s, a) =>
            {
                if (this.Owner is MainForm main)
                {
                    if (cbReg.CheckState == CheckState.Checked)
                    {
#pragma warning disable CS0197 // Использование поля класса с маршалингом по ссылке в виде значения ref или out или получение его адреса может вызвать исключение времени выполнения
                        TextWork.ReplaceTextBox(wordnote: ref main.wordnote, findText: tbFind.Text, replaceText: tbReplace.Text, findCutLength: ref findCutLength, register: true);
#pragma warning restore CS0197 // Использование поля класса с маршалингом по ссылке в виде значения ref или out или получение его адреса может вызвать исключение времени выполнения
                    }
                    else
                    {
#pragma warning disable CS0197 // Использование поля класса с маршалингом по ссылке в виде значения ref или out или получение его адреса может вызвать исключение времени выполнения
                        TextWork.ReplaceTextBox(wordnote: ref main.wordnote, findText: tbFind.Text, replaceText: tbReplace.Text, findCutLength: ref findCutLength, register: false);
#pragma warning restore CS0197 // Использование поля класса с маршалингом по ссылке в виде значения ref или out или получение его адреса может вызвать исключение времени выполнения
                    }
                }
            };

            btReplaceAll.Click += (s, a) =>
            {
                if (this.Owner is MainForm main)
                {
                    if (cbReg.CheckState == CheckState.Checked)
                    {
#pragma warning disable CS0197 // Использование поля класса с маршалингом по ссылке в виде значения ref или out или получение его адреса может вызвать исключение времени выполнения
                        TextWork.ReplaceAllTextBox(wordnote: ref main.wordnote, findText: tbFind.Text, replaceText: tbReplace.Text, register: true);
#pragma warning restore CS0197 // Использование поля класса с маршалингом по ссылке в виде значения ref или out или получение его адреса может вызвать исключение времени выполнения
                    }
                    else
                    {
#pragma warning disable CS0197 // Использование поля класса с маршалингом по ссылке в виде значения ref или out или получение его адреса может вызвать исключение времени выполнения
                        TextWork.ReplaceAllTextBox(wordnote: ref main.wordnote, findText: tbFind.Text, replaceText: tbReplace.Text, register: false);
#pragma warning restore CS0197 // Использование поля класса с маршалингом по ссылке в виде значения ref или out или получение его адреса может вызвать исключение времени выполнения
                    }
                }
            };

            btCancel.Click += (s, a) => { this.Close(); };
        }

        void SearchForm_Shown(object sender, EventArgs e) // Событие при открытии формы поиска и замены
        {
            tbFind.Focus();
        }

        void SearchForm_FormClosing(object sender, FormClosingEventArgs e) // Событие при закрытии формы (до закрытия)
        {
            findCutLength = 0;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
