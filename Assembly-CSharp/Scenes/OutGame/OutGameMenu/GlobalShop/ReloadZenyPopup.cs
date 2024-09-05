// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GlobalShop.ReloadZenyPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.GlobalShop
{
  [Token(Token = "0x2003BC5")]
  public class ReloadZenyPopup : PopupBase
  {
    [Token(Token = "0x4010885")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text necessaryZenyTxt;
    [Token(Token = "0x4010886")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text beforeZenyTxt;
    [Token(Token = "0x4010887")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text afterZenyTxt;
    [Token(Token = "0x4010888")]
    [FieldOffset(Offset = "0xA0")]
    private bool isComfirm;

    [Token(Token = "0x17004C57")]
    public Action<bool> OnClickConfrim
    {
      [Token(Token = "0x60177FE"), Address(RVA = "0x265A764", Offset = "0x265A764", VA = "0x265A764")] get
      {
        return (Action<bool>) null;
      }
      [Token(Token = "0x60177FF"), Address(RVA = "0x265A76C", Offset = "0x265A76C", VA = "0x265A76C")] set
      {
      }
    }

    [Token(Token = "0x17004C58")]
    public Action OnClickCancel
    {
      [Token(Token = "0x6017800"), Address(RVA = "0x265A774", Offset = "0x265A774", VA = "0x265A774")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6017801"), Address(RVA = "0x265A77C", Offset = "0x265A77C", VA = "0x265A77C")] set
      {
      }
    }

    [Token(Token = "0x6017802")]
    [Address(RVA = "0x265A784", Offset = "0x265A784", VA = "0x265A784")]
    public void SetData(PlayerShopResetButtonType resetButtonType)
    {
    }

    [Token(Token = "0x6017803")]
    [Address(RVA = "0x265A98C", Offset = "0x265A98C", VA = "0x265A98C")]
    public void OnClickToConfirm()
    {
    }

    [Token(Token = "0x6017804")]
    [Address(RVA = "0x265A9AC", Offset = "0x265A9AC", VA = "0x265A9AC")]
    public void OnClickToCancel()
    {
    }

    [Token(Token = "0x6017805")]
    [Address(RVA = "0x265A9C8", Offset = "0x265A9C8", VA = "0x265A9C8")]
    public ReloadZenyPopup()
    {
    }
  }
}
