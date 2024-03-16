using System;

public class EventManager
{
    public static event Action<MyCharacter> OnCharacterSelected;

    public static void CharacterSelected(MyCharacter character)
    {
        OnCharacterSelected?.Invoke(character);
    }
}
