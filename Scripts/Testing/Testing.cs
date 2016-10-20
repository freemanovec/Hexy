﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Testing : MonoBehaviour {

    Referent referent;

    void Start()
    {
        referent = GameObject.FindGameObjectWithTag("referent").GetComponent<Referent>();
        referent.KeyDown += (s, c) => { if (c.keycode != KeyCode.None)
            {
                CallMe(c.keycode.ToString());
                HandleKeyPress(c.keycode);
            }};
        referent.KeyDown += (s, c) => { if (c.keycode == KeyCode.None) isKeyDown = false; };
        referent.KeyDown += (s, c) => { if (c.keycode == KeyCode.Escape) KillTheGame(); };
        referent.MouseClicked += (s, p) => { DeleteTile(p.position); };
        referent.map = GenerateWorld();
    }
    public Map GenerateWorld()
    {
        float seed = Random.Range(-2571f, 2571f);
        referent.textSeed.text = seed.ToString();
        return MapGenerator.MakeTerrainBase(MapGenerator.CreateBlankGrid(new Vector2(49, 23), 0), MapTypes.NormalLake, seed);
    }
    public void Reload()
    {
        referent.map.ClearMap(true);
        referent.map = GenerateWorld();
    }
    void CallMe(string message)
    {
        Debug.Log(message);
    }
    void KillTheGame()
    {
        Debug.LogWarning("The game is quitting");
        Application.Quit();
    }
    void DeleteTile(Vector2 gridPos)
    {
        Debug.Log("Deleting: " + gridPos);
        Destroy(referent.map.GetTileAtWorld(gridPos));
    }

    bool isKeyDown = false;
    void HandleKeyPress(KeyCode keyCode)
    {
        if (isKeyDown)
            return;
        isKeyDown = true;
        switch (keyCode)
        {
            case KeyCode.Delete:
                break;
            case KeyCode.UpArrow:
                break;
            case KeyCode.DownArrow:
                break;
            case KeyCode.RightArrow:
                break;
            case KeyCode.LeftArrow:
                break;
            case KeyCode.A:
                break;
            case KeyCode.B:
                break;
            case KeyCode.C:
                break;
            case KeyCode.D:
                break;
            case KeyCode.E:
                break;
            case KeyCode.F:
                break;
            case KeyCode.G:
                break;
            case KeyCode.H:
                break;
            case KeyCode.I:
                break;
            case KeyCode.J:
                break;
            case KeyCode.K:
                break;
            case KeyCode.L:
                break;
            case KeyCode.M:
                break;
            case KeyCode.N:
                break;
            case KeyCode.O:
                break;
            case KeyCode.P:
                break;
            case KeyCode.Q:
                break;
            case KeyCode.R:
                break;
            case KeyCode.S:
                break;
            case KeyCode.T:
                break;
            case KeyCode.U:
                break;
            case KeyCode.V:
                break;
            case KeyCode.W:
                break;
            case KeyCode.X:
                break;
            case KeyCode.Y:
                break;
            case KeyCode.Z:
                break;
            default:
                break;
        }
    }
}
