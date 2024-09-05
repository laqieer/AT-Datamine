// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.Reincarnation.ReincarnationPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Network.API;
using StaqData;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.Reincarnation
{
  [Token(Token = "0x20032E5")]
  public class ReincarnationPopup : PopupBase
  {
    [Token(Token = "0x400DB9A")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text costText;
    [Token(Token = "0x400DB9B")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ItemContainer itemContainer;
    [Token(Token = "0x400DB9C")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private DataContainer beforeContainer;
    [Token(Token = "0x400DB9D")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private DataContainer afterContainer;
    [Token(Token = "0x400DB9E")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text reincarnationCountText;
    [Token(Token = "0x400DB9F")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text surplusExp;
    [Token(Token = "0x400DBA0")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text afterLevel;
    [Token(Token = "0x400DBA1")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Color warningColor;
    [Token(Token = "0x400DBA2")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Color defaultColor;
    [Token(Token = "0x400DBA3")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private RectTransform alertParent;
    [Token(Token = "0x400DBA4")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private CommonButton disableConfirmButton;
    [Token(Token = "0x400DBA5")]
    [FieldOffset(Offset = "0xF0")]
    private Style style;
    [Token(Token = "0x400DBA6")]
    [FieldOffset(Offset = "0xF8")]
    private APIUnitReincarnationReset unitReincarnationResetApi;
    [Token(Token = "0x400DBA7")]
    [FieldOffset(Offset = "0x100")]
    private bool isConenctApi;
    [Token(Token = "0x400DBA8")]
    [FieldOffset(Offset = "0x101")]
    private bool isEnoughCost;

    [Token(Token = "0x1700431A")]
    public Action UpdateUnit
    {
      [Token(Token = "0x6013FF5"), Address(RVA = "0x2348DDC", Offset = "0x2348DDC", VA = "0x2348DDC")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6013FF6"), Address(RVA = "0x2348DE4", Offset = "0x2348DE4", VA = "0x2348DE4")] set
      {
      }
    }

    [Token(Token = "0x1700431B")]
    public Action OpenSavePopup
    {
      [Token(Token = "0x6013FF7"), Address(RVA = "0x2348DEC", Offset = "0x2348DEC", VA = "0x2348DEC")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6013FF8"), Address(RVA = "0x2348DF4", Offset = "0x2348DF4", VA = "0x2348DF4")] set
      {
      }
    }

    [Token(Token = "0x6013FF9")]
    [Address(RVA = "0x2348DFC", Offset = "0x2348DFC", VA = "0x2348DFC")]
    public void SetData(Style style)
    {
    }

    [Token(Token = "0x6013FFA")]
    [Address(RVA = "0x2349368", Offset = "0x2349368", VA = "0x2349368")]
    public void OnClickToDisableConfirm()
    {
    }

    [Token(Token = "0x6013FFB")]
    [Address(RVA = "0x234925C", Offset = "0x234925C", VA = "0x234925C")]
    private void ViewToReincarnation()
    {
    }

    [Token(Token = "0x6013FFC")]
    [Address(RVA = "0x2349444", Offset = "0x2349444", VA = "0x2349444")]
    private bool CheckConnectApi() => new bool();

    [Token(Token = "0x6013FFD")]
    [Address(RVA = "0x234960C", Offset = "0x234960C", VA = "0x234960C")]
    public void OnClickToConfirm()
    {
    }

    [Token(Token = "0x6013FFE")]
    [Address(RVA = "0x2349744", Offset = "0x2349744", VA = "0x2349744")]
    private IEnumerator ConnectToReincarnation() => (IEnumerator) null;

    [Token(Token = "0x6013FFF")]
    [Address(RVA = "0x23497D4", Offset = "0x23497D4", VA = "0x23497D4")]
    public void OnClickToSave()
    {
    }

    [Token(Token = "0x6014000")]
    [Address(RVA = "0x23497F0", Offset = "0x23497F0", VA = "0x23497F0")]
    public ReincarnationPopup()
    {
    }
  }
}
