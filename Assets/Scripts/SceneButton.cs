using UnityEngine;

public class SceneButton : MonoBehaviour
{
    public void ToTitle()
    {
        SceneController.LoadTitle();
    }

    public void ToMain()
    {
        SceneController.LoadMain();
    }

    public void ToGoal()
    {
        SceneController.LoadGoal();
    }

    public void ToGameOver()
    {
        SceneController.LoadGameOver();
    }
}
