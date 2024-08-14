using ShopManagementApp.Domain.Business;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ShopManagementApp.Application.Contracts;

public partial interface IBusinessService
{
    Task<User> Get_Current_User();
    Task GetAppContext(long i_UserID);
    Task GetAppContext(string i_Subject);
    Task GetAppContext(ActionExecutingContext context);
}
