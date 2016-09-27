using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtils
{
    public partial class Form1 : Form
    {
        private Random rand;
        private char[] spec_char;
        private string pass;
       
        public Form1()
        {
            InitializeComponent();
            rand = new Random();
            spec_char = new char[] { '%', '*', '(', ')', '?', '#', '$', '^', '&', '~', '!', '@', '+', '/', '\\', '"', '[', ']' };
            pass = "";
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            pass = "";
            if (cblProp.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите не менее одного параметра", "Ахтунг!");
            }
            for(int i = 0; i < nudPassLength.Value; i++)
            {
                int n = rand.Next(0, cblProp.CheckedItems.Count);
                string s = cblProp.CheckedItems[n].ToString();

                switch (s)
                {
                    case "Цифры": pass += rand.Next(10).ToString();
                        break;
                    case "Прописные буквы": pass += Convert.ToChar(rand.Next(65, 91));
                        break;
                    case "Строчные буквы": pass += Convert.ToChar(rand.Next(97, 123));
                        break;
                    default: pass += spec_char[rand.Next(spec_char.Length)];
                        break;
                }
            }
            tbListPass.AppendText(pass + "\n");
            Clipboard.SetText(pass);
        }

        private void btBuffer_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(pass);
            }
            catch (System.ArgumentNullException)
            {
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cblProp.SetItemChecked(0, true);
            cblProp.SetItemChecked(1, true);
            cblProp.SetItemChecked(2, true);
            cblProp.SetItemChecked(3, true);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
