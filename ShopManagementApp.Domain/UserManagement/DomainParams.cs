namespace ShopManagementApp.Domain.UserManagement;

public partial class Params_Get_Admins_By_ADMINS_ID
{
    public int ADMINS_ID { get; set; }
}
public partial class Params_Get_Admins_By_ADMINS_ID_List
{
    public IEnumerable<int> ADMINS_ID_LIST { get; set; }
}
public partial class Params_Get_Admins_By_Properties
{
    public int? ADMINS_ID { get; set; }
    public IEnumerable<int?> ADMINS_ID_LIST { get; set; }
    public string NAME { get; set; }
    public string USERNAME { get; set; }
    public string EMAIL { get; set; }
    public string PASSWORD { get; set; }
    public DateTime? CREATED_AT { get; set; }
    public DateTime? CREATED_AT_START { get; set; }
    public DateTime? CREATED_AT_END { get; set; }
    public bool? CREATED_AT_INCLUSIVE { get; set; }
    public int? TENANTS_ID { get; set; }
    public IEnumerable<int?> TENANTS_ID_LIST { get; set; }
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
    public bool IS_EAGER_LOAD { get; set; }
    public int? OFFSET { get; set; }
    public int? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Admins_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Admins_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Get_Admins_By_TENANTS_ID_List
{
    public IEnumerable<int> TENANTS_ID_LIST { get; set; }
}
public partial class Params_Get_Customers_By_CUSTOMERS_ID
{
    public int CUSTOMERS_ID { get; set; }
}
public partial class Params_Get_Customers_By_CUSTOMERS_ID_List
{
    public IEnumerable<int> CUSTOMERS_ID_LIST { get; set; }
}
public partial class Params_Get_Customers_By_Properties
{
    public int? CUSTOMERS_ID { get; set; }
    public IEnumerable<int?> CUSTOMERS_ID_LIST { get; set; }
    public string NAME { get; set; }
    public string USERNAME { get; set; }
    public string EMAIL { get; set; }
    public string PASSWORD { get; set; }
    public DateTime? CREATED_AT { get; set; }
    public DateTime? CREATED_AT_START { get; set; }
    public DateTime? CREATED_AT_END { get; set; }
    public bool? CREATED_AT_INCLUSIVE { get; set; }
    public int? TENANTS_ID { get; set; }
    public IEnumerable<int?> TENANTS_ID_LIST { get; set; }
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
    public bool IS_EAGER_LOAD { get; set; }
    public int? OFFSET { get; set; }
    public int? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Customers_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Customers_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Get_Customers_By_TENANTS_ID_List
{
    public IEnumerable<int> TENANTS_ID_LIST { get; set; }
}
public partial class Params_Delete_Admins
{
    public int ADMINS_ID { get; set; }
}
public partial class Params_Delete_Admins_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Admins_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Edit_Admins_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Admins> List_To_Edit { get; set; }
    public IEnumerable<Admins> List_Failed_Edit { get; set; }
}
public partial class Params_Delete_Customers
{
    public int CUSTOMERS_ID { get; set; }
}
public partial class Params_Delete_Customers_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Customers_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Edit_Customers_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Customers> List_To_Edit { get; set; }
    public IEnumerable<Customers> List_Failed_Edit { get; set; }
}
