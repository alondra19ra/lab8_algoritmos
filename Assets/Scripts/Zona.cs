using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class Zona 
{
    [Title("Información General")]
    [LabelText("Nombre de la Zona")] public string NombreZona;
    [Multiline(3)] public string Descripcion;

    [TextArea]
    public string Description;

    [Title("Estado de la zona")]
    [ToggleLeft] public bool TieneTesoro;
    [ToggleLeft] public bool EsPeligrosa;

    public Zona(string nombre, string descripcion, bool tieneTesoro, bool esPeligrosa)
    {
        NombreZona = nombre;
        Descripcion = descripcion;
        TieneTesoro = tieneTesoro;
        EsPeligrosa = esPeligrosa;
    }

    public override string ToString()
    {
        return NombreZona + " (Tesoro: " + (TieneTesoro ? "Sí" : "No") + ", Peligrosa: " + (EsPeligrosa ? "Sí" : "No") + ")";
    }
}
