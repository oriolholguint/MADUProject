package com.example.madu_project;

import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.google.android.material.tabs.TabLayout;


public class FragmentRanking extends Fragment {

    View view;
    MainActivity ma;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        view = inflater.inflate(R.layout.fragment_ranking, container, false);

        //Inicializar variables, Arrays, GridViews,... y metodos
        TabLayout tl = view.findViewById(R.id.tablayoutranking);
        this.ma = (MainActivity) getActivity();
        for ( Genero : this.ma.generos) {

        }

        return view;
    }
}