using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class locale_manager : MonoBehaviour
{
    private bool active = false;
    int localId = 0;

    public void ChangeLocal()
    {
        if(active){
            return;
        }
        if(localId == 0){
            StartCoroutine(SetLocale(1));
        }
        else{
            StartCoroutine(SetLocale(0));
        }


    }

    IEnumerator SetLocale(int local){
        if(local == 1){
            localId = 1;
        }
        else{
            localId = 0;
        }
        active = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[local];
        active = false;
    }
}

