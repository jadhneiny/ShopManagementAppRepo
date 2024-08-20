namespace ShopManagementApp.Application.Services;
{
    public partial class CommonService
    {
        private void PostConstruct()
        {
            // Custom logic that runs after construction can be added here
        }

        public TenantEntity Get_Tenant_By_Id(Params_Get_Tenant_By_Id i_Params_Get_Tenant_By_Id)
        {
            return _context.Tenants.Find(i_Params_Get_Tenant_By_Id.TenantId);
        }

        public List<TenantEntity> Get_All_Tenants()
        {
            return _context.Tenants.ToList();
        }
    }

    public class Params_Get_Tenant_By_Id
    {
        public int TenantId { get; set; }
    }
}