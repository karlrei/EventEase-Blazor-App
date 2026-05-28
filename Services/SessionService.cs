public class SessionService
{
    public string UserName { get; set; } = "";
    public bool IsLoggedIn => !string.IsNullOrEmpty(UserName);
}
