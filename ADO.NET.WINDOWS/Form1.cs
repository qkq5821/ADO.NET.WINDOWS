using ADO.NETC;
using AppConfiguration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET.WINDOWS
{
    public partial class Form1 : Form
    {
        //참조추가에서 타 프로젝트 클래스 가져온다.
        MsSql msql;
        string ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ReadConfiguragion();
        }
        private void ReadConfiguragion()
        {
            //App.config에서 만든 Configuration 다 읽어옴
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //Configuration중 name이 WinConnection을 불러온다
            ConnectionString = config.ConnectionStrings.ConnectionStrings["WinConnection"].ToString();
            //생성자 오버로딩을 통하여 생성자에 매개변수를 넣어준다.
            msql = new MsSql(ConnectionString);
      
        }

        private void button1_Click(object sender , EventArgs e)
        {
            //싱글톤으로 호출하며 외부프로젝트 사용시 참조에 넣고 Using사용
            ConfigurationMgr mgr = ConfigurationMgr.Instance();
        }








    }

    }

