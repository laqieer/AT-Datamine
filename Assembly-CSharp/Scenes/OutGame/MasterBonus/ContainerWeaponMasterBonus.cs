// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.MasterBonus.ContainerWeaponMasterBonus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.MasterBonus
{
  [Token(Token = "0x2003530")]
  public class ContainerWeaponMasterBonus : MonoBehaviour
  {
    [Token(Token = "0x400E75E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<ContainerWeaponMasterBonus.WeaponBonusView> containerWeaponMasterBonusListItems;
    [Token(Token = "0x400E75F")]
    [FieldOffset(Offset = "0x20")]
    private MasterBonusDetailPopupGenerator masterBonusDetailPopupGenerator;
    [Token(Token = "0x400E760")]
    [FieldOffset(Offset = "0x28")]
    private MasterBonusDetailPopup masterBonusDetailPopup;

    [Token(Token = "0x6014DAD")]
    [Address(RVA = "0x1B3FA24", Offset = "0x1B3FA24", VA = "0x1B3FA24")]
    public void Setup(
      List<IMasterBonusData> bonusList,
      MasterBonusDetailPopupGenerator masterBonusDetailPopupGenerator)
    {
    }

    [Token(Token = "0x6014DAE")]
    [Address(RVA = "0x1B411C8", Offset = "0x1B411C8", VA = "0x1B411C8")]
    private void OnClickDetail(IMasterBonusData masterBonusData)
    {
    }

    [Token(Token = "0x6014DAF")]
    [Address(RVA = "0x1B410E0", Offset = "0x1B410E0", VA = "0x1B410E0")]
    private ContentMasterBonus FindListItemByWeapon(WeaponMasterBonusData masterBonusData)
    {
      return (ContentMasterBonus) null;
    }

    [Token(Token = "0x6014DB0")]
    [Address(RVA = "0x1B413A0", Offset = "0x1B413A0", VA = "0x1B413A0")]
    public ContainerWeaponMasterBonus()
    {
    }

    [Token(Token = "0x2003531")]
    [Serializable]
    public class WeaponBonusView
    {
      [Token(Token = "0x400E761")]
      [FieldOffset(Offset = "0x10")]
      public int Condition;
      [Token(Token = "0x400E762")]
      [FieldOffset(Offset = "0x18")]
      public ContentMasterBonus BonusListItem;

      [Token(Token = "0x6014DB3")]
      [Address(RVA = "0x1B41474", Offset = "0x1B41474", VA = "0x1B41474")]
      public WeaponBonusView()
      {
      }
    }
  }
}
