using System.Collections.Generic;
using System;
using UnityEngine;

/// <summary>
/// The service container that provides access to work with game services.
/// </summary>
public sealed class ServiceContainer
{
    private readonly Dictionary<Type, object> services = new Dictionary<Type, object>();

    /// <summary>
    /// Registers the game service.
    /// </summary>
    /// <exception cref="ArgumentNullException"></exception>
    public void RegisterService<T>(T service) where T : class
    {
        if (service == null)
        {
            throw new ArgumentNullException($"Attempt to register a null service.");
        }
        else if (services.ContainsKey(typeof(T)))
        {
            Debug.LogWarning($"The {typeof(T).Name} service is already registered.");
            return;
        }

        services[typeof(T)] = service;
    }

    /// <summary>
    /// Returns an instance of a service of a type T.
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    public T GetService<T>() where T : class
    {
        if (services.TryGetValue(typeof(T), out var service))
            return (T)service;

        throw new InvalidOperationException($"The {typeof(T).Name} service is not registered.");
    }

    /// <summary>
    /// Unregisters the game service.
    /// </summary>
    /// <exception cref="ArgumentNullException"></exception>
    public void UnregisterService<T>(T service) where T : class
    {
        if (service == null)
            throw new ArgumentNullException($"Attempt to unregister a null service.");

        services.Remove(typeof(T));
    }
}



/*

How to use:
1. Just copy this script into your project and call necessary methods.

*/