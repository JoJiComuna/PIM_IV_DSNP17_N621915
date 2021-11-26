package com.example.hotel.ui.reserva;

import android.view.View;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MutableLiveData;
import androidx.lifecycle.ViewModel;

public class ReservaViewModel extends ViewModel

{

    private MutableLiveData<String> mText;

    public ReservaViewModel()
    {
        mText = new MutableLiveData<>();
        mText.setValue("");
    }

    public LiveData<String> getText()
    {
        return mText;
    }



}