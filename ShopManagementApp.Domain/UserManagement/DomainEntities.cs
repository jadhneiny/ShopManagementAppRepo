using ShopManagementApp.Domain.Attributes;
using ShopManagementApp.Domain.Common;

namespace ShopManagementApp.Domain.UserManagement;

public partial class Admins
{
    public int ADMINS_ID { get; set; }
    public string NAME { get; set; }
    public string USERNAME { get; set; }
    public string EMAIL { get; set; }
    public string PASSWORD { get; set; }
    public DateTime? CREATED_AT { get; set; }
    public int TENANTS_ID { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Tenants Tenants { get; set; }
    #endregion
}
public partial class Get_Admins_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Admins> List_Admins { get; set; }
}
public partial class Customers
{
    public int CUSTOMERS_ID { get; set; }
    public string NAME { get; set; }
    public string USERNAME { get; set; }
    public string EMAIL { get; set; }
    public string PASSWORD { get; set; }
    public DateTime? CREATED_AT { get; set; }
    public int TENANTS_ID { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Tenants Tenants { get; set; }
    #endregion
}
public partial class Get_Customers_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Customers> List_Customers { get; set; }
}
