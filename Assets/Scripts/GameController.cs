using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Variables related to spawning blockers
    public GameObject blocker;
    public Vector3 spawnPoint1;
    public Vector3 spawnPoint2;
    public int blockerCount;
    public float startWait;
    public float spawnWait;
    public float waveWait;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBlockers());
    }

    private IEnumerator SpawnBlockers()
    {
        // Wait before first wave
        yield return new WaitForSeconds(startWait);

        while (true)
        {
            //Spawn blockers
            for (int i = 0; i < blockerCount; i++)
            {
                Vector3 spawnPosition = new Vector3(spawnPoint1.x, Random.Range(spawnPoint2.y, spawnPoint1.y), spawnPoint1.z);

                Instantiate(blocker, spawnPosition, Quaternion.identity);

                // Wait before next blocker
                yield return new WaitForSeconds(spawnWait);
            }

            // Next blockers spawn in a moment
            yield return new WaitForSeconds(waveWait);
        }
    }
}
