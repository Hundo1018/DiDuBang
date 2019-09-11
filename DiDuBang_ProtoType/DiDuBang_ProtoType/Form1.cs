using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiDuBang_ProtoType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RichTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
          
        }

        private void Bold_BTN_Click(object sender, EventArgs e)
        {
            SetSelectionFont(FontStyle.Bold);
        }

        private void Italic_BTN_Click(object sender, EventArgs e)
        {
            SetSelectionFont(FontStyle.Italic);
        }
        private void Strikeout_BTN_Click(object sender, EventArgs e)
        {
            SetSelectionFont(FontStyle.Strikeout);
        }

        private void Underline_BTN_Click(object sender, EventArgs e)
        {
            SetSelectionFont(FontStyle.Underline);
        }
        void SetSelectionFont(FontStyle i)
        {
            //if (richTextBox1.SelectionFont is null)
            //    return;
            //else
                richTextBox1.SelectionFont =
                new Font(richTextBox1.SelectionFont.FontFamily.ToString(), 12, richTextBox1.SelectionFont.Style | i);
        }

        
    }
}
