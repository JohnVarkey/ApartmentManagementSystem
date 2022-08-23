namespace ModelUI.UIElements
{
    public interface IUIElement
    {
        void Ask<T>(out T data);
    }
}