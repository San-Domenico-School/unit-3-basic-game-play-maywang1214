using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfScene : MonoBehaviour
{
    private float upperBound = 30.0f;
    private float lowerBound = -15.0f;

    // Start is called before the first frame update
    void Start()
    {
        //to be implemented
    }

    // Update is called once per frame
    void Update()
    {
        DestroyOutOfBounds();
    }

    private void DestroyOutOfBounds()
    {
        if (gameObject.transform.position.z > upperBound)
        {
            Destroy(gameObject);
        }
        if (gameObject.transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
    }
}
