using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacter", menuName = "Character Data", order = 0)]
public class MyCharacter : ScriptableObject, ICharacter
{
    [SerializeField] private int id;
    [SerializeField] private string characterName;
    [SerializeField] private int level;
    [SerializeField] private Sprite avatar;

    public int Id => this.id;
    public string Name => this.characterName;
    public int Level => this.level;
    public Sprite Avatar => this.avatar;
}
