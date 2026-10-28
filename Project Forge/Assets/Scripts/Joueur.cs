using UnityEngine;

public class Joueur : MonoBehaviour
{

    public Transform pointTir;
    public GameObject projectile;
    public float vitesse = 0.1f;
    public Animator animator;

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
        {
            transform.position -= new Vector3(vitesse, 0, 0);
            //animator.SetBool("isLeft", true);
        }
        /*else
        {
            animator.SetBool("isLeft", false);
        }*/
        if(Input.GetKeyDown(KeyCode.A))
        {
            animator.Play("GAUCHE");
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.Play("IDLE");
        }


        //Droite
        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(vitesse, 0, 0);
        

        if(Input.GetKeyDown(KeyCode.Space))
            SpawnProjectile();


    }

    private void SpawnProjectile()
    {
        Instantiate(projectile, pointTir.position, Quaternion.identity);
    }

}
