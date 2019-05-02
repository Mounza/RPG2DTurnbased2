using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{

    public List<GameObject> items;
    private bool chestOpenend;
  
    public SpriteRenderer spriteRenderer;
    public Sprite openSprite;

    private bool canPickup;

   // public Transform spawnPoint;

    public int[] table =
        {
             60, //item1
             30, //item2
             10  //item3
        };

    public int total;
    public int randomNumber;

    void Start()
    {
        foreach (var item in table)
        {
            total += item;
        }

        randomNumber = Random.Range(0, total);

        for (int i = 0; i < table.Length; i++)
        {
            if (randomNumber <= table[i])
            {
                items[i].SetActive(true);
                return;

            }
            else
            {
                randomNumber -= table[i];
            }
        }
    }
    void Update()
    {
        if (canPickup && Input.GetButtonDown("Fire1") && PlayerController.instance.canMove && !chestOpenend)
        {
            OpenChest();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canPickup = true;          
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            canPickup = false;
        }
    }

    void OpenChest()
    {
        spriteRenderer.sprite = openSprite;
        chestOpenend = true;
        Debug.Log("CHest Opened!");
        
        //GameManager.instance.AddItem(GetComponent<Item>().itemName);       
                   
    }

    
}
