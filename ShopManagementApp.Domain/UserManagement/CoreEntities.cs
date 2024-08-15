namespace ShopManagementApp.Domain.UserManagement
{
    public class CoreEntities
    {
        public class AdminEntity
        {
            public int AdminId { get; set; }
            public string Name { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public DateTime CreatedAt { get; set; }
            public int TenantId { get; set; }
        }

        public class CustomerEntity
        {
            public int CustomerId { get; set; }
            public string Name { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public DateTime CreatedAt { get; set; }
            public int TenantId { get; set; }
        }
    }
}