using System.Data;
using Microsoft.Data.SqlClient;

namespace DynamicData.Web.Config.After.Service;

public class DataTableDataService : IDataTableDataService
{
    public readonly IConfiguration _config;

    public DataTableDataService(IConfiguration config)
    {
        _config = config;
    }

    public SqlConnection Connection => new SqlConnection(_config.GetConnectionString("DefaultConnection"));

    public DataTable GetData(string sql)
    {
        using var conn = Connection;
        var cmd = new SqlCommand(sql, conn);
        cmd.CommandType = CommandType.Text;

        var ds = new DataSet();
        var myData = new SqlDataAdapter(cmd);
        myData.Fill(ds);

        return ds.Tables[0];
    }
}