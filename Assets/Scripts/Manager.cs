using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace tw0pchess
{
    public class Manager : MonoBehaviour
    {
        private const float tileSize = 1.0f;
        private const float tileOffset = 0.5f;
        private int selectionX = -1;
        private int selectionY = -1;
        public List<GameObject> chessmanPrefabs;
        private Dictionary<Position, GameObject> activeChessman = new Dictionary<Position, GameObject>();
        private Board board = new Board();


        private void Start()
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    ChessPiece chessPiece = this.board.matrix[x, y];
                    if (chessPiece != null)
                    {

                        SpawnChessman(chessPiece.asset, new Position(x, y));
                    }
                }

            }

        }

        private void Update()
        {
            updateSelection();
            DrawChessBoard();


        }
        private void DrawChessBoard()
        {

            Vector3 widthLine = Vector3.right * 8;
            Vector3 heightLine = Vector3.forward * 8;

            for (int i = 0; i <= 8; i++)
            {
                Vector3 start = Vector3.forward * i;
                Debug.DrawLine(start, start + widthLine);
                for (int j = 0; j <= 8; j++)
                {
                    start = Vector3.right * j;
                    Debug.DrawLine(start, start + heightLine);
                }
            }
            //Draw selection
            if (selectionX >= 0 && selectionY >= 0)
            {
                Debug.DrawLine(
                    Vector3.forward * selectionY + Vector3.right * selectionX,
                    Vector3.forward * (selectionY + 1) + Vector3.right * (selectionX + 1));
                Debug.DrawLine(
                    Vector3.forward * (selectionY + 1) + Vector3.right * selectionX,
                    Vector3.forward * selectionY + Vector3.right * (selectionX + 1));
            }

        }
        private void updateSelection()
        {
            if (!Camera.main)
                return;
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 25.0f, LayerMask.GetMask("ChessPlane")))
                {
                    selectionX = (int)hit.point.x;
                    selectionY = (int)hit.point.z;
                    this.board.mouseClick(selectionX, selectionY, activeChessman);
                }
                else
                {
                    selectionX = -1;
                    selectionY = -1;

                }
            }
        }
        private void SpawnChessman(int index, Position position)
        {
            Vector3 vector = GetTileCenter(position.x, position.y);
            GameObject go = Instantiate(chessmanPrefabs[index], vector, Quaternion.identity) as GameObject;
            go.transform.SetParent(transform);

            activeChessman.Add(new Position(position.x, position.y), go);
        }
        private Vector3 GetTileCenter(int x, int y)
        {
            Vector3 origin = Vector3.zero;
            origin.x += (tileSize * x) + tileOffset;
            origin.z += (tileSize * y) + tileOffset;
            return origin;
        }
    }
}