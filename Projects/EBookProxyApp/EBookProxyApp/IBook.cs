using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookProxyApp
{
    public interface IBook
    {
        string GetPage(int pageNumber);
        int GetTotalPages();
    }

}
