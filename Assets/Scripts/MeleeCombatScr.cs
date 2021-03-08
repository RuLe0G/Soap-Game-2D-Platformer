using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeCombatScr : MonoBehaviour
{
    public Transform attakpoint;
    public float RangeAtk = 0.5f;
    public LayerMask enemyLayer;

    public GameObject tempAnim;
    private float tempint = 0;
    private float tempMax = 0.1f;

    public int damage = 60;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            Attack();
        }
        if (tempint <= 0)
        {
            tempAnim.SetActive(false);
        }
        if (tempint > 0)
        {
            
            tempint -= Time.deltaTime;
        }
    }

    private void Attack()
    {
        tempAnim.SetActive(true);
        tempint = tempMax;

        
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attakpoint.position, RangeAtk, enemyLayer);

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(damage);
        }
        
    }

    private void OnDrawGizmosSelected()
    {
        if (attakpoint == null)
            return;

        Gizmos.DrawWireSphere(attakpoint.position, RangeAtk);
    }
}
