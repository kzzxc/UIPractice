using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ShopItemViewFactory", menuName = "Shop/ShopItemViewFactory")]
public class ShopItemViewFactory : ScriptableObject
{
    [SerializeField] private ShopItemView _characterSkinItemPrefab;
    [SerializeField] private ShopItemView _mazeSkinItemPrefab;

    public ShopItemView Get(ShopItem shopItem, Transform parent)
    {
        ShopItemView instance;

        switch (shopItem)
        {
            case CharacterSkinItem characterSkinItem:
                instance = Instantiate(_characterSkinItemPrefab, parent);
                break;
            
            case MazeSkinItem mazeSkinItem:
                instance = Instantiate(_mazeSkinItemPrefab, parent);
                break;
            
            default:
                throw new ArgumentException(nameof(shopItem));
        }
        instance.Initialize(shopItem);
        return instance;
    }
}
