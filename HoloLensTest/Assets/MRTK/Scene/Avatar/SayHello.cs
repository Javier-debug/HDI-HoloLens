using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SayHello : MonoBehaviour
{

    //Variables de posicion de daños 
    float danos_x = -0.75f, danos_y = 0.079f, danos_z = 0.205f;//Variables inicio
    float danos_xf = -0.857f, danos_zf = 0.266f;//Variables Finales

    //Variables de posicion de siniestros
    float siniestros_x = -0.202f, siniestros_y = 0.079f, siniestros_z = 0.753f;//Variables inicio
    float siniestros_xf = -0.314f, siniestros_zf = 0.947f;//Variables Finales

    //Variables de posicion de costos
    float costos_x = 0.45f, costos_y = 0.070f, costos_z = 0.646f;//Variables inicio
    float costos_xf = 0.62f, costos_zf = 0.816f;//Variables Finales

    //Variables de posicion de refacciones
    float refacciones_x = -0.646f, refacciones_y = 0.079f, refacciones_z = -0.45f;//Variables inicio
    float refacciones_xf = -0.788f, refacciones_zf = -0.592f;//Variables Finales

    //Objetos del juego
    GameObject danos, siniestos, costos, refacciones, optionMenu;

    //Declaracion de Vectores
    Vector3 newPositionDanos, newPositionSiniestros, newPositionCostos, newPositionRefacciones;


    // Start is called before the first frame update
    void Start()
    {

        //GameObjets dashboards
        danos = GameObject.Find("Daños");
        siniestos = GameObject.Find("Siniestros");
        costos = GameObject.Find("Costos");
        refacciones = GameObject.Find("Refacciones");

        //GameObjets Menu
        optionMenu = GameObject.Find("OptionsMenu");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sayHello(TextMeshPro opcion)
    {

      
        //Generamos la rama de condicionantes 
        if (opcion.text.ToString() == "Daños")
         {
            posicionDanos();//Funcion para posicionar el dashboard de daños
        }
        else if (opcion.text.ToString() == "Siniestros")
        {
            posicionSiniestros();//Funcion para posicionar el dashboard de siniestros

        }
        else if (opcion.text.ToString() == "Costos")
        {
            posicionCostos();//Funcion para posicionar el dashboard de costos
        }
        else if (opcion.text.ToString() == "Refacciones")
        {
            posicionRefacciones();//Funcion para posicionar el dashboard de refacciones
        }



    }

    //----------------------------------------------------------------------------------------------
    //----------------------------------------------------------------------------------------------
    //----------------------------------------------------------------------------------------------
    //Funcion para posicionar el Dashboard de Daños
    void posicionDanos()
    {
        //Daños
        newPositionDanos = new Vector3(danos_x, danos_y, danos_z);
        danos.transform.localPosition = newPositionDanos;

        //Siniestros
        newPositionSiniestros = new Vector3(siniestros_xf, siniestros_y, siniestros_zf);
        siniestos.transform.localPosition = newPositionSiniestros;

        //Costos
        newPositionCostos = new Vector3(costos_xf, costos_y, costos_zf);
        costos.transform.localPosition = newPositionCostos;

        //Refacciones
        newPositionRefacciones = new Vector3(refacciones_xf, refacciones_y, refacciones_zf);
        refacciones.transform.localPosition = newPositionRefacciones;
    }

    //----------------------------------------------------------------------------------------------
    //----------------------------------------------------------------------------------------------
    //----------------------------------------------------------------------------------------------
    //Funcion para posicionar el Dashboard de Siniestros
    void posicionSiniestros()
    {
        //Daños
        newPositionDanos = new Vector3(danos_xf, danos_y, danos_zf);
        danos.transform.localPosition = newPositionDanos;

        //Siniestros
        newPositionSiniestros = new Vector3(siniestros_x, siniestros_y, siniestros_z);
        siniestos.transform.localPosition = newPositionSiniestros;

        //Costos
        newPositionCostos = new Vector3(costos_xf, costos_y, costos_zf);
        costos.transform.localPosition = newPositionCostos;

        //Refacciones
        newPositionRefacciones = new Vector3(refacciones_xf, refacciones_y, refacciones_zf);
        refacciones.transform.localPosition = newPositionRefacciones;
    }

    //----------------------------------------------------------------------------------------------
    //----------------------------------------------------------------------------------------------
    //----------------------------------------------------------------------------------------------
    //Funcion para posicionar el Dashboard de Costos
    void posicionCostos()
    {
        //Daños
        newPositionDanos = new Vector3(danos_xf, danos_y, danos_zf);
        danos.transform.localPosition = newPositionDanos;

        //Siniestros
        newPositionSiniestros = new Vector3(siniestros_xf, siniestros_y, siniestros_zf);
        siniestos.transform.localPosition = newPositionSiniestros;

        //Costos
        newPositionCostos = new Vector3(costos_x, costos_y, costos_z);
        costos.transform.localPosition = newPositionCostos;

        //Refacciones
        newPositionRefacciones = new Vector3(refacciones_xf, refacciones_y, refacciones_zf);
        refacciones.transform.localPosition = newPositionRefacciones;
    }

    //----------------------------------------------------------------------------------------------
    //----------------------------------------------------------------------------------------------
    //----------------------------------------------------------------------------------------------
    //Funcion para posicionar el Dashboard de Refacciones
    void posicionRefacciones()
    {
        //Daños
        newPositionDanos = new Vector3(danos_xf, danos_y, danos_zf);
        danos.transform.localPosition = newPositionDanos;

        //Siniestros
        newPositionSiniestros = new Vector3(siniestros_xf, siniestros_y, siniestros_zf);
        siniestos.transform.localPosition = newPositionSiniestros;

        //Costos
        newPositionCostos = new Vector3(costos_x, costos_y, costos_z);
        costos.transform.localPosition = newPositionCostos;

        //Refacciones
        newPositionRefacciones = new Vector3(refacciones_x, refacciones_y, refacciones_z);
        refacciones.transform.localPosition = newPositionRefacciones;
    }


}


//Funcionalidad extra de pruebas de coordenadas

//Obtenemos el nombre del titulo
//textMesh = title.name.ToString();
//Debug.Log(opcion.text.ToString());

//Debug.Log("Posicion X" + siniestos.transform.position.x);
//Debug.Log("Posicion Y" + siniestos.transform.position.y);
//Debug.Log("Posicion Z" + siniestos.transform.position.z);

//Debug.Log("");

//Debug.Log("Rotacion X" + Camera.main.transform.localEulerAngles.x);
//Debug.Log("Rotacion Y" + Camera.main.transform.localEulerAngles.y);
//Debug.Log("Rotacion Z" + Camera.main.transform.localEulerAngles.z);


//Posicionamos el modelo a base de la posicion de la camara
//Vector3 newPosition = new Vector3(optionMenu.transform.localPosition.x, optionMenu.transform.localPosition.y, optionMenu.transform.localPosition.z);
//danos.transform.localPosition = newPosition;

//Rotamos el modelo a base de la rotacion de la camara
//Vector3 newRotation = new Vector3(optionMenu.transform.localEulerAngles.x, optionMenu.transform.localEulerAngles.y, optionMenu.transform.localEulerAngles.z);
//Vector3 newRotation = new Vector3(Camera.main.transform.eulerAngles.x, Camera.main.transform.eulerAngles.y, Camera.main.transform.eulerAngles.z);
//danos.transform.localEulerAngles = newRotation;
