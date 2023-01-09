using Accounts.Base;


namespace ClientEntity{
public class Client
{
    public string UserName { get; set; }
    private string Password { get; set; }
    public List<BaseAccount> AccountList { get; set; }

    public Client()
    {
        AccountList = new List<BaseAccount>();
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
}