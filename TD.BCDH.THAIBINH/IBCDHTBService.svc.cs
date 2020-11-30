using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using TD.BCDH.THAIBINH.DATA.Models;
using TD.BCDH.THAIBINH.ViewModels;

namespace TD.BCDH.THAIBINH
{
    [ServiceContract]
    public partial interface IBCDHTBService
    {
        [OperationContract]
        [WebGet(UriTemplate = "HelloWorld")]
        string HelloWorld();

        [WebInvoke(UriTemplate = "nhiemvus", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        ApiResult<List<NhiemVu>> AddNhiemVus(List<NhiemVuViewModel> nhiemVuViewModels);

        [WebInvoke(UriTemplate = "nhiemvuketquas", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        ApiResult<List<NhiemVuKetQua>> AddNhiemVuKetQuas(List<NhiemVuKetQuaViewModel> nhiemVuKetQuaViewModels);

        [WebInvoke(UriTemplate = "vanbandis", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        ApiResult<List<VanBanDi>> AddVanBanDis(List<VanBanDiViewModel> vanBanDiViewModels);

        [WebInvoke(UriTemplate = "vanbandens", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        ApiResult<List<VanBanDen>> AddVanBanDens(List<VanBanDenViewModel> vanBanDenViewModels);
    }
}
