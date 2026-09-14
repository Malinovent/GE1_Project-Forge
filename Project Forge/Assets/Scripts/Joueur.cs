using UnityEngine;

public class Joueur : MonoBehaviour
{
    public float vitesse = 0.1f;

    private float yPos = 0;

    // Update is called once per frame
    void Update()
    {
        //Haut
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, vitesse, 0);
        }

        //Bas
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, vitesse, 0);
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
