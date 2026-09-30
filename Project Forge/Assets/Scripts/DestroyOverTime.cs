using UnityEngine;

public class DestroyOverTime : MonoBehaviour
{

    [SerializeField] private float tempsPourDetruireEnSecondes;

    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > tempsPourDetruireEnSecondes)
        {
           Dispose();
        }
    }

    private void Dispose()
    {
        Destroy(this.gameObject);
    }
}
