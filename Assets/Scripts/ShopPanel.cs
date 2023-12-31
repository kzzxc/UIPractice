using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPanel : MonoBehaviour
{
    private List<ShopItemView> _shopItems = new List<ShopItemView>();

    [SerializeField] private Transform _itemsParent;
    [SerializeField] private ShopItemViewFactory _shopItemViewFactory;
    
    public void Show(IEnumerable<ShopItem> items)
    {
        Clear();
        
        foreach (ShopItem item in items)
        {
            ShopItemView spawnedItem = _shopItemViewFactory.Get(item, _itemsParent);

            spawnedItem.Click += OnItemViewClick;
            
            spawnedItem.UnSelect();
            spawnedItem.UnHighlight();
            
            //Проверка открытости скина и тп
            
            _shopItems.Add(spawnedItem);
        }
    }

    private void OnItemViewClick(ShopItemView obj)
    {
        
    }

    private void Clear()
    {
        foreach (ShopItemView item in _shopItems)
        {
            item.Click -= OnItemViewClick;
            Destroy(item.gameObject);
        }
        
        _shopItems.Clear();
    }
}
