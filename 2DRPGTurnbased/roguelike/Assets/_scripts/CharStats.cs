using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharStats : MonoBehaviour
{

    public string charName;
    public int playerLevel = 1;
    public int currentEXP;
    public int[] expToNextLevel;
    public int maxLevel = 100;
    public int baseEXP = 1000;

    public int currentHP;
    public int maxHP = 100;
   // public int[] hpLvlBonus;
    public int currentMP;
    public int maxMP = 30;
   // public int[] mpLvlBonus;
    public int strength;    
  //  public int[] strLvlBonus;
    public int intelligence;
    public int defence;
    //public int[] defLvlBonus;
    public int wpnPwr; //weaponPower
    public int armrPwr; //armorPower
    public string equippedWpn;
    public string equippedArmr;
    public Sprite charImage;

    void Start()
    {
        expToNextLevel = new int[maxLevel];
        expToNextLevel[1] = baseEXP;

        for(int i = 2; i < expToNextLevel.Length; i++)
        {
            expToNextLevel[i] = Mathf.FloorToInt(expToNextLevel[i - 1] * 1.05f);
        }
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            AddExp(1000);
        }
    }
    public void AddExp(int expToAdd)
    {
        currentEXP += expToAdd;
        if (playerLevel < maxLevel)
        {
            if (currentEXP > expToNextLevel[playerLevel])
            {
                currentEXP -= expToNextLevel[playerLevel];

                playerLevel++;

                //determine whether to add to str or def based on odd or even
                // if (playerLevel % 2 == 0)
                //  {
                //float strengthLvlBonus = strength + Random.Range(3, 5);

                // strength++;
                // }
                //  else
                //  {
                // defence = Random.Range(3, 5);

                // defence++;
                //  }

                if (charName == "Maxim")
                {


                    strength = Mathf.FloorToInt(strength + Random.Range(3, 5));
                    intelligence = Mathf.FloorToInt(intelligence + Random.Range(1, 3));
                    defence = Mathf.FloorToInt(defence + Random.Range(3, 5));
                    maxHP = Mathf.FloorToInt(maxHP + Random.Range(7, 9));
                    currentHP = maxHP;
                    maxMP = Mathf.FloorToInt(maxMP + Random.Range(4, 6));
                    currentMP = maxMP;
                    //maxHP += hpLvlBonus[playerLevel];
                    // currentHP = maxHP;
                    //  maxMP += mpLvlBonus[playerLevel];
                    
                    //  strength += strLvlBonus[playerLevel];
                    //  defence += defLvlBonus[playerLevel];
                }

                if (charName == "Selan")
                {
                    strength = Mathf.FloorToInt(strength + Random.Range(1, 3));
                    intelligence = Mathf.FloorToInt(intelligence + Random.Range(4, 7));
                    defence = Mathf.FloorToInt(defence + Random.Range(1, 3));
                    maxHP = Mathf.FloorToInt(maxHP + Random.Range(4, 7));
                    currentHP = maxHP;
                    maxMP = Mathf.FloorToInt(maxMP + Random.Range(5, 7));
                    currentMP = maxMP;
                }

                if (charName == "Guy")
                {
                    strength = Mathf.FloorToInt(strength + Random.Range(5, 7));
                    intelligence = Mathf.FloorToInt(intelligence + Random.Range(0, 3));
                    defence = Mathf.FloorToInt(defence + Random.Range(5, 7));
                    maxHP = Mathf.FloorToInt(maxHP + Random.Range(11, 13));
                    currentHP = maxHP;
                    maxMP = Mathf.FloorToInt(maxMP + Random.Range(2, 4));
                    currentMP = maxMP;
                }

                if (charName == "Dekar")
                {
                    strength = Mathf.FloorToInt(strength + Random.Range(8, 11));
                    intelligence = Mathf.FloorToInt(intelligence + Random.Range(0, 1));
                    defence = Mathf.FloorToInt(defence + Random.Range(8, 11));
                    maxHP = Mathf.FloorToInt(maxHP + Random.Range(15, 17));
                    currentHP = maxHP;
                    maxMP = Mathf.FloorToInt(maxMP + Random.Range(1, 3));
                    currentMP = maxMP;
                }
            }
        }
        if (playerLevel >= maxLevel)
        {
            currentEXP = 0;
        }
    }
}
