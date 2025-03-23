using UnityEditor;
using UnityEngine;

namespace Lustie.QuickRef.Editor
{
    [CustomPropertyDrawer(typeof(DisabledAttribute))]
    public class DisabledAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            using var propertyScope = new EditorGUI.PropertyScope(position, label, property);

            bool wasEnabled = GUI.enabled;
            GUI.enabled = false;

            EditorGUI.PropertyField(position, property, label);

            GUI.enabled = wasEnabled;
        }
    }
}
