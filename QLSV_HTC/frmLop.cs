using DevExpress.XtraEditors;
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
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        public frmLop()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSLOP);

        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSLOP1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.DSLOP.LOP);
            // TODO: This line of code loads data into the 'DSLOP.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.DSLOP.SINHVIEN);
            


        }

        private void mALOPLabel_Click(object sender, EventArgs e)
        {

        }

        private void mALOPTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lOPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSLOP);
        }
    }
}