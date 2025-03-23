using Lustie.QuickRef.Editor;
using UnityEditor;
using UnityEngine;

namespace Lustie.QuickRef
{
    [CustomPropertyDrawer(typeof(GetComponentInParentAttribute))]
    public class GetComponentInParentAttributeDrawer : QuickAttributeDrawer
    {
        protected override void OnDrawProperty(Rect position, SerializedProperty property, GUIContent label)
        {
            property.AssignIfNull(property.TargetComponent().GetComponentInParent(fieldInfo.FieldType));
            EditorGUI.PropertyField(position, property, label);
        }
    }
}
