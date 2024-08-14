using ShopManagementApp.Domain.PromoCode;

namespace ShopManagementApp.Application.Contracts;

public partial interface IPromoCodeService
{
    Task Delete_Promo_codes(Params_Delete_Promo_codes i_Params_Delete_Promo_codes);
    Task Delete_Promo_codes_By_TENANT_ID(Params_Delete_Promo_codes_By_TENANT_ID i_Params_Delete_Promo_codes_By_TENANT_ID);
    Task Delete_Promo_codes_By_TENANTS_ID(Params_Delete_Promo_codes_By_TENANTS_ID i_Params_Delete_Promo_codes_By_TENANTS_ID);
    Task Edit_Promo_codes(Promo_codes i_Promo_codes);
    Task Edit_Promo_codes_List(Params_Edit_Promo_codes_List i_Params_Edit_Promo_codes_List);
}
