using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBookProxyApp
{
    public class RealBook : IBook
    {
        private List<string> pages = new List<string>();

        public RealBook()
        {
            LoadBook();
        }

        private void LoadBook()
        {
            pages.Add("Глава 1. Введение в C#\nПрограммирование - это интересно!");
            pages.Add("Глава 2. Основы ООП\nОбъекты, классы и наследование.");
            pages.Add("Глава 3. Коллекции и массивы\nСписки, массивы, словари.");
            pages.Add("Глава 4. LINQ и работа с данными\nФильтрация и выборки данных.");
        }

        public string GetPage(int pageNumber)
        {
            if (pageNumber >= 0 && pageNumber < pages.Count)
                return pages[pageNumber];
            return "Страница не найдена!";
        }

        public int GetTotalPages()
        {
            return pages.Count;
        }
    }
}
