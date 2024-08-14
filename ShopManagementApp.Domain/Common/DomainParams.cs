namespace ShopManagementApp.Domain.Common;

public partial class Params_Get_Tenants_By_Properties
{
    public int? TENANTS_ID { get; set; }
    public IEnumerable<int?> TENANTS_ID_LIST { get; set; }
    public string NAME { get; set; }
    public DateTime? CREATED_AT { get; set; }
    public DateTime? CREATED_AT_START { get; set; }
    public DateTime? CREATED_AT_END { get; set; }
    public bool? CREATED_AT_INCLUSIVE { get; set; }
    public long? LAST_UPDATED_BY_USER_ID { get; set; }
    public IEnumerable<long?> LAST_UPDATED_BY_USER_ID_LIST { get; set; }
    public DateTimeOffset? CREATED_ON { get; set; }
    public DateTimeOffset? CREATED_ON_START { get; set; }
    public DateTimeOffset? CREATED_ON_END { get; set; }
    public bool? CREATED_ON_INCLUSIVE { get; set; }
    public DateTimeOffset? UPDATED_ON { get; set; }
    public DateTimeOffset? UPDATED_ON_START { get; set; }
    public DateTimeOffset? UPDATED_ON_END { get; set; }
    public bool? UPDATED_ON_INCLUSIVE { get; set; }
    public bool? IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
    public int? OFFSET { get; set; }
    public int? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Tenants_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Tenants_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Get_Tenants_By_TENANTS_ID_List
{
    public IEnumerable<int> TENANTS_ID_LIST { get; set; }
}
public partial class Params_Delete_Tenants
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Delete_Tenants_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Edit_Tenants_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Tenants> List_To_Edit { get; set; }
    public IEnumerable<Tenants> List_Failed_Edit { get; set; }
}
