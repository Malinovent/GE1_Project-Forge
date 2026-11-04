using UnityEngine;

//Tourne le visuel de l'ennemi pour qu'il regarde toujours le joueur
public class EnnemiRegardeJoueur : MonoBehaviour
{
    [SerializeField] private Transform visuel;

    private Transform joueur;

    void Start()
    {
        //Trouve le joueur avec son tag
        GameObject objetJoueur = GameObject.FindWithTag("Player");

        if (objetJoueur != null)
        {
            joueur = objetJoueur.transform;
        }

    }

 

    // Update is called once per frame
    void Update()
    {
        if (joueur == null)
            return;
       
        //Direction de l'ennemi vers le joueur
        Vector3 direction = joueur.position - visuel.position;

        //Angle de cette direction, en degrés
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //Le sprite de l'ennemi pointe vers le bas, donc on ajoute 90 degrés
        visuel.rotation = Quaternion.Euler(0, 0, angle + 90);
        
    }
}
