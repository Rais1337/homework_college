using SupportSystem;
using System.Windows.Forms;

public class BasicSupport : SupportHandler
{
    public override void HandleRequest(string request)
    {
        if (request.Contains("як зареєструватися") || request.Contains("забув пароль"))
        {
            MessageBox.Show("Оператор 1: Я допоможу вам із реєстрацією або відновленням пароля.");
        }
        else if (nextHandler != null)
        {
            nextHandler.HandleRequest(request);
        }
    }
}
