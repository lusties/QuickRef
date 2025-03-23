using System;
using UnityEngine;

namespace Lustie.QuickRef
{
    /// <summary>
    /// Automatically get component in parent
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public class GetComponentInParentAttribute : PropertyAttribute
    {
    }
}
