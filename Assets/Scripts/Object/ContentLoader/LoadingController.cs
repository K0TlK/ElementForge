using UnityEngine;

public class LoadingController : MonoBehaviour
{
    [SerializeField] private ContentLoader contentLoader;
    [SerializeField] private DataPack dataPack_Characters;
    [SerializeField] private CharacterView characterViewPrefab;
    [SerializeField] private Transform viewParent;

    void Start()
    {
        var characterManager = new CharacterManager();

        MyCharacter[] characters = LoadCharacters();
        contentLoader.LoadContent(characterManager, characters);
        DisplayCharacters(characters);
    }

    private MyCharacter[] LoadCharacters()
    {
        return dataPack_Characters.GetItems<MyCharacter>();
    }

    private void DisplayCharacters(MyCharacter[] characters)
    {
        foreach (MyCharacter character in characters)
        {
            CharacterView viewInstance = Instantiate(characterViewPrefab, viewParent);
            viewInstance.DisplayCharacter(character);
        }
    }
}
