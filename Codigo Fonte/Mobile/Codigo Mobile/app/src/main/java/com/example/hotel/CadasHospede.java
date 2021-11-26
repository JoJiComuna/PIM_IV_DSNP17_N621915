package com.example.hotel;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class CadasHospede extends AppCompatActivity
{

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cadas_hospede);
    }

    public void ClicaBotao001(View view)
    {


        startActivity(new Intent(CadasHospede.this, tl_Menu.class));

    }


}