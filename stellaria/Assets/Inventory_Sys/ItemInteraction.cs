using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemInteraction : MonoBehaviour
{
    Transform cam;
    [SerializeField] LayerMask itemLayer;
    InventorySystem inventorySystem;

    [SerializeField] TextMeshProUGUI txt_HoveredItem;

    void Start()
    {
        cam = Camera.main.transform;
        inventorySystem = GetComponent<InventorySystem>();
    }
    /*
    void Update()
    {
        RaycastHit hit;

        if(Physics.RaycastHit(cam.position,cam.forward, out hit,2,itemLayer))
        {
            if (!hit.collider.GetComponent<ItemObject>())
                return;

            txt_HoveredItem.text = $"press 'F' to pick up {hit.collider.GetComponent<ItemObject>().amount}x {hit.collider.GetCompnent<itemObject>().itemStats.name}";

            if (Input.GetKeyDown(KeyCode.F))
            {
                inventorySystem.PickUpItem(hit.collider.GetComponent<ItemObject>());
            }



        }
        else
        {
            txt_HoveredItem.text = string.Empty;
        }
    }*/
}
