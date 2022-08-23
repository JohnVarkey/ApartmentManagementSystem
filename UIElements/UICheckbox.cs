using System;

namespace ModelUI.UIElements
{

    public class UICheckBox : UIElement
    {
        public string Label { set; get; }
        public string[] options;

        public UICheckBox(string label, string[] options)
        {
            Label = label;
            this.options = options;
        }

        public override void Ask<T>(out T data)
        {
            Console.WriteLine(Label);
            for (int i = 0; i < options.Length; i++)
            {
                Console.Write(new string(' ', Label.Length));
                Console.WriteLine($"{i}: {options[i]}");
            }
            Console.Write("Select Option: ");
            base.Sanitize(Console.ReadLine(), out data);
        }


    }
}
