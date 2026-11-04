using UnityEngine;

//Tire un projectile à toutes les quelques secondes
public class EnnemiTireur : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform pointTir;
    [SerializeField] private float intervalleTir = 2f;

    private float tempsPasse = 0;

    // Update is called once per frame
    void Update()
    {
        tempsPasse += Time.DeltaTime;

        if (tempsPasse >= intervalleTir)
        {
            tempsPasse = 0;
            Tirer();
        }
    }

    private void Tirer()
    {
        //Crée une copie du projectile au point de tir
        Instanciate(projectile, pointTir.position, Quaternion.identity);
    }
}
