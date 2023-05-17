using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlateIconsSingleUI : MonoBehaviour
{
    [SerializeField] private Image image;

    public void SetKithcenObjectSO(KitchenObjectsSO kitchenObjectsSO)
    {
        image.sprite = kitchenObjectsSO.sprite;
    }
}
