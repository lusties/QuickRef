using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Lustie.QuickRef.Editor
{
    [CustomPropertyDrawer(typeof(NoDisplayAttribute))]
    public class NoDisplayAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
        }

        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            return null;
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return 0;
        }
    }
}
