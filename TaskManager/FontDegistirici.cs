using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public static class SpecialMethods
{
    public static IEnumerable<Control> GetAllControls(Control aControl)
    {
        Stack<Control> stack = new Stack<Control>();

        stack.Push(aControl);

        while (stack.Any())
        {
            var nextControl = stack.Pop();

            foreach (Control childControl in nextControl.Controls)
            {
                stack.Push(childControl);
            }

            yield return nextControl;
        }
    }
}