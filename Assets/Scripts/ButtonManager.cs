using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public string selectedStripe = "None";

    public Button generatorButton;
    public Button shipButton;
    public Button shieldButton;

    public GameObject generatorPrefab;
    public GameObject shipPrefab;
    public GameObject shieldPrefab;

    private void Start()
    {
        generatorButton.onClick.AddListener(() => SelectStripe("Generator"));
        shipButton.onClick.AddListener(() => SelectStripe("Ship"));
        shieldButton.onClick.AddListener(() => SelectStripe("Shield"));
    }

    private void SelectStripe(string type)
    {
        selectedStripe = type;
        Debug.Log("Selected: " + type);
    }

    public void PlaceStripe(Vector2 position)
    {
        if (selectedStripe == "None") return;

        GameObject prefabToPlace = null;

        switch (selectedStripe)
        {
            case "Generator":
                prefabToPlace = generatorPrefab;
                break;
            case "Ship":
                prefabToPlace = shipPrefab;
                break;
            case "Shield":
                prefabToPlace = shieldPrefab;
                break;
        }

        if (prefabToPlace != null)
        {
            Instantiate(prefabToPlace, position, Quaternion.identity);
        }
    }
}
