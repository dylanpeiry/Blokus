﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece_Y : Piece
{
    public override int[,] piece_form {
        get {
            return new int[4, 2] {
                { 1, 0},
                { 1, 1},
                { 1, 0},
                { 1, 0},
            };
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}