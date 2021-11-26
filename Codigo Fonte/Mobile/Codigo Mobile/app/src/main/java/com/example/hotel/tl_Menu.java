package com.example.hotel;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.Menu;

import com.example.hotel.ui.quartos.QuartosFragment;
import com.google.android.material.snackbar.Snackbar;
import com.google.android.material.navigation.NavigationView;

import androidx.navigation.NavController;
import androidx.navigation.Navigation;
import androidx.navigation.ui.AppBarConfiguration;
import androidx.navigation.ui.NavigationUI;
import androidx.drawerlayout.widget.DrawerLayout;
import androidx.appcompat.app.AppCompatActivity;

import com.example.hotel.databinding.ActivityTlMenuBinding;

public class tl_Menu extends AppCompatActivity
{

    private AppBarConfiguration mAppBarConfiguration;
    private ActivityTlMenuBinding binding;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);

        binding = ActivityTlMenuBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        setSupportActionBar(binding.appBarTlMenu.toolbar);


        DrawerLayout drawer = binding.drawerLayout;
        NavigationView navigationView = binding.navView;
        // Passing each menu ID as a set of Ids because each
        // menu should be considered as top level destinations.
        mAppBarConfiguration = new AppBarConfiguration.Builder(
                R.id.nav_home, R.id.nav_perfil, R.id.nav_quartos, R.id.reservaFragment, R.id.sobreFragment)
                .setOpenableLayout(drawer)
                .build();
        NavController navController = Navigation.findNavController(this, R.id.nav_host_fragment_content_tl_menu);
        NavigationUI.setupActionBarWithNavController(this, navController, mAppBarConfiguration);
        NavigationUI.setupWithNavController(navigationView, navController);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu)
    {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.tl__menu, menu);
        return true;
    }

    @Override
    public boolean onSupportNavigateUp()
    {
        NavController navController = Navigation.findNavController(this, R.id.nav_host_fragment_content_tl_menu);
        return NavigationUI.navigateUp(navController, mAppBarConfiguration)
                || super.onSupportNavigateUp();



    }



    public void ClicaBotao05(View view)
    {

        Intent intent = new Intent(this,tl_Sobre.class);
        startActivity(intent);


    }

    public void ClicaBotao11(View view)
    {

        Intent intent = new Intent(this,CadasHospede.class);
        startActivity(intent);


    }

    public void ClicaBotao09(View view)
    {

        Intent intent = new Intent(this,tl_Quartos.class);
        startActivity(intent);


    }
    public void ClicaBotao10(View view)
    {


        startActivity(new Intent(this, NewReserva.class));
    }

    public void ClicaBotao15(View view)
    {


        startActivity(new Intent(this, NewReserva.class));
    }

    public void ClicaBotao19(View view)
    {


        startActivity(new Intent(this, tl_AlterarReserva.class));
    }
    public void ClicaBotao30(View view)
    {


        startActivity(new Intent(this, NewReserva.class));
    }




}