using System.Data;
using DynamicData.Web.Config.After.Service;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DynamicData.Web.Config.After.Pages
{
    public class DtExampleModel : PageModel
    {
        private readonly IDataTableDataService _userData;

        public DtExampleModel(IDataTableDataService userData)
        {
            _userData = userData;
        }

        public DataTable Output { get; set; }
        public string Entity { get; set; }

        public void OnGet(string entity = "user")
        {
            Entity = entity;

            var sql = "SELECT * FROM [dbo].[UserData] ORDER BY [id]";

            if (entity.Equals("products", StringComparison.CurrentCultureIgnoreCase))
            {
                sql = "SELECT * FROM [dbo].[Product] ORDER BY [ProductId]";
            }


            Output = _userData.GetData(sql);
        }
    }
}