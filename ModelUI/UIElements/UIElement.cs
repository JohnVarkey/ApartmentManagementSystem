

using System.Reflection.PortableExecutable;
using System;

namespace ModelUI.UIElements
{
    public abstract class UIElement: IUIElement
    {
        public abstract void Ask<T>(out T data);

        protected virtual void Sanitize<T>(string str, out T data)
        {

            if (str.Length == 0) throw new Exception("Value was of invalid format");
            data = (T)Convert.ChangeType(str, typeof(T));

        }

        
    }
}