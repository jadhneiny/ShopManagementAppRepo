using ShopManagementApp.Domain.Attributes;

namespace ShopManagementApp.Domain.Business;

public partial class Setup
{
    public long SETUP_ID { get; set; }
    public int SETUP_CATEGORY_ID { get; set; }
    public bool IS_SYSTEM { get; set; }
    public bool IS_DELETEABLE { get; set; }
    public bool IS_UPDATEABLE { get; set; }
    public bool IS_DELETED { get; set; }
    public bool IS_VISIBLE { get; set; }
    public int DISPLAY_ORDER { get; set; }
    public string VALUE { get; set; }
    public string DESCRIPTION { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public int TENANT_ID { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Setup_category Setup_category { get; set; }
    #endregion
}
public partial class Get_Setup_By_Properties_Response
{
    public long? TOTAL_COUNT { get; set; }
    public IEnumerable<Setup> List_Setup { get; set; }
}
public partial class Setup_category
{
    public int SETUP_CATEGORY_ID { get; set; }
    public string SETUP_CATEGORY_NAME { get; set; }
    public string DESCRIPTION { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public bool IS_DELETED { get; set; }
    public int TENANT_ID { get; set; }
}
public partial class Get_Setup_category_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Setup_category> List_Setup_category { get; set; }
}
public partial class Tenant
{
    public int TENANT_ID { get; set; }
    public string TENANT_NAME { get; set; }
    public string TENANT_CODE { get; set; }
    public bool IS_SUPER_TENANT { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    public string DESCRIPTION { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public bool IS_DELETED { get; set; }
}
public partial class Get_Tenant_By_Properties_Response
{
    public int? TOTAL_COUNT { get; set; }
    public IEnumerable<Tenant> List_Tenant { get; set; }
}
public partial class User
{
    public long USER_ID { get; set; }
    public long USER_TYPE_SETUP_ID { get; set; }
    public string FULL_NAME { get; set; }
    public string EMAIL { get; set; }
    public string USERNAME { get; set; }
    public string PASSWORD { get; set; }
    public bool IS_ACTIVE { get; set; }
    public bool IS_DELETED { get; set; }
    public DateTimeOffset CREATED_ON { get; set; }
    public int TENANT_ID { get; set; }
    public long LAST_UPDATED_BY_USER_ID { get; set; }
    public DateTimeOffset UPDATED_ON { get; set; }
    #region One to One Relations Entities
    [SQLIgnore]
    public Setup User_type_setup { get; set; }
    #endregion
}
public partial class Get_User_By_Properties_Response
{
    public long? TOTAL_COUNT { get; set; }
    public IEnumerable<User> List_User { get; set; }
}
