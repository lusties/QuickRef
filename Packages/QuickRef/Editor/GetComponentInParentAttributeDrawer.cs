using Lustie.QuickRef.Editor;
using UnityEditor;
using UnityEngine;

namespace Lustie.QuickRef
{
    [CustomPropertyDrawer(typeof(GetComponentInParentAttribute))]
    public class GetComponentInParentAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (!property.IsUnityObject())
            {
                QuickLog.NotUnityObjectError(property, this);
                return;
            }

            property.AssignIfNull(property.TargetComponent().GetComponentInParent(fieldInfo.FieldType));

            EditorGUI.PropertyField(position, property, label);
        }
    }
}
