using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script for block to dissapear on collision with ball
/// </summary>
public class Block : MonoBehaviour
{
    #region Fields

    protected int points = 10;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Destroys the block on collision with a ball
    /// </summary>
    /// <param name="coll">Coll.</param>
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ball"))
        {
            HUD.AddPoints(points);
            Destroy(gameObject);
        }
    }
}
