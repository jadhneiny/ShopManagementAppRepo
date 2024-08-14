using ShopManagementApp.Domain.Business;

namespace ShopManagementApp.Application.Contracts;

public partial interface IBusinessService
{
    Task Delete_Setup(Params_Delete_Setup i_Params_Delete_Setup);
    Task Delete_Setup_By_SETUP_CATEGORY_ID(Params_Delete_Setup_By_SETUP_CATEGORY_ID i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);
    Task Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);
    Task Delete_Setup_By_TENANT_ID(Params_Delete_Setup_By_TENANT_ID i_Params_Delete_Setup_By_TENANT_ID);
    Task Edit_Setup(Setup i_Setup);
    Task Edit_Setup_List(Params_Edit_Setup_List i_Params_Edit_Setup_List);
    Task Delete_Setup_category(Params_Delete_Setup_category i_Params_Delete_Setup_category);
    Task Delete_Setup_category_By_TENANT_ID(Params_Delete_Setup_category_By_TENANT_ID i_Params_Delete_Setup_category_By_TENANT_ID);
    Task Edit_Setup_category(Setup_category i_Setup_category);
    Task Edit_Setup_category_List(Params_Edit_Setup_category_List i_Params_Edit_Setup_category_List);
    Task Delete_Tenant(Params_Delete_Tenant i_Params_Delete_Tenant);
    Task Delete_Tenant_By_IS_DELETED(Params_Delete_Tenant_By_IS_DELETED i_Params_Delete_Tenant_By_IS_DELETED);
    Task Edit_Tenant(Tenant i_Tenant);
    Task Edit_Tenant_List(Params_Edit_Tenant_List i_Params_Edit_Tenant_List);
    Task Delete_User(Params_Delete_User i_Params_Delete_User);
    Task Delete_User_By_EMAIL_TENANT_ID(Params_Delete_User_By_EMAIL_TENANT_ID i_Params_Delete_User_By_EMAIL_TENANT_ID);
    Task Delete_User_By_TENANT_ID(Params_Delete_User_By_TENANT_ID i_Params_Delete_User_By_TENANT_ID);
    Task Delete_User_By_TENANT_ID_IS_DELETED(Params_Delete_User_By_TENANT_ID_IS_DELETED i_Params_Delete_User_By_TENANT_ID_IS_DELETED);
    Task Delete_User_By_USER_TYPE_SETUP_ID(Params_Delete_User_By_USER_TYPE_SETUP_ID i_Params_Delete_User_By_USER_TYPE_SETUP_ID);
    Task Delete_User_By_USERNAME_TENANT_ID(Params_Delete_User_By_USERNAME_TENANT_ID i_Params_Delete_User_By_USERNAME_TENANT_ID);
    Task Edit_User(User i_User);
    Task Edit_User_List(Params_Edit_User_List i_Params_Edit_User_List);
}
