package com.example.madu_project;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Arrays;

public class Genero
{
    private String nombre;
    private String musicaFondo;
    private String imagenFondo;
    private String imagenMenu;
    private ArrayList<Pregunta> preguntas;
    private ArrayList<Personaje> personajes;
    private ArrayList<Partida> partidas;

    public Genero(String nombre, String musicaFondo, String imagenFondo, String imagenMenu,
                  ArrayList<Pregunta> preguntas, ArrayList<Personaje> personajes, ArrayList<Partida> partidas)
    {
        this.nombre = nombre;
        this.musicaFondo = musicaFondo;
        this.imagenFondo = imagenFondo;
        this.imagenMenu = imagenMenu;
        this.preguntas = preguntas;
        this.personajes = personajes;
        this.partidas = partidas;
    }

    public String getNombre() {
        return nombre;
    }

    public String getMusicaFondo() {
        return musicaFondo;
    }

    public String getImagenFondo() {
        return imagenFondo;
    }

    public String getImagenMenu() {
        return imagenMenu;
    }

    public ArrayList<Pregunta>  getPreguntas() {
        return preguntas;
    }

    public ArrayList<Personaje> getPersonajes() {
        return personajes;
    }

    public ArrayList<Partida> getPartidas() {
        return partidas;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public void setMusicaFondo(String musicaFondo) {
        this.musicaFondo = musicaFondo;
    }

    public void setImagenFondo(String imagenFondo) {
        this.imagenFondo = imagenFondo;
    }

    public void setImagenMenu(String imagenMenu) {
        this.imagenMenu = imagenMenu;
    }

    public void setPreguntas(ArrayList<Pregunta> preguntas) {
        this.preguntas = preguntas;
    }

    public void setPersonajes(ArrayList<Personaje> personajes) {
        this.personajes = personajes;
    }

    public void setPartidas(ArrayList<Partida>  partidas) {
        this.partidas = partidas;
    }

    @Override
    public String toString() {
        return "Genero{" +
                "Nombre='" + nombre + '\'' +
                ", MusicaFondo='" + musicaFondo + '\'' +
                ", ImagenFondo='" + imagenFondo + '\'' +
                ", ImagenMenu='" + imagenMenu + '\'' +
                ", Preguntas=" + preguntas +
                ", Personajes=" + personajes +
                ", Partidas=" + partidas +
                '}';
    }
}
