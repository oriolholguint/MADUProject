package com.example.madu_project;

import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ImageButton;
import android.widget.ListView;

import java.security.acl.Group;
import java.util.ArrayList;


public class MainActivity extends AppCompatActivity
{

    public String layout = "Idioma";
    public String status = "Pricipal";
    public ArrayList generos;
    public int duracion;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ImageButton imgBtnConfiguracion = findViewById(R.id.imgBtnConfiguracion);

        androidx.fragment.app.FragmentManager mgr = getSupportFragmentManager();
        androidx.fragment.app.FragmentTransaction fragmentTransaction = mgr.beginTransaction();

        FragmentBotones fragmentBotones = new FragmentBotones();

        fragmentTransaction.replace(R.id.ContenedorFragmentsPricipales,fragmentBotones);
        fragmentTransaction.commit();

        generos = llenarGeneros();
        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setMessage("").setTitle("Opciones");
        final AlertDialog dialog = builder.create();


        imgBtnConfiguracion.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                dialog.show();

            }
        });

    }




    public ArrayList<Genero> llenarGeneros (){

        ArrayList<Pregunta> preguntasElectronica = new ArrayList<>();
        ArrayList<Pregunta> preguntasRock = new ArrayList<>();
        ArrayList<Pregunta> preguntasPop = new ArrayList<>();
        ArrayList<Pregunta> preguntasHipHop = new ArrayList<>();
        ArrayList<Personaje> personajes = new ArrayList<>();
        ArrayList<Partida> partidas = new ArrayList<>();
        ArrayList<Genero> generos = new ArrayList<>();

        Respuesta [] respuestas = {new Respuesta("Respuesta 1",true),
                                    new Respuesta("Respuesta 2",false),
                                    new Respuesta("Respuesta 3",false),
                                    new Respuesta("Respuesta 4",false)};

        preguntasElectronica.add(new Pregunta("Esta es la pregunta 1 Electronica?","","",true,respuestas));
        preguntasElectronica.add(new Pregunta("Esta es la pregunta 2 Electronica?","","",true,respuestas));
        preguntasRock.add(new Pregunta("Esta es la pregunta 1 Rock?","","",true,respuestas));
        preguntasRock.add(new Pregunta("Esta es la pregunta 2 Rock?","","",true,respuestas));
        preguntasPop.add(new Pregunta("Esta es la pregunta 1 Pop?","","",true,respuestas));
        preguntasPop.add(new Pregunta("Esta es la pregunta 2 Pop?","","",true,respuestas));
        preguntasHipHop.add(new Pregunta("Esta es la pregunta 1 Hip-Hop?","","",true,respuestas));
        preguntasHipHop.add(new Pregunta("Esta es la pregunta 2 Hip-Hop?","","",true,respuestas));



        generos.add(new Genero("Electronica","","","",preguntasElectronica,personajes,partidas));
        generos.add(new Genero("Rock","","","",preguntasRock,personajes,partidas));
        generos.add(new Genero("Pop","","","",preguntasPop,personajes,partidas));
        generos.add(new Genero("Hip-Hop","","","",preguntasHipHop,personajes,partidas));


        return generos;
    }


}