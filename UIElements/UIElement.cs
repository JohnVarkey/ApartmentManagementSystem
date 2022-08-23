

using System.Reflection.PortableExecutable;
using System;

namespace ModelUI.UIElements
{
    public abstract class UIElement: IUIElement
    {
        public abstract void Ask<T>(out T data);

        protected virtual void Sanitize<T>(string str, out T data)
        {

            if (str == null) throw new FormatException();
            data = (T)Convert.ChangeType(str, typeof(T));

        }

        
    }
}