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

        GlobalVariables.Difficulty = Difficulty;
        GlobalVariables.EnemiesTime = EnemiesTime;
        GlobalVariables.EnemiesSpeed = EnemiesSpeed;

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
    }
}
