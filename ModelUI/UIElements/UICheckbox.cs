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

        protected override void Sanitize<T>(string str, out T data)
        {
          
                if (str.Length == 0) throw new Exception("Value was of invalid format");
                int temp = Convert.ToInt32(str) - 1;
                data = (T)Convert.ChangeType(temp, typeof(T));
        }

        public override void Ask<T>(out T data)
        {
            Console.WriteLine(Label);
            Console.WriteLine();
            for (int i = 0; i < options.Length; i++)
            {
                Console.Write(new string(' ', Label.Length));
                Console.WriteLine($"{i+1}: {options[i]}");
            }
            Console.Write("\nSelect Option: ");
            Sanitize(Console.ReadLine(), out data);
        }


    }
}
