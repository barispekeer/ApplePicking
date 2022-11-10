using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BasketControl : MonoBehaviour
{
    public TMP_Text scoreTxt, timeTxt;
    int score;
    float time = 30f;
    int speed = 10;
    void Start()
    {
        Time.timeScale = 1;
    }


    void Update()
    {
        if (time >=0)
        {
            time -= Time.deltaTime;
            timeTxt.text = "TIME:" + (int)time;
        }
        else
        {
            Time.timeScale = 0;
        }
       
        float xMove = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(xMove * Time.deltaTime * speed, 0, 0));
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("Apple"))
        {
            score++;
            scoreTxt.text = "SCORE: " + score;
            float random = Random.Range(-3.5f, 11.4f);
            collision.transform.position = new Vector3(random, 8.3f, -7.2f);
        }
    }
}
