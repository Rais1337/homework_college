using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DarkRP_Professions
{
    public class MechanicCommand : ICommand
    {
        public string GetInfo() => "🔧 Стати механіком";

        public void Execute(List<object> parameters)
        {
            MessageBox.Show("Ви обрали професію Механіка! Тепер ви можете лагодити транспорт.");
        }
    }
}
