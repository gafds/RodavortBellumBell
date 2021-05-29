﻿using UnityEngine;

[CreateAssetMenu(fileName = "New Card",menuName = "Cards/Normal")]
public class Card : ScriptableObject
{
    public uint cardId;

    [Header("Reading")]
    public Sprite design;
    
    [Header("Attributes")]
    public int gold;
    public int life;

    [Header("Dubbing")]
    public AudioClip[] SoundAtEntrance;
    public AudioClip[] SoundInDeath;

}

