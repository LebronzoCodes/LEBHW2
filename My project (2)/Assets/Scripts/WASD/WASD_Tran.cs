using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_Tran : MonoBehaviour
{

    //Variables

    public float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Find position of the object every frame, then create a vector
        Vector2 pos = transform.position;

        //If I press 'D', move my position to the right
        if(Input.GetKey(KeyCode.RightArrow)) 
        {
            pos.x += speed * Time.deltaTime;
        }

        //If I press 'A', move my position to the left
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
        }

        //If I press 'W', move my position upwards

        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += speed * Time.deltaTime;
        }

        //If I press 'S', move my position downwards
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.y -= speed * Time.deltaTime;
        }

        //What allows us to move our object relative to pos
        transform.position = pos;
    }
}
