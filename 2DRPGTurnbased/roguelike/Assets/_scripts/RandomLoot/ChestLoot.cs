using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestLoot : MonoBehaviour
{

    public string tagName;
    public GameObject[] objects;
    public Transform spawnPoint;

    private void OnTriggerEnter2D(Collider2D other)
    
    {
        if(other.gameObject.tag == tagName)
        {
            OpenChest();
        }
    }

    void OpenChest()
    {
        GameObject item = Instantiate(objects[Random.Range(0, objects.Length)], spawnPoint.position, spawnPoint.rotation) as GameObject;
    }



}
