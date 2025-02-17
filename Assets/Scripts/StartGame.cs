using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour
{
    public int Score;
    public int Coins;

    public int Difficulty;
    public int EnemiesTime;

    public GameObject PrefabGenerator;
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


        //init Prefabs
        //GlobalVariables.PrefabGenerator = PrefabGenerator;
        //GlobalVariables.PrefabShield = PrefabShield;

        GlobalVariables.PrefabShip1 = PrefabShip1;
        GlobalVariables.PrefabShip2 = PrefabShip2;
        GlobalVariables.PrefabShip3 = PrefabShip3;

        GlobalVariables.PrefabEnemy1 = PrefabEnemy1;
        GlobalVariables.PrefabEnemy2 = PrefabEnemy2;
        GlobalVariables.PrefabEnemy3 = PrefabEnemy3;
    }
}
