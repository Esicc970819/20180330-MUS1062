using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    
    class Program
    {
        static ConsoleApp1.Repository.IRepository reg;
        static void Main(string[] args)
        {    
            reg = new ConsoleApp1.Repository.OpenDataRepository();
            List<object> content = reg.ReadJsonData();
            foreach (Models.Object tag in content)
            {
                Console.WriteLine("宗教場域名稱 :{0} \n宗教別 :{1} \n宗教場域地址 :{2}{3} \n管理人員 :{4} \n電話 :{5} \n\n", tag.Name, tag.Religion, tag.District, tag.Address, tag.Manager, tag.Tel);
            }
            Console.ReadLine();
        }
    }
}
