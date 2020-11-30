using System;
using TD.BCDH.THAIBINH.DATA.Models;
using TD.BCDH.THAIBINH.ViewModels;

namespace TD.BCDH.THAIBINH.Mappers
{
    public class VanBanDiMapper
    {
        public void VanBanDiViewModelToVanBanDi(VanBanDiViewModel source, VanBanDi destination)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (destination is null)
            {
                throw new ArgumentNullException(nameof(destination));
            }


            destination.CoQuanBanHanh = source.CoQuanBanHanh;
            destination.DonViNhan = source.DonViNhan;
            destination.IdVanBan = source.IdVanBan;
            destination.LoaiVanBan = source.LoaiVanBan;
            destination.NguoiKy = source.NguoiKy;
            destination.NguoiSoanThao = source.NguoiSoanThao;
            destination.SoKiHieu = source.SoKiHieu;
            destination.SoVanBan = source.SoVanBan;
            destination.TrichYeu = source.TrichYeu;

            try
            {
                destination.NgayKy = DateTime.Parse(source.NgayKy);
            } 
            catch (Exception)
            {
                destination.NgayKy = null;
            }
        }
    }
}
