﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Particles_Manager : MonoBehaviour
{
    public float time;

    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        if (time <= 0)
        {
            Destroy(gameObject);
        }
    }


}
