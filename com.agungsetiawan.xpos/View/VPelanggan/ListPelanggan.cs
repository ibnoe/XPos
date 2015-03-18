﻿using com.agungsetiawan.xpos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.agungsetiawan.xpos.View.VPelanggan
{
    public partial class ListPelanggan : Form
    {
        PelangganService pelangganService;
        static ListPelanggan form;
        private ListPelanggan()
        {
            InitializeComponent();
            pelangganService = new PelangganService();

            dataGridViewPelanggan.DataSource = pelangganService.Get();
            dataGridViewPelanggan.Columns[0].Visible = false;
        }

        public static ListPelanggan GetForm()
        {
            if (form == null || form.IsDisposed)
                form = new ListPelanggan();

            return form;
        }
    }
}
