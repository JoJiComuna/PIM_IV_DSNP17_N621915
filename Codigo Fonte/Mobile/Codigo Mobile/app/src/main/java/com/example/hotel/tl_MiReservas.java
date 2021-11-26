package com.example.hotel;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class tl_MiReservas extends AppCompatActivity
{

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tl_mi_reservas);
    }

    public void ClicaBotao19(View view)
    {


        startActivity(new Intent(tl_MiReservas.this, tl_AlterarReserva.class));
    }

    public void ClicaBotao30(View view)
    {


        startActivity(new Intent(this, NewReserva.class));
    }
}