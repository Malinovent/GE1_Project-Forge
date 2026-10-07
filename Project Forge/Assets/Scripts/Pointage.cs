using UnityEngine;

public class Pointage : MonoBehaviour
{
    [SerializeField] private int points; //Combien point ca donne
    [SerializeField] private PointageUI pointageUI; //Reference au UI

    //Testing
    private void OnDestroy()
    {
        pointageUI.SetText(points);
    }
}