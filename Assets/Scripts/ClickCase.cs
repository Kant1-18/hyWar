using UnityEngine;

public class ClickCase : MonoBehaviour
{
    public string caseName;
    // Cette méthode est appelée automatiquement quand l'objet est cliqué
    private void OnMouseDown()
    {
        Debug.Log(gameObject.name + caseName + " a été cliqué !");
        // Ajoute ici le comportement souhaité lors du clic.
    }
}
