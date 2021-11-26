package com.example.hotel;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class tl_Quartos extends AppCompatActivity
{

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tl_quartos);
    }




    public void ClicaBotao10(View view)
    {


        startActivity(new Intent(tl_Quartos.this, NewReserva.class));
    }

    public void ClicaBotao11(View view)
    {


        startActivity(new Intent(tl_Quartos.this, NewReserva.class));
    }


}