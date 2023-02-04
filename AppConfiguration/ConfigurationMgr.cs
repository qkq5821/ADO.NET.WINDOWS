using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfiguration
{
    class ConfigurationMgr
    {
        private static ConfigurationMgr instance;

        //아무것도 없으면 컴파일러가 생성자를 만들어줌 생성자 단축키 ctor+tan
        //private접근제한하면 외부에서 참조 불가 
        public ConfigurationMgr()
        {

        }
        //static사용시 
        public static ConfigurationMgr instance()
        {
            if(instance == null)
            {
                instance = new ConfigurationMgr();
                return instance;
            }
        }

    }
}
