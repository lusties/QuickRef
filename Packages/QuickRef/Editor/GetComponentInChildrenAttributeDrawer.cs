using Lustie.QuickRef.Editor;
using UnityEditor;
using UnityEngine;

namespace Lustie.QuickRef
{
    [CustomPropertyDrawer(typeof(GetComponentInChildrenAttribute))]
    public class GetComponentInChildrenAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (!property.IsUnityObject())
            {
                QuickLog.NotUnityObjectError(property, this);
                return;
            }

            property.AssignIfNull(property.TargetComponent().GetComponentInChildren(fieldInfo.FieldType));

            EditorGUI.PropertyField(position, property, label);
        }
    }
}
