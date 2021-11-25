package com.example.madu_project;

import android.app.Activity;
import android.app.AlertDialog;
import android.os.Bundle;

import androidx.core.content.ContextCompat;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;
import androidx.recyclerview.widget.DividerItemDecoration;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ListView;
import android.widget.TextView;

import java.util.ArrayList;


public class FragmentMenu extends Fragment {

   View view;
   MainActivity activity;
   ArrayList<Genero> generos;
   ArrayList<Pregunta> preguntas;
   RecyclerView listGeneros;


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        view = inflater.inflate(R.layout.fragment_menu, container, false);

        activity = (MainActivity) getActivity();

        generos = activity.generos;

        listGeneros = view.findViewById(R.id.ListGeneros);
        GeneroAdapter adapter = new GeneroAdapter(generos);
        listGeneros.setHasFixedSize(true);
        listGeneros.setLayoutManager(new LinearLayoutManager(getActivity(),LinearLayoutManager.HORIZONTAL,false));


        listGeneros.setAdapter(adapter);

        DividerItemDecoration dividerItemDecoration = new DividerItemDecoration(getContext(),DividerItemDecoration.HORIZONTAL);

        dividerItemDecoration.setDrawable(ContextCompat.getDrawable(getContext(),R.drawable.divider));
        listGeneros.addItemDecoration(dividerItemDecoration);





        adapter.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                Genero genero = (Genero) generos.get(listGeneros.getChildAdapterPosition(view));

                preguntas = genero.getPreguntas();

                Bundle bundle = new Bundle();
                bundle.putSerializable("pregunta",preguntas);
                getParentFragmentManager().setFragmentResult("preguntas",bundle);

                FragmentManager mg = getFragmentManager();
                FragmentTransaction fragmentTransaction = mg.beginTransaction();

                FragmentPreguntas fragmentPreguntas = new FragmentPreguntas();
                fragmentTransaction.replace(R.id.ContenedorFragmentsPricipales,fragmentPreguntas);
                fragmentTransaction.commit();



            }
        });



        return view;
    }
}