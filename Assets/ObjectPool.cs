using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> where T : Component
{
    private readonly T prefab;
    private readonly Transform parent;
    private readonly Queue<T> pool = new Queue<T>();

    private readonly int initialSize;

    public ObjectPool(T prefab, int initialSize = 8, Transform parent = null)
    {
        this.prefab = prefab;
        this.parent = parent;
        this.initialSize = initialSize;

        Prepare();
    }

    public ObjectPool(T prefab, Transform parent, int initialSize = 8)
    {
        this.prefab = prefab;
        this.parent = parent;
        this.initialSize = initialSize;

        Prepare();
    }

    /// <summary>
    /// Gets the object from object pool at specified position and rotation.
    /// </summary>
    public T Get(Vector3 position, Quaternion rotation)
    {
        if (pool.Count == 0)
        {
            T newObj = Object.Instantiate(prefab, parent);
            newObj.gameObject.SetActive(false);
            pool.Enqueue(newObj);
        }

        T obj = pool.Dequeue();
        obj.transform.position = position;
        obj.transform.rotation = rotation;
        obj.gameObject.SetActive(true);

        return obj;
    }

    /// <summary>
    /// Returns the specified object to the object pool.
    /// </summary>
    public void Return(T obj)
    {
        if (obj != null)
        {
            obj.gameObject.SetActive(false);
            pool.Enqueue(obj);
        }
    }

    /// <summary>
    /// Clears the object pool.
    /// </summary>
    public void Clear()
    {
        while (pool.Count > 0)
        {
            T obj = pool.Dequeue();

            if (obj != null)
                Object.Destroy(obj.gameObject);
        }
    }

    private void Prepare()
    {
        for (int i = 0; i < initialSize; i++)
        {
            T obj = Object.Instantiate(prefab, parent);
            obj.gameObject.SetActive(false);
            pool.Enqueue(obj);
        }
    }
}



/*

How to use:
1. Just copy this script into your project and call necessary methods.

*/