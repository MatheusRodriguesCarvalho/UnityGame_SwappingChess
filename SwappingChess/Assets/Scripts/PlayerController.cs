using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject controller;
    public GameObject movePlate;

    private int xBoard = -1;
    private int yBoard = -1;


    private string player;

    public Sprite bQueen, bKing, bPawn, bKnight, bRook, bBishop;
    public Sprite wQueen, wKing, wPawn, wKnight, wRook, wBishop;


    public void Activate()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");

        //adjust the coordinates of the unity
        SetCords();


        switch(this.name)
        {
            case "bQueen": this.GetComponent<SpriteRenderer>().sprite = bQueen; break;
            case "bKing": this.GetComponent<SpriteRenderer>().sprite = bKing; break;
            case "bPawn": this.GetComponent<SpriteRenderer>().sprite = bPawn; break;
            case "bRook": this.GetComponent<SpriteRenderer>().sprite = bRook; break;
            case "bBishop": this.GetComponent<SpriteRenderer>().sprite = bBishop; break;
            case "bKnight": this.GetComponent<SpriteRenderer>().sprite = bKnight; break;

            case "wQueen": this.GetComponent<SpriteRenderer>().sprite = wQueen; break;
            case "wKing": this.GetComponent<SpriteRenderer>().sprite = wKing; break;
            case "wPawn": this.GetComponent<SpriteRenderer>().sprite = wPawn; break;
            case "wRook": this.GetComponent<SpriteRenderer>().sprite = wRook; break;
            case "wBishop": this.GetComponent<SpriteRenderer>().sprite = wBishop; break;
            case "wKnight": this.GetComponent<SpriteRenderer>().sprite = wKnight; break;
        }
    }

    public void SetCords()
    {
        float x = xBoard;
        float y = yBoard;

        x = (x * 1f) - 3.5f;
        y = (y * 1f) - 3.5f;

        this.transform.position = new Vector3(x, y, -1.0f);
    }

    public int GetXBoard()
    {
        return xBoard;
    }
    public int GetYBoard()
    {
        return yBoard;
    }

    public void SetXBoard(int x)
    {
        xBoard = x;
    }
    public void SetyBoard(int y)
    {
        yBoard = y;
    }

}

