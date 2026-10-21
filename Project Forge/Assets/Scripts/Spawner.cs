using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnObjet;
    [SerializeField] private float spawnInterval = 5;

    private float tempsPasse = 0;

    private void Update()
    {
        tempsPasse += Time.deltaTime;
        if (tempsPasse >= spawnInterval)
        {
            tempsPasse = 0;
            Spawn();
        }
    }

    private void Spawn()
    {
        Instantiate(spawnObjet, transform.position, Quaternion.identity);
    }
}
