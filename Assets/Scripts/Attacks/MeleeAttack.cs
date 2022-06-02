using System.Collections;
using UnityEngine;

public class MeleeAttack : TriggerDemage, IAttack
{
    [SerializeField]
    private float attackTime = 0.2f;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    public void Attack()
    {
        gameObject.SetActive(true);
        StartCoroutine(PerformAttack());
    }

    private IEnumerator PerformAttack()
    {
        yield return new WaitForSeconds(attackTime);
        gameObject.SetActive(false);
    }
}
