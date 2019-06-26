using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        SpawnDefenders();
    }

    public void setSelectDefender(Defender defenderSelect)
    {
        this.defender = defenderSelect;
    }

    private Vector2 GetSquareClick()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        worldPos = putInSquare(worldPos);

        return worldPos;
    }

    private Vector2 putInSquare(Vector2 floatWorldPos)
    {
        float newX = Mathf.RoundToInt(floatWorldPos.x);
        float newY = Mathf.RoundToInt(floatWorldPos.y);

        return new Vector2(newX, newY);
    }

    private void SpawnDefenders()
    {
        if (defender)
        {
            Defender newDefender = Instantiate(defender, GetSquareClick(), Quaternion.identity) as Defender;
        }
        
    }
}
