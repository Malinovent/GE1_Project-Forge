using UnityEngine;

//Change la couleur du sprite de l'ennemi
//Permet de créer de nouvelles variantes sans nouveaux dessins
public class EnnemiTeinte : MonoBehaviour
{
    [SerializeField] private Color teinte = Color.white;

    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        spriteRenderer.color = teinte;
    }
}
