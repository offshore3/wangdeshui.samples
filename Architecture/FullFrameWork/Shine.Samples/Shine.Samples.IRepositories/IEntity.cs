namespace Shine.Samples.IRepositories
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}