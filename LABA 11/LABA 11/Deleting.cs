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
    public partial class Deleting : Form
    {
        public Deleting()
        {
            InitializeComponent();
        }

        private void BTDelete_Click(object sender, EventArgs e)
        {
            if (!SupportingMethods.IsStringEmpty(TBKey.Text))
            {
                string key = TBKey.Text;
                Collections.DeleteByKey(key);
                MessageBox.Show("Объект удален");
            }
            else
            {
                SupportingMethods.ShowMistake();
            }
        }
    }
}
