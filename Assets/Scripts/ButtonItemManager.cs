using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public void Ship1()
    {
        GlobalVariables.friendObject = "ship1";
    }

    public void Ship2()
    {
        GlobalVariables.friendObject = "ship2";
    }

    public void Ship3()
    {
        GlobalVariables.friendObject = "ship3";
    }

    public void Shield()
    {
        GlobalVariables.friendObject = "shield";
    }

    public void generator()
    {
        GlobalVariables.friendObject = "generator";
    }
}
