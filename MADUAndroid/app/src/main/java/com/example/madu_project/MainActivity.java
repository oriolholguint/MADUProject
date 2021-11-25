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

        //no tocar
        androidx.fragment.app.FragmentManager mgr = getSupportFragmentManager();
        androidx.fragment.app.FragmentTransaction fragmentTransaction = mgr.beginTransaction();

        FragmentBotones fragmentBotones = new FragmentBotones();

        fragmentTransaction.replace(R.id.ContenedorFragmentsPricipales,fragmentBotones);
        fragmentTransaction.commit();

        //igualar array al idioma seleccionado
        //generos = llenarGeneros();


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




}