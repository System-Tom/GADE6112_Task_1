using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoblinHunter
{
    public partial class Form1 : Form
    {
        Character char1 = new Character(1, 2, 'F');
        Character char2 = new Character(1, 1, 'P');

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Characters created"+ "\n");
            richTextBox1.AppendText("Ready"+ "\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char1.Attack(char2);
            richTextBox1.AppendText(char1.CheckRange(char2)+ "\n");
        }
    }
}
