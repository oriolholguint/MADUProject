package com.example.madu_project;

import android.app.AlertDialog;
import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.constraintlayout.widget.Group;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.Toast;


public class FragmentBotones extends Fragment
{
    View view;
    Button btnAtras;
    Button btnSiguienteCentro;
    Button btnSiguiente;
    Group grpBotones;
    MainActivity ActivityMain;


    @Override
    public void onCreate( Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);


    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        view = inflater.inflate(R.layout.fragment_botones, container, false);

        btnAtras = view.findViewById(R.id.btnAtras);
        btnSiguienteCentro = view.findViewById(R.id.btnSiguienteCentro);
        btnSiguiente = view.findViewById(R.id.btnSiguiente);
        grpBotones = view.findViewById(R.id.grpBotones);
        FragmentIdioma fragmentIdioma = new FragmentIdioma();

        getFragmentManager().beginTransaction().add(R.id.frLContenedorFragments,fragmentIdioma).commit();


        ActivityMain = (MainActivity)getActivity();



        btnSiguienteCentro.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                if(ActivityMain.layout.equals("Idioma")){
                    ActivityMain.layout = "Introduccion";

                    FragmentManager mg = getFragmentManager();
                    FragmentTransaction fragmentTransaction = mg.beginTransaction();

                    FragmentTutorial fragmentTutorial = new FragmentTutorial();
                    fragmentTransaction.replace(R.id.frLContenedorFragments,fragmentTutorial);
                    fragmentTransaction.commit();

                    grpBotones.setVisibility(View.VISIBLE);
                    btnSiguienteCentro.setVisibility(View.INVISIBLE);
                }

            }
        });


        btnAtras.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view)
            {


                if(ActivityMain.layout.equals("Introduccion"))
                {
                    ActivityMain.layout = "Idioma";

                    FragmentManager mg = getFragmentManager();
                    FragmentTransaction fragmentTransaction = mg.beginTransaction();

                    FragmentIdioma fragmentIdioma = new FragmentIdioma();
                    fragmentTransaction.replace(R.id.frLContenedorFragments,fragmentIdioma);
                    fragmentTransaction.commit();


                    grpBotones.setVisibility(View.INVISIBLE);
                    btnSiguienteCentro.setVisibility(View.VISIBLE);

                } else if(ActivityMain.layout.equals("Login")){
                    ActivityMain.layout = "Introduccion";

                    FragmentManager mg = getFragmentManager();
                    FragmentTransaction fragmentTransaction = mg.beginTransaction();

                    FragmentTutorial fragmentTutorial = new FragmentTutorial();
                    fragmentTransaction.replace(R.id.frLContenedorFragments,fragmentTutorial);
                    fragmentTransaction.commit();



                    btnSiguiente.setText("Siguiente");

                }

            }
        });



        btnSiguiente.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view)
            {
                if(ActivityMain.layout.equals("Introduccion"))
                {
                    ActivityMain.layout = "Login";

                    FragmentManager mg = getFragmentManager();
                    FragmentTransaction fragmentTransaction = mg.beginTransaction();

                    FragmentLogin fragmentLogin = new FragmentLogin();
                    fragmentTransaction.replace(R.id.frLContenedorFragments,fragmentLogin);
                    fragmentTransaction.commit();

                    btnSiguiente.setText("Login");

                } else if (ActivityMain.layout.equals("Login")) // i el usuario sea diferente a null
                {
                    ActivityMain.layout = "Menu";
                    ActivityMain.status = "Juego";
                    FragmentManager mg = getFragmentManager();
                    FragmentTransaction fragmentTransaction = mg.beginTransaction();

                    FragmentMenu fragmentMenu = new FragmentMenu();
                    fragmentTransaction.replace(R.id.ContenedorFragmentsPricipales,fragmentMenu);
                    fragmentTransaction.commit();


                    ActivityMain.findViewById(R.id.grpDatosUsuario).setVisibility(View.VISIBLE);


                    btnSiguiente.setText("Siguiente");

                }
            }
        });



        return view;

    }




}