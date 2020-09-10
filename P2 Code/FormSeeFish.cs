using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_Code
{
    public partial class FormSeeFish : Form
    {
        public string _SelectedFish;
        private string _SelectedF;
        public FormSeeFish(string selectedFish)
        {
            InitializeComponent();
            _SelectedF = selectedFish;
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
                 case selectedFish.Crappie:
                    pictureBox1.Image = Properties.Resources.Crappie;
                    break;
             } 

        }

    }
}

