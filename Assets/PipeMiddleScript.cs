using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public LogicScript logic;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*
            Hack - since the bird has two colliders, one that's a trigger (used for this purpose)
            and one that's a normal collider (used for pipe collision), we only want to trigger
            score increase once. This function will be called for both colliders, so only increase
            the score if the one we're colliding with is the trigger collider.
         */
        if (collision.isTrigger)
        {
            logic.addScore();
        }
    }
}
