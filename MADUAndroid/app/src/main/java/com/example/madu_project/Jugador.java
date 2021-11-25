package com.example.madu_project;

public class Jugador
{
    private String nombre;
    private Boolean esMayorEdad;
    private String avatar;


    public Jugador(String nombre, Boolean esMayorEdad, String avatar) {
        this.nombre = nombre;
        this.esMayorEdad = esMayorEdad;
        this.avatar = avatar;
    }
}