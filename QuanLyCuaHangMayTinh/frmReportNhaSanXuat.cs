﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangMayTinh
{
    public partial class frmReportNhaSanXuat : Form
    {
        public frmReportNhaSanXuat()
        {
            InitializeComponent();
        }

        private void frmReportNhaSanXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsNhaSanXuat.NHASX' table. You can move, or remove it, as needed.
            this.NHASXTableAdapter.Connection.ConnectionString = "Data Source=HOANGSON\\SQLEXPRESS;Initial Catalog=QLBANHANG;Integrated Security=True";

            this.NHASXTableAdapter.Fill(this.dtsNhaSanXuat.NHASX);

            this.reportViewer1.RefreshReport();
        }
    }
}
