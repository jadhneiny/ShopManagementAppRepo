namespace ShopManagementApp.Application.Services
{
    public partial class PromoCodeService
    {
        private void PostConstruct()
        {
            // Custom logic that runs after construction can be added here
        }

        public PromoCodeEntity Get_Promo_Code_By_Id(Params_Get_Promo_Code_By_Id i_Params_Get_Promo_Code_By_Id)
        {
            return _context.PromoCodes.Find(i_Params_Get_Promo_Code_By_Id.PromoCodeId);
        }

        public List<PromoCodeEntity> Get_All_Promo_Codes()
        {
            return _context.PromoCodes.ToList();
        }

        public List<PromoCodeEntity> Get_Active_Promo_Codes()
        {
            var currentDate = DateTime.Now;
            return _context.PromoCodes.Where(pc => pc.ExpirationDate > currentDate).ToList();
        }
    }

    public class Params_Get_Promo_Code_By_Id
    {
        public int PromoCodeId { get; set; }
    }
}