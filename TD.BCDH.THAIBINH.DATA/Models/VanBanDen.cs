using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD.BCDH.THAIBINH.DATA.Models
{
    public class VanBanDen
    {
        public int ID { get; set; }
        public string IdVanBan { get; set; }
        public string SoKyHieu { get; set; }
        public string TrichYeu { get; set; }
        public string CoQuanBanHanh { get; set; }
        public DateTime? NgayBanHanh { get; set; }
        public string DonViNhan { get; set; }
        public DateTime? NgayNhan { get; set; }
        public string TrangThai { get; set; }
        public DateTime? NgayXuLyXong { get; set; }
    }
}
