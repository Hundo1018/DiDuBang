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
            FontStyle FSFrom = richTextBox1.SelectionFont.Style;
            FontStyle FSTo = i;
            
            richTextBox1.SelectionFont =
                new Font(richTextBox1.SelectionFont.FontFamily.ToString(), 12, (FSTo == FSFrom ? FontStyle.Regular : FSFrom | i));
            int SS = richTextBox1.SelectionStart;
            int SL = richTextBox1.SelectionLength;
        }
        //未實現
        //ABC
        //A
        //交集刪去
        //BC
        //A
        //交集外加入
        //ABC

        //實作網狀關聯結構

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = richTextBox1.SelectedRtf;
        }
    }
}
