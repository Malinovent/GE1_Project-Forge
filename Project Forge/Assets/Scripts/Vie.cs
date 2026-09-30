using UnityEngine;

public class Vie : MonoBehaviour
{
    [SerializeField] private int vieMax = 5;
    
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
            Dispose();
        }
    }

    private void Dispose()
    {
        Destroy(this.gameObject);
    }
}
