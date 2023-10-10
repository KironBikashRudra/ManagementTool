namespace ManagementTool.Helpers
{
    using Models;
    using Common;

    public class AccessHelper
    {
        public static User LoginUser { get; set; } = new User() {
            Id = "1",
            Name = "MyName",
            Role = (int)Common.UserRole.General
        };


        public static bool CanBeEditedBy(User user) { 
            if (user.Role == (int)Common.UserRole.Admin) {
                return true;
            }
            if (user.Role == (int)Common.UserRole.Manager) { 
                return false;
            }
            // user == LoginUser　← user と LoginUser は違う変数
            if (user.Role == (int)Common.UserRole.General && user == LoginUser) {
                return true;
            }
            return false;
        }

    }
}
