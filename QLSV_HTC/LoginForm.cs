using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLSV_HTC
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private ChooseServerForm chooseServer;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {         
            chooseServer =  new ChooseServerForm();
            chooseServer.Show();
        }

    }
}
