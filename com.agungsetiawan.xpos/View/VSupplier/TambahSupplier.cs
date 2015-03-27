﻿using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.agungsetiawan.xpos.View.VSupplier
{
    public partial class TambahSupplier : Form
    {
        public ListSupplier ParentForm { get; set; }
        private SupplierService supplierService;
        public TambahSupplier()
        {
            InitializeComponent();
            this.ActiveControl = this.textBoxNamaSupplier;
            supplierService = new SupplierService();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            bool IsPass = true;
            if (string.IsNullOrEmpty(textBoxNamaSupplier.Text))
            {
                IsPass = false;
                sb.Append("- Nama Supplier harus diisi \n");
            }

            if (string.IsNullOrEmpty(textBoxAlamat.Text))
            {
                IsPass = false;
                sb.Append("- Alamat harus diisi \n");
            }

            if (string.IsNullOrEmpty(textBoxNomorTelepon.Text))
            {
                IsPass = false;
                sb.Append("- Nomor Telepon harus diisi \n");
            }

            if(!IsPass)
            {
                MessageBox.Show(sb.ToString(),"Invalid Input",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            var supplier = new Supplier()
            {
                NamaSupplier=textBoxNamaSupplier.Text,
                Alamat=textBoxAlamat.Text,
                NoTelepon=textBoxNomorTelepon.Text
            };

            supplierService.Post(supplier);

            this.ParentForm.dataGridViewSupplier.DataSource = supplierService.Get();
            this.Dispose();
        }

        private void TambahSupplier_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Rectangle rectNamaSupplier = new Rectangle(panelNamaSupplier.Location.X, panelNamaSupplier.Location.Y,
                                                          panelNamaSupplier.ClientSize.Width, panelNamaSupplier.ClientSize.Height);

            System.Drawing.Rectangle rectAlamat = new Rectangle(panelAlamat.Location.X, panelAlamat.Location.Y,
                                                          panelAlamat.ClientSize.Width, panelAlamat.ClientSize.Height);

            System.Drawing.Rectangle rectNomorTelepon = new Rectangle(panelNomorTelepon.Location.X, panelNomorTelepon.Location.Y,
                                                          panelNomorTelepon.ClientSize.Width, panelNomorTelepon.ClientSize.Height);


            rectNamaSupplier.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectNamaSupplier, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectAlamat.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectAlamat, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);

            rectNomorTelepon.Inflate(1, 1); // border thickness
            System.Windows.Forms.ControlPaint.DrawBorder(e.Graphics, rectNomorTelepon, Color.FromArgb(146, 202, 249), ButtonBorderStyle.Solid);
        }
    }
}
