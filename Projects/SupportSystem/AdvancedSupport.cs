using SupportSystem;
using System.Windows.Forms;

public class AdvancedSupport : SupportHandler
{
    public override void HandleRequest(string request)
    {
        if (request.Contains("помилка") || request.Contains("не працює"))
        {
            MessageBox.Show("Оператор 2: Я допоможу вирішити технічні проблеми.");
        }
        else if (nextHandler != null)
        {
            nextHandler.HandleRequest(request);
        }
    }
}
