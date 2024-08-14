namespace ShopManagementApp.Domain.Business;

public partial class Params_Get_Setup_By_Properties
{
    public long? SETUP_ID { get; set; }
    public IEnumerable<long?> SETUP_ID_LIST { get; set; }
    public int? SETUP_CATEGORY_ID { get; set; }
    public IEnumerable<int?> SETUP_CATEGORY_ID_LIST { get; set; }
    public bool? IS_SYSTEM { get; set; }
    public bool? IS_DELETEABLE { get; set; }
    public bool? IS_UPDATEABLE { get; set; }
    public bool? IS_DELETED { get; set; }
    public bool? IS_VISIBLE { get; set; }
    public int? DISPLAY_ORDER { get; set; }
    public string VALUE { get; set; }
    public string DESCRIPTION { get; set; }
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
    public int TENANT_ID { get; set; }
    public bool IS_EAGER_LOAD { get; set; }
    public long? OFFSET { get; set; }
    public long? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Setup_By_SETUP_CATEGORY_ID
{
    public int SETUP_CATEGORY_ID { get; set; }
}
public partial class Params_Get_Setup_By_SETUP_CATEGORY_ID_List
{
    public IEnumerable<int> SETUP_CATEGORY_ID_LIST { get; set; }
}
public partial class Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE
{
    public int SETUP_CATEGORY_ID { get; set; }
    public string VALUE { get; set; }
}
public partial class Params_Get_Setup_By_SETUP_ID
{
    public long SETUP_ID { get; set; }
}
public partial class Params_Get_Setup_By_SETUP_ID_List
{
    public IEnumerable<long> SETUP_ID_LIST { get; set; }
}
public partial class Params_Get_Setup_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Setup_category_By_Properties
{
    public int? SETUP_CATEGORY_ID { get; set; }
    public IEnumerable<int?> SETUP_CATEGORY_ID_LIST { get; set; }
    public string SETUP_CATEGORY_NAME { get; set; }
    public string DESCRIPTION { get; set; }
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
public partial class Params_Get_Setup_category_By_SETUP_CATEGORY_ID
{
    public int SETUP_CATEGORY_ID { get; set; }
}
public partial class Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List
{
    public IEnumerable<int> SETUP_CATEGORY_ID_LIST { get; set; }
}
public partial class Params_Get_Setup_category_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Tenant_By_IS_DELETED
{
    public bool IS_DELETED { get; set; }
}
public partial class Params_Get_Tenant_By_Properties
{
    public int TENANT_ID { get; set; }
    public string TENANT_NAME { get; set; }
    public string TENANT_CODE { get; set; }
    public bool? IS_SUPER_TENANT { get; set; }
    public DateTimeOffset? CREATED_ON { get; set; }
    public DateTimeOffset? CREATED_ON_START { get; set; }
    public DateTimeOffset? CREATED_ON_END { get; set; }
    public bool? CREATED_ON_INCLUSIVE { get; set; }
    public DateTimeOffset? UPDATED_ON { get; set; }
    public DateTimeOffset? UPDATED_ON_START { get; set; }
    public DateTimeOffset? UPDATED_ON_END { get; set; }
    public bool? UPDATED_ON_INCLUSIVE { get; set; }
    public string DESCRIPTION { get; set; }
    public long? LAST_UPDATED_BY_USER_ID { get; set; }
    public IEnumerable<long?> LAST_UPDATED_BY_USER_ID_LIST { get; set; }
    public bool? IS_DELETED { get; set; }
    public int? OFFSET { get; set; }
    public int? FETCH_NEXT { get; set; }
}
public partial class Params_Get_Tenant_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Tenant_By_TENANT_ID_List
{
    public IEnumerable<int> TENANT_ID_LIST { get; set; }
}
public partial class Params_Get_User_By_EMAIL_TENANT_ID
{
    public string EMAIL { get; set; }
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_User_By_Properties
{
    public long? USER_ID { get; set; }
    public IEnumerable<long?> USER_ID_LIST { get; set; }
    public long? USER_TYPE_SETUP_ID { get; set; }
    public IEnumerable<long?> USER_TYPE_SETUP_ID_LIST { get; set; }
    public string FULL_NAME { get; set; }
    public string EMAIL { get; set; }
    public string USERNAME { get; set; }
    public string PASSWORD { get; set; }
    public bool? IS_ACTIVE { get; set; }
    public bool? IS_DELETED { get; set; }
    public DateTimeOffset? CREATED_ON { get; set; }
    public DateTimeOffset? CREATED_ON_START { get; set; }
    public DateTimeOffset? CREATED_ON_END { get; set; }
    public bool? CREATED_ON_INCLUSIVE { get; set; }
    public int TENANT_ID { get; set; }
    public long? LAST_UPDATED_BY_USER_ID { get; set; }
    public IEnumerable<long?> LAST_UPDATED_BY_USER_ID_LIST { get; set; }
    public DateTimeOffset? UPDATED_ON { get; set; }
    public DateTimeOffset? UPDATED_ON_START { get; set; }
    public DateTimeOffset? UPDATED_ON_END { get; set; }
    public bool? UPDATED_ON_INCLUSIVE { get; set; }
    public bool IS_EAGER_LOAD { get; set; }
    public long? OFFSET { get; set; }
    public long? FETCH_NEXT { get; set; }
}
public partial class Params_Get_User_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_User_By_TENANT_ID_IS_DELETED
{
    public int TENANT_ID { get; set; }
    public bool IS_DELETED { get; set; }
}
public partial class Params_Get_User_By_USER_ID
{
    public long USER_ID { get; set; }
}
public partial class Params_Get_User_By_USER_ID_List
{
    public IEnumerable<long> USER_ID_LIST { get; set; }
}
public partial class Params_Get_User_By_USER_TYPE_SETUP_ID
{
    public long USER_TYPE_SETUP_ID { get; set; }
}
public partial class Params_Get_User_By_USER_TYPE_SETUP_ID_List
{
    public IEnumerable<long> USER_TYPE_SETUP_ID_LIST { get; set; }
}
public partial class Params_Get_User_By_USERNAME_TENANT_ID
{
    public string USERNAME { get; set; }
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Setup
{
    public long SETUP_ID { get; set; }
}
public partial class Params_Delete_Setup_By_SETUP_CATEGORY_ID
{
    public int SETUP_CATEGORY_ID { get; set; }
}
public partial class Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE
{
    public int SETUP_CATEGORY_ID { get; set; }
    public string VALUE { get; set; }
}
public partial class Params_Delete_Setup_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Edit_Setup_List
{
    public IEnumerable<long> List_To_Delete { get; set; }
    public IEnumerable<long> List_Failed_Delete { get; set; }
    public IEnumerable<Setup> List_To_Edit { get; set; }
    public IEnumerable<Setup> List_Failed_Edit { get; set; }
}
public partial class Params_Delete_Setup_category
{
    public int SETUP_CATEGORY_ID { get; set; }
}
public partial class Params_Delete_Setup_category_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Edit_Setup_category_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Setup_category> List_To_Edit { get; set; }
    public IEnumerable<Setup_category> List_Failed_Edit { get; set; }
}
public partial class Params_Delete_Tenant
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Tenant_By_IS_DELETED
{
    public bool IS_DELETED { get; set; }
}
public partial class Params_Edit_Tenant_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Tenant> List_To_Edit { get; set; }
    public IEnumerable<Tenant> List_Failed_Edit { get; set; }
}
public partial class Params_Delete_User
{
    public long USER_ID { get; set; }
}
public partial class Params_Delete_User_By_EMAIL_TENANT_ID
{
    public string EMAIL { get; set; }
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_User_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_User_By_TENANT_ID_IS_DELETED
{
    public int TENANT_ID { get; set; }
    public bool IS_DELETED { get; set; }
}
public partial class Params_Delete_User_By_USER_TYPE_SETUP_ID
{
    public long USER_TYPE_SETUP_ID { get; set; }
}
public partial class Params_Delete_User_By_USERNAME_TENANT_ID
{
    public string USERNAME { get; set; }
    public int TENANT_ID { get; set; }
}
public partial class Params_Edit_User_List
{
    public IEnumerable<long> List_To_Delete { get; set; }
    public IEnumerable<long> List_Failed_Delete { get; set; }
    public IEnumerable<User> List_To_Edit { get; set; }
    public IEnumerable<User> List_Failed_Edit { get; set; }
}
