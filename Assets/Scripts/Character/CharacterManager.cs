using UnityEngine;

public class CharacterManager : ObjectManager<MyCharacter>
{
    public int CurrentIndex => currentIndex;
    private int currentIndex = -1;

    public override void LoadObjects(MyCharacter[] charactersToLoad)
    {
        base.LoadObjects(charactersToLoad);
    }

    public override void SelectObject(int id)
    {
        for (int i = 0; i < objects.Length; i++)
        {
            if (objects[i].Id == id)
            {
                currentIndex = i;
                DisplayCharacterInfo(objects[i]);
                break;
            }
        }
    }

    private void DisplayCharacterInfo(MyCharacter character)
    {
        Debug.Log($"Name: {character.Name}, Level: {character.Level}");
    }
}
