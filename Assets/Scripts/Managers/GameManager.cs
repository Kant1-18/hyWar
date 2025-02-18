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
