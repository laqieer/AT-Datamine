// Decompiled with JetBrains decompiler
// Type: Gacha.GachaProvidePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.Popup;
using HTMLViewer;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x200154B")]
  public class GachaProvidePopup : PopupBase
  {
    [Token(Token = "0x40061D3")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Transform content;
    [Token(Token = "0x40061D4")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x40061D5")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Toggle toggleRatio;
    [Token(Token = "0x40061D6")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Toggle toggleDetail;
    [Token(Token = "0x40061D7")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private HTMLView htmlView;
    [Token(Token = "0x40061D8")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x40061D9")]
    [FieldOffset(Offset = "0xB8")]
    private string ratioBody;
    [Token(Token = "0x40061DA")]
    [FieldOffset(Offset = "0xC0")]
    private string detailBody;
    [Token(Token = "0x40061DB")]
    [FieldOffset(Offset = "0xC8")]
    private bool isOpenedDetail;

    [Token(Token = "0x600789E")]
    [Address(RVA = "0x44FC824", Offset = "0x44FC824", VA = "0x44FC824")]
    public void Initialize(
      string ratioBody,
      string detailBody,
      Action<bool> closeAction,
      bool isRatio)
    {
    }

    [Token(Token = "0x600789F")]
    [Address(RVA = "0x44FCAF4", Offset = "0x44FCAF4", VA = "0x44FCAF4", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x60078A0")]
    [Address(RVA = "0x44FCAFC", Offset = "0x44FCAFC", VA = "0x44FCAFC", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x60078A1")]
    [Address(RVA = "0x44FCB04", Offset = "0x44FCB04", VA = "0x44FCB04")]
    public GachaProvidePopup()
    {
    }
  }
}
