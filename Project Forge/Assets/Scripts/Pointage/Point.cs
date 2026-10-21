using UnityEngine;

public class Point : MonoBehaviour
{
    [SerializeField] private int points = 0;
    //[SerializeField] private PointageUI pointageUI;

    private void DonnePoints()
    {
        //pointageUI.AddPoints(points);
        //GameObject.Find("Score Container").GetComponent<PointageUI>().AddPoints(points);
        //GameObject.FindFirstObjectByType<PointageUI>().AddPoints(points);
        PointageUI.Singleton.AddPoints(points);
    }

    private void OnDestroy()
    {
        DonnePoints();
    }
}
