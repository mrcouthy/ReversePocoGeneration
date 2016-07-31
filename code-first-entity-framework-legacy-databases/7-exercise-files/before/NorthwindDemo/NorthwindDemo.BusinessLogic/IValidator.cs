namespace NorthwindDemo.BusinessLogic
{
    public interface IValidator<in T> where T : class
    {
        bool IsValid(T customer);
    }
}