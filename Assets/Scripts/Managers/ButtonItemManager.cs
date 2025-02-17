using UnityEngine;

public class ButtonItemManager : MonoBehaviour
{
    public void Ship1()
    {
        GlobalVariables.FriendObject = "ship1";
        Debug.Log("Vous avez sélectionnez " + GlobalVariables.FriendObject);
    }

    public void Ship2()
    {
        GlobalVariables.FriendObject = "ship2";
        Debug.Log("Vous avez sélectionnez ship2");
    }

    public void Ship3()
    {
        GlobalVariables.FriendObject = "ship3";
        Debug.Log("Vous avez sélectionnez ship3");
    }

    public void Shield()
    {
        GlobalVariables.FriendObject = "shield";
        Debug.Log("Vous avez sélectionnez shield");
    }

    public void generator()
    {
        GlobalVariables.FriendObject = "generator";
        Debug.Log("Vous avez sélectionnez generator");
    }
}
