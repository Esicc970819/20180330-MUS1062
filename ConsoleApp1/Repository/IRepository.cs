using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repository
{
    public interface IRepository
    {
        string DataName { get;}
        List<object> ReadJsonData();
    }
}
