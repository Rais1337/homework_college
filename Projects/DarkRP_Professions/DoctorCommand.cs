using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DarkRP_Professions
{
    public class DoctorCommand : ICommand
    {
        public string GetInfo() => "🏥 Стати лікарем";

        public void Execute(List<object> parameters)
        {
            MessageBox.Show("Ви обрали професію Лікаря! Тепер ви можете лікувати гравців.");
        }
    }
}
