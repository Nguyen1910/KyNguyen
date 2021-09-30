using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_HTC
{
    public partial class ChooseServerForm : Form
    {
        private MainForm mainForm;
        public ChooseServerForm()
        {
            InitializeComponent();
        }

        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDoorOpen_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm = new MainForm();
            mainForm.Show();
        }

    }
}
