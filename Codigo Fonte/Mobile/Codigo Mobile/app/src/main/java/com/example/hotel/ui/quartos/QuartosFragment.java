package com.example.hotel.ui.quartos;

import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.lifecycle.Observer;
import androidx.lifecycle.ViewModelProvider;

import com.example.hotel.CadasHospede;
import com.example.hotel.NewReserva;
import com.example.hotel.databinding.FragmentQuartosBinding;
import com.example.hotel.tl_Quartos;

public class QuartosFragment extends Fragment
{

    private QuartosViewModel quartosViewModel;
    private FragmentQuartosBinding binding;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState)
    {
        quartosViewModel =
                new ViewModelProvider(this).get(QuartosViewModel.class);

        binding = FragmentQuartosBinding.inflate(inflater, container, false);
        View root = binding.getRoot();

        final TextView textView = binding.textQuartos;
        quartosViewModel.getText().observe(getViewLifecycleOwner(), new Observer<String>()
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