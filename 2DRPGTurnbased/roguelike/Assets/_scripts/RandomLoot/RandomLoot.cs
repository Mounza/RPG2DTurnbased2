using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLoot : MonoBehaviour
{
    public List<GameObject> items;
    public int[] table =
        {
             60, //item1
             30, //item2
             10  //item3
        };

    public int total;
    public int randomNumber;

    private void Start()
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
        //tally the total weight
        //draw a random number between 0 and the total weight (100)

        //randomNumber == 49

        //is 49 < 60? 
        //sword A

        //random numer = 61
        //is 61 <= 60
        // no = ??
        //61 - 60 = 1
        //1 <=30 ?
        //yes thats your weapon

        //randomNumber = 92
        // is 92 <= 60?
        // 92 - 60 = 32
        //

    }
}
