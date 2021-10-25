using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Görev")]
[SerializeField]
public class Gorev : ScriptableObject
{
    public string GorevAciklama;
    public string Diyalog;
    public Item item;
}
