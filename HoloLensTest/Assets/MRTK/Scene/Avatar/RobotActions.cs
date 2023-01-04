using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotActions : MonoBehaviour
{
    public GameObject dashboardDaños;
    public GameObject dashboardSiniestros;
    public GameObject dashboardCostos;
    public GameObject dashboardRefacciones;
    public Animator animation;
    Transform startMarker;
    public Transform endMarker;
    public float speed;
    private float startTime;
    private float journeyLength;
    private bool animationSucceded = false;
    // Start is called before the first frame update
    void Start()
    {
        startMarker = transform;
        startTime = Time.time;

        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
        StartCoroutine(appearDashboards());
    }

    // Update is called once per frame
    void Update()
    {
        if (animation.GetCurrentAnimatorStateInfo(0).IsName("Walking"))
        {
            transform.rotation = Quaternion.Euler(0, 191, 0);
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, endMarker.position, step);
            if (transform.position.x == endMarker.position.x && transform.position.z == endMarker.position.z)
            {
                Debug.Log("Entro");
                animation.Play("Catwalk");
                transform.rotation = endMarker.rotation;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {

    }

    IEnumerator appearDashboards()
    {
        yield return new WaitForSeconds(4);
        dashboardRefacciones.SetActive(true);
        yield return new WaitForSeconds(4);
        dashboardDaños.SetActive(true);
        yield return new WaitForSeconds(4);
        dashboardCostos.SetActive(true);
        yield return new WaitForSeconds(4);
        dashboardSiniestros.SetActive(true);
    }


}
