namespace ShopManagementApp.Domain.PromoCode;

public partial class Params_Get_Promo_codes_By_PROMO_CODES_ID
{
    public int PROMO_CODES_ID { get; set; }
}
public partial class Params_Get_Promo_codes_By_PROMO_CODES_ID_List
{
    public IEnumerable<int> PROMO_CODES_ID_LIST { get; set; }
}
public partial class Params_Get_Promo_codes_By_Properties
{
    public int? PROMO_CODES_ID { get; set; }
    public IEnumerable<int?> PROMO_CODES_ID_LIST { get; set; }
    public string CODE { get; set; }
    public decimal? DISCOUNT { get; set; }
    public DateTime? EXPIRATION_DATE { get; set; }
    public DateTime? EXPIRATION_DATE_START { get; set; }
    public DateTime? EXPIRATION_DATE_END { get; set; }
    public bool? EXPIRATION_DATE_INCLUSIVE { get; set; }
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
public partial class Params_Get_Promo_codes_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Get_Promo_codes_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Get_Promo_codes_By_TENANTS_ID_List
{
    public IEnumerable<int> TENANTS_ID_LIST { get; set; }
}
public partial class Params_Delete_Promo_codes
{
    public int PROMO_CODES_ID { get; set; }
}
public partial class Params_Delete_Promo_codes_By_TENANT_ID
{
    public int TENANT_ID { get; set; }
}
public partial class Params_Delete_Promo_codes_By_TENANTS_ID
{
    public int TENANTS_ID { get; set; }
}
public partial class Params_Edit_Promo_codes_List
{
    public IEnumerable<int> List_To_Delete { get; set; }
    public IEnumerable<int> List_Failed_Delete { get; set; }
    public IEnumerable<Promo_codes> List_To_Edit { get; set; }
    public IEnumerable<Promo_codes> List_Failed_Edit { get; set; }
}
