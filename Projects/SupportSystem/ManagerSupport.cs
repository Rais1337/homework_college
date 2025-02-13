using SupportSystem;
using System.Windows.Forms;

public class ManagerSupport : SupportHandler
{
    public override void HandleRequest(string request)
    {
        MessageBox.Show("Менеджер: Я допоможу вам із будь-якими складними питаннями.");
    }
}
