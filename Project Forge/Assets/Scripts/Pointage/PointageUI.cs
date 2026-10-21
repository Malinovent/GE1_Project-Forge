using UnityEngine;
using TMPro;

public class PointageUI : MonoBehaviour
{
    [SerializeField] private TMP_Text pointsText;

    private int pointsTotal = 0;

    #region SINGLETON

    public static PointageUI Singleton;

    private void Awake()
    {
        if(Singleton == null)
        {
            Singleton = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    #endregion



    public void AddPoints(int points)
    {
        pointsTotal += points;
        UpdateUI();
    }

    private void UpdateUI()
    {
        //pointsText.text = pointsTotal.ToString();
        pointsText.SetText(pointsTotal.ToString());
    }
}
