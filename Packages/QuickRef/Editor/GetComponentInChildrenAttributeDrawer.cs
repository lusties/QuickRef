using System;
using UnityEditor;
using UnityEngine;

namespace Lustie.QuickRef.Editor
{
    [CustomPropertyDrawer(typeof(GetComponentInChildrenAttribute))]
    public class GetComponentInChildrenAttributeDrawer : GetComponentRelativeAttributeDrawer<GetComponentInChildrenAttribute>
    {
        protected override Component GetComponentRelative(Component targetComponent, Type fieldType)
        {
            return targetComponent.GetComponentInChildren(fieldInfo.FieldType);
        }

        protected override Component[] GetComponentsRelative(Component targetComponent, Type fieldType, bool includeInactive)
        {
            return targetComponent.GetComponentsInChildren(fieldInfo.FieldType, propertyAttribute.includeInactive);
        }
    }
}
