using UnityEngine;

public class LoadingController : MonoBehaviour
{
    [SerializeField] private ContentLoader contentLoader;
    [SerializeField] private DataPack dataPack_Characters;

    void Start()
    {
        var characterManager = new CharacterManager();
        MyCharacter[] characters = LoadCharacters();

        contentLoader.LoadContent(characterManager, characters);
    }

    private MyCharacter[] LoadCharacters()
    {
        return dataPack_Characters.GetItems<MyCharacter>();
    }
}
