using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// �V�[���J�ڂ𓝈�Ǘ����郆�[�e�B���e�B�N���X�B
/// </summary>
public static class SceneController
{
    private const string TITLE_SCENE = "Title";
    private const string MAIN_SCENE = "Main";
    private const string GOAL_SCENE = "Goal";
    private const string GAMEOVER_SCENE = "GameOver";

    /// <summary>�^�C�g����</summary>
    public static void LoadTitle() => SceneManager.LoadScene(TITLE_SCENE);

    /// <summary>���C���Q�[����</summary>
    public static void LoadMain() => SceneManager.LoadScene(MAIN_SCENE);

    /// <summary>�S�[���V�[����</summary>
    public static void LoadGoal() => SceneManager.LoadScene(GOAL_SCENE);

    /// <summary>�Q�[���I�[�o�[��</summary>
    public static void LoadGameOver() => SceneManager.LoadScene(GAMEOVER_SCENE);
}
