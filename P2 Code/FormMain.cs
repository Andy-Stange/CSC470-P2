using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2_Code
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        
        private void FormMain_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();
            Populatefish();

        }

        private void Populatefish()
        {
            listBoxFish.Items.Clear();
            listBoxFish.Items.Add("Crappie");
            listBoxFish.Items.Add("Walleye");
            listBoxFish.Items.Add("Perch");
            listBoxFish.SelectedIndex = 0;
        }

        private void SeeFish_Click(object sender, EventArgs e)
        {
                // Make sure a Fish is selected
                if (listBoxFish.SelectedIndex >= 0)
                {
                    string selectedFish = listBoxFish.SelectedItem.ToString().Trim();
                    // Open the form as a dialog
                    FormSeeFish formFish = new FormSeeFish(selectedFish);
                    DialogResult result = formFish.ShowDialog();

                    // Check the dialog result
                    if (result == DialogResult.OK)
                    {
                            
                            //if (formFish._SelectedFish == );
                    
                    }
                    else
                    {
                        MessageBox.Show("No fish selected - dialog cancelled");
                    }
                }
                else
                {
                    MessageBox.Show("Please selecte a fish", "Attention");
                }


        }
        private void LoadPic()
        {
 //           switch (_SelectedFish)
  //          {
    //            case selectedFish.Crappie:
      //              pictureBox1.Image = Properties.FishPics.Crappie;
        //            break;
          //  }

        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {

        }
        //      private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        //      {

        //     }
    }
}
