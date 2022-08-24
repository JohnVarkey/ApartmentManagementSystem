using System;

namespace ModelUI.UIElements
{

    public class UIInputText : UIElement
    {
        public string Label { get; set; }

        public UIInputText(string label)
        {
            Label = label;
        }

        public override void Ask<T>(out T data)
        {
            Console.Write($"{Label}: ");
            base.Sanitize(Console.ReadLine(), out data);
        }
    }
}
