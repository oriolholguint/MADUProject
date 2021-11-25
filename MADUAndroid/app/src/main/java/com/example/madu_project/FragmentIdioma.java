package com.example.madu_project;

import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.Spinner;


public class FragmentIdioma extends Fragment
{
    ImageView imgEspañol;
    ImageView imgIngles;
    Spinner dificultad;


    @Override
    public View onCreateView(LayoutInflater inflater,
                             ViewGroup container,
                             Bundle savedInstanceState)
    {
        View view = inflater.inflate(R.layout.fragment_idioma, container, false);

        imgEspañol = view.findViewById(R.id.imgEspañol);
        imgIngles = view.findViewById(R.id.imgIngles);
        dificultad = view.findViewById(R.id.sprDificultad);

        ArrayAdapter<CharSequence> adapter = ArrayAdapter.createFromResource(getActivity(),R.array.combo_dificultad,R.layout.support_simple_spinner_dropdown_item);
        dificultad.setAdapter(adapter);
        return view;
    }





}