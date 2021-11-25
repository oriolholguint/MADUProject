package com.example.madu_project;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class GeneroAdapter extends RecyclerView.Adapter<GeneroAdapter.ViewHolder> implements View.OnClickListener
{
    private ArrayList<Genero> generos;
    private View.OnClickListener listener;

    public GeneroAdapter(ArrayList<Genero> generos)
    {
        this.generos = generos;
    }


    public static class ViewHolder extends RecyclerView.ViewHolder
    {
        TextView txtNombreGenero;

        public ViewHolder(@NonNull View item) {
            super(item);
            txtNombreGenero = item.findViewById(R.id.txtNombreGenero);
        }

        void bindGenero(Genero genero){
            txtNombreGenero.setText(genero.getNombre());
        }

    }


    @Override
    public ViewHolder onCreateViewHolder(ViewGroup parent, int viewType)
    {
        View item = LayoutInflater.from(parent.getContext()).
                inflate(R.layout.genero_item,parent,false);

        item.setOnClickListener(this);

        return new ViewHolder(item);
    }


    public void onBindViewHolder(ViewHolder holder, int position)
    {
        holder.bindGenero(generos.get(position));
    }

    public int getItemCount()
    {
        return generos.size();
    }


    public void setOnClickListener(View.OnClickListener listener)
    {
        this.listener = listener;
    }


    @Override
    public void onClick(View view) {
        if(listener != null){
            listener.onClick(view);
        }
    }


}
