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
    public partial class PrintThisType : Form
    {
        public PrintThisType()
        {
            InitializeComponent();
        }

        private void BTPrint_Click(object sender, EventArgs e)
        {
            switch (CBType.SelectedIndex)
            {
                case 0:                    

                    break;
                case 1:
                  

                    break;
                case 2:
                  

                    break;
                case 3:
                    
            
                    break;
            }
        }
        public void Output(KingdomAnimal animal)
        {
            string name = animal.Name;
            int weight = animal.Weight;

            string output = $"{name}, {weight}кг\n";
            TBOutput.Text += output;
        }
        public void Output(ClassMammals animal)
        {
            string name = animal.Name;
            int weight = animal.Weight;
            int incubationPeriod = animal.IncubationPeriod;
            int lifeExpectancy = animal.LifeExpectancy;

            string output = $"{name}, {weight}кг, {incubationPeriod}месяцев, {lifeExpectancy}лет\n";
            TBOutput.Text += output;
        }
        public void Output(ClassBirds animal)
        {
            string name = animal.Name;
            int weight = animal.Weight;
            bool flying = animal.Flying;
            bool domestic = animal.Domestic;

            string output = $"{name}, {weight}кг, летает: {flying}, домашняя: {domestic}\n";
            TBOutput.Text += output;
        }
        public void Output(OrderArtiodactyl animal)
        {
            string name = animal.Name;
            int weight = animal.Weight;
            int incubationPeriod = animal.IncubationPeriod;
            int lifeExpectancy = animal.LifeExpectancy;
            bool hasHorns = animal.HasHorns;
            string habitat = animal.Habitat;

            string output = $"{name}, {weight}кг, {incubationPeriod}месяцев, {lifeExpectancy}лет, есть рога: {hasHorns}, {habitat}\n";
            TBOutput.Text += output;
        }

    }
}
