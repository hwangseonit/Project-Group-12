﻿namespace QuanLyCuaHangMayTinh
{
    partial class frmReportLoaiSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportLoaiSanPham));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtsLoaiSanPham = new QuanLyCuaHangMayTinh.dtsLoaiSanPham();
            this.LOAISPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LOAISPTableAdapter = new QuanLyCuaHangMayTinh.dtsLoaiSanPhamTableAdapters.LOAISPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtsLoaiSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOAISPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LOAISPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangMayTinh.rptLoaiSanPham.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 484);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtsLoaiSanPham
            // 
            this.dtsLoaiSanPham.DataSetName = "dtsLoaiSanPham";
            this.dtsLoaiSanPham.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LOAISPBindingSource
            // 
            this.LOAISPBindingSource.DataMember = "LOAISP";
            this.LOAISPBindingSource.DataSource = this.dtsLoaiSanPham;
            // 
            // LOAISPTableAdapter
            // 
            this.LOAISPTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportLoaiSanPham";
            this.Text = "In danh sách loại sản phẩm";
            this.Load += new System.EventHandler(this.frmReportLoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsLoaiSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOAISPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LOAISPBindingSource;
        private dtsLoaiSanPham dtsLoaiSanPham;
        private dtsLoaiSanPhamTableAdapters.LOAISPTableAdapter LOAISPTableAdapter;
    }
}