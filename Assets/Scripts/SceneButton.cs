using UnityEngine;

public class SceneButton : MonoBehaviour
{
    public void ToTitle()
    {
        AudioManager.Instance.PlaySE(AudioManager.Instance.buttonSE);
        SceneController.LoadTitle();
    }

    public void ToMain()
    {
        AudioManager.Instance.PlaySE(AudioManager.Instance.buttonSE);
        SceneController.LoadMain();
    }

    public void ToGoal()
    {
        AudioManager.Instance.PlaySE(AudioManager.Instance.buttonSE);
        SceneController.LoadGoal();
    }

    public void ToGameOver()
    {
        AudioManager.Instance.PlaySE(AudioManager.Instance.buttonSE);
        SceneController.LoadGameOver();
    }
}
