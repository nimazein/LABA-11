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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BTMammalCreate_Click(object sender, EventArgs e)
        {
            if (!SupportingMethods.IsStringEmpty(TBMammalName.Text)
                && !SupportingMethods.IsStringEmpty(TBMammalWeight.Text)
                && !SupportingMethods.IsStringEmpty(TBMammalMaxAge.Text)
                && !SupportingMethods.IsStringEmpty(TBMammalIncubationPeriod.Text))
            {
                string name = TBMammalName.Text;
                int weight = Convert.ToInt32(TBMammalWeight.Text);
                int incubationPeriod = Convert.ToInt32(TBMammalIncubationPeriod.Text);
                int lifeExpectancy = Convert.ToInt32(TBMammalMaxAge.Text);

                 Collections.AddToList(name, weight, incubationPeriod, lifeExpectancy);
            }
            else
            {
                SupportingMethods.ShowMistake();
            }

            TBMammalWeight.Clear();
            TBMammalName.Clear();
            TBMammalMaxAge.Clear();
            TBMammalIncubationPeriod.Clear();
        }

        private void BTAnimalCreate_Click(object sender, EventArgs e)
        {
            if (!SupportingMethods.IsStringEmpty(TBAnimalName.Text)
                && !SupportingMethods.IsStringEmpty(TBAnimalWeight.Text))
            {
                string name = TBAnimalName.Text;
                int weight = Convert.ToInt32(TBAnimalWeight.Text);

                Collections.AddToList(name, weight);
            }
            else
            {
                SupportingMethods.ShowMistake();
            }

            TBAnimalName.Clear();
            TBAnimalWeight.Clear();
        }

        private void BTBirdCreate_Click(object sender, EventArgs e)
        {
            if (!SupportingMethods.IsStringEmpty(TBBirdName.Text)
                && !SupportingMethods.IsStringEmpty(TBBirdWeight.Text))
            {
                string name = TBBirdName.Text;
                int weight = Convert.ToInt32(TBBirdWeight.Text);
                bool flying = CBFlying.Checked;
                bool domestic = CBDomestic.Checked;

                Collections.AddToList(name, weight, flying, domestic);
            }
            else
            {
                SupportingMethods.ShowMistake();
            }

            TBBirdWeight.Clear();
            TBBirdName.Clear();
        }

        private void BTArtiodactylCreate_Click(object sender, EventArgs e)
        {
            if (!SupportingMethods.IsStringEmpty(TBArtiodactylName.Text)
                && !SupportingMethods.IsStringEmpty(TBArtiodactylWeight.Text)
                && !SupportingMethods.IsStringEmpty(TBArtiodactylMaxAge.Text)
                && !SupportingMethods.IsStringEmpty(TBArtiodactylIncubationPeriod.Text)
                && !SupportingMethods.IsStringEmpty(TBArtiodactylHabitat.Text))
            {
                string name = TBArtiodactylName.Text;
                int weight = Convert.ToInt32(TBArtiodactylWeight.Text);
                int incubationPeriod = Convert.ToInt32(TBArtiodactylIncubationPeriod.Text);
                int lifeExpectancy = Convert.ToInt32(TBArtiodactylMaxAge.Text);
                bool hasHorns = CBHorns.Checked;
                string habitat = TBArtiodactylHabitat.Text;

                Collections.AddToList(name, weight, incubationPeriod, lifeExpectancy, hasHorns, habitat);
            }
            else
            {
                SupportingMethods.ShowMistake();
            }

            TBArtiodactylHabitat.Clear();
            TBArtiodactylIncubationPeriod.Clear();
            TBArtiodactylMaxAge.Clear();
            TBArtiodactylName.Clear();
            TBArtiodactylWeight.Clear();
        }

        private void УдалениеОбъектовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deleting form = new Deleting();
            form.ShowDialog();
        }

        private void ПечатьОсобейДанногоВидаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintThisType form = new PrintThisType();
            form.ShowDialog();
        }

        private void ПоискОбъектаПоКлючуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindThisKey form = new FindThisKey();
            form.ShowDialog();
        }

        private void ПечатьЭлементовДанногоТипаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintThisType form = new PrintThisType();
            form.ShowDialog();
        }
    }
}
