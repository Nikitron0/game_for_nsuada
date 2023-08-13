using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class ClosedDoor : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("����� �������", "���"));

        dialogTexts.Add(new DialogData("�� ����� ��� ����� ��������", "���"));

        DialogManager.Show(dialogTexts);
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }
}
