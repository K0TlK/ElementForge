using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private Image avatarImage;

    private void OnEnable()
    {
        EventManager.OnCharacterSelected += DisplayCharacter;
    }

    private void OnDisable()
    {
        EventManager.OnCharacterSelected -= DisplayCharacter;
    }

    private void DisplayCharacter(MyCharacter character)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(character.name);
        sb.AppendLine();
        sb.AppendLine($"Level: {character.Level}");
        sb.AppendLine($"ID: {character.Id}");

        nameText.text = sb.ToString();
        avatarImage.sprite = character.Avatar;
    }
}
