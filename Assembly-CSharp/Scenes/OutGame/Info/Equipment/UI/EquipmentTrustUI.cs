// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.UI.EquipmentTrustUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.OutGameMenu;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Equipment.UI
{
  [Token(Token = "0x20035BB")]
  public class EquipmentTrustUI : MonoBehaviour
  {
    [Token(Token = "0x400E9CC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private EquipmentCombatPowerUI combatPower;
    [Token(Token = "0x400E9CD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private EquipmentParametersUI parameters;
    [Token(Token = "0x400E9CE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private DetailSkillListThumb detailSkillListThumb;

    [Token(Token = "0x14000215")]
    public event Action OnShowDetail
    {
      [Token(Token = "0x601525B"), Address(RVA = "0x4AAE180", Offset = "0x4AAE180", VA = "0x4AAE180")] add
      {
      }
      [Token(Token = "0x601525C"), Address(RVA = "0x4AAE21C", Offset = "0x4AAE21C", VA = "0x4AAE21C")] remove
      {
      }
    }

    [Token(Token = "0x14000216")]
    public event Action OnShowSkillDetail
    {
      [Token(Token = "0x601525D"), Address(RVA = "0x4AAE2B8", Offset = "0x4AAE2B8", VA = "0x4AAE2B8")] add
      {
      }
      [Token(Token = "0x601525E"), Address(RVA = "0x4AAE354", Offset = "0x4AAE354", VA = "0x4AAE354")] remove
      {
      }
    }

    [Token(Token = "0x601525F")]
    [Address(RVA = "0x4AAE3F0", Offset = "0x4AAE3F0", VA = "0x4AAE3F0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6015260")]
    [Address(RVA = "0x4AAE49C", Offset = "0x4AAE49C", VA = "0x4AAE49C")]
    public void ShowDetail()
    {
    }

    [Token(Token = "0x6015261")]
    [Address(RVA = "0x4AAE4B8", Offset = "0x4AAE4B8", VA = "0x4AAE4B8")]
    private void ShowSkillDetail()
    {
    }

    [Token(Token = "0x6015262")]
    [Address(RVA = "0x4AAE4D4", Offset = "0x4AAE4D4", VA = "0x4AAE4D4")]
    public EquipmentTrustStatusView CreateStatusView(IAssetProvider assetProvider)
    {
      return (EquipmentTrustStatusView) null;
    }

    [Token(Token = "0x6015263")]
    [Address(RVA = "0x4AAE584", Offset = "0x4AAE584", VA = "0x4AAE584")]
    public DetailSkillListThumb GetDetailSkillListThumb() => (DetailSkillListThumb) null;

    [Token(Token = "0x6015264")]
    [Address(RVA = "0x4AAE58C", Offset = "0x4AAE58C", VA = "0x4AAE58C")]
    public EquipmentTrustUI()
    {
    }
  }
}
