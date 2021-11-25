package com.example.madu_project;


import android.os.Parcelable;

import java.io.Serializable;
import java.util.Arrays;

public class Pregunta implements Serializable
{
    private String pregunta;
    private String imagen;
    private String sonido;
    private boolean esMayorEdad;
    private Respuesta[] respuestas;

    public Pregunta(String pregunta, String imagen, String sonido, boolean esMayorEdad, Respuesta[] respuestas)
    {
        this.pregunta = pregunta;
        this.imagen = imagen;
        this.sonido = sonido;
        this.esMayorEdad = esMayorEdad;
        this.respuestas = respuestas;
    }

    public String getPregunta() {
        return pregunta;
    }

    public String getImagen() {
        return imagen;
    }

    public String getSonido() {
        return sonido;
    }

    public boolean isEsMayorEdad() {
        return esMayorEdad;
    }

    public Respuesta[] getRespuestas() {
        return respuestas;
    }

    public void setPregunta(String pregunta) {
        this.pregunta = pregunta;
    }

    public void setImagen(String imagen) {
        this.imagen = imagen;
    }

    public void setSonido(String sonido) {
        this.sonido = sonido;
    }

    public void setEsMayorEdad(boolean esMayorEdad) {
        this.esMayorEdad = esMayorEdad;
    }

    public void setRespuestas(Respuesta[] respuestas) {
        this.respuestas = respuestas;
    }

    @Override
    public String toString()
    {
        return "Pregunta{" +
                "Pregunta='" + pregunta + '\'' +
                ", Imagen='" + imagen + '\'' +
                ", Sonido='" + sonido + '\'' +
                ", EsMayorEdad=" + esMayorEdad +
                ", Respuestas=" + Arrays.toString(respuestas) +
                '}';
    }
}
