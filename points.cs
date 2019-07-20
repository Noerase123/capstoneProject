using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class points : MonoBehaviour {

    public GameObject puntos;
    public Vector2 speedMinMax;
    float speed;

    float visibleHeightThreshold;

    void Start()
    {
        speed = Mathf.Lerp(speedMinMax.x, speedMinMax.y, Difficulty.GetDifficultyPercent());
        visibleHeightThreshold = -Camera.main.orthographicSize - transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.Self);
        if (transform.position.y < visibleHeightThreshold)
        {
            score();
            
        }
    }

    void score()
    {
        puntos.SetActive(true);
        Destroy(gameObject);
        
       
    }
}
