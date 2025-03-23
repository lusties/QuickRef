using Lustie.QuickRef.Editor;
using UnityEditor;
using UnityEngine;

namespace Lustie.QuickRef
{
    [CustomPropertyDrawer(typeof(GetComponentAttribute))]
    public class GetComponentAttributeDrawer : QuickAttributeDrawer<GetComponentAttribute>
    {
        protected override void OnDrawProperty(Rect position, SerializedProperty property, GUIContent label)
        {
            using var propertyScope = new EditorGUI.PropertyScope(position, label, property);
            property.AssignIfNotEqual(property.TargetComponent().GetComponent(fieldInfo.FieldType));
            EditorGUI.PropertyField(position, property, label);
        }
    }
}
