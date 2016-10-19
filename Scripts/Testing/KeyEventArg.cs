﻿using UnityEngine;
using System.Collections;
using System;

public class KeyEventArg : EventArgs {

    public readonly KeyCode keycode;
    public KeyEventArg(KeyCode val)
    {
        keycode = val;
    }
}
public class MouseEventArg : EventArgs
{
    public readonly int button;
    public readonly Vector2 position;
    public MouseEventArg(int button, Vector2 position)
    {
        this.button = button;
        this.position = position;
    }
}