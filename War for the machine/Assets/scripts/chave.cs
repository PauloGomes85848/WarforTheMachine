using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace key
{
    [RequireComponent(typeof(BoxCollider2D))]

    public class chave : MonoBehaviour
{
    public enum InteractionType{NONE, PickUp,Examine}
    public InteractionType type;

    private void Reset() 
    {
        GetComponent<Collider2D>().isTrigger = true;
        gameObject.layer = 5;   
    }

    public void Interact()
    {
        switch(type)
        {
            case InteractionType.PickUp:
            Debug.Log("PICK UP");
            break;
            default:
            Debug.Log("NULL ITEM");
            break;
        }
    }

}

}
