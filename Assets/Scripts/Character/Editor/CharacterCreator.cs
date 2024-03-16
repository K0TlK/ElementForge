using UnityEngine;
using UnityEditor;

public class CharacterCreator : MonoBehaviour
{
    [MenuItem("Content/Character Data From Selected Images")]
    private static void CreateCharacterDataFromSelectedImages()
    {
        foreach (Object obj in Selection.objects)
        {
            if (obj is Texture2D)
            {
                Texture2D texture = obj as Texture2D;
                string path = AssetDatabase.GetAssetPath(texture);

                MyCharacter newCharacter = ScriptableObject.CreateInstance<MyCharacter>();

                newCharacter.SetEditorOnlyProperties(
                    path, 
                    texture.name, 
                    Random.Range(1, 10), 
                    Random.Range(1, 10000));

                string assetPath = AssetDatabase.GenerateUniqueAssetPath("Assets/NewCharacter_" + texture.name + ".asset");

                AssetDatabase.CreateAsset(newCharacter, assetPath);
            }
        }

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}
