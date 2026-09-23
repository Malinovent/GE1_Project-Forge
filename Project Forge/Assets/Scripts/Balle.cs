using UnityEngine;

public class Balle : MonoBehaviour
{
    public float vitesse;
     
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, vitesse * Time.deltaTime, 0);
    }
}
