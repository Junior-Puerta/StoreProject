using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.ClientModels
{
    public class ClientModel
    {

        public ClientModel(string name, string cpf, int phoneNumber, DateTime birthDate)
        {
            Id = Guid.NewGuid();
            Name = name.ToUpper();
            Cpf = cpf;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
        }



        public Guid Id { get; init; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public long PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }

    }
}