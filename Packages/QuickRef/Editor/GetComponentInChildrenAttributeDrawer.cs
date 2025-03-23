﻿using Lustie.QuickRef.Editor;
using UnityEditor;
using UnityEngine;

namespace Lustie.QuickRef
{
    [CustomPropertyDrawer(typeof(GetComponentInChildrenAttribute))]
    public class GetComponentInChildrenAttributeDrawer : QuickAttributeDrawer
    {
        protected override void OnDrawProperty(Rect position, SerializedProperty property, GUIContent label)
        {
            property.AssignIfNull(property.TargetComponent().GetComponentInChildren(fieldInfo.FieldType));
            EditorGUI.PropertyField(position, property, label);
        }
    }
}
