using UnityEngine;

public class TennisArea : MonoBehaviour
{
    public GameObject ball;
    public GameObject agent;
    Rigidbody m_BallRb;

    // Use this for initialization
    void Start()
    {
        m_BallRb = ball.GetComponent<Rigidbody>();
        MatchReset();
    }

    public void MatchReset()
    {
        var ballOut = Random.Range(-6f, -8f); // distancia en x
        ball.transform.position = new Vector3(ballOut, 0f, 0f) + transform.position;
        m_BallRb.velocity = new Vector3(0f, 0f, 0f); //reset velocidad, hace caida
        ball.transform.localScale = new Vector3(.5f, .5f, .5f);
        ball.GetComponent<HitWall>().lastAgentHit = -1;
    }

    void FixedUpdate()
    {
        var rgV = m_BallRb.velocity;
        m_BallRb.velocity = new Vector3(Mathf.Clamp(rgV.x, -9f, 9f), Mathf.Clamp(rgV.y, -9f, 9f), rgV.z);
    }
}