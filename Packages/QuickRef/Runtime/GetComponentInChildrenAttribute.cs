﻿using System;
using UnityEngine;

namespace Lustie.QuickRef
{
    /// <summary>
    /// Automatically get component in chidlren
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public class GetComponentInChildrenAttribute : PropertyAttribute
    {
    }
}
