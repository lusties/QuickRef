using UnityEditor;
using UnityEngine;

namespace Lustie.QuickRef.Editor
{
    [CustomPropertyDrawer(typeof(DisabledAttribute))]
    public class DisabledAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            bool wasEnabled = GUI.enabled;
            GUI.enabled = false;

            EditorGUI.PropertyField(position, property, label, false);

            GUI.enabled = wasEnabled;
        }
    }
}
