using System;
using UnityEngine;

namespace Lustie.QuickRef
{
    /// <summary>
    /// Automatically find gameobject of Type
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public class FindObjectOfTypeAttribute : PropertyAttribute
    {
    }
}
