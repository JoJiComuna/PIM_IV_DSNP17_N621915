package com.example.hotel;

import androidx.appcompat.app.AppCompatActivity;

import android.content.ContentValues;
import android.content.Intent;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;


import com.example.hotel.DataBase.DadosOpenHelper;
import com.example.hotel.DataBase.UsuarioContract;
import com.example.hotel.R;
import com.example.hotel.entity.UserEntity;
import com.orm.query.Condition;
import com.orm.query.Select;

import static java.security.AccessController.getContext;

public class Tl_Cadastro extends AppCompatActivity
{

    EditText Edt_Usuario, Edt_Email, Edt_Senha;


    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tl_cadastro);

        Edt_Usuario = findViewById(R.id.Edt_Usuario);
        Edt_Email =  findViewById(R.id.Edt_Email);
        Edt_Senha = findViewById(R.id.Edt_Senha);

    }

    public void ClicaBotao04(View view){
//        // Gravar Dados
//        DadosOpenHelper dbHelper = new DadosOpenHelper(this);
//
//        SQLiteDatabase db = dbHelper.getWritableDatabase();
//
//        ContentValues values = new ContentValues();
//        values.put(UsuarioContract.Usuario.COLUMN_NAME_USERNAME, Edt_Usuario.getText().toString());
//        values.put(UsuarioContract.Usuario.COLUMN_NAME_EMAIL, Edt_Email.getText().toString());
//        values.put(UsuarioContract.Usuario.COLUMN_NAME_SENHA, Edt_Senha.getText().toString());
//
//        long newRowId = db.insert(UsuarioContract.Usuario.TABLE_NAME, null, values);

        final UserEntity registeredUser = Select.from(UserEntity.class)
                .where(Condition.prop("email").eq(Edt_Email.getText().toString()))
                .first();

        if(registeredUser == null){
            final UserEntity user = new UserEntity(Edt_Usuario.getText().toString(),
                    Edt_Email.getText().toString(),
                    Edt_Senha.getText().toString());

            user.save();
            Toast.makeText(this,"Usuario Cadastrado",Toast.LENGTH_SHORT).show();
        } else {
            Toast.makeText(this,"Este email já está cadastrado",Toast.LENGTH_SHORT).show();
        }
    }

    public void ClicaBotao07(View view)
    {


        startActivity(new Intent(Tl_Cadastro.this, MainActivity.class));
    }


}