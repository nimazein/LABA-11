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
    public partial class FindThisKey : Form
    {
        public FindThisKey()
        {
            InitializeComponent();
        }

        private void BTFind_Click(object sender, EventArgs e)
        {
            if (!SupportingMethods.IsStringEmpty(TBKey.Text))
            {
                string key = TBKey.Text;
                object soughtForAnimal = Collections.FindByKey(key);

                if (soughtForAnimal != null)
                {
                    if (key.Contains("Животное"))
                    {
                        KingdomAnimal animal = soughtForAnimal as KingdomAnimal;
                        Output(animal);
                    }
                    if (key.Contains("Млекопитающее"))
                    {
                        ClassMammals mammal = soughtForAnimal as ClassMammals;
                        Output(mammal);
                    }
                    if (key.Contains("Птица"))
                    {
                        ClassBirds bird = soughtForAnimal as ClassBirds;
                        Output(bird);
                    }
                    if (key.Contains("Парнокопытное"))
                    {
                        OrderArtiodactyl artiodactyl = soughtForAnimal as OrderArtiodactyl;
                        Output(artiodactyl);
                    }
                }
            }
            else
            {
                SupportingMethods.ShowMistake();
            }
        }
        private void Output(KingdomAnimal animal)
        {
            string name = animal.Name;
            int weight = animal.Weight;

            string output = $"{name}, {weight}кг\n";
            TBOutput.Text += output;
        }
        private void Output(ClassMammals animal)
        {
            string name = animal.Name;
            int weight = animal.Weight;
            int incubationPeriod = animal.IncubationPeriod;
            int lifeExpectancy = animal.LifeExpectancy;

            string output = $"{name}, {weight}кг, {incubationPeriod}месяцев, {lifeExpectancy}лет\n";
            TBOutput.Text += output;
        }
        private void Output(ClassBirds animal)
        {
            string name = animal.Name;
            int weight = animal.Weight;
            bool flying = animal.Flying;
            bool domestic = animal.Domestic;

            string output = $"{name}, {weight}кг, летает: {flying}, домашняя: {domestic}\n";
            TBOutput.Text += output;
        }
        private void Output(OrderArtiodactyl animal)
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
