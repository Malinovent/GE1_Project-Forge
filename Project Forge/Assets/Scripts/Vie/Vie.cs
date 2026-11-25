using UnityEngine;

public class Vie : MonoBehaviour
{
    [SerializeField] private int vieMax = 5;
    [SerializeField] private AudioClip audioClip;
    [SerializeField] private GameObject SFX;

    private int vieActuelle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FullHeal();
    }

    public void FullHeal()
    {
        vieActuelle = vieMax;
    }

    public void PrendsDegats(int degats)
    {
        Debug.Log("Vie actuelle : " + vieActuelle);
        vieActuelle -= degats;

        if(vieActuelle <= 0)
        {
            GameObject sfx = Instantiate(SFX, transform.position, Quaternion.identity);

            AudioSource audioSource = sfx.GetComponent<AudioSource>();

            audioSource.clip = audioClip;
            audioSource.Play();
            Dispose();
        }
    }

    private void Dispose()
    {
        Destroy(this.gameObject);
    }
}
