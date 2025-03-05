using System.Collections.Generic;

namespace DarkRP_Professions
{
    public interface ICommand
    {
        string GetInfo();
        void Execute(List<object> parameters);
    }
}
