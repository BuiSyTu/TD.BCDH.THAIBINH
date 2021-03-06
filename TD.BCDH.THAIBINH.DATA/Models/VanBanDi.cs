﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD.BCDH.THAIBINH.DATA.Models
{
    public class VanBanDi
    {
        public int ID { get; set; }
        public string IdVanBan { get; set; }
        public string DonViNhan { get; set; }
        public string SoKiHieu { get; set; }
        public string TrichYeu { get; set; }
        public DateTime? NgayKy { get; set; }
        public string LoaiVanBan { get; set; }
        public string SoVanBan { get; set; }
        public string CoQuanBanHanh { get; set; }
        public string NguoiKy { get; set; }
        public string NguoiSoanThao { get; set; }
    }
}
