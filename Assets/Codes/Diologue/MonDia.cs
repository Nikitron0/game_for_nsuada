using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class MonDia : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Дух монументального искусства: Добрый день!", "Чел"));

        dialogTexts.Add(new DialogData("Егор: И вам добрый день!", "Чел"));

        dialogTexts.Add(new DialogData("Дух монументального искусства: Я Дух монументального искусства. Мы создаем искусство в чистом его виде!", "Чел"));

        dialogTexts.Add(new DialogData("Дух монументального искусства: Мы воплощаем идеи большого количества людей, делаем пространство не таким скучным и серым.", "Чел"));

        dialogTexts.Add(new DialogData("Дух монументального искусства: Тебе нравится здесь?", "Чел"));

        dialogTexts.Add(new DialogData("Егор: Ага, ваш вуз такой красивый, особенно витражные окна. На полу такие весёлые разноцветные блики благодаря им", "Чел"));

        dialogTexts.Add(new DialogData("Дух монументального искусства: Хочешь внести часть себя в наш вуз?", "Чел"));

        dialogTexts.Add(new DialogData("Егор: Ч-чего?", "Чел"));

        dialogTexts.Add(new DialogData("Дух монументального искусства: Помоги мне собрать один очень красивый витраж по кусочкам и помещение заиграет новыми красками!", "Чел"));

        DialogManager.Show(dialogTexts);
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }
}
