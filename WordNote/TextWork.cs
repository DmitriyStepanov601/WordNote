using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordNote
{
    public static class TextWork
    {
        // Метод поиска текста в TextBox
        // Для использования создаем в форме поиска глобальную переменную 
        // типа int = 0 для стартовой позиции поиска,
        // передаем в метод ссылки на TextBox'ы с исходным и искомым текстами,
        // а также необходимо укзать, учитывать ли регистр букв при поиске (True - учитывать, False - не учитывать)

        public static int FindTextBox(ref RichTextBox wordnote, string findText, ref int findCutLength, bool register)
        {
            // Поиск с учетом регистра
            if (register == true)
            {
                if (wordnote.Text.Contains(findText))
                {
                    // Заносим текст в переменную string, удаляем из него уже пройденный 
                    // текст (findCutLength) в переменной nextText
                    string text = wordnote.Text;
                    string nextText = text.Remove(0, findCutLength);
                    // Ищем в nextText
                    int resultPosition = nextText.IndexOf(findText);
                    // Если искомое выражение найдено - выделяем его, добавляем его позицию и длину 
                    // к значению пройденного текста (findCutLenght)
                    if (resultPosition != -1)
                    {
                        wordnote.Select(resultPosition + findCutLength, findText.Length);
                        wordnote.ScrollToCaret();
                        wordnote.Focus();
                        findCutLength += findText.Length + resultPosition;
                    }
                    // Если попытка поиска не первая, и больше совпадений в тексте нет - обнуляем
                    // значение пройденного текста и начинаем поиск сначала
                    else if (resultPosition == -1 && findCutLength != 0)
                    {
                        findCutLength = 0;
                        return FindTextBox(ref wordnote, findText, ref findCutLength, register);
                    }
                }
                else
                {
                    findCutLength = 0;
                    MessageBox.Show("По вашему запросу ничего не нашлось.", "Совпадений не найдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            // Поиск без учета регистра
            else if (register == false)
            {
                if (wordnote.Text.ToLower().Contains(findText.ToLower()))
                {
                    string text = wordnote.Text.ToLower();
                    string nextText = text.Remove(0, findCutLength);
                    int resultPosition = nextText.IndexOf(findText.ToLower());

                    if (resultPosition != -1)
                    {
                        wordnote.Select(resultPosition + findCutLength, findText.Length);
                        wordnote.ScrollToCaret();
                        wordnote.Focus();
                        findCutLength += findText.Length + resultPosition;
                    }
                    else if (resultPosition == -1 && findCutLength != 0)
                    {
                        findCutLength = 0;
                        return FindTextBox(ref wordnote, findText, ref findCutLength, register);
                    }
                }
                else
                {
                    findCutLength = 0;
                    MessageBox.Show("По вашему запросу ничего не нашлось.", "Совпадений не найдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // Если текст изначально не содержит результатов поиска - обнуляем findCutLength, выводим сообщение
            return 0;
        }

        // Метод "Заменить"
        public static int ReplaceTextBox(ref RichTextBox wordnote, string findText, string replaceText, ref int findCutLength, bool register)
        {
            if (register == true)
            {
                if (wordnote.Text.Contains(findText))
                {
                    if (wordnote.SelectedText == "" || wordnote.SelectedText != findText)
                    {
                        string text = wordnote.Text;
                        string nextText = text.Remove(0, findCutLength);
                        int resultPosition = nextText.IndexOf(findText);
                        if (resultPosition != -1)
                        {
                            wordnote.Select(resultPosition + findCutLength, findText.Length);
                            wordnote.ScrollToCaret();
                            wordnote.Focus();
                            findCutLength += findText.Length + resultPosition;
                        }
                        else if (resultPosition == -1 && findCutLength != 0)
                        {
                            findCutLength = 0;
                            return ReplaceTextBox(ref wordnote, findText, replaceText, ref findCutLength, register);
                        }
                    }
                    else if (wordnote.SelectedText == findText)
                    {
                        wordnote.SelectedText = replaceText;
                    }
                }
                else
                {
                    findCutLength = 0;
                    MessageBox.Show("По вашему запросу ничего не нашлось.", "Совпадений не найдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (register == false)
            {
                if (wordnote.Text.ToLower().Contains(findText.ToLower()))
                {
                    if (wordnote.SelectedText == "" || wordnote.SelectedText.ToLower() != findText.ToLower())
                    {
                        string text = wordnote.Text.ToLower();
                        string nextText = text.Remove(0, findCutLength);
                        int resultPosition = nextText.IndexOf(findText.ToLower());
                        if (resultPosition != -1)
                        {
                            wordnote.Select(resultPosition + findCutLength, findText.Length);
                            wordnote.ScrollToCaret();
                            wordnote.Focus();
                            findCutLength += findText.Length + resultPosition;
                        }
                        else if (resultPosition == -1 && findCutLength != 0)
                        {
                            findCutLength = 0;
                            return ReplaceTextBox(ref wordnote, findText, replaceText, ref findCutLength, register);
                        }
                    }
                    else if (wordnote.SelectedText.ToLower() == findText.ToLower())
                    {
                        wordnote.SelectedText = replaceText;
                    }
                }
                else
                {
                    findCutLength = 0;
                    MessageBox.Show("По вашему запросу ничего не нашлось.", "Совпадений не найдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return 0;
        }

        // Метод "Заменить всё"
        public static int ReplaceAllTextBox(ref RichTextBox wordnote, string findText, string replaceText, bool register)
        {
            if (register == true)
            {
                string text = wordnote.Text;
                string words = findText;
                if (wordnote.Text.Contains(words))
                {
                    int startPosition = text.IndexOf(words);
                    wordnote.Select(startPosition, words.Length);
                    wordnote.SelectedText = replaceText;
                    return ReplaceAllTextBox(ref wordnote, findText, replaceText, register);
                }
                else
                {
                    MessageBox.Show("Замены произведены успешно.", "Заменить всё", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (register == false)
            {
                string text = wordnote.Text.ToLower();
                string words = findText.ToLower();
                if (text.Contains(words))
                {
                    int startPosition = text.IndexOf(words);
                    wordnote.Select(startPosition, findText.Length);
                    wordnote.SelectedText = replaceText;
                    return ReplaceAllTextBox(ref wordnote, findText, replaceText, register);
                }
                else
                {
                    MessageBox.Show("Замены произведены успешно.", "Заменить всё", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return 0;
        }

        public static void EditEnableds(ref RichTextBox wordnote, ref ToolStripMenuItem copy, ref ToolStripMenuItem cut, ref ToolStripMenuItem del, ref ToolStripMenuItem find, ref ToolStripMenuItem go)
        {
            if (wordnote.Text.Length < 1)
            {
                copy.Enabled = false;
                cut.Enabled = false;
                del.Enabled = false;
                find.Enabled = false;
                go.Enabled = false;
            }
            else
            {
                copy.Enabled = true;
                cut.Enabled = true;
                del.Enabled = true;
                find.Enabled = true;              
                go.Enabled = true;                
            }
        }

        public static void StatusAnalize(ref RichTextBox wordnote, ref ToolStripStatusLabel statusLinesCount, ref ToolStripStatusLabel statusWordsCount, ref ToolStripStatusLabel statusCharSpaceCount, ref ToolStripStatusLabel statusCharCount)
        {
            string text = wordnote.Text;
            // Количество строк в тексте
            statusLinesCount.Text = wordnote.Lines.Count().ToString();
            // Количество слов в тексте
            statusWordsCount.Text = text.Split(new Char[] { ' ', '\t', '\n', '\r', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-',
                '_', '+', '=', '[', '{', ']', '}', '/', '\\', '|', '"', ':', ';', '.', ',', '>', '<' }, StringSplitOptions.RemoveEmptyEntries).Length.ToString();
            // Количество символов без пробелов
            statusCharCount.Text = text.Replace(" ", "").Replace("\t", "").Replace("\n", "").Replace("\r", "").ToCharArray().Length.ToString();
            // Количество символов с пробелами
            statusCharSpaceCount.Text = text.ToCharArray().Length.ToString();
        }
    }
}
