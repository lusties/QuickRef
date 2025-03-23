using System;
using UnityEngine;

namespace Lustie.QuickRef
{
    /// <summary>
    /// Base class for get component in children/parent attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public abstract class GetComponentRelativeAttribute : PropertyAttribute
    {
        public bool excludeSelf { get; set; } = true;
        public bool includeInactive { get; set; } = true;
        public string name { get; set; } = null;
    }
}
