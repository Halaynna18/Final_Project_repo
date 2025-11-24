using Unity.VisualScripting;
using UnityEngine;

public class ProjectileSpawnManager : MonoBehaviour
{
    public GameObject[] projectilePrefabs;
    private float spawnLimitXLeft = -10;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 20f;
    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;
    private float topBound = 30;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
        Invoke("SpawnRandomProjectile", startDelay);
    }
    void SpawnRandomProjectile()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int projectileIndex = Random.Range(0, projectilePrefabs.Length);

        Instantiate(projectilePrefabs[projectileIndex], spawnPos, projectilePrefabs[projectileIndex].transform.rotation);

        spawnInterval = Random.Range(0.3f, 3.0f);
        Invoke("SpawnRandomProjectile", spawnInterval);
    }
    // Update is called once per frame
    void Update()
    {
      if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
    }
}
