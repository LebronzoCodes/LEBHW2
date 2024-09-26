using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_Tran : MonoBehaviour
{

    //Variables

    public float speed = 3f;
    public GameObject pl2;
    private bool spawn = true;
   
    //public GameManager gameManager;

    // Awake happens on spawn of an Item
    private void Awake()
    {
        pl2 = this.gameObject;
        //gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
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
        */

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Only spawn if true
        if (spawn) 
        {
        spawn = false;
            
            if (collision.transform.tag == "Player")
            {
                //gameManager.sc_num++;
                GameManager.instance.sc_num++;
            }
            else if (collision.transform.tag == "Player 3")
            {
                //gameManager.p3sc_num++;
                GameManager.instance.p3sc_num++;
            }
            
        var pos = new Vector2(Random.Range(-10f, 10f), Random.Range(-3.3f, 3.3f));
        Instantiate(pl2, pos, Quaternion.identity);

        //Destroy Player
        Destroy(this.gameObject); 
        
        }
        
    }
    //Bounds: x (-10f, 10f) y(-3.3f , 3.3f)
}
