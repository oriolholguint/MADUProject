package com.example.madu_project;

import java.util.Date;

public class Partida
{
    private int puntuacion;
    private String dificultad;
    private Date fecha;
    private Jugador jugador;

    public Partida(int puntuacion, String dificultad, Date fecha, Jugador jugador)
    {
        this.puntuacion = puntuacion;
        this.dificultad = dificultad;
        this.fecha = fecha;
        this.jugador = jugador;
    }

    public int getPuntuacion() {
        return puntuacion;
    }

    public String getDificultad() {
        return dificultad;
    }

    public Date getFecha() {
        return fecha;
    }

    public Jugador getJugador() {
        return jugador;
    }

    public void setPuntuacion(int puntuacion) {
        this.puntuacion = puntuacion;
    }

    public void setDificultad(String dificultad) {
        this.dificultad = dificultad;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public void setJugador(Jugador jugador) {
        this.jugador = jugador;
    }

    @Override
    public String toString()
    {
        return "Partida{" +
                "Puntuacion=" + puntuacion +
                ", Dificultad='" + dificultad + '\'' +
                ", Fecha=" + fecha +
                ", Jugador=" + jugador +
                '}';
    }
}
