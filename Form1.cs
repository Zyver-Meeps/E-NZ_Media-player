using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENZ_MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            ENZMediaPlayer1.URL = textBox1.Text;
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
            ENZMediaPlayer1.URL = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ENZMediaPlayer1.Controls
        }
    }
}
