using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1.Repository
{
    class OpenDataRepository : IRepository
    {
        public string DataName
        {
            get
            {
                return ConsoleApp1.Shared.Data.GetDataName();
            }
        }
        public List<object> ReadJsonData()
        {
            StreamReader x = new StreamReader(DataName);
            string Datas = x.ReadToEnd();
            List<ConsoleApp1.Models.Object> content;
            content = JsonConvert.DeserializeObject<List<ConsoleApp1.Models.Object>>(Datas);
            return content.OfType<Object>().ToList();
        }
    }
}
