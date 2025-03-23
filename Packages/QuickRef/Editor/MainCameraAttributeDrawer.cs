using UnityEditor;
using UnityEngine;

namespace Lustie.QuickRef.Editor
{
    [CustomPropertyDrawer(typeof(MainCameraAttribute))]
    public class MainCameraAttributeDrawer : QuickAttributeDrawer<MainCameraAttribute>
    {
        protected override void OnDrawProperty(Rect position, SerializedProperty property, GUIContent label)
        {
            using var propertyScope = new EditorGUI.PropertyScope(position, label, property);
            property.AssignIfNotEqual(Camera.main);
            EditorGUI.PropertyField(position, property, label);
        }
    }
}
