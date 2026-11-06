using UnityEngine;

public class CoinController : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 180 * Time.deltaTime, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.score += 10;
            Destroy(gameObject);
        }
    }
}
