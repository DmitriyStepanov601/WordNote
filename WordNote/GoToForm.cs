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
    public partial class GoToForm : Form
    {
        public GoToForm()
        {
            InitializeComponent();

            butGo.Click += (s, a) => {
                if (this.Owner is MainForm main) {
                    int lineNumber = Convert.ToInt32(tbLineNum.Text);
                    if (lineNumber > 0 && lineNumber <= main.wordnote.Lines.Count())
                    {
                        main.wordnote.SelectionStart = main.wordnote.GetFirstCharIndexFromLine(Convert.ToInt32(tbLineNum.Text) - 1);
                        main.wordnote.ScrollToCaret();
                        this.Close();
                    }
                }
            };

            butCancel.Click += (s, a) => { this.Close(); };
        }

        private void GoToForm_Load(object sender, EventArgs e)
        {

        }
    }
}
