namespace ShopManagementApp.Domain.Address;

public partial class Params_Get_Addresses_By_ADDRESSES_ID
{
    public int ADDRESSES_ID { get; set; }
}
public partial class Params_Get_Addresses_By_ADDRESSES_ID_List
{
    public IEnumerable<int> ADDRESSES_ID_LIST { get; set; }
}
public partial class Params_Get_Addresses_By_CUSTOMERS_ID
{
    public int? CUSTOMERS_ID { get; set; }
}
public partial class Params_Get_Addresses_By_CUSTOMERS_ID_List
{
    public IEnumerable<int?> CUSTOMERS_ID_LIST { get; set; }
}
public partial class Params_Get_Addresses_By_Properties
{
    public int? ADDRESSES_ID { get; set; }
    public IEnumerable<int?> ADDRESSES_ID_LIST { get; set; }
    public int? CUSTOMERS_ID { get; set; }
    public IEnumerable<int?> CUSTOMERS_ID_LIST { get; set; }
    public string STREET { get; set; }
    public string CITY { get; set; }
    public string STATE { get; set; }
    public string ZIP_CODE { get; set; }
    public string COUNTRY { get; set; }
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
public partial class Params_Get_Addresses_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Addresses
{
    public int ADDRESSES_ID { get; set; }
}
public partial class Params_Delete_Addresses_By_CUSTOMERS_ID
{
    public int? CUSTOMERS_ID { get; set; }
}
public partial class Params_Delete_Addresses_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Edit_Addresses_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Addresses> List_To_Edit { get; set; }
    public IEnumerable<Addresses> List_Failed_Edit { get; set; }
}
