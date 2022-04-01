using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class Customer
    {
        private int id { get; set; }
        private string? name { get; set; }

        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int GetId { get { return id; } } //id otomatik oluşturuluyor diye varsayıyorum o yüzden setter oluşturmuyorum
        public string GetName { get { return name; } }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void 
    }
}
