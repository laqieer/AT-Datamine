// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.MasterBonus.ContainerElementMasterBonus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.MasterBonus
{
  [Token(Token = "0x2003527")]
  public class ContainerElementMasterBonus : MonoBehaviour
  {
    [Token(Token = "0x400E743")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<ContainerElementMasterBonus.ElementBonusView> containerElementMasterBonusListItems;
    [Token(Token = "0x400E744")]
    [FieldOffset(Offset = "0x20")]
    private MasterBonusDetailPopupGenerator masterBonusDetailPopupGenerator;
    [Token(Token = "0x400E745")]
    [FieldOffset(Offset = "0x28")]
    private MasterBonusDetailPopup masterBonusDetailPopup;

    [Token(Token = "0x6014D76")]
    [Address(RVA = "0x1B3F390", Offset = "0x1B3F390", VA = "0x1B3F390")]
    public void Setup(
      List<IMasterBonusData> bonusList,
      MasterBonusDetailPopupGenerator masterBonusDetailPopupGenerator)
    {
    }

    [Token(Token = "0x6014D77")]
    [Address(RVA = "0x1B40A8C", Offset = "0x1B40A8C", VA = "0x1B40A8C")]
    private void OnClickDetail(IMasterBonusData masterBonusData)
    {
    }

    [Token(Token = "0x6014D78")]
    [Address(RVA = "0x1B409A4", Offset = "0x1B409A4", VA = "0x1B409A4")]
    private ContentMasterBonus FindListItemByElement(ElementStyleMasterBonusData masterBonusData)
    {
      return (ContentMasterBonus) null;
    }

    [Token(Token = "0x6014D79")]
    [Address(RVA = "0x1B40C64", Offset = "0x1B40C64", VA = "0x1B40C64")]
    public ContainerElementMasterBonus()
    {
    }

    [Token(Token = "0x2003528")]
    [Serializable]
    public class ElementBonusView
    {
      [Token(Token = "0x400E746")]
      [FieldOffset(Offset = "0x10")]
      public ElementTypeEnum ElementType;
      [Token(Token = "0x400E747")]
      [FieldOffset(Offset = "0x18")]
      public ContentMasterBonus BonusListItem;

      [Token(Token = "0x6014D7C")]
      [Address(RVA = "0x1B40D38", Offset = "0x1B40D38", VA = "0x1B40D38")]
      public ElementBonusView()
      {
      }
    }
  }
}
