using UnityEditor;
using UnityEngine;

namespace Lustie.QuickRef.Editor
{
    internal static class SerializedObjectUtils
    {
        public static Component TargetComponent(this SerializedProperty serializedProperty)
        {
            return serializedProperty.serializedObject.TargetComponent();
        }

        public static Component TargetComponent(this SerializedObject serializedObject)
        {
            return serializedObject.targetObject as Component;
        }

        public static bool IsUnityObject(this SerializedProperty serializedProperty)
        {
            return serializedProperty.propertyType == SerializedPropertyType.ObjectReference;
        }

        public static void AssignIfNotEqual(this SerializedProperty property, Object objectValue, bool ignorenWhilePlaying = true)
        {
            if (ignorenWhilePlaying && Application.isPlaying)
                return;
            if (property.objectReferenceValue == null || property.objectReferenceValue != objectValue)
            {
                property.objectReferenceValue = objectValue;
                property.serializedObject.ApplyModifiedPropertiesWithoutUndo();
            }
        }
    }
}
