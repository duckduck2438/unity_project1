using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update


    int hp = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {

            hp -= 20;
            if(hp <= 0)
            {
                print("게임오버");

            }
            else
            {
                Debug.Log("현재 체력은" + hp + "입니다");
            }

        }   
    }
}
