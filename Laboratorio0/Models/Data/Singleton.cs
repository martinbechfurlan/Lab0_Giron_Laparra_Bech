using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio0.Models.Data
{
    
        public sealed class Singleton
        {
            private readonly static Singleton NewCliente = new Singleton();
            public List<Clientes> ClientesList;
            private Singleton()
            {
                ClientesList = new List<Clientes>();
            }



            public static Singleton Instance
            {
                get
                {
                    return NewCliente;
                }
            }

       
    }
    }

