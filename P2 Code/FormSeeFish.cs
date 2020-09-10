using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace P2_Code
{
    public partial class FormSeeFish : Form
    {
        public string _SelectedFish;
        public string _SelectedF;

        public FormSeeFish(string selectedFish)
        {
            InitializeComponent();
            
            _SelectedFish = selectedFish;
            LoadPic();
        }

        private void FormSeeFish_Load(object sender, EventArgs e)
        {
            CenterToScreen();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void LoadPic()
        {
            switch (_SelectedFish)
            {
                case "Crappie":
                    pictureBox1.Image = Properties.Resources.Crappie;
                    break;
                case "Walleye":
                    pictureBox1.Image = Properties.Resources.Walleye;
                    break;
                case "Perch":
                    pictureBox1.Image = Properties.Resources.Perch;
                    break;
            }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Decision is to Keep It!");
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Decision is to Let it go!");
            Environment.Exit(0);

        }
    }
}

