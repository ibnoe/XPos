﻿namespace com.agungsetiawan.xpos.View.VPenjualan
{
    partial class TransaksiPenjualan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTransaksiPenjualan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelKodeTransaksi = new System.Windows.Forms.Panel();
            this.textBoxKodeTransaksi = new System.Windows.Forms.TextBox();
            this.textBoxTanggal = new System.Windows.Forms.TextBox();
            this.panelTanggal = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelKaryawan = new System.Windows.Forms.Panel();
            this.textBoxKaryawan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelKodePelanggan = new System.Windows.Forms.Panel();
            this.textBoxKodePelanggan = new System.Windows.Forms.TextBox();
            this.buttonPelanggan = new System.Windows.Forms.Button();
            this.panelPelanggan = new System.Windows.Forms.Panel();
            this.textBoxPelanggan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksiPenjualan)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelKodeTransaksi.SuspendLayout();
            this.panelTanggal.SuspendLayout();
            this.panelKaryawan.SuspendLayout();
            this.panelKodePelanggan.SuspendLayout();
            this.panelPelanggan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTransaksiPenjualan
            // 
            this.dataGridViewTransaksiPenjualan.AllowUserToAddRows = false;
            this.dataGridViewTransaksiPenjualan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTransaksiPenjualan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTransaksiPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(113)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTransaksiPenjualan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTransaksiPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaksiPenjualan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewTransaksiPenjualan.EnableHeadersVisualStyles = false;
            this.dataGridViewTransaksiPenjualan.Location = new System.Drawing.Point(0, 220);
            this.dataGridViewTransaksiPenjualan.Name = "dataGridViewTransaksiPenjualan";
            this.dataGridViewTransaksiPenjualan.Size = new System.Drawing.Size(1039, 419);
            this.dataGridViewTransaksiPenjualan.TabIndex = 1;
            this.dataGridViewTransaksiPenjualan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kode";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama Barang";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Jumlah Jual";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Harga Jual";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Diskon (%)";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Subtotal";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Location = new System.Drawing.Point(0, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 100);
            this.panel1.TabIndex = 2;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.labelTotal.Font = new System.Drawing.Font("Meiryo UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(253)))));
            this.labelTotal.Location = new System.Drawing.Point(556, 4);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(452, 87);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "0.00";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 688);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 43);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(249)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "[Del]=Hapus  |  [F11]=Minus  |  [F12]=Tambah  |  [F9]=Custom Harga ";
            // 
            // panelKodeTransaksi
            // 
            this.panelKodeTransaksi.BackColor = System.Drawing.SystemColors.Control;
            this.panelKodeTransaksi.Controls.Add(this.textBoxKodeTransaksi);
            this.panelKodeTransaksi.Location = new System.Drawing.Point(127, 20);
            this.panelKodeTransaksi.Name = "panelKodeTransaksi";
            this.panelKodeTransaksi.Padding = new System.Windows.Forms.Padding(3);
            this.panelKodeTransaksi.Size = new System.Drawing.Size(170, 22);
            this.panelKodeTransaksi.TabIndex = 16;
            // 
            // textBoxKodeTransaksi
            // 
            this.textBoxKodeTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKodeTransaksi.Enabled = false;
            this.textBoxKodeTransaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKodeTransaksi.Location = new System.Drawing.Point(6, 5);
            this.textBoxKodeTransaksi.Name = "textBoxKodeTransaksi";
            this.textBoxKodeTransaksi.Size = new System.Drawing.Size(158, 13);
            this.textBoxKodeTransaksi.TabIndex = 7;
            // 
            // textBoxTanggal
            // 
            this.textBoxTanggal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTanggal.Enabled = false;
            this.textBoxTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTanggal.Location = new System.Drawing.Point(6, 5);
            this.textBoxTanggal.Name = "textBoxTanggal";
            this.textBoxTanggal.Size = new System.Drawing.Size(158, 13);
            this.textBoxTanggal.TabIndex = 7;
            // 
            // panelTanggal
            // 
            this.panelTanggal.BackColor = System.Drawing.SystemColors.Control;
            this.panelTanggal.Controls.Add(this.textBoxTanggal);
            this.panelTanggal.Location = new System.Drawing.Point(127, 49);
            this.panelTanggal.Name = "panelTanggal";
            this.panelTanggal.Padding = new System.Windows.Forms.Padding(3);
            this.panelTanggal.Size = new System.Drawing.Size(170, 22);
            this.panelTanggal.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kode Transaksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tanggal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Karyawan";
            // 
            // panelKaryawan
            // 
            this.panelKaryawan.BackColor = System.Drawing.SystemColors.Window;
            this.panelKaryawan.Controls.Add(this.textBoxKaryawan);
            this.panelKaryawan.Location = new System.Drawing.Point(422, 20);
            this.panelKaryawan.Name = "panelKaryawan";
            this.panelKaryawan.Padding = new System.Windows.Forms.Padding(3);
            this.panelKaryawan.Size = new System.Drawing.Size(170, 22);
            this.panelKaryawan.TabIndex = 17;
            // 
            // textBoxKaryawan
            // 
            this.textBoxKaryawan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKaryawan.Location = new System.Drawing.Point(6, 5);
            this.textBoxKaryawan.Name = "textBoxKaryawan";
            this.textBoxKaryawan.Size = new System.Drawing.Size(158, 13);
            this.textBoxKaryawan.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Pelanggan";
            // 
            // panelKodePelanggan
            // 
            this.panelKodePelanggan.BackColor = System.Drawing.SystemColors.Window;
            this.panelKodePelanggan.Controls.Add(this.textBoxKodePelanggan);
            this.panelKodePelanggan.Location = new System.Drawing.Point(422, 49);
            this.panelKodePelanggan.Name = "panelKodePelanggan";
            this.panelKodePelanggan.Padding = new System.Windows.Forms.Padding(3);
            this.panelKodePelanggan.Size = new System.Drawing.Size(144, 22);
            this.panelKodePelanggan.TabIndex = 18;
            // 
            // textBoxKodePelanggan
            // 
            this.textBoxKodePelanggan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKodePelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKodePelanggan.Location = new System.Drawing.Point(6, 5);
            this.textBoxKodePelanggan.Name = "textBoxKodePelanggan";
            this.textBoxKodePelanggan.Size = new System.Drawing.Size(132, 13);
            this.textBoxKodePelanggan.TabIndex = 7;
            // 
            // buttonPelanggan
            // 
            this.buttonPelanggan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.buttonPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPelanggan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPelanggan.Location = new System.Drawing.Point(568, 48);
            this.buttonPelanggan.Name = "buttonPelanggan";
            this.buttonPelanggan.Size = new System.Drawing.Size(26, 23);
            this.buttonPelanggan.TabIndex = 22;
            this.buttonPelanggan.Text = "...";
            this.buttonPelanggan.UseVisualStyleBackColor = false;
            this.buttonPelanggan.Click += new System.EventHandler(this.buttonPelanggan_Click);
            // 
            // panelPelanggan
            // 
            this.panelPelanggan.BackColor = System.Drawing.SystemColors.Window;
            this.panelPelanggan.Controls.Add(this.textBoxPelanggan);
            this.panelPelanggan.Location = new System.Drawing.Point(422, 76);
            this.panelPelanggan.Name = "panelPelanggan";
            this.panelPelanggan.Padding = new System.Windows.Forms.Padding(3);
            this.panelPelanggan.Size = new System.Drawing.Size(170, 22);
            this.panelPelanggan.TabIndex = 18;
            // 
            // textBoxPelanggan
            // 
            this.textBoxPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPelanggan.Location = new System.Drawing.Point(6, 5);
            this.textBoxPelanggan.Name = "textBoxPelanggan";
            this.textBoxPelanggan.Size = new System.Drawing.Size(158, 13);
            this.textBoxPelanggan.TabIndex = 7;
            // 
            // TransaksiPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1038, 733);
            this.Controls.Add(this.panelPelanggan);
            this.Controls.Add(this.buttonPelanggan);
            this.Controls.Add(this.panelKodePelanggan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelKaryawan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelTanggal);
            this.Controls.Add(this.panelKodeTransaksi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewTransaksiPenjualan);
            this.Name = "TransaksiPenjualan";
            this.Text = "TransaksiPenjualan";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TransaksiPenjualan_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaksiPenjualan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelKodeTransaksi.ResumeLayout(false);
            this.panelKodeTransaksi.PerformLayout();
            this.panelTanggal.ResumeLayout(false);
            this.panelTanggal.PerformLayout();
            this.panelKaryawan.ResumeLayout(false);
            this.panelKaryawan.PerformLayout();
            this.panelKodePelanggan.ResumeLayout(false);
            this.panelKodePelanggan.PerformLayout();
            this.panelPelanggan.ResumeLayout(false);
            this.panelPelanggan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewTransaksiPenjualan;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panelKodeTransaksi;
        public System.Windows.Forms.TextBox textBoxKodeTransaksi;
        private System.Windows.Forms.TextBox textBoxTanggal;
        private System.Windows.Forms.Panel panelTanggal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelKaryawan;
        private System.Windows.Forms.TextBox textBoxKaryawan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelKodePelanggan;
        public System.Windows.Forms.TextBox textBoxKodePelanggan;
        private System.Windows.Forms.Button buttonPelanggan;
        private System.Windows.Forms.Panel panelPelanggan;
        public System.Windows.Forms.TextBox textBoxPelanggan;
    }
}