using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMovement : MonoBehaviour
{
    // Variables
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    Vector2 targetPosition;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = GetRandomPosition();
    }


    void Update()
    {
        // Move to random place
        if ((Vector2)transform.position != targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed);
        }
        else
        {
            targetPosition = GetRandomPosition();
        }
    }
    Vector2 GetRandomPosition()
    {
        // Get random position on screen
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxX);
        return new Vector2(randomX, randomY);
    }
}
