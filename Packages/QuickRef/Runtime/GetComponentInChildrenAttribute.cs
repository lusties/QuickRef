using System;
using UnityEngine;

namespace Lustie.QuickRef
{
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public class GetComponentInChildrenAttribute : PropertyAttribute
    {
    }
}
