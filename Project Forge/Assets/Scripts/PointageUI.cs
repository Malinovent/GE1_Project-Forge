using UnityEngine;
using TMPro;

public class PointageUI : MonoBehaviour
{
    [SerializeField] private TMP_Text text;

    public void SetText(int score)
    {
        text.SetText(score.ToString());
    }
}
