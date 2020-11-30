using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.BCDH.THAIBINH.DATA.Models;
using TD.BCDH.THAIBINH.ViewModels;

namespace TD.BCDH.THAIBINH.Mappers
{
    public class NhiemVuKetQuaMapper
    {
        public void NhiemVuKetQuaViewModelToNhiemVuKetQua(NhiemVuKetQuaViewModel source, NhiemVuKetQua destination)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (destination is null)
            {
                throw new ArgumentNullException(nameof(destination));
            }


            destination.DonViXuLy = source.DonViXuLy;
            destination.IdVanBan = source.IdVanBan;
            destination.LoaiVanBan = source.LoaiVanBan;
            destination.NguoiKy = source.NguoiKy;
            destination.NguoiXuLy = source.NguoiXuLy;
            destination.SoKiHieu = source.SoKiHieu;
            destination.TrichYeu = source.TrichYeu;
        }
    }
}
