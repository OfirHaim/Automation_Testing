using System.Web;
using System.Web.Mvc;

namespace IDobet_Automation_Test_GUI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
