namespace Jalasoft.DevBootcamp.Pc.Software.User
{
    public class User
    {
        public bool Type { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        private string Password { get; set; }
        
        public void SetUser()
        {
        }

        public void ChangePassword()
        {
        }

        public bool Login()
        {
            return false;
        }

        public bool Logout()
        {
            return true;
        }
    }
}
