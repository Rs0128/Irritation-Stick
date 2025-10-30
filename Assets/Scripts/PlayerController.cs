using UnityEngine;

/// <summary>
/// イライラ棒プレイヤー制御
/// ・スタート時は右方向へ自動移動
/// ・十字キーで方向変更可能
/// ・3秒ごとに速度が1.1倍
/// ・壁に当たるとゲームオーバー
/// ・重力無効
/// </summary>
public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    [Tooltip("初期移動速度")]
    [SerializeField] float initialMoveSpeed = 1f;

    [Tooltip("速度増加倍率")]
    [SerializeField] float speedIncreaseRate = 1.1f;

    [Tooltip("速度増加間隔（秒）")]
    [SerializeField] float speedIncreaseInterval = 3f;

    private const string WALL_TAG = "Wall";

    private float currentMoveSpeed;
    private bool isPlaying = false;
    private Vector2 moveDirection = Vector2.right; // 初期は右向き

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.gravityScale = 0f;
        rb.freezeRotation = true;
    }

    private void Start()
    {
        currentMoveSpeed = initialMoveSpeed;
    }

    /// <summary>
    /// ゲーム開始（GameManager から呼ばれる）
    /// </summary>
    public void StartMove()
    {
        isPlaying = true;
        InvokeRepeating(nameof(IncreaseSpeed), speedIncreaseInterval, speedIncreaseInterval);
    }

    void Update()
    {
        if (!isPlaying) return;

        // 十字キー入力取得
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // 斜め移動禁止（優先順位：横入力 → 縦入力）
        if (horizontal != 0 && vertical != 0)
        {
            vertical = 0;
        }

        // 横 → 縦の順に判定
        if (horizontal != 0)
        {
            moveDirection = new Vector2(horizontal, 0).normalized;
        }
        else if (vertical != 0)
        {
            moveDirection = new Vector2(0, vertical).normalized;
        }
    }


    private void FixedUpdate()
    {
        if (!isPlaying) return;

        rb.linearVelocity = moveDirection * currentMoveSpeed;
    }

    /// <summary>
    /// 一定時間ごとに速度アップ
    /// </summary>
    private void IncreaseSpeed()
    {
        currentMoveSpeed *= speedIncreaseRate;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall"))
        {
            SceneController.LoadGameOver();
        }
    }
}
