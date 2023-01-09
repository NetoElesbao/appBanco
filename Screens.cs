

public static class Screens
{
    public static void MainMenuScreen()
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("                             appBanco                             ");
        Console.WriteLine("                          MENU PRINCIPAL                          ");
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("O que você deseja?:");
        Console.WriteLine("[1] Fazer login");
        Console.WriteLine("[2] Me cadastrar como cliente");
        Console.WriteLine("[3] Sair do app");
        Console.WriteLine("");
        Console.WriteLine("Minha escolha ");
    }
    public static void nextMenuScreen()
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("                             appBanco                             ");
        Console.WriteLine("                           MENU DE CONTA                           ");
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("O que você deseja?:");
        Console.WriteLine("[1] Criar conta bancária");
        Console.WriteLine("[2] Voltar");
        Console.WriteLine("");
        Console.WriteLine("Minha escolha ");

    }

    public static void accountsMenu()
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("                             appBanco                             ");
        Console.WriteLine("                           MENU DE CONTA                           ");
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("Qual o tipo de conta que você deseja criar?:");
        Console.WriteLine("[1] Conta corrente");
        Console.WriteLine("[2] Conta poupança");
        Console.WriteLine("[3] Voltar");
        Console.WriteLine("");
        Console.WriteLine("Minha escolha ");

    }
    public static void registerScreen()
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("                          Registrando Cliente                     ");
        Console.WriteLine("                                                                  ");
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("");
    }
    public static void loginScreen()
    {
        Console.Clear();
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("                          Logando Cliente                         ");
        Console.WriteLine("                                                                  ");
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("");
    }
}