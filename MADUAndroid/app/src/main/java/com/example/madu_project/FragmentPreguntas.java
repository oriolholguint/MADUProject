package com.example.madu_project;

import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentResultListener;
import androidx.fragment.app.FragmentTransaction;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.RadioButton;
import android.widget.TextView;
import java.util.ArrayList;

public class FragmentPreguntas extends Fragment {

    View view;
    TextView descPregunta;
    ArrayList<Pregunta> preguntas;


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        view = inflater.inflate(R.layout.fragment_preguntas, container, false);
        descPregunta = view.findViewById(R.id.lblDescPregunta);

        getParentFragmentManager().setFragmentResultListener("preguntas", this, new FragmentResultListener() {
            @Override
            public void onFragmentResult(@NonNull  String requestKey, @NonNull Bundle result) {
                preguntas = (ArrayList<Pregunta>) result.getSerializable("pregunta");

                descPregunta.setText(preguntas.get(0).getPregunta());

            }
        });



        return view;
    }
}