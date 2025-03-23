using System;
using UnityEngine;

namespace Lustie.QuickRef
{
    /// <summary>
    /// Attribute for adding a CREATE button in the Unity inspector.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public class CreateSOAttribute : PropertyAttribute
    {
    }
}

