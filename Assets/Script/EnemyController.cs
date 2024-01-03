using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 2f;  // Tốc độ di chuyển của enemy
    private Rigidbody2D rb;
    private Collider2D enemyCollider;
    private bool isFacingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        enemyCollider = GetComponent<Collider2D>();
    }

    void Update()
    {
        MoveEnemy();
    }

    void MoveEnemy()
    {
        // Tính toán hướng di chuyển
        Vector2 movement = isFacingRight ? Vector2.right : Vector2.left;

        // Kiểm tra trước với Raycast để xác định khi nào nên đổi hướng
        RaycastHit2D hit = Physics2D.Raycast(transform.position, movement, 0.1f);

        // Kiểm tra nếu có va chạm với vật cản
        if (hit.collider != null && hit.collider != enemyCollider)
        {
            // Đổi hướng mặt của enemy
            Flip();
        }

        // Áp dụng di chuyển
        rb.velocity = new Vector2(movement.x * moveSpeed, rb.velocity.y);
    }

    void Flip()
    {
        // Đảo ngược hướng mặt của enemy
        isFacingRight = !isFacingRight;
        Vector3 newScale = transform.localScale;
        newScale.x *= -1;
        transform.localScale = newScale;
    }
}
