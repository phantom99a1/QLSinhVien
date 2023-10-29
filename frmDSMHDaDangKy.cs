using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class frmDSMHDaDangKy : Form
    {
        public frmDSMHDaDangKy(string MaSV)
        {
            InitializeComponent();
            this.MaSV = MaSV;
        }
        private string MaSV = "";
        private void frmDSMHDaDangKy_Load(object sender, EventArgs e)
        {
            LoaDDSMHDaDangKy();
        }
        private void LoaDDSMHDaDangKy()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    Key="@Ma_SinhVien",
                    Value=MaSV
                }
            };
            dgvDSMHDaDangKy.DataSource = new Database().SelectData("MonHocDaDangKy", lstPara);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoaDDSMHDaDangKy();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {

        }
    }
}
