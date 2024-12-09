using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
      
 // static mariable to make me available everywhere in the code
	public static Base Me;
    
    //how long until the next enemy appairs
    public float SpawnTimer=0;
    
    //Once a monster spawns, how long until the next?
    public float SpawnMaxTimer=2;

	//The prefab for the monster that spawns
    public EnemyCAT EnemyPrefab;

   //A link to the player
    public CarMovement player;
    //Keep a list of all the monsters
	public List<EnemyCAT>AllEnemies;
    // Start is called before the first frame update

    private float highestPointInPath = 15f;
    void Start()
    {
         Base.Me = this;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTimer -= Time.deltaTime;

        if (SpawnTimer <= 0)
        {
            SpawnTimer = SpawnMaxTimer;

            // Calculate the spawn position, using the CarMovement's y-coordinate as a base
            float spawnY = player.transform.position.y + Random.Range(5f, 10f);
            Vector3 where = new Vector3(Random.Range(-8f, 8), spawnY, 0);
            Instantiate(EnemyPrefab, where, Quaternion.identity);

        }
    }
}
