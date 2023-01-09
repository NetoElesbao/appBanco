
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

                var porta = loginOperation();

                Console.WriteLine("");
                if (porta != null)
                {
                    Console.WriteLine("Login bem sucedido!");
                    Console.ReadKey();
                    nextMenuOperation();
                    goto repeat;
                }
                else
                {
                    Console.WriteLine("Nenhuma conta condiz com essas informações, tente inserir os dados corretamente!");
                    Console.ReadKey();
                    goto repeat;
                }
            case EnumOptions.Register:

                registerOperation();
                Console.Clear();
                goto repeat;
            case EnumOptions.Exit:

                Console.Clear();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                Console.WriteLine("Tente novamente!");
                Console.ReadKey();
                Console.Clear();
                goto repeat;
        }
    }
    public static Client loginOperation()
    {
        Screens.loginScreen();
        Console.Write("Nome de usuário: ");
        var userName = Console.ReadLine();
        Console.Write("Senha: ");
        var password = Console.ReadLine();

        Client client = new Client();
        //client.registerName(userName);
        client.registerPassword(password);

        var porta = ClientRepository.CustomerList.Where(c => c.UserName == userName && c.getPassword().Equals(password)).FirstOrDefault();

        return porta;
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
        Screens.menuRegisterScreen();
    }

    public static void nextMenuOperation()
    {
    repeatMenuScreen:
        Screens.nextMenuScreen();
        var choiceUser = Convert.ToInt32(Console.ReadLine());

        switch (choiceUser)
        {
            case 1:
            repeat:
                Screens.accountsMenu();
                var accountChoice = Console.ReadLine();
                int.TryParse(accountChoice, out var choice);
                switch (choice)
                {
                    case 1:
                    repeatPasswordCurrent:
                        Console.WriteLine();
                        Console.WriteLine("Para confirmar a criação da conta bancária do tipo corrente, digite novamente a sua senha");
                        Console.WriteLine("");
                        Console.Write("Senha: ");
                        var passwordCurrent = Console.ReadLine();

                        if (ClientRepository.CustomerList.FirstOrDefault(c => c.getPassword().Equals(passwordCurrent)) != null)
                        {
                            CurrentAccount contaCorrente = new CurrentAccount();
                            Console.Clear();
                            Screens.accountsMenuShort();
                            Console.WriteLine("Conta corrente criada com êxito!");
                            var client = ClientRepository.CustomerList.FirstOrDefault(c => c.getPassword().Equals(passwordCurrent));
                            client.AccountList.Add(contaCorrente);

                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Senha incorreta por favor tente novante!");
                            Console.ReadKey();
                            Console.Clear();
                            Screens.accountsMenu();
                            Console.WriteLine(accountChoice);
                            goto repeatPasswordCurrent;
                        }
                        break;
                    case 2:
                    repeatPasswordSavings:
                        Console.WriteLine();
                        Console.WriteLine("Para confirmar a criação da conta bancária do tipo poupança, digite novamente a sua senha");
                        Console.WriteLine("");
                        Console.Write("Senha: ");
                        var passwordCSavings = Console.ReadLine();

                        if (ClientRepository.CustomerList.FirstOrDefault(c => c.getPassword().Equals(passwordCSavings)) != null)
                        {
                            SavingsAccount contaPoupanca = new SavingsAccount();
                            Console.Clear();
                            Screens.accountsMenuShort();
                            Console.WriteLine("Conta poupança criada com êxito!");

                            var client = ClientRepository.CustomerList.FirstOrDefault(c => c.getPassword().Equals(passwordCSavings));
                            client.AccountList.Add(contaPoupanca);

                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Senha incorreta por favor tente novante!");
                            Console.ReadKey();
                            Console.Clear();
                            Screens.accountsMenu();
                            Console.WriteLine(accountChoice);
                            goto repeatPasswordSavings;
                        }
                        break;
                    case 3:
                        goto repeatMenuScreen;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine("Tente novamente!");
                        Console.ReadKey();
                        Console.Clear();
                        goto repeat;
                }
                break;
            case 2:
                break;
        }

    }
}