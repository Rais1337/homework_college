using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DarkRP_Professions
{
    public class PoliceOfficerCommand : ICommand
    {
        public string GetInfo() => "👮 Стати поліцейським";

        public void Execute(List<object> parameters)
        {
            MessageBox.Show("Ви обрали професію Поліцейського! Тепер ви можете патрулювати місто.");
        }
    }
}
