// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.Mindequipment.ConversionCompleted.ConversionCompletedPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.Mindequipment.ConversionCompleted
{
  [Token(Token = "0x2003C0A")]
  public class ConversionCompletedPopup : PopupBase
  {
    [Token(Token = "0x4010A03")]
    private const string AssetBundleName = "ui_page_mnemnographlist";
    [Token(Token = "0x4010A04")]
    private const string AssetName = "Com_Popup_Base_S_ComversionCompleted";
    [Token(Token = "0x4010A05")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private ConversionCompletedPresenter _presenter;

    [Token(Token = "0x601799F")]
    [Address(RVA = "0x237EC40", Offset = "0x237EC40", VA = "0x237EC40")]
    public static IEnumerator RequestAsync(
      AssetCachedSpawner assetCachedSpawner,
      ConversionContext contex,
      Action callback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60179A0")]
    [Address(RVA = "0x237EE04", Offset = "0x237EE04", VA = "0x237EE04")]
    private void Initialize(in ConversionContext context)
    {
    }

    [Token(Token = "0x60179A1")]
    [Address(RVA = "0x237F08C", Offset = "0x237F08C", VA = "0x237F08C")]
    private void InitializeAndOpen(in ConversionContext context)
    {
    }

    [Token(Token = "0x60179A2")]
    [Address(RVA = "0x237F1F4", Offset = "0x237F1F4", VA = "0x237F1F4")]
    public ConversionCompletedPopup()
    {
    }
  }
}
