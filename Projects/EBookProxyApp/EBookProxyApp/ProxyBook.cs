using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookProxyApp
{
    public class ProxyBook : IBook
    {
        private RealBook realBook;
        private Dictionary<int, string> cachedPages = new Dictionary<int, string>();

        public string GetPage(int pageNumber)
        {
            if (!cachedPages.ContainsKey(pageNumber))
            {
                Console.WriteLine($"Загрузка страницы {pageNumber}...");
                if (realBook == null)
                    realBook = new RealBook();

                cachedPages[pageNumber] = realBook.GetPage(pageNumber);
            }
            return cachedPages[pageNumber];
        }

        public int GetTotalPages()
        {
            if (realBook == null)
                realBook = new RealBook();
            return realBook.GetTotalPages();
        }
    }

}
