/*using UnityEngine;

public class Destroy : MonoBehaviour 
{
    public GameObject spawner;
    private SpawnerLogic spawnerLogic;
    public int pointsPerObject = 10;

    private int points;

    void start()
    {
        spawnerLogic = spawnerLogic.Getcomponent<SpawnerLogic>();
    }

    void OnCollisionEnter(Collision collision) 
    {
        if(hit spawn object)
        {
            Destroy(collision.gameObject);  
            points += pointsPerObject;
            spawnerLogic.ObjectDestroyed();
        }
    }

    void Update()
    {
        // Display points for example
        Debug.Log("Points: " + points);  
    }
}*/
