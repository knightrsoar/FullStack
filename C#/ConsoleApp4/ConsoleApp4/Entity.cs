namespace ConsoleApp4;

public abstract class Entity
{
    public int Id { get; set; }
}

public interface IRepository<T> where T : Entity
{
    void Add(T item);
    void Remove(T item);
    void Save();
    IEnumerable<T> GetAll();
    T GetById(int id);
}


public class GenericRepository<T> : IRepository<T> where T : Entity, new()
{
    private List<T> data = new List<T>();
    
    public void Add(T item)
    {
        data.Add(item);
    }

    public void Remove(T item)
    {
        data.Remove(item);
    }

    public void Save()
    {
        
    }

    public IEnumerable<T> GetAll() => data;

    public T GetById(int id)
    {
        return data.FirstOrDefault(item => item.Id == id);
    }
}
