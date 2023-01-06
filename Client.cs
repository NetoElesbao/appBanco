

public class Client
{
    public string UserName { get; set; }
    public string Password { get; set; }

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

}