﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManagerScript : MonoBehaviour
{
    private Transform _currentCheckpoint = null;
    private Vector3 _fallbackLevelSpawnPosition;

    public Transform CurrentSpawnPoint => _currentCheckpoint;

    public Vector3 LevelSpawnPosition
    {
        get => _fallbackLevelSpawnPosition;
        set => _fallbackLevelSpawnPosition = value;
    }

    public void SetRespawnLocation(Transform transform)
    {
        if (transform != null)
        {
            _currentCheckpoint = transform;
        }
    }
}
