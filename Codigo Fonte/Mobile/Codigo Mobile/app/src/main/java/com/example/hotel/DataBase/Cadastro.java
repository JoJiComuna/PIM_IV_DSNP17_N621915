package com.example.hotel.DataBase;

import android.provider.BaseColumns;

class CadastroContract {

    private CadastroContract() {}

    /* Inner class that defines the table contents */
    public static class Cadastro implements BaseColumns {
        public static final String TABLE_NAME = "cadastro";
        public static final String COLUMN_NAME_USERNAME = "cadastro_name";
        public static final String COLUMN_NAME_EMAIL = "cadastro_email";
        public static final String COLUMN_NAME_SENHA = "cadastro_senha";
    }
}
