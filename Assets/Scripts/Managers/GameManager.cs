using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public int Score;
    public int Coins;

    public int Difficulty;
    public int EnemiesTime;
    public int EnemiesSpeed;
    public int GeneratorTime;
    public int Ship1Cost;
    public int Ship2Cost;
    public int Ship3Cost;
    public int ShieldCost;
    public int GeneratorCost;

    public int EnemiesLife1;
    public int EnemiesLife2;
    public int EnemiesLife3;
    public int EnemiesAttack1;
    public int EnemiesAttack2;
    public int EnemiesAttack3;

    public int ShipAttack1;
    public int ShipAttack2;
    public int ShipAttack3;
    public int ShipLife1;
    public int ShipLife2;
    public int ShipLife3;

    public GameObject PrefabGeneratorEmpty;
    public GameObject PrefabGeneratorFull;
    public GameObject PrefabShield;
    public GameObject PrefabShip1;
    public GameObject PrefabShip2;
    public GameObject PrefabShip3;
    public GameObject PrefabEnemy1;
    public GameObject PrefabEnemy2;
    public GameObject PrefabEnemy3;

    void Start()
	{
        //init constantes
        GlobalVariables.Score = Score;
        GlobalVariables.Coins = Coins;
        GlobalVariables.GeneratorTime = GeneratorTime;

        GlobalVariables.Difficulty = Difficulty;
        GlobalVariables.EnemiesTime = EnemiesTime;
        GlobalVariables.EnemiesSpeed = EnemiesSpeed;
        GlobalVariables.ShieldCost = ShieldCost;
        GlobalVariables.GeneratorCost = GeneratorCost;
        GlobalVariables.Ship1Cost = Ship1Cost;
        GlobalVariables.Ship2Cost = Ship2Cost;
        GlobalVariables.Ship3Cost = Ship3Cost;

        GlobalVariables.EnemiesLife1 = EnemiesLife1;
        GlobalVariables.EnemiesLife2 = EnemiesLife2;
        GlobalVariables.EnemiesLife3 = EnemiesLife3;

        GlobalVariables.ShipAttack1 = ShipAttack1;
        GlobalVariables.ShipAttack2 = ShipAttack2;
        GlobalVariables.ShipAttack3 = ShipAttack3;

        //init Prefabs
        GlobalVariables.PrefabGeneratorEmpty = PrefabGeneratorEmpty;
        GlobalVariables.PrefabGeneratorFull = PrefabGeneratorFull;

        GlobalVariables.PrefabShield = PrefabShield;

        GlobalVariables.PrefabShip1 = PrefabShip1;
        GlobalVariables.PrefabShip2 = PrefabShip2;
        GlobalVariables.PrefabShip3 = PrefabShip3;

        GlobalVariables.PrefabEnemy1 = PrefabEnemy1;
        GlobalVariables.PrefabEnemy2 = PrefabEnemy2;
        GlobalVariables.PrefabEnemy3 = PrefabEnemy3;

        GlobalVariables.isFirstObjectSpawned = false;
        GlobalVariables.isActivePortal1 = false;
        GlobalVariables.isActivePortal2 = false;
        GlobalVariables.isActivePortal3 = false;
        GlobalVariables.isActivePortal4 = false;
    }
}
