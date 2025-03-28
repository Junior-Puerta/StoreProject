using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreProject.ClientModels;


namespace StoreProject.ClientRoutes
{
    public static class ClientRoute
    {
        public static void ClientRoutes(this WebApplication app)
        {
            app.MapGet("client", () =>
                new ClientModel("Junior", "12312312312", 1233333333)
            );


        }
    }
}