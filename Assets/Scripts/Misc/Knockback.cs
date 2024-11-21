using UnityEditor.Callbacks;
using UnityEngine;
using System.Collections;

public class Knockback : MonoBehaviour
{
    public bool gettingKnockedBack { get; private set; }

    [SerializeField] private float knockBackTime = .2f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void GetKnockedBack(Transform DamageSource, float knockBackThrust)
    {
        gettingKnockedBack = true;
        Vector2 differance = (transform.position - DamageSource.position).normalized * knockBackThrust * rb.mass;
        rb.AddForce(differance, ForceMode2D.Impulse);
        StartCoroutine(KnockRoutine());
    }

    private IEnumerator KnockRoutine()
    {
        yield return new WaitForSeconds(knockBackTime);
        rb.linearVelocity = Vector2.zero;
        gettingKnockedBack = false;
    }

}
