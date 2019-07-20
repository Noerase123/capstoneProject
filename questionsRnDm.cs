using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class questionsRnDm : MonoBehaviour {

    public GameObject[] objectPool;
    private int currentIndex = 0;

    public void NewRandomObject()
    {
        int newIndex = Random.Range(0, objectPool.Length);
        // Deactivate old gameobject
        objectPool[currentIndex].SetActive(false);
        // Activate new gameobject
        currentIndex = newIndex;
        objectPool[currentIndex].SetActive(true);
    }
}
