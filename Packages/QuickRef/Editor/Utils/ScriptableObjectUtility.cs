using UnityEditor;
using UnityEngine;

namespace Lustie.QuickRef.Editor
{
    public class ScriptableObjectUtility
    {
        public static ScriptableObject CreateAsset(string className, string title, string defaultName, string message = "")
        {
            if (string.IsNullOrWhiteSpace(defaultName))
            {
                defaultName = "NewAsset";
            }
            string filePath = EditorUtility.SaveFilePanelInProject(title, defaultName, "asset", message);

            if (!string.IsNullOrEmpty(filePath))
            {
                //UnityEngine.Debug.Log(filePath);
                var data = ScriptableObject.CreateInstance(className);

                return Create(data, filePath);
            }
            return null;
        }

        static ScriptableObject Create(ScriptableObject asset, string path)
        {
            if (!asset)
            {
                Debug.LogError("failed to create asset");
                return null;
            }
            AssetDatabase.CreateAsset(asset, path);
            AssetDatabase.SaveAssets();

            //EditorUtility.FocusProjectWindow();
            //EditorUtility.RevealInFinder(Path.GetDirectoryName(AssetDatabase.GetAssetPath(asset)));

            //Selection.activeObject = asset;
            return asset;
        }
    }
}