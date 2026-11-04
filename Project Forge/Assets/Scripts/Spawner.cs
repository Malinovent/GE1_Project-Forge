using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnObjets;
    [SerializeField] private float spawnInterval = 5;
    [SerializeField] private float largeurSpawn = 8;

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
        //Choisit un objet au hasard dans la liste
        int index = Random.Range(0, spawnObjets.Length);

        //Choisit une position X au hasard en haut de l'écran
        float x = Random.Range(-largeurSpawn / 2, largeurSpawn / 2);
        Vector3 position = transform.position + new Vector3(x, 0, 0);

        Instantiate(spawnObjets[index], position, Quaternion.identity);
    }
}
