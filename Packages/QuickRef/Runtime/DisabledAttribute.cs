using System;
using UnityEngine;

namespace Lustie.QuickRef
{
    /// <summary>
    /// Disable the property, this will disallow modifying value in the inspector.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public class DisabledAttribute : PropertyAttribute
    {
    }
}
