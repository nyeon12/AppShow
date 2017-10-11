using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject[] CreatFireBall = new GameObject[3];
    public float randomX;
    public float randomSeconds;
    public GameObject GameOverBg;

    private void Start()
    {

        StartCoroutine(ObjectRandomGenerator());
    }
    
    IEnumerator ObjectRandomGenerator()
    {
       
        while (true)
        {
            randomX = Random.Range(-1.7f, 2f);
            randomSeconds = Random.Range(1f,2f);

            Instantiate(CreatFireBall[Random.Range(0, 3)] ,new Vector2(randomX, 7f) ,Quaternion.identity);
            yield return new WaitForSeconds(randomSeconds);
        }
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Rocket")
        {
            GameOverBg.SetActive(true);
        }
    }

}
