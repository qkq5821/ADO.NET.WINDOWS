using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETC
{
    public class MsSql : IDatabase
    {

        public string ConnectionString { get; set;}
        
        //생성자 오버로딩을 통하여 만들었기에 기본생성자는 만들어지지않는다.
        public MsSql(String connection_string)
        {
            ConnectionString = connection_string;
        }
    }
  
}
