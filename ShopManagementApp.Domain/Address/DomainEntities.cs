using ShopManagementApp.Domain.Attributes;
using ShopManagementApp.Domain.UserManagement;

namespace ShopManagementApp.Domain.Address;

public partial class Addresses
{
    public int ADDRESSES_ID { get; set; }
    public int? CUSTOMERS_ID { get; set; }
    public string STREET { get; set; }
    public string CITY { get; set; }
    public string STATE { get; set; }
    public string ZIP_CODE { get; set; }
    public string COUNTRY { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Customers Customers { get; set; }
    #endregion
}
public partial class Get_Addresses_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Addresses> List_Addresses { get; set; }
}
