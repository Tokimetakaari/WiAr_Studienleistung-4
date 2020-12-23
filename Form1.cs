using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiAr_Studienleistung_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color[] colors = { Color.White, Color.Gray, Color.Red, Color.Blue, Color.Green, Color.Purple, Color.Yellow,Color.DeepSkyBlue};

            Random rnd = new Random();
            int r = rnd.Next(colors.Length);

            Color randomColor = (colors[r]);

            button1.BackColor= randomColor;
        }
    }
}
