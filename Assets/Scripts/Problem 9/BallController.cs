using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5;
    [SerializeField]
    private GameObject panel;
    private float minX = -9, maxX = 9, minY = -5, maxY = 5;
    private Vector2 mosPos;
    public Text scoreText;
    private int score;
    private float x;
    private float y;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        mosPos = Input.mousePosition;
        mosPos = Camera.main.ScreenToWorldPoint(mosPos);
        scoreText.text = "Score : " + score.ToString();
        if(gameObject.transform.localScale.x<0.1 && gameObject.transform.localScale.y < 0.1)
        {
            gameover();
        }

        if (Input.GetMouseButtonDown(0))
        {
            // reload
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void FixedUpdate()
    {        
        if (mosPos.x > minX && mosPos.x < maxX && mosPos.y > minY && mosPos.y < maxY)
        {
            transform.position = Vector2.MoveTowards(transform.position, mosPos, speed * Time.deltaTime);
        }
        else
        {
            return;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            score++;
            x+=0.1f;
            y+=0.1f;
        }
        else
        {
            x -= 0.1f;
            y -= 0.1f;
        }
        gameObject.transform.localScale = new Vector3(x, y, 0);
    }

    void gameover()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }
}
