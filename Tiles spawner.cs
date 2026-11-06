using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    public GameObject roadPrefab;
    public Transform player;

    public float segmentLength = 30f;
    private float nextSpawnZ = 0f;

    void Start()
    {
        for (int i = 0; i < 5; i++)
            SpawnRoad();
    }

    void Update()
    {
        if (player.position.z + 60f > nextSpawnZ)
            SpawnRoad();
    }

    void SpawnRoad()
    {
        Vector3 position = new Vector3(
            0, -0.5f, nextSpawnZ + segmentLength / 2
        );

        Instantiate(roadPrefab, position, Quaternion.identity);
        nextSpawnZ += segmentLength;
    }
}
