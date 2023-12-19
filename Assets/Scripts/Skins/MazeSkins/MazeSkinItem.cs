using UnityEngine;

[CreateAssetMenu(fileName = "MazeSkinItem", menuName = "Shop/MazeSkinItem")]
public class MazeSkinItem : ShopItem
{
    [field: SerializeField]
    public MazeSkins MazeType { get; private set; }  
}