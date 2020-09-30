using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class BoardManager : MonoBehaviour
{

    [SerializeField]
    private int boardSizeX = 8;
    [SerializeField]
    private int boardSizeY = 8;

    [SerializeField]
    private Transform boardContainer;

    [SerializeField]
    private Sprite backgroundTileSprite;

    [SerializeField]
    private Tile tilePrefab;
    [SerializeField]
    private Vector2 tileSize;


    private Tile[,] board;


    // Start is called before the first frame update
    void Start()
    {
        if(tilePrefab != null)
        {
            tileSize = tilePrefab.GetSpriteBounds();
        }

        InitBoard();
    }

    private void InitBoard()
    {
        board = new Tile[boardSizeX, boardSizeY];
        for(int x = 0 ; x < boardSizeX; x++)
        {
            for (int y = 0; y < boardSizeY; y++)
            {
                var newTile = Instantiate<Tile>(tilePrefab, boardContainer) as Tile;

                newTile.SetPosition(x * tileSize.x, y * tileSize.y);
                newTile.SetSprite(backgroundTileSprite);

                board[x, y] = newTile;
            }
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
