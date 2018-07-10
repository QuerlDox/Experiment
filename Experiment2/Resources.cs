using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment2
{
   
    class Resources
    {

        private string dataSource = "Data Source = DESKTOP-937IC7S\\MSSQLSERVER01; Initial Catalog = Stock; Integrated Security = True";

        

        public string getDatabaseConnectionString() {
            return this.dataSource;
        }
    }
}
