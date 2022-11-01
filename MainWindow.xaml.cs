using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.IO;

using NLua;

namespace CC_UIGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string path = Directory.GetCurrentDirectory() + "/Content/LuaScripts/";
            File.WriteAllText(@"Content/LuaScripts/AbsPath.txt", Directory.GetCurrentDirectory());

            Lua state = new Lua();
            var scriptResult = state.DoFile(@"Content/LuaScripts/test1.lua");

            long? result1 = (long)scriptResult[0];
            string? result2 = scriptResult[1] as string;
            string? result3 = scriptResult[2] as string;
            LuaTable? d = scriptResult[4] as LuaTable;

            List<List<string>> news = new List<List<string>>();
            foreach(var v in d.Values)
            {
                var v_ = v as LuaTable;
                List<string> news_temp = new List<string>();
                foreach(var v__ in v_.Values)
                {
                    news_temp.Add(v__ as string);
                }
                news.Add(news_temp);
            }



            var aa = result1;

            int a = 123;

        }
    }
}
