namespace ShopManagementApp.Domain.Common;

public partial class Tenants
{
    public int TENANTS_ID { get; set; }
    public string NAME { get; set; }
    public DateTime? CREATED_AT { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
}
public partial class Get_Tenants_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Tenants> List_Tenants { get; set; }
}
