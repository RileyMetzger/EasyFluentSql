using System.Data.Common;

namespace EasyFluentSql.Core.Abstracts;

public abstract class ConnectionInformation
{
    public abstract string GetConnectionString();

}