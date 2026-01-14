using System.Data;

namespace DynamicData.Web.Config.After.Service;

public interface IDataTableDataService
{
    DataTable GetData(string sql);
}