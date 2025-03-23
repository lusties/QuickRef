using System;
using UnityEditor;
using UnityEngine;

namespace Lustie.QuickRef.Editor
{
    [CustomPropertyDrawer(typeof(GetComponentInParentAttribute))]
    public class GetComponentInParentAttributeDrawer : GetComponentRelativeAttributeDrawer<GetComponentInParentAttribute>
    {
        protected override Component GetComponentRelative(Component targetComponent, Type fieldType)
        {
            return targetComponent.GetComponentInParent(fieldInfo.FieldType);
        }

        protected override Component[] GetComponentsRelative(Component targetComponent, Type fieldType, bool includeInactive)
        {
            return targetComponent.GetComponentsInParent(fieldInfo.FieldType, propertyAttribute.includeInactive);
        }
    }
}
