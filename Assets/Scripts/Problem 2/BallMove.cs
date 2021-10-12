using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public float xInitialForce;
    public float yInitialForce;

    private Rigidbody2D ball;
    // Titik asal lintasan bola saat ini
    private Vector2 trajectoryOrigin;

    void PushBall()
    {
        // Tentukan nilai komponen y dari gaya dorong antara -yInitialForce dan yInitialForce
        float yRandomInitialForce = Random.Range(-yInitialForce, yInitialForce);

        // Tentukan nilai acak antara 0 (inklusif) dan 2 (eksklusif)
        float randomDirection = Random.Range(0, 2);

        // Jika nilainya di bawah 1, bola bergerak ke kiri. 
        // Jika tidak, bola bergerak ke kanan.
        if (randomDirection < 1.0f)
        {
            // Gunakan gaya untuk menggerakkan bola ini.
            ball.AddForce(new Vector2(-xInitialForce, yInitialForce));
        }
        else
        {
            ball.AddForce(new Vector2(xInitialForce, yInitialForce));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        trajectoryOrigin = transform.position;
        Invoke("PushBall", 1);
    }

    public Vector2 TrajectoryOrigin
    {
        get { return trajectoryOrigin; }
    }
}
