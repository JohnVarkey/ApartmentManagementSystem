
using ModelUI.Pages;
using System.Text;
using CircleStack;

namespace ModelUI
{
    static class UIHandler {

        public static IBuilding Building { get; set; }
        public static Dictionary<string, IPage> pages= new Dictionary<string, IPage>();
        private static Stack<IPage> activePage = new Stack<IPage> ();

        public static void AddPage(string pageName, IPage page) { 
            pages.Add(pageName, page);
        }

        public static void SetInitialPage(string pageName) {
            if (activePage.Count != 0) {
                Console.WriteLine("Stack Not Empty");
                return;
            }

            activePage.Push(pages[pageName]);
        }

        public static void Navigate(string pageName) {
            Console.WriteLine("Navigate");
            activePage.Push(pages[pageName]);
        }

        public static void Pop() {
            activePage.Pop();
        }

        public static void start()
        {
            while (activePage.Count != 0)
            {
                Console.Clear();
                activePage.Peek().Display();
            }
        }

        public static string ReadLine()
        {
            StringBuilder inputstring = new StringBuilder();
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if(key.Key == ConsoleKey.Escape) {
                    activePage.Pop();
                    return ""; 
                }
                if(key.Key == ConsoleKey.Enter) return inputstring.ToString();
                inputstring.Append(key.KeyChar);
            }
        }  
    }
}
