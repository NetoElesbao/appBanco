
public static class Operations
{
    public static void pickOperation()
    {
    repeat:
        Screens.MainMenuScreen();
        var choiceUser = Console.ReadLine();

        int.TryParse(choiceUser, out var optionDefault);
        switch ((EnumOptions)optionDefault)
        {
            case EnumOptions.Login:
                Console.WriteLine("Esta opcão é válida!");
                Console.ReadKey();
                loginOperation();
                break;
            case EnumOptions.Register:
                Console.WriteLine("Esta opcão é válida!");
                Console.ReadKey();
                registerOperation();
                Console.Clear();
                goto repeat;
            case EnumOptions.Exit:
                Console.WriteLine("Esta opcão é válida!");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                Console.WriteLine("Tente novamente!");
                Console.ReadKey();
                Console.Clear();
                goto repeat;
        }
    }
    public static void loginOperation()
    {
        Screens.loginScreen();
        Console.Write("Nome de usuário: ");
        var userName = Console.ReadLine();
        Console.Write("Senha: ");
        var password = Console.ReadLine();

        Client client = new Client();
        //client.registerName(userName);
        client.registerPassword(password);

        var porta = ClientRepository.CustomerList.Where(c => c.UserName == userName && c.Password == password).First();


        if (porta != null)
        {
            Console.WriteLine("VOCÊ POSSUI REGISTO");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("VOCÊ NÃO POSSUI REGISTO");
            Console.ReadKey();
        }

    }

    public static void registerOperation()
    {


        Client client = new Client();
        Screens.registerScreen();
    repeatName:
        Console.Write("Digite o seu nome de usuário: ");
        var userName = Console.ReadLine();
        if (userName.Equals(null) || userName.Equals(""))
        {
            Console.WriteLine("Digite seu nome de usuário para poder passar para a proxima etapa!");
            Console.ReadKey();
            Screens.registerScreen();
            goto repeatName;
        }
        client.registerName(userName);

    repeatPassword:
        Console.Write("Digite a sua senha: ");
        var password = Console.ReadLine();
        if (password.Equals(null) || password.Equals(""))
        {
            Console.WriteLine("Digite sua senha para poder passar para a proxima etapa!");
            Console.ReadKey();
            Console.Clear();
            Screens.registerScreen();
            Console.WriteLine("Digite o seu nome de usuário: " + client.getUserName());
            goto repeatPassword;
        }
        client.registerPassword(password);

        ClientRepository.AddList(client);
        Console.Clear();
        Console.WriteLine("Registrado com sucesso!");
        Console.ReadKey();

    }

}