using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NETC
{
    public interface IDatabase
    {
        //인터페이스에 접근지정자 넣으면 안됨
        string ConnectionString
        {
            get; set;

        }

    }
}
