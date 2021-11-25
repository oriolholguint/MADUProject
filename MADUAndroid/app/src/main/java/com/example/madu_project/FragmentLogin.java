package com.example.madu_project;

import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.Spinner;


public class FragmentLogin extends Fragment {

   View view;
   Spinner spredad;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        view = inflater.inflate(R.layout.fragment_login, container, false);

        spredad = view.findViewById(R.id.sprEdad);

        ArrayAdapter<CharSequence> adapter = ArrayAdapter.createFromResource(getActivity(),R.array.combo_edad,R.layout.support_simple_spinner_dropdown_item);
        spredad.setAdapter(adapter);


        return view;
    }
}