using UnityEditor;
using UnityEngine;

namespace Lustie.QuickRef.Editor
{
    internal static class QuickLog
    {
        public static void NotUnityObjectError(SerializedProperty property, PropertyDrawer drawer)
        {
            //var drawerAttribute = drawer.GetType().GetCustomAttribute<CustomPropertyDrawer>();
            //if (drawerAttribute == null)
            //    return;

            //var typeInfo = typeof(CustomPropertyDrawer).GetField("m_Type", BindingFlags.Instance | BindingFlags.NonPublic);
            //Type customAttribute = typeInfo.GetValue(drawerAttribute) as Type;

            Debug.LogError($"Field {property.name} is not an unity object and cannot be used with {nameof(drawer.attribute)}");
        }
    }
}
