using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfiguration
{
    public class ConfigurationMgr
    {
        //블럭안에 전역멤버
        private static ConfigurationMgr instance;

        public string ConnectionString { get; set; }
        public IDbConnection Connection { get; set; }

        //아무것도 없으면 컴파일러가 생성자를 만들어줌 생성자 단축키 ctor+tab
        //private접근제한하면 외부에서 참조 불가 
        public ConfigurationMgr()
        {

        }


        //외부에서 생성자를 직접 생성하는 것이 아닌 메소드 호출방식으로 객체생성 
        //객체를 1개만 생성하기에 싱글톤으로 사용됨
        public static ConfigurationMgr Instance()
        {
            if(instance == null)
            {
                instance = new ConfigurationMgr();

               return instance;
            }
        }

    }
}
