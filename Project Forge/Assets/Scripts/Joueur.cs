using UnityEngine;

public class Joueur : MonoBehaviour
{
    public Collider2D collider;
    public float vitesse = 0.1f;

    private float yPos = 0;

    // Update is called once per frame
    void Update()
    {
        //Haut
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, vitesse, 0);
            //GetComponent<Transform>().position += new Vector3(0, vitesse, 0);

            //Collider2D collider = GetComponent<Collider2D>();
            collider.isTrigger = true;
        }

        //Bas
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, vitesse, 0);

            //GetComponent<Collider2D>().isTrigger = false;
            collider.isTrigger = false;
        }

        //Gauche
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(vitesse,0 , 0);
        }

        //Droite
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(vitesse,0, 0);
        }

    }

}
