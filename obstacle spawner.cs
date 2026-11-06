using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Transform player;

    void Update()
    {
        if (Random.value < 0.02f)
        {
            int lane = Random.Range(0, 3);

            float x = (lane - 1) * 3f;
            float z = player.position.z + 60f;

            Instantiate(
                obstaclePrefab,
                new Vector3(x, 1f, z),
                Quaternion.identity
            );
        }
    }
}
