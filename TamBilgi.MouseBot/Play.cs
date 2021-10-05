using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TamBilgi.MouseBot
{
    
    public partial class Play : Form
    {

        public Play()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Play_Load(object sender, EventArgs e)
        {
            lblDate.Text = "Tarih: " +DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var main = new TamBilgi.MouseBot.Recorder();
            main.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;  
            p.StartInfo.RedirectStandardOutput = true;
        //phyton uzantısını veriyoruz
            p.StartInfo.FileName = @"C:\BotTamBilgi\player.py";
            p.StartInfo.Arguments = @"C:\Users\TAMBİLGİ YAYINLARI\AppData\Local\Programs\Python\Python39\python.exe";
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            //return output;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
