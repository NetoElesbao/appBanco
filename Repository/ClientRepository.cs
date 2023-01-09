using ClientEntity;

namespace Repository
{

    public static class ClientRepository
    {
        public static List<Client> CustomerList { get; set; } = CustomerList = new List<Client>();
        public static void AddList(Client client)
        {
            CustomerList.Add(client);
        }
    }
}