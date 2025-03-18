﻿using System;
using UnityEngine;

namespace Lustie.QuickRef
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public class GetComponentAttribute : PropertyAttribute
    {
    }
}
