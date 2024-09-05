// Decompiled with JetBrains decompiler
// Type: GameCore.Toaster.ToasterManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using GameCore.DLC;
using Il2CppDummyDll;
using Scenes.Story;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace GameCore.Toaster
{
  [Token(Token = "0x2000C34")]
  public class ToasterManager : SingletonMonoBehaviour<ToasterManager>
  {
    [Token(Token = "0x4003759")]
    private const string NoTitleToasterAssetPath = "UI/Common/Prefab/Com_Toaster_A";
    [Token(Token = "0x400375A")]
    private const string ToasterAssetPath = "UI/Common/Prefab/Com_Toaster_B";
    [Token(Token = "0x400375B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform toasterParent;
    [Token(Token = "0x400375C")]
    [FieldOffset(Offset = "0x28")]
    private ToasterUI noTitleToaster;
    [Token(Token = "0x400375D")]
    [FieldOffset(Offset = "0x30")]
    private ToasterUI toaster;
    [Token(Token = "0x400375E")]
    [FieldOffset(Offset = "0x38")]
    private GameObject loadingProgressObject;
    [Token(Token = "0x400375F")]
    [FieldOffset(Offset = "0x40")]
    private GameObject loadingSimpleObject;

    [Token(Token = "0x6004620")]
    [Address(RVA = "0x3514B14", Offset = "0x3514B14", VA = "0x3514B14")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6004621")]
    [Address(RVA = "0x3514BA4", Offset = "0x3514BA4", VA = "0x3514BA4")]
    public void ShowToaster(string title, string message, Action onComplete = null)
    {
    }

    [Token(Token = "0x6004622")]
    [Address(RVA = "0x3514CCC", Offset = "0x3514CCC", VA = "0x3514CCC")]
    public void ShowToaster(string message, Action onComplete = null)
    {
    }

    [Token(Token = "0x6004623")]
    [Address(RVA = "0x3514DD4", Offset = "0x3514DD4", VA = "0x3514DD4")]
    public void ShowToasterByGetText(string abName, string key, Action onComplete = null)
    {
    }

    [Token(Token = "0x6004624")]
    [Address(RVA = "0x3514E5C", Offset = "0x3514E5C", VA = "0x3514E5C")]
    public void ShowToasterByGetTextSystem(string key, Action onComplete = null)
    {
    }

    [Token(Token = "0x6004625")]
    [Address(RVA = "0x3514EBC", Offset = "0x3514EBC", VA = "0x3514EBC")]
    private void OnClickBG(ToasterUI toaster)
    {
    }

    [Token(Token = "0x6004626")]
    [Address(RVA = "0x3514FC4", Offset = "0x3514FC4", VA = "0x3514FC4")]
    public void ShowLoadingPanel(bool enabledVideo)
    {
    }

    [Token(Token = "0x6004627")]
    [Address(RVA = "0x3515504", Offset = "0x3515504", VA = "0x3515504")]
    public void UpdateDownloadProgress(DLCProgress dlcProgress)
    {
    }

    [Token(Token = "0x6004628")]
    [Address(RVA = "0x351556C", Offset = "0x351556C", VA = "0x351556C")]
    public void HideLoadingPanel()
    {
    }

    [Token(Token = "0x6004629")]
    [Address(RVA = "0x3515644", Offset = "0x3515644", VA = "0x3515644")]
    public ToasterManager()
    {
    }
  }
}
