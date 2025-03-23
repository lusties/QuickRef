using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Lustie.QuickRef.Editor
{
    public abstract class GetComponentRelativeAttributeDrawer<TRelativeAttribute> : QuickAttributeDrawer<TRelativeAttribute>
        where TRelativeAttribute : GetComponentRelativeAttribute
    {
        protected override void OnDrawProperty(Rect position, SerializedProperty property, GUIContent label)
        {
            Component targetComponent = property.TargetComponent();
            Component childrenComponent = null;
            if (propertyAttribute.excludeSelf)
            {
                var components = GetComponentsRelative(targetComponent, fieldInfo.FieldType, propertyAttribute.includeInactive);
                childrenComponent = components.FirstOrDefault(component =>
                {
                    string name = propertyAttribute.name;
                    return component.gameObject != targetComponent.gameObject
                        && (name == null || (name == component.name));
                });
            }
            else
            {
                childrenComponent = GetComponentRelative(targetComponent, fieldInfo.FieldType);
            }

            using var propertyScope = new EditorGUI.PropertyScope(position, label, property);
            property.AssignIfNotEqual(childrenComponent);
            EditorGUI.PropertyField(position, property, label);
        }

        protected abstract Component[] GetComponentsRelative(Component targetComponent, Type fieldType, bool includeInactive);
        protected abstract Component GetComponentRelative(Component targetComponent, Type fieldType);
    }
}
