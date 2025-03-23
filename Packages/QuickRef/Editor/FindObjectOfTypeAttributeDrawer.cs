using Lustie.QuickRef.Editor;
using UnityEditor;
using UnityEngine;

namespace Lustie.QuickRef
{
    [CustomPropertyDrawer(typeof(FindObjectOfTypeAttribute))]
    public class FindObjectOfTypeAttributeDrawer : QuickAttributeDrawer
    {
        protected override void OnDrawProperty(Rect position, SerializedProperty property, GUIContent label)
        {
            property.AssignIfNull(GameObject.FindObjectOfType(fieldInfo.FieldType));
            EditorGUI.PropertyField(position, property, label);
        }
    }
}
