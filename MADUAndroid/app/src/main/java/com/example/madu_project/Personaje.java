package com.example.madu_project;

public class Personaje
{
    private String nombre;
    private String imagen;
    private int posicionRanking;

    public Personaje(String nombre, String imagen, int posicionRanking)
    {
        this.nombre = nombre;
        this.imagen = imagen;
        this.posicionRanking = posicionRanking;
    }

    public String getNombre() {
        return nombre;
    }

    public String getImagen() {
        return imagen;
    }

    public int getPosicionRanking() {
        return posicionRanking;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setImagen(String imagen) {
        this.imagen = imagen;
    }

    public void setPosicionRanking(int posicionRanking) {
        this.posicionRanking = posicionRanking;
    }

    @Override
    public String toString()
    {
        return "Personaje{" +
                "Nombre='" + nombre + '\'' +
                ", Imagen='" + imagen + '\'' +
                ", PosicionRanking=" + posicionRanking +
                '}';
    }
}
