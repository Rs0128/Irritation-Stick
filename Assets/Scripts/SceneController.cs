using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// シーン遷移を統一管理するユーティリティクラス。
/// </summary>
public static class SceneController
{
    private const string TITLE_SCENE = "Title";
    private const string MAIN_SCENE = "Main";
    private const string GOAL_SCENE = "Goal";
    private const string GAMEOVER_SCENE = "GameOver";

    /// <summary>タイトルへ</summary>
    public static void LoadTitle() => SceneManager.LoadScene(TITLE_SCENE);

    /// <summary>メインゲームへ</summary>
    public static void LoadMain() => SceneManager.LoadScene(MAIN_SCENE);

    /// <summary>ゴールシーンへ</summary>
    public static void LoadGoal() => SceneManager.LoadScene(GOAL_SCENE);

    /// <summary>ゲームオーバーへ</summary>
    public static void LoadGameOver() => SceneManager.LoadScene(GAMEOVER_SCENE);
}
