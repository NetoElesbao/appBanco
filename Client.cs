public class Client
{
    public string UserName { get; set; }
    private string Password { get; set; }
    public List<AccountBase> AccountList { get; set; }

    public Client()
    {
        AccountList = new List<AccountBase>();
    }

    public void registerName(string UserName)
    {
        this.UserName = UserName;
    }

    public void registerPassword(string Password)
    {
        this.Password = Password;
    }

    public string getUserName()
    {
        return this.UserName;
    }
    public string getPassword()
    {
        return this.Password;
    }
}