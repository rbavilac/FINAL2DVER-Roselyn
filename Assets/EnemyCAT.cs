using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCAT : MonoBehaviour
{
    public SpriteRenderer SR;
    public Rigidbody2D RB;
    public Collider2D Coll;

	public int maxHealth=4;
	int currentHealth;
    
    //My personal speed
    public float Speed = 2;

  public GameObject enemyPrefab;
    // Start is called befo
    // re the first frame update
    void Start()
    {

		currentHealth=maxHealth;

         Base baseScript = FindObjectOfType<Base>();
		if (baseScript != null) {
   		 baseScript.AllEnemies.Add(this);
		} else 
        {
    	Debug.LogError("Base script not found!");}
    }
	public void TakeDamage(int damage)
		{
			currentHealth-=damage;
			
            if (currentHealth<=0)
			{ Destroy(gameObject);}
        }
}
