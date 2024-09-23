﻿using System;
using System.Collections.Generic;
using Enemy;
using UnityEngine;

namespace GameCore.LevelSystem
{
    [Serializable]
    public class Level: IActivate
    {
        [SerializeField] private List<EnemySpawner> _enemySpawners = new List<EnemySpawner>();


        public void Activate()
        {
            for (int i = 0; i < _enemySpawners.Count; i++) 
                _enemySpawners[i].Activate();
        }

        public void Deactivate()
        {
            for (int i = 0; i < _enemySpawners.Count; i++) 
                _enemySpawners[i].Deactivate();
        }
    }
}