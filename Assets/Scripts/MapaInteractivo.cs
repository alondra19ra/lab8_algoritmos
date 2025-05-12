using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class MapaInteractivo : MonoBehaviour
{
    [Title("Zonas del Mapa")]
    [ReadOnly] private Graph<string, Zona> grafoZona = new Graph<string, Zona>();

    [Button("Agregar zonas al Mapa")]
    public void AgregarZonasEjemplo()
    {
        grafoZona = new Graph<string, Zona>();
        var zonaA = new Zona("Bosque", "Un bosque oscuro y húmedo.", false, true);
        var zonaB = new Zona("Cueva", "Una cueva misteriosa con ruidos extraños.", true, true);
        var zonaC = new Zona("Aldea", "Una aldea tranquila con habitantes amigables.", false, false);
        var zonaD = new Zona("Río", "Un río de aguas cristalinas.", true, false);

        grafoZona.AddNode(zonaA.NombreZona, zonaA);
        grafoZona.AddNode(zonaB.NombreZona, zonaB);
        grafoZona.AddNode(zonaC.NombreZona, zonaC);
        grafoZona.AddNode(zonaD.NombreZona, zonaD);

        grafoZona.AddEdge(zonaA.NombreZona, zonaB.NombreZona);
        grafoZona.AddEdge(zonaB.NombreZona, zonaC.NombreZona);
        grafoZona.AddEdge(zonaC.NombreZona, zonaD.NombreZona);
        grafoZona.AddEdge(zonaA.NombreZona, zonaD.NombreZona);

        Debug.Log("==============Zonas y caminos agregados================");
        MostrarMapa();
    }
    [Button("Mostrar Grafo")]
    public void MostrarGrafo()
    {
        if (grafoZona != null)
        {
            Debug.Log("======Mostrando Grafo ========");
            grafoZona.DisplayGaphAsList();
            grafoZona.DisplayGraphAsMatrix();
        }
        else
        {
            Debug.Log("Grafo no inicializado.");
        }
    }
    [Button("Mostrar Mapa")]
    public void MostrarMapa()
    {
        Debug.Log("======Mostrando Mapa ========");
        grafoZona.DisplayGaphAsList();
        grafoZona.DisplayGraphAsMatrix();
    }

    [Button("Reiniciar Grafo")]
    public void ReiniciarGrafo()
    {
        grafoZona = new Graph<string, Zona>();
        Debug.Log("Grafo reiniciado.");
    }

}
