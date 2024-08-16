namespace ShopManagementApp.Application.Contracts
{
    public partial interface IPromoCodeService
    {
        PromoCodeEntity Get_Promo_Code_By_Id(Params_Get_Promo_Code_By_Id i_Params_Get_Promo_Code_By_Id);
        List<PromoCodeEntity> Get_All_Promo_Codes();
        List<PromoCodeEntity> Get_Active_Promo_Codes();
    }
}