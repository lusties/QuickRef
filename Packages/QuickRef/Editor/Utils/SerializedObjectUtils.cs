﻿using UnityEditor;
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

        public static void AssignIfNull(this SerializedProperty property, Object objectValue)
        {
            if (property.objectReferenceValue == null)
            {
                property.objectReferenceValue = objectValue;
                property.serializedObject.ApplyModifiedPropertiesWithoutUndo();
            }
        }
    }
}
