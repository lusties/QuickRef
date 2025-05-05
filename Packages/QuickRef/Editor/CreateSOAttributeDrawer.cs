using UnityEditor;
using UnityEngine;

namespace Lustie.QuickRef.Editor
{
    [CustomPropertyDrawer(typeof(CreateSOAttribute))]
    public class CreateSOAttributeDrawer : QuickAttributeDrawer<CreateSOAttribute>
    {
        protected override void OnDrawProperty(Rect position, SerializedProperty property, GUIContent label)
        {
            using var propertyScope = new EditorGUI.PropertyScope(position, label, property);
            float buttonWidth = 80;

            position.width -= buttonWidth;
            EditorGUI.PropertyField(position, property, label);

            position.x += position.width;
            position.width = buttonWidth;
            if (GUI.Button(position, new GUIContent("Create")))
            {
                var className = fieldInfo.FieldType.FullName;
                var objectName = property.TargetComponent() ? property.TargetComponent().gameObject.name : "NewAsset";
                var newScriptableObject = ScriptableObjectUtility.CreateAsset(className,
                    $"Create New {className} Asset",
                    $"{objectName}_{fieldInfo.FieldType.Name} Asset", "");

                if (newScriptableObject)
                    property.AssignIfNotEqual(newScriptableObject);
            }
        }
    }
}