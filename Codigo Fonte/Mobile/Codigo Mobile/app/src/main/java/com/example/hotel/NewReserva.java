package com.example.hotel;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Toast;

public class NewReserva extends AppCompatActivity
{

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_new_reserva);
    }

    public void ClicaBotao12(View view)
    {
        Toast.makeText(this, "Reservado com Sucesso", Toast.LENGTH_SHORT).show();
    }



    public void ClicaBotao13(View view)
    {

        startActivity(new Intent(NewReserva.this, tl_Quartos.class));

    }

}