using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TD.BCDH.THAIBINH.DATA.Models;
using TD.BCDH.THAIBINH.ViewModels;

namespace TD.BCDH.THAIBINH.Mappers
{
    public class VanBanDenMapper
    {
        public void VanBanDenViewModelToVanVanDen(VanBanDenViewModel source, VanBanDen destination)
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
            destination.SoKyHieu = source.SoKyHieu;
            destination.TrangThai = source.TrangThai;
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
                destination.NgayNhan = DateTime.Parse(source.NgayNhan);
            }
            catch (Exception)
            {
                destination.NgayNhan = null;
            }

            try
            {
                destination.NgayXuLyXong = DateTime.Parse(source.NgayXuLyXong);
            }
            catch (Exception)
            {
                destination.NgayXuLyXong = null;
            }
        }
    }
}
