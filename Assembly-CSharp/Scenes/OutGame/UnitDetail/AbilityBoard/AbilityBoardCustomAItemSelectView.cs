// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardCustomAItemSelectView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x2003317")]
  public class AbilityBoardCustomAItemSelectView : PopupBase
  {
    [Token(Token = "0x400DCB8")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text[] texts;
    [Token(Token = "0x400DCB9")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private AbilityBoardSelectContent selectContent;
    [Token(Token = "0x400DCBA")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text[] effects;
    [Token(Token = "0x400DCBB")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text[] bonuses;
    [Token(Token = "0x400DCBC")]
    [FieldOffset(Offset = "0xA8")]
    private Dictionary<int, AbilityBoardSelectContent> selectContentDic;
    [Token(Token = "0x400DCBD")]
    [FieldOffset(Offset = "0xB0")]
    private Style style;
    [Token(Token = "0x400DCBE")]
    [FieldOffset(Offset = "0xB8")]
    private AbilityBoardStyleSettingData styleSettingData;
    [Token(Token = "0x400DCBF")]
    [FieldOffset(Offset = "0xC0")]
    private AbilityBoardNodeData nodeData;
    [Token(Token = "0x400DCC0")]
    [FieldOffset(Offset = "0xC8")]
    private MoldTypeEnum selectMoldType;
    [Token(Token = "0x400DCC1")]
    [FieldOffset(Offset = "0xCC")]
    private int customId;
    [Token(Token = "0x400DCC2")]
    [FieldOffset(Offset = "0xD0")]
    public IItemDetailController itemDetailController;
    [Token(Token = "0x400DCC3")]
    [FieldOffset(Offset = "0xD8")]
    public IAbilityBoardIconLoader iconLoader;
    [Token(Token = "0x400DCC4")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400DCC5")]
    [FieldOffset(Offset = "0xE8")]
    public Action<MoldTypeEnum> CloseAction;

    [Token(Token = "0x601413E")]
    [Address(RVA = "0x20BF4A4", Offset = "0x20BF4A4", VA = "0x20BF4A4")]
    public void SetData(
      Style style,
      AbilityBoardStyleSettingData styleSettingData,
      AbilityBoardNodeData nodeData,
      MoldTypeEnum selectMoldType,
      int customId)
    {
    }

    [Token(Token = "0x601413F")]
    [Address(RVA = "0x20BF88C", Offset = "0x20BF88C", VA = "0x20BF88C")]
    private void UpdateView()
    {
    }

    [Token(Token = "0x6014140")]
    [Address(RVA = "0x20BFAF8", Offset = "0x20BFAF8", VA = "0x20BFAF8")]
    public void OnSelectButton(int index, int moldType)
    {
    }

    [Token(Token = "0x6014141")]
    [Address(RVA = "0x20BF590", Offset = "0x20BF590", VA = "0x20BF590")]
    private void SetItemInfo()
    {
    }

    [Token(Token = "0x6014142")]
    [Address(RVA = "0x20C0008", Offset = "0x20C0008", VA = "0x20C0008")]
    public void OnCloseButton()
    {
    }

    [Token(Token = "0x6014143")]
    [Address(RVA = "0x20C02E0", Offset = "0x20C02E0", VA = "0x20C02E0")]
    public AbilityBoardCustomAItemSelectView()
    {
    }
  }
}
