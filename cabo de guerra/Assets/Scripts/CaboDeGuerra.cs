using UnityEngine;

public class CaboDeGuerra : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
    }

    void Update()
    {
        lineRenderer.SetPosition(0, player1.position);
        lineRenderer.SetPosition(1, player2.position);
    }
}
