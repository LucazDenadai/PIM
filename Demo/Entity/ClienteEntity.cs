using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entity
{
    public class ClienteEntity : PessoaEntity
    {
        public int id { get; set; }

        public string Status { get; set; }
    }
}
