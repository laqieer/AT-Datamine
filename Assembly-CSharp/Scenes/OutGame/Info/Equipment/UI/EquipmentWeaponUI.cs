// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.UI.EquipmentWeaponUI
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
  [Token(Token = "0x20035BC")]
  public class EquipmentWeaponUI : MonoBehaviour
  {
    [Token(Token = "0x400E9D1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private IconUI weaponTypeIcon;
    [Token(Token = "0x400E9D2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private IconUI weaponSystemIcon;
    [Token(Token = "0x400E9D3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GemListUI gem;
    [Token(Token = "0x400E9D4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CurrentMaxGaugeUI level;
    [Token(Token = "0x400E9D5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private EquipmentCombatPowerUI combatPower;
    [Token(Token = "0x400E9D6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private EquipmentParametersUI parameters;
    [Token(Token = "0x400E9D7")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private EquipmentOptionEffectListUI optionEffectList;
    [Token(Token = "0x400E9D8")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private DetailSkillListThumb detailSkillListThumb;

    [Token(Token = "0x14000217")]
    public event Action OnShowDetail
    {
      [Token(Token = "0x6015266"), Address(RVA = "0x4AAE5B0", Offset = "0x4AAE5B0", VA = "0x4AAE5B0")] add
      {
      }
      [Token(Token = "0x6015267"), Address(RVA = "0x4AAE64C", Offset = "0x4AAE64C", VA = "0x4AAE64C")] remove
      {
      }
    }

    [Token(Token = "0x14000218")]
    public event Action OnShowSkillDetail
    {
      [Token(Token = "0x6015268"), Address(RVA = "0x4AAE6E8", Offset = "0x4AAE6E8", VA = "0x4AAE6E8")] add
      {
      }
      [Token(Token = "0x6015269"), Address(RVA = "0x4AAE784", Offset = "0x4AAE784", VA = "0x4AAE784")] remove
      {
      }
    }

    [Token(Token = "0x601526A")]
    [Address(RVA = "0x4AAE820", Offset = "0x4AAE820", VA = "0x4AAE820")]
    public void Initialize()
    {
    }

    [Token(Token = "0x601526B")]
    [Address(RVA = "0x4AAE8DC", Offset = "0x4AAE8DC", VA = "0x4AAE8DC")]
    public void ShowDetail()
    {
    }

    [Token(Token = "0x601526C")]
    [Address(RVA = "0x4AAE8F8", Offset = "0x4AAE8F8", VA = "0x4AAE8F8")]
    private void ShowSkillDetail()
    {
    }

    [Token(Token = "0x601526D")]
    [Address(RVA = "0x4AAE914", Offset = "0x4AAE914", VA = "0x4AAE914")]
    public EquipmentWeaponStatusView CreateStatusView(IAssetProvider assetProvider)
    {
      return (EquipmentWeaponStatusView) null;
    }

    [Token(Token = "0x601526E")]
    [Address(RVA = "0x4AAEA0C", Offset = "0x4AAEA0C", VA = "0x4AAEA0C")]
    public DetailSkillListThumb GetDetailSkillListThumb() => (DetailSkillListThumb) null;

    [Token(Token = "0x601526F")]
    [Address(RVA = "0x4AAEA14", Offset = "0x4AAEA14", VA = "0x4AAEA14")]
    public EquipmentWeaponUI()
    {
    }
  }
}
