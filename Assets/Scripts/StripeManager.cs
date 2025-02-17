using UnityEngine;
using UnityEngine.UI;

public class StripeManager : MonoBehaviour
{
    public string selectedStripe = "None";

    public Button generatorButton;
    public Button shipButton;
    public Button shieldButton;

    public GameObject generatorPrefab;
    public GameObject shipPrefab;
    public GameObject shieldPrefab;

    public Transform gridParent;

    private void Start()
    {
        generatorButton.onClick.AddListener(() => HandleButtonClick("Generator"));
        shipButton.onClick.AddListener(() => HandleButtonClick("Ship"));
        shieldButton.onClick.AddListener(() => HandleButtonClick("Shield"));
    }

    private void HandleButtonClick(string type)
    {
        GameObject prefabToPlace = GetPrefabByType(type);
        PlaceStripe(prefabToPlace);
    }

    private GameObject GetPrefabByType(string type)
    {
        switch (type)
        {
            case "Generator":
                return generatorPrefab;
            case "Ship":
                return shipPrefab;
            case "Shield":
                return shieldPrefab;
            default:
                return null;
        }
    }

    private void PlaceStripe(GameObject prefab)
    {
        if (prefab != null && gridParent != null)
        {
            Instantiate(prefab, gridParent.position, Quaternion.identity, gridParent);
        }
    }
}
