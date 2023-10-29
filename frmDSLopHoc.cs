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
    public partial class frmDSLopHoc : Form
    {
        public frmDSLopHoc()
        {
            InitializeComponent();
        }

        private void frmDSLopHoc_Load(object sender, EventArgs e)
        {
            LoadDSLopHoc();
        }
        private void LoadDSLopHoc()
        {
            string sql = "SelectAllLopHoc";
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                Key = "@TuKhoa",
                Value = txtTuKhoa.Text
            });
            dgvDSLH.DataSource = new Database().SelectData(sql, lstPara);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSLopHoc();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            new frmLopHoc(null).ShowDialog();
            LoadDSLopHoc();
        }

        private void dgvDSLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                new frmLopHoc(dgvDSLH.Rows[e.RowIndex].Cells["ID_LopHoc"].Value.ToString()).ShowDialog();
                LoadDSLopHoc();
            }
        }
    }
}
