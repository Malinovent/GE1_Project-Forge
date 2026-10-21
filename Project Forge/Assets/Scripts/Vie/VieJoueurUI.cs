using UnityEngine;

public class VieJoueurUI : MonoBehaviour
{
    [SerializeField] private int vieMax = 5;
    [SerializeField] private int vieCommence = 3;

    [SerializeField] private GameObject[] vieImages;
    
    private int vieActuel = 0;

    private void Start()
    {
        vieActuel = vieCommence;
        UpdateUI();
    }


    //TESTING
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            RemoveLife();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            AddLife();
        }
    }

    public void AddLife()
    {
        vieActuel++;
        if(vieActuel > vieMax)
        {
            vieActuel = vieMax;
        }

        UpdateUI();
    }

    public void RemoveLife()
    {
        vieActuel--;
        if(vieActuel < 0)
        {
            vieActuel = 0;
            Debug.Log("Game Over!");
            //GameOVER!!!
        }

        UpdateUI();
    }

    void UpdateUI()
    {
        for(int i = 0; i < vieImages.Length; i++)
        {
            vieImages[i].SetActive(i < vieActuel);
        }
    }
}
