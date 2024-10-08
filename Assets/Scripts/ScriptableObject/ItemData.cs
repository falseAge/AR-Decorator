using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New ItemDate", menuName = "ItemData", order = 51)]

public class ItemData : ScriptableObject
{
    [SerializeField] private Sprite _preview;
    [SerializeField] private string _label;
    [SerializeField] private GameObject _prefab;

    public Sprite Preview => _preview;
    public string Label => _label;
    public GameObject Prefab => _prefab;
}
