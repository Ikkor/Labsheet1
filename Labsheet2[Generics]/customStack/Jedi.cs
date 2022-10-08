using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customStack
{
    public class Jedi:IIntern
    {
        private string _name; 

        private int _id { get; set; }

        public string NameId => $"Jedi - {_name}: {_id}";

        public Jedi(string name, int id)
        {
            this._name = name;
            _id = id;
        }   
    }
}
