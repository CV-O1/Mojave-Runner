using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // TODO: A public float variable to control how fast the obstacle moves across the screen
    public Parallax.Layer layer;
    // TODO: A public float variable to control how far the object should go before being destroyed offscreen.
    public float endRange = -12f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        transform.position += Vector3.left * Parallax.GetSpeed(layer) * Time.deltaTime;

        if (transform.position.x <= endRange)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Health.TryDamageTarget(other.gameObject, 1);
    }

}
