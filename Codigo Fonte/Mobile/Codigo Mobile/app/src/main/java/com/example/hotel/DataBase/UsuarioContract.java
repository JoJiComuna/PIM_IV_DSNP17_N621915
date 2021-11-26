package com.example.hotel.DataBase;

import android.provider.BaseColumns;

public final class UsuarioContract {
    // To prevent someone from accidentally instantiating the contract class,
    // make the constructor private.
    private UsuarioContract() {}

    /* Inner class that defines the table contents */
    public static class Usuario implements BaseColumns {
        public static final String TABLE_NAME = "usuario";
        public static final String COLUMN_NAME_USERNAME = "username";
        public static final String COLUMN_NAME_EMAIL = "email";
        public static final String COLUMN_NAME_SENHA = "senha";
    }
}