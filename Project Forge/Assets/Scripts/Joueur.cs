using UnityEngine;

public class Joueur : MonoBehaviour
{

    public Transform pointTir;
    public GameObject projectile;
    public float vitesse = 0.1f;

    // Update is called once per frame
    void Update()
    {
        //Haut
        if(Input.GetKey(KeyCode.W))
            transform.position += new Vector3(0, vitesse, 0);
        
        //Bas
        if (Input.GetKey(KeyCode.S))
            transform.position -= new Vector3(0, vitesse, 0);
        

        //Gauche
        if (Input.GetKey(KeyCode.A))
            transform.position -= new Vector3(vitesse,0 , 0);
        

        //Droite
        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(vitesse,0, 0);
        

        if(Input.GetKeyDown(KeyCode.Space))
            SpawnProjectile();


    }

    private void SpawnProjectile()
    {
        Instantiate(projectile, pointTir.position, Quaternion.identity);
    }

}
