package com.example.hotel.ui.quartos;

import android.content.Intent;
import android.view.View;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MutableLiveData;
import androidx.lifecycle.ViewModel;

import com.example.hotel.NewReserva;
import com.example.hotel.tl_Quartos;

public class QuartosViewModel extends ViewModel
{

    private MutableLiveData<String> mText;

    public QuartosViewModel()
    {
        mText = new MutableLiveData<>();
        mText.setValue("");
    }

    public LiveData<String> getText()
    {
        return mText;
    }


}