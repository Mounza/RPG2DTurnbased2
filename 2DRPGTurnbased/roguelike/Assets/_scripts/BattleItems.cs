using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleItems : MonoBehaviour
{
    public bool isItem, effectHP, effectMP, effectSTR, effectDEF, isWpn, isArmr;
    public int amountToChange;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Use(int charToUseOn)
    {
        CharStats selectedChar = GameManager.instance.playerStats[charToUseOn];
        BattleChar selectedBattleChar = BattleManager.instance.activeBattlers[charToUseOn];

        if(isItem)
        {
            if(effectHP)
            {
                selectedChar.currentHP += amountToChange;
                selectedBattleChar.currentHP += amountToChange;
            }
            if(selectedChar.currentHP > selectedChar.maxHP || selectedBattleChar.currentHP > selectedChar.maxHP)
            {
                selectedChar.currentHP = selectedChar.maxHP;
                selectedBattleChar.currentHP = selectedChar.maxHP;
            }
            if (effectMP)
            {
                selectedChar.currentMP += amountToChange;
                selectedBattleChar.currentMP += amountToChange;
            }
            if (selectedChar.currentMP > selectedChar.maxMP || selectedBattleChar.currentMP > selectedChar.maxMP)
            {
                selectedChar.currentMP = selectedChar.maxMP;
                selectedBattleChar.currentMP = selectedChar.maxMP;
            }
            if(effectSTR)
            {
                selectedChar.strength += amountToChange;
            }
            if (effectDEF)
            {
                selectedChar.defence += amountToChange;
            }
        }

    }
}
