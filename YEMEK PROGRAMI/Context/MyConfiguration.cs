using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YEMEK_PROGRAMI.Context
{
    public class MyConfiguration : MySqlEFConfiguration
    {
        public MyConfiguration()
        {
            SetExecutionStrategy(MySqlProviderInvariantName.ProviderName, () => new MySqlExecutionStrategy());
        }
    }
}
