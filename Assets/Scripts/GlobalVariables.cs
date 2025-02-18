using UnityEngine;

public class GlobalVariables: MonoBehaviour
{
    public static int Score { get; set; }
    public static int Coins { get; set; }

    public static int Difficulty { get; set; } // de 1 à 3
    public static int EnemiesTime { get; set; }
    public static int EnemiesSpeed { get; set; }

    public static int EnemiesLife1 { get; set; }
    public static int EnemiesLife2 { get; set; }
    public static int EnemiesLife3 { get; set; }
    public static int EnemiesAttack1 { get; set; }
    public static int EnemiesAttack2 { get; set; }
    public static int EnemiesAttack3 { get; set; }

    public static int ShipLife1 { get; set; }
    public static int ShipLife2 { get; set; }
    public static int ShipLife3 { get; set; }
    public static int ShipAttack1 { get; set; }
    public static int ShipAttack2 { get; set; }
    public static int ShipAttack3 { get; set; }

    public static GameObject PrefabShip1 { get; set; }
    public static GameObject PrefabShip2 { get; set; }
    public static GameObject PrefabShip3 { get; set; }
    public static GameObject PrefabShield { get; set; }
    public static GameObject PrefabGeneratorEmpty { get; set; }
    public static GameObject PrefabGeneratorFull { get; set; }
    public static GameObject PrefabEnemy1 { get; set; }
    public static GameObject PrefabEnemy2 { get; set; }
    public static GameObject PrefabEnemy3 { get; set; }

    public static string FriendObject { get; set; }
}
