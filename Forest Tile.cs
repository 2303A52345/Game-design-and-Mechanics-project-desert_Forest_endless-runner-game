
using UnityEngine;

public class ForestTile : MonoBehaviour
{
    public GameObject[] obstacles;
    public GameObject coinPrefab;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            int lane = Random.Range(0, 3);
            int obstacle = Random.Range(0, obstacles.Length);

            float x = (lane - 1) * 3f;
            float z = Random.Range(5f, 27f);

            Instantiate(
                obstacles[obstacle],
                transform.position + new Vector3(x, 1f, z),
                Quaternion.identity,
                transform
            );
        }

        for (int i = 0; i < 8; i++)
        {
            int lane = Random.Range(0, 3);
            float x = (lane - 1) * 3f;
            float z = Random.Range(5f, 27f);

            Instantiate(
                coinPrefab,
                transform.position + new Vector3(x, 1.5f, z),
                Quaternion.identity,
                transform
            );
        }
    }
}
