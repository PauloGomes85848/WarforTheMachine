using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    [Header("General Fields")]
    //List of items picked up
    public List<GameObject> items = new List<GameObject>();
    //flag indicates if the inventory is open or not
    public bool isOpen = false;
    [Header("UI Items Section")]
    //Inventory system window
    public GameObject ui_Window;
    public Image[] items_images;

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            ToggleInventory();
        }    
    }

    void ToggleInventory()
    {
        isOpen = !isOpen;
        ui_Window.SetActive(isOpen);
    }

    //Adiciona item a lista de items
    public void PickUp(GameObject item)
    {
        items.Add(item);
        Update_UI();
    }

    //Refresh the UI elements in the inventory window
    void Update_UI()
    {
        HideAll();
        //For each item in the "items" list 
        //Show it in the respective slot in the "items_images"
        for(int i=0; i<items.Count; i++)
        {
            items_images[i].sprite = items[i].GetComponent<SpriteRenderer>().sprite;
            items_images[i].gameObject.SetActive(true);
        }
    }

    //Hide all the items ui images
    void HideAll()
    {
        foreach(var i in items_images)
        {
            i.gameObject.SetActive(false);
        }
    }
}
