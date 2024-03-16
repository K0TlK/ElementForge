using UnityEngine;

[CreateAssetMenu(fileName = "NewLocation", menuName = "Location Data", order = 1)]
public class MyLocation : ScriptableObject, ILocation
{
    [SerializeField] private int id;
    [SerializeField] private string locationName;
    [SerializeField] private string description;
    [SerializeField] private Sprite image;
    [SerializeField] private int sceneId;

    public int Id => this.id;
    public string Name => this.locationName;
    public string Description => this.description;
    public Sprite Image => this.image;
    public int SceneId => this.sceneId;
}