using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class MoveShape : MonoBehaviour
{
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;
    public Vector2 speed;
    public double speed1D;
    float delay;

    bool gotOutYmin = true;
    bool gotOutYmax = true;

    bool gotOutXmin = true;
    bool gotOutXmax = true;

    // Start is called before the first frame update
    void Start()
    {
        speed1D = 1;
    }
    
    // Update is called once per frame
    void Update(){   
        CheckY();
        CheckX();

        transform.position = Vector2.MoveTowards(transform.position, GetNewPosition(), (float)speed1D * Time.deltaTime);

        speed1D *= 1.002;

    }

    Vector2 GetNewPosition(){
        double xPos = transform.position.x + speed.x;
        double yPos = transform.position.y + speed.y;
        return new Vector2((float)xPos, (float)yPos);
    }
        
    void CheckY(){

        if(transform.position.y > yMax && gotOutYmax){
            speed.y = -speed.y;
            gotOutYmax = false; //(1,2,3,4,5,6,7) Without these checks, at higher speeds, the shapes might get stuck outside the playing area.
        }else if(!(transform.position.y > yMax))
            gotOutYmax = true; //1

        if(transform.position.y < yMin && gotOutYmin){
            speed.y = -speed.y;
            gotOutYmin = false; //2
        }else if(!(transform.position.y < yMin))
            gotOutYmin = true; //3
      
    }
    void CheckX(){

        if(transform.position.x > xMax && gotOutXmax){
            speed.x = -speed.x;
            gotOutXmax = false; //4
        }else if(!(transform.position.x > xMax))
            gotOutXmax = true; //5

        if(transform.position.x < xMin && gotOutXmin){
            speed.x = -speed.x;
            gotOutXmin = false; //6
        }else if(!(transform.position.x < xMin))
            gotOutXmin = true; //7

    }
}
