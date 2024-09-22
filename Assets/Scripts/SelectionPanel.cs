using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionPanel : MonoBehaviour
{
    [SerializeField] ItemData[] _itemDatas;
    [SerializeField] private ObjectPlacer _objectPlacer;
    [SerializeField] private GameObject _itemTemplate;
    [SerializeField] private Transform _container;

    private void Start()
    {
        for (int i = 0; i < _itemDatas.Length; i++)
        {
            AddItem(_itemDatas[i]);
        }
    }

    private void AddItem(ItemData itemData)
    {
        Instantiate(_itemTemplate, _container).TryGetComponent(out ItemView itemView);
        itemView.Initialize(itemData);
        itemView.ItemSelected += OnItemSelected;
        itemView.ItemDisabled += OnItemDisable;
    }

    private void OnItemSelected(ItemData itemData)
    {
        _objectPlacer.SetInstalledObject(itemData);
    }

    private void OnItemDisable(ItemView itemView)
    {
        itemView.ItemSelected -= OnItemSelected;
        itemView.ItemDisabled -= OnItemDisable;
    }
}
