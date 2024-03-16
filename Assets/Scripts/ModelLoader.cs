using UnityEngine;

public class ModelLoader : MonoBehaviour
{
    [SerializeField] private Transform parent = null;

    private void OnEnable()
    {
        EventManager.OnCharacterSelected += LoadCharacterModel;
    }

    private void OnDisable()
    {
        EventManager.OnCharacterSelected -= LoadCharacterModel;
    }

    void LoadCharacterModel(MyCharacter character)
    {
        foreach (Transform child in parent)
        {
            Destroy(child.gameObject);
        }

        var model = Resources.Load(character.ModelPath, typeof(GameObject)) as GameObject;
        if (model != null)
        {
            var gameObject = Instantiate(model, parent);
            gameObject.transform.localRotation = Quaternion.identity;
            gameObject.transform.localPosition = Vector3.zero;
        }
        else
        {
            Debug.LogError("Failed to load the model.");
        }
    }
}
