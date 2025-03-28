using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.ClientModels
{
    public class ClientModel
    {

        public ClientModel(string name, string cpf, int phoneNumber)
        {
            Id = Guid.NewGuid();
            Name = name.ToUpper();
            Cpf = cpf;
            PhoneNumber = phoneNumber;
        }



        public Guid Id { get; init; }
        public string Name { get; private set; }
        public string Cpf { get; private set; }
        public long PhoneNumber { get; private set; }

    }
}