package com.example.hotel;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.example.hotel.entity.UserEntity;
import com.orm.query.Condition;
import com.orm.query.Select;

public class MainActivity extends AppCompatActivity
{

    EditText Edt_Usuario, Edt_Senha;
    Button Btn_Login;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Edt_Usuario = findViewById(R.id.Edt_Usuario);
        Edt_Senha =  findViewById(R.id.Edt_Senha);
        Btn_Login =  findViewById(R.id.Btn_Login);




        /*
        Btn_Login.setOnClickListener((View) -> {




            startActivity(new Intent(MainActivity.this, Tl_Principal.class));
        });

         */


    }


    public void ClicaBotao(View view){

        final UserEntity user = Select.from(UserEntity.class)
                .where(Condition.prop("name").eq(Edt_Usuario.getText().toString()),
                Condition.prop("password").eq(Edt_Senha.getText().toString()))
                .first();

        if(user == null){
            Toast.makeText(this, "Usuario ou Senha Invalido", Toast.LENGTH_SHORT).show();
        } else {
            startActivity(new Intent(MainActivity.this, tl_Menu.class));
        }

//        if (Edt_Usuario.getText().toString().equals("admin") && Edt_Senha.getText().toString().equals("123"))
//            startActivity(new Intent(MainActivity.this, Tl_Principal.class));
//        else
//            Toast.makeText(this, "Usuario ou Senha Invalido", Toast.LENGTH_SHORT).show();


    }


    public void ClicaBotao02(View view)
    {


        startActivity(new Intent(MainActivity.this, Tl_Cadastro.class));

    }

    public void ClicaBotao03(View view)
    {


        startActivity(new Intent(MainActivity.this, tl_ESqueceu_senha.class));
    }


}


