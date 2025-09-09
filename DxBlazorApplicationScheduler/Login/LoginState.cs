namespace DxBlazorApplicationScheduler.Login
{
    public class LoginState
    {
        private List<string> loggedInUsers
              = new List<string>();

        public void AddId(string id)
        {
            if (!loggedInUsers.Contains(id)) loggedInUsers.Add(id);
        }

        public void RemoveId(string id)
        {
            if (loggedInUsers.Contains(id)) loggedInUsers.Remove(id);
        }

        public bool IsUserLoggedIn(string id)
        {
            return loggedInUsers.Contains(id);
        }
    }
}
