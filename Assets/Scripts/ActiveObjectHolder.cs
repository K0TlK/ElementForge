using System.Text;
using TMPro;
using UnityEngine;

public class ActiveObjectHolder : MonoBehaviour
{
    [SerializeField] private TMP_Text text;

    private MyCharacter activeCharacter;
    private MyLocation activeLocation;

    private void OnEnable()
    {
        EventManager.OnObjectSetActive += SetNewActiveObject;
    }

    private void OnDisable()
    {
        EventManager.OnObjectSetActive -= SetNewActiveObject;
    }

    private void SetNewActiveObject(IObject newObject)
    {
        try
        {
            var character = (MyCharacter)newObject;
            activeCharacter = character;
            UpdateText();
        }
        catch
        {
            return;
        }

        try
        {
            var location = (MyLocation)newObject;
            activeLocation = location;
            UpdateText();
        }
        catch
        {
            return;
        }
    }

    private void UpdateText()
    {
        StringBuilder stringBuilder = new StringBuilder();

        if (activeCharacter != null)
        {
            stringBuilder.AppendLine($"Ch: {activeCharacter.Id}");
        }

        if (activeLocation != null)
        {
            stringBuilder.AppendLine($"Lo: {activeLocation.Id}");
        }

        text.text = stringBuilder.ToString();
    }
}
