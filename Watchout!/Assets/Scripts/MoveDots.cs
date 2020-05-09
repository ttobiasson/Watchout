using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDots : MonoBehaviour
{
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;
    public float speed;
    public Vector2 targetPosition;
    int frame;
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = GetRandomPosition();
        frame = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(frame > 100){
            targetPosition = GetRandomPosition();
            frame = 0;
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        frame++;
        
    }
    Vector2 GetRandomPosition(){
        float randomX = Random.Range(xMin, xMax);
        float randomY = Random.Range(yMin, yMax);
        return new Vector2(randomX, randomY);
    }
}
