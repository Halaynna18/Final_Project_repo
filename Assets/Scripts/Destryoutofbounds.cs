using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Destryoutofbounds : MonoBehaviour
{
    private float topBound = 20f;
    private float lowerBound = -10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
            if (transform.position.z < lowerBound)
            {
                Debug.Log("game over!");
                Destroy(gameObject);
            }
        }
    }
}
