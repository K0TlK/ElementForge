using UnityEngine;

public interface ILocation : IObject
{
    string Description { get; }
    Sprite Image { get; }
}