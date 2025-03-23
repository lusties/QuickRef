using Lustie.QuickRef.Editor;
using UnityEditor;
using UnityEngine;

namespace Lustie.QuickRef
{
    [CustomPropertyDrawer(typeof(GetComponentAttribute))]
    public class GetComponentAttributeDrawer : QuickAttributeDrawer
    {
        protected override void OnDrawProperty(Rect position, SerializedProperty property, GUIContent label)
        {
            property.AssignIfNull(property.TargetComponent().GetComponent(fieldInfo.FieldType));
            EditorGUI.PropertyField(position, property, label);
        }
    }
}
