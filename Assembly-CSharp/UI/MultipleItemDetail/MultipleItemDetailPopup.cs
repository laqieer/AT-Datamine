// Decompiled with JetBrains decompiler
// Type: UI.MultipleItemDetail.MultipleItemDetailPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace UI.MultipleItemDetail
{
  [Token(Token = "0x20008B7")]
  public class MultipleItemDetailPopup : PopupBase
  {
    [Token(Token = "0x40028E5")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x40028E6")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject content;
    [Token(Token = "0x40028E7")]
    [FieldOffset(Offset = "0x98")]
    private MultipleItemDetailPopupResource resource;
    [Token(Token = "0x40028E8")]
    [FieldOffset(Offset = "0xA0")]
    private List<UI.MultipleItemDetail.MultipleItemDetail> items;

    [Token(Token = "0x1700072A")]
    private Action onClickToClose
    {
      [Token(Token = "0x600317B"), Address(RVA = "0x3C188EC", Offset = "0x3C188EC", VA = "0x3C188EC")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x600317C"), Address(RVA = "0x3C188F4", Offset = "0x3C188F4", VA = "0x3C188F4")] set
      {
      }
    }

    [Token(Token = "0x600317D")]
    [Address(RVA = "0x3C188FC", Offset = "0x3C188FC", VA = "0x3C188FC")]
    public void InitializeAsync(
      MultipleItemDetailPopupResource resource,
      MultipleItemDetailParamater[] paramaters,
      Action onInitializeFinished,
      Action onClosed)
    {
    }

    [Token(Token = "0x600317E")]
    [Address(RVA = "0x3C18A58", Offset = "0x3C18A58", VA = "0x3C18A58")]
    private void InitializeCloseButton(Action onClosed)
    {
    }

    [Token(Token = "0x600317F")]
    [Address(RVA = "0x3C18AFC", Offset = "0x3C18AFC", VA = "0x3C18AFC")]
    private void InitializeContent(MultipleItemDetailParamater[] paramaters)
    {
    }

    [Token(Token = "0x6003180")]
    [Address(RVA = "0x3C18E28", Offset = "0x3C18E28", VA = "0x3C18E28")]
    private UI.MultipleItemDetail.MultipleItemDetail GenerateMultipleItemDetail(
      MultipleItemDetailParamater parameter)
    {
      return (UI.MultipleItemDetail.MultipleItemDetail) null;
    }

    [Token(Token = "0x6003181")]
    [Address(RVA = "0x3C18D78", Offset = "0x3C18D78", VA = "0x3C18D78")]
    private void DeleteChild(Transform trans)
    {
    }

    [Token(Token = "0x6003182")]
    [Address(RVA = "0x3C18F34", Offset = "0x3C18F34", VA = "0x3C18F34", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6003183")]
    [Address(RVA = "0x3C18FD0", Offset = "0x3C18FD0", VA = "0x3C18FD0")]
    public MultipleItemDetailPopup()
    {
    }
  }
}
