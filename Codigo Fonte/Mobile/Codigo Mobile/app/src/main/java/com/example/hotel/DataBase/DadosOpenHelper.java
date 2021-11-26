package com.example.hotel.DataBase;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class DadosOpenHelper extends SQLiteOpenHelper
{
    public static final int DATABASE_VERSION = 1;
    public static final String DATABASE_NAME = "Hotel.db";

    private static final String SQL_CREATE_ENTRIES =
        "CREATE TABLE " + CadastroContract.Cadastro.TABLE_NAME + " (" +
        CadastroContract.Cadastro._ID + " INTEGER PRIMARY KEY," +
        CadastroContract.Cadastro.COLUMN_NAME_USERNAME + " TEXT," +
        CadastroContract.Cadastro.COLUMN_NAME_EMAIL + " TEXT," +
        CadastroContract.Cadastro.COLUMN_NAME_SENHA + " TEXT)";

    private static final String SQL_DELETE_ENTRIES =
        "DROP TABLE IF EXISTS " + CadastroContract.Cadastro.TABLE_NAME;



    public DadosOpenHelper(@Nullable Context context )
    {
        super(context, "Dados", null, 1);
    }



    @Override
    public void onCreate(SQLiteDatabase db)
    {
        db.execSQL(SQL_CREATE_ENTRIES);
    }


    @Override
    public void onUpgrade(SQLiteDatabase db, int i, int i1)
    {
        db.execSQL(SQL_DELETE_ENTRIES);
        onCreate(db);
    }

}
