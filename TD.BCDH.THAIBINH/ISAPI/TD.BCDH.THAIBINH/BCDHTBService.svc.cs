using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Activation;
using TD.BCDH.THAIBINH.DATA.Data;
using TD.BCDH.THAIBINH.DATA.Models;
using TD.BCDH.THAIBINH.Mappers;
using TD.BCDH.THAIBINH.ViewModels;

namespace TD.BCDH.THAIBINH
{
    [AspNetCompatibilityRequirements(
    RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public partial class BCDHTBService : IBCDHTBService
    {
        public ApiResult<List<NhiemVuKetQua>> AddNhiemVuKetQuas(List<NhiemVuKetQuaViewModel> nhiemVuKetQuaViewModels)
        {
            var nhiemVuKetQuas = new List<NhiemVuKetQua>();
            var mapper = new NhiemVuKetQuaMapper();

            foreach (var src in nhiemVuKetQuaViewModels)
            {
                var des = new NhiemVuKetQua();
                mapper.NhiemVuKetQuaViewModelToNhiemVuKetQua(src, des);

                nhiemVuKetQuas.Add(des);
            }

            try
            {
                var db = new BCDHTBContext();
                db.NhiemVuKetQuas.AddRange(nhiemVuKetQuas);
                db.SaveChanges();

                return new ApiResult<List<NhiemVuKetQua>>
                {
                    data = null,
                    total = nhiemVuKetQuas.Count,
                    err = new Error
                    {
                        code = "201",
                        internalMessage = "",
                        userMessage = ""
                    }
                };
            }
            catch (Exception ex)
            {
                return new ApiResult<List<NhiemVuKetQua>>
                {
                    data = null,
                    total = 0,
                    err = new Error
                    {
                        code = "500",
                        internalMessage = ex.ToString(),
                        userMessage = ""
                    }
                };
            }
        }

        public ApiResult<List<NhiemVu>> AddNhiemVus(List<NhiemVuViewModel> nhiemVuViewModels)
        {
            var nhiemVus = new List<NhiemVu>();
            var mapper = new NhiemVuMapper();

            foreach (var src in nhiemVuViewModels)
            {
                var des = new NhiemVu();
                mapper.NhiemVuViewModelToNhiemVu(src, des);

                nhiemVus.Add(des);
            }
            
            try
            {
                var db = new BCDHTBContext();
                db.NhiemVus.AddRange(nhiemVus);
                db.SaveChanges();

                return new ApiResult<List<NhiemVu>>
                {
                    data = null,
                    total = nhiemVus.Count,
                    err = new Error
                    {
                        code = "201",
                        internalMessage = "",
                        userMessage = ""
                    }
                };
            }
            catch (Exception ex)
            {
                return new ApiResult<List<NhiemVu>>
                {
                    data = null,
                    total = 0,
                    err = new Error
                    {
                        code = "500",
                        internalMessage = ex.ToString(),
                        userMessage = ""
                    }
                };
            }
        }

        public ApiResult<List<VanBanDen>> AddVanBanDens(List<VanBanDenViewModel> vanBanDenViewModels)
        {
            var vanBanDens = new List<VanBanDen>();
            var mapper = new VanBanDenMapper();

            foreach (var src in vanBanDenViewModels)
            {
                var des = new VanBanDen();
                mapper.VanBanDenViewModelToVanVanDen(src, des);

                vanBanDens.Add(des);
            }

            try
            {
                var db = new BCDHTBContext();
                db.VanBanDens.AddRange(vanBanDens);
                db.SaveChanges();

                return new ApiResult<List<VanBanDen>>
                {
                    data = null,
                    total = vanBanDens.Count,
                    err = new Error
                    {
                        code = "201",
                        internalMessage = "",
                        userMessage = ""
                    }
                };
            }
            catch (Exception ex)
            {
                return new ApiResult<List<VanBanDen>>
                {
                    data = null,
                    total = 0,
                    err = new Error
                    {
                        code = "500",
                        internalMessage = ex.ToString(),
                        userMessage = ""
                    }
                };
            }
        }

        public ApiResult<List<VanBanDi>> AddVanBanDis(List<VanBanDiViewModel> vanBanDiViewModels)
        {
            var vanBanDis = new List<VanBanDi>();
            var mapper = new VanBanDiMapper();

            foreach (var src in vanBanDiViewModels)
            {
                var des = new VanBanDi();
                mapper.VanBanDiViewModelToVanBanDi(src, des);

                vanBanDis.Add(des);
            }

            try
            {
                var db = new BCDHTBContext();
                db.VanBanDis.AddRange(vanBanDis);
                db.SaveChanges();

                return new ApiResult<List<VanBanDi>>
                {
                    data = null,
                    total = vanBanDis.Count,
                    err = new Error
                    {
                        code = "201",
                        internalMessage = "",
                        userMessage = ""
                    }
                };
            }
            catch (Exception ex)
            {
                return new ApiResult<List<VanBanDi>>
                {
                    data = null,
                    total = 0,
                    err = new Error
                    {
                        code = "500",
                        internalMessage = ex.ToString(),
                        userMessage = ""
                    }
                };
            }
        }

        public string HelloWorld()
        {
            return "Hello world";
        }
    }
}
