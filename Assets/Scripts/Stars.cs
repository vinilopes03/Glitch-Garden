﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stars : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text starText;
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }

    public void spendStars(int value)
    {
        if (stars >= value)
        {
            stars -= value;
            UpdateDisplay();
        }
    }

    public bool haveEnoughStars(int amount)
    {
        return stars >= amount;
    }

    void Update()
    {
        
    }
}
