using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA_11
{
    public partial class NumberOfElementsWithThisType : Form
    {
        public NumberOfElementsWithThisType()
        {
            InitializeComponent();
        }

        private void BTCount_Click(object sender, EventArgs e)
        {
            string content = "";
            switch (CBType.SelectedIndex)
            {
                case 0:
                    int numberOfAnimals = Collections.GetAnimalNumber();

                    content = "Животных: "+numberOfAnimals.ToString();
                    break;
                case 1:
                    int numberOfMammals = Collections.GetMammalNumber();

                    content = "Млекопитающих: "+numberOfMammals.ToString();
                    break;
                case 2:
                    int numberOfBirds = Collections.GetBirdNumber();

                    content = "Птиц: " + numberOfBirds.ToString();
                    break;
                case 3:
                    int numberOArtiodactyls = Collections.GetArtiodactylNumber();

                    content = "Парнокопытных: "+numberOArtiodactyls.ToString();
                    break;
            }
            MessageBox.Show(content,"",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            
        }
    }
}
