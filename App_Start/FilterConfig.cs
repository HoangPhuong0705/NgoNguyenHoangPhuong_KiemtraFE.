using System.Web;
using System.Web.Mvc;

namespace NgoNguyenHoangPhuong_KiemtraFE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
