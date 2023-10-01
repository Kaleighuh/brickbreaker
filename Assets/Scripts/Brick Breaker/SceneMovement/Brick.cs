using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Brick : MonoBehaviour
{
    public new Renderer renderer { get; private set; }
    public Material[] materials = new Material[0];
    public int health { get; private set; }
    public int points = 100;
    public bool unbreakable;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        // ResetBrick();
    }

    public void ResetBrick()
    {
        gameObject.SetActive(true);

        if (!unbreakable)
        {
            health = materials.Length;
            renderer.material = materials[health - 1];
        }
    }

    private void Hit()
    {
        if (unbreakable)
        {
            return;
        }

        health--;

        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
        else
        {
            renderer.material = materials[health - 1];
        }

        GameManager gameManager = FindObjectOfType<GameManager>();

        if (gameManager != null)
        {
            gameManager.Hit(this);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Hit();
        }
    }
}
