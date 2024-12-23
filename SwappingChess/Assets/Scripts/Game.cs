using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject chessPiece;


    private GameObject[,] positions = new GameObject[8,8];
    private GameObject[] blackPlayer = new GameObject[16];
    private GameObject[] whitePlayer = new GameObject[16];

    private string currentPlayer = "white";

    private bool gameOver = false;

    public void Start()
    {

        whitePlayer = new GameObject[] {
        Create("wRook", 0, 0), Create("wKnight", 1, 0), Create("wBishop", 2, 0), Create("wQueen", 3, 0),
        Create("wKing", 4, 0), Create("wBishop", 5, 0), Create("wKnight", 6, 0), Create("wRook", 7, 0),
        Create("wPawn", 0, 1), Create("wPawn", 1, 1), Create("wPawn", 2, 1), Create("wPawn", 3, 1),
        Create("wPawn", 4, 1), Create("wPawn", 5, 1), Create("wPawn", 6, 1), Create("wPawn", 7, 1)
        };

        blackPlayer = new GameObject[] {
        Create("bRook", 0, 7), Create("bKnight", 1, 7), Create("bBishop", 2, 7), Create("bQueen", 3, 7),
        Create("bKing", 4, 7), Create("bBishop", 5, 7), Create("bKnight", 6, 7), Create("bRook", 7, 7),
        Create("bPawn", 0, 6), Create("bPawn", 1, 6), Create("bPawn", 2, 6), Create("bPawn", 3, 6),
        Create("bPawn", 4, 6), Create("bPawn", 5, 6), Create("bPawn", 6, 6), Create("bPawn", 7, 6)
        };

        for (int i = 0; i < whitePlayer.Length; i++)
        {
            setPosition(whitePlayer[i]);
            setPosition(blackPlayer[i]);
        }
    }

    public GameObject Create(string name, int x, int y)
    {
        GameObject obj = Instantiate(chessPiece, new Vector3(0, 0, -1), Quaternion.identity);
        PlayerController cm = obj.GetComponent<PlayerController>();
        cm.name = name;
        cm.SetXBoard(x); 
        cm.SetyBoard(y);
        cm.Activate();
        return obj;
    }

    public void setPosition(GameObject obj)
    {
        PlayerController cm = obj.GetComponent<PlayerController>();

        positions[cm.GetXBoard(), cm.GetYBoard()] = obj;
    }

}
