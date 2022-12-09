using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotActions : MonoBehaviour
{
    public GameObject dashboardDaños;
    public GameObject dashboardSiniestros;
    public GameObject dashboardCostos;
    public GameObject dashboardRefacciones;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(appearDashboards());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //dashboards.SetActive(false);
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
