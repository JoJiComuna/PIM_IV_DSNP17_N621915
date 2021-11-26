package com.example.hotel.ui.reserva;

import androidx.lifecycle.Observer;
import androidx.lifecycle.ViewModelProvider;

import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import com.example.hotel.databinding.ReservaFragmentBinding;


public class ReservaFragment extends Fragment
{


    private ReservaViewModel reservaViewModel;
    private ReservaFragmentBinding binding;




    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState)
    {
        reservaViewModel =
                new ViewModelProvider(this).get(ReservaViewModel.class);

        binding = ReservaFragmentBinding.inflate(inflater, container, false);
        View root = binding.getRoot();

        final TextView textView = binding.textReserva;
        reservaViewModel.getText().observe(getViewLifecycleOwner(), new Observer<String>()
        {
            @Override
            public void onChanged(@Nullable String s)
            {
                textView.setText(s);
            }
        });
        return root;




    }

    @Override
    public void onDestroyView()
    {
        super.onDestroyView();
        binding = null;
    }



}
