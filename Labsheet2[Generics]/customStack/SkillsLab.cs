using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customStack
{
    public class SkillsLab:IIntern
    {
        private string _name { get; set; }  

        private int _id { get; set; }

        public string NameId => $"SkillsLab - {_name}: {_id}";

        public SkillsLab(string _name, int _id)
        {
            this._name = _name;
            this._id = _id;
        }   
    }
}
