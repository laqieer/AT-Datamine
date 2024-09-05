// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaDefenseResultPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x20030F9")]
  public class ArenaDefenseResultPopup : PopupBase
  {
    [Token(Token = "0x400D07C")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private StyleThumb styleThumbPrefab;
    [Token(Token = "0x400D07D")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text winResultText;
    [Token(Token = "0x400D07E")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text loseResultText;
    [Token(Token = "0x400D07F")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject presentResultText;
    [Token(Token = "0x400D080")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private CommonButton buttonClose;
    [Token(Token = "0x400D081")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private CommonButton buttonEdit;
    [Token(Token = "0x400D082")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private List<Transform> styleParent;
    [Token(Token = "0x400D083")]
    [FieldOffset(Offset = "0xC0")]
    private ArenaTopSceneBase sceneBase;
    [Token(Token = "0x400D084")]
    [FieldOffset(Offset = "0xC8")]
    private Action callback;

    [Token(Token = "0x6013232")]
    [Address(RVA = "0x45DDE80", Offset = "0x45DDE80", VA = "0x45DDE80")]
    public IEnumerator InitializeWithOpen(
      ArenaTopSceneBase sceneBase,
      int winCount,
      int loseCount,
      Action callback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6013233")]
    [Address(RVA = "0x45DDF38", Offset = "0x45DDF38", VA = "0x45DDF38", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x6013234")]
    [Address(RVA = "0x45DDF40", Offset = "0x45DDF40", VA = "0x45DDF40", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6013235")]
    [Address(RVA = "0x45DDF74", Offset = "0x45DDF74", VA = "0x45DDF74")]
    public void Edit()
    {
    }

    [Token(Token = "0x6013236")]
    [Address(RVA = "0x45DE080", Offset = "0x45DE080", VA = "0x45DE080")]
    private (string, string) GetBundle(int styleId) => ();

    [Token(Token = "0x6013237")]
    [Address(RVA = "0x45DE100", Offset = "0x45DE100", VA = "0x45DE100")]
    private void SetupStyleThumbnail(Style style, Transform parent)
    {
    }

    [Token(Token = "0x6013238")]
    [Address(RVA = "0x45DE2B0", Offset = "0x45DE2B0", VA = "0x45DE2B0")]
    public ArenaDefenseResultPopup()
    {
    }
  }
}
