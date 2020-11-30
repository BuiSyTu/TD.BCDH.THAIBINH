using System;
using TD.BCDH.THAIBINH.DATA.Models;
using TD.BCDH.THAIBINH.ViewModels;

namespace TD.BCDH.THAIBINH.Mappers
{
    public class NhiemVuMapper
    {
        public void NhiemVuViewModelToNhiemVu(NhiemVuViewModel source, NhiemVu destination)
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
            destination.NguoiPhuTrach = source.NguoiPhuTrach;
            destination.SoKyHieu = source.SoKyHieu;
            destination.TenNhiemVu = source.TenNhiemVu;
            destination.TrichYeu = source.TrichYeu;

            try
            {
                destination.NgayBanHanh = DateTime.Parse(source.NgayBanHanh);
            }
            catch (Exception)
            {
                destination.NgayBanHanh = null;
            }

            try
            {
                destination.NgayBaoCao = DateTime.Parse(source.NgayBaoCao);
            }
            catch (Exception)
            {
                destination.NgayBaoCao = null;
            }

            try
            {
                destination.NgayXuLy = DateTime.Parse(source.NgayXuLy);
            }
            catch (Exception)
            {
                destination.NgayXuLy = null; ;
            }
        } 
    }
}
