using System;
using System.Collections.Generic;
using System.Linq;

public class InMemoryRepository<T> where T : class
{

    protected List<T> _items;
    public InMemoryRepository()
    {
        _items = new List<T>();
    }

    public void Add(T item)
    {
        _items.Add(item);
    }
   
    public void Update(T item, Func<T, bool> predicate)
    {
        var existingItem = _items.FirstOrDefault(predicate);
        if (existingItem != null)
        {
            // Replace the existing item with the updated one
            _items[_items.IndexOf(existingItem)] = item;
        }
        else
        {
            throw new ArgumentException("Item to update not found");
        }
    }

    public void Delete(T item)
    {
        _items.Remove(item);
    }

    public T FindById(Func<T, bool> predicate)
    {
        return _items.FirstOrDefault(predicate);
    }

    public IEnumerable<T> FindAll(Func<T, bool> predicate)
    {
        return _items.Where(predicate) ;
    }

    public void Clear()
    {
        _items.Clear();
    }
}
