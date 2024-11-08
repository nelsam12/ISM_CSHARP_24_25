using Cours.Enum;
using Cours.Repository;
using Cours.Repository.Impl;

namespace Cours.Core.Factory
{
    public static class ClientFactory
    {
        public static IClientRepository? createClientRepository(Persistence type)
        {
            IClientRepository? clientRepository;
            switch (type)
            {
                case Persistence.DATABASE:
                    clientRepository = new ClientRepositoryBdImpl(new DataBaseConnection());
                    break;
                case Persistence.LIST:
                    clientRepository = new ClientRepositoryListImpl();
                    break;
                default:
                    clientRepository = null;
                    break;
            }
            return clientRepository;
        }
    }
}