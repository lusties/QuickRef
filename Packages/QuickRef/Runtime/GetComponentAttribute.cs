using System;
using UnityEngine;

namespace Lustie.QuickRef
{
    /// <summary>
    /// Automatically get component from self
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public class GetComponentAttribute : PropertyAttribute
    {
    }
}
