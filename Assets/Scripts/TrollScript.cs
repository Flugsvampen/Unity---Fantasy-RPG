﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrollScript : EnemyClass
{
    int attacked = Animator.StringToHash("Attacked");
    
    [SerializeField] private int confusionChance = 20;
    private bool canConfuse = false;

    // Use this for initialization
    void Awake()
    {
    }

    void Update()
    {
        if (enemyHp <= maxHP * 0.75f)
            canConfuse = true;
    }

    public override void AttackPattern()
    {
        if (canConfuse && Random.Range(0, 100 / confusionChance) == 0)
            base.ConfusionAttack();
        else
            base.NormalAttack();
    }
}
