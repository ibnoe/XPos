﻿using com.agungsetiawan.xpos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Repository
{
    public class BarangRepository : GenericRepository<Barang>
    {
        public List<Barang> GetWithKategori()
        {
            return db.Barangs.Include("Kategori").ToList();
        }
    }
}