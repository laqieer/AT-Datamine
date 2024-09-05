// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.LimitBreak.LimitBreakPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Network.API;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.LimitBreak
{
  [Token(Token = "0x20032E8")]
  public class LimitBreakPopup : PopupBase
  {
    [Token(Token = "0x400DBB4")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Image charaImage;
    [Token(Token = "0x400DBB5")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TextMeshProUGUI lvText;
    [Token(Token = "0x400DBB6")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private LimitBreakPopup.TextGroup limitBreakGroup;
    [Token(Token = "0x400DBB7")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Image[] limitBreakIcons;
    [Token(Token = "0x400DBB8")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private LimitBreakPopup.TextGroup lvMaxGroup;
    [Token(Token = "0x400DBB9")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Image[] equipFilters;
    [Token(Token = "0x400DBBA")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Image[] nextEquipFilters;
    [Token(Token = "0x400DBBB")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private RectTransform itemContainerParent;
    [Token(Token = "0x400DBBC")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private ItemConteiner itemConteinerBase;
    [Token(Token = "0x400DBBD")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GameObject enableRarityUpButton;
    [Token(Token = "0x400DBBE")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private GameObject disableRarityUpButton;
    [Token(Token = "0x400DBBF")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private RectTransform alertUiParent;
    [Token(Token = "0x400DBC0")]
    [FieldOffset(Offset = "0xE8")]
    private Style style;
    [Token(Token = "0x400DBC1")]
    [FieldOffset(Offset = "0xF0")]
    private List<ItemConteiner> createdItemConteiners;
    [Token(Token = "0x400DBC2")]
    [FieldOffset(Offset = "0xF8")]
    private bool isConnect;
    [Token(Token = "0x400DBC3")]
    [FieldOffset(Offset = "0xF9")]
    private bool isItemCost;
    [Token(Token = "0x400DBC4")]
    [FieldOffset(Offset = "0x100")]
    private APIUnitRarityup unitRarityupApi;

    [Token(Token = "0x1700431F")]
    public Action UpdateUnit
    {
      [Token(Token = "0x601400A"), Address(RVA = "0x2349D28", Offset = "0x2349D28", VA = "0x2349D28")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x601400B"), Address(RVA = "0x2349D30", Offset = "0x2349D30", VA = "0x2349D30")] set
      {
      }
    }

    [Token(Token = "0x601400C")]
    [Address(RVA = "0x2349D38", Offset = "0x2349D38", VA = "0x2349D38")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x601400D")]
    [Address(RVA = "0x2349F08", Offset = "0x2349F08", VA = "0x2349F08")]
    public void SetData(Style style)
    {
    }

    [Token(Token = "0x601400E")]
    [Address(RVA = "0x234A578", Offset = "0x234A578", VA = "0x234A578")]
    private void SetItem()
    {
    }

    [Token(Token = "0x601400F")]
    [Address(RVA = "0x234AEA8", Offset = "0x234AEA8", VA = "0x234AEA8")]
    private void CreateItemObject(int itemId, int necessaryNum, int possessionNum)
    {
    }

    [Token(Token = "0x6014010")]
    [Address(RVA = "0x234AF74", Offset = "0x234AF74", VA = "0x234AF74")]
    private bool CheckCost() => new bool();

    [Token(Token = "0x6014011")]
    [Address(RVA = "0x234AF7C", Offset = "0x234AF7C", VA = "0x234AF7C")]
    public void OnClickToRarityUp()
    {
    }

    [Token(Token = "0x6014012")]
    [Address(RVA = "0x234B020", Offset = "0x234B020", VA = "0x234B020")]
    public void OnClickToDisableRarityUp()
    {
    }

    [Token(Token = "0x6014013")]
    [Address(RVA = "0x234AFB8", Offset = "0x234AFB8", VA = "0x234AFB8")]
    private IEnumerator ConnectToApi() => (IEnumerator) null;

    [Token(Token = "0x6014014")]
    [Address(RVA = "0x234B0DC", Offset = "0x234B0DC", VA = "0x234B0DC")]
    public LimitBreakPopup()
    {
    }

    [Token(Token = "0x20032E9")]
    [Serializable]
    public class TextGroup
    {
      [Token(Token = "0x400DBC6")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private Text beforeTxt;
      [Token(Token = "0x400DBC7")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private Text beforeMaxTxt;
      [Token(Token = "0x400DBC8")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private Text afterTxt;
      [Token(Token = "0x400DBC9")]
      [FieldOffset(Offset = "0x28")]
      [SerializeField]
      private Text afterMaxTxt;

      [Token(Token = "0x6014015")]
      [Address(RVA = "0x234A49C", Offset = "0x234A49C", VA = "0x234A49C")]
      public void Set(int before, int beforeMax, int after, int afterMax)
      {
      }

      [Token(Token = "0x6014016")]
      [Address(RVA = "0x234B1F4", Offset = "0x234B1F4", VA = "0x234B1F4")]
      public TextGroup()
      {
      }
    }
  }
}
