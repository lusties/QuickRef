using UnityEditor;
using UnityEngine;

namespace Lustie.QuickRef.Editor
{
    public abstract class QuickAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (!property.IsUnityObject())
            {
                QuickLog.NotUnityObjectError(property, this);
                return;
            }

            OnDrawProperty(position, property, label);
        }

        protected abstract void OnDrawProperty(Rect position, SerializedProperty property, GUIContent label);

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }
    }
}
