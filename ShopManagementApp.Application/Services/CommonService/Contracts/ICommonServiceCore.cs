namespace ShopManagementApp.Application.Contracts
{
    public partial interface ICommonService
    {
        TenantEntity Get_Tenant_By_Id(Params_Get_Tenant_By_Id i_Params_Get_Tenant_By_Id);
        List<TenantEntity> Get_All_Tenants();
    }
}