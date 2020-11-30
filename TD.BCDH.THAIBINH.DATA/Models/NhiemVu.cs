using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD.BCDH.THAIBINH.DATA.Models
{
    public class NhiemVu
    {
        public int ID { get; set; }
        public string IdVanBan { get; set; }
        public string SoKyHieu { get; set; }
        public string TrichYeu { get; set; }
        public string TenNhiemVu { get; set; }
        public string DonViXuLy { get; set; }
        public DateTime? NgayBanHanh { get; set; }
        public DateTime? NgayBaoCao { get; set; }
        public DateTime? NgayXuLy { get; set; }
        public string NguoiPhuTrach { get; set; }
    }
}
