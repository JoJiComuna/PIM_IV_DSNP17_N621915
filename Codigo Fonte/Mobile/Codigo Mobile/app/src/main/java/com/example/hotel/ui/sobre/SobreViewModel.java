package com.example.hotel.ui.sobre;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MutableLiveData;
import androidx.lifecycle.ViewModel;

public class SobreViewModel extends ViewModel
{

    private MutableLiveData<String> mText;

    public SobreViewModel()
    {
        mText = new MutableLiveData<>();
        mText.setValue("");
    }

    public LiveData<String> getText()
    {
        return mText;
    }


}