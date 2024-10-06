// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.UI.EquipmentAccessoryUI
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
  [Token(Token = "0x20035AA")]
  public class EquipmentAccessoryUI : MonoBehaviour
  {
    [Token(Token = "0x400E982")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private IconUI typeIcon;
    [Token(Token = "0x400E983")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GemListUI gem;
    [Token(Token = "0x400E984")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CurrentMaxGaugeUI level;
    [Token(Token = "0x400E985")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private EquipmentCombatPowerUI combatPower;
    [Token(Token = "0x400E986")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private EquipmentParametersUI parameters;
    [Token(Token = "0x400E987")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private EquipmentOptionEffectListUI optionEffectList;
    [Token(Token = "0x400E988")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private DetailSkillListThumb detailSkillListThumb;

    [Token(Token = "0x14000210")]
    public event Action OnShowDetail
    {
      [Token(Token = "0x60151FA"), Address(RVA = "0x4AAC5F4", Offset = "0x4AAC5F4", VA = "0x4AAC5F4")] add
      {
      }
      [Token(Token = "0x60151FB"), Address(RVA = "0x4AAC690", Offset = "0x4AAC690", VA = "0x4AAC690")] remove
      {
      }
    }

    [Token(Token = "0x14000211")]
    public event Action OnShowSkillDetail
    {
      [Token(Token = "0x60151FC"), Address(RVA = "0x4AAC72C", Offset = "0x4AAC72C", VA = "0x4AAC72C")] add
      {
      }
      [Token(Token = "0x60151FD"), Address(RVA = "0x4AAC7C8", Offset = "0x4AAC7C8", VA = "0x4AAC7C8")] remove
      {
      }
    }

    [Token(Token = "0x60151FE")]
    [Address(RVA = "0x4AAC864", Offset = "0x4AAC864", VA = "0x4AAC864")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60151FF")]
    [Address(RVA = "0x4AAC920", Offset = "0x4AAC920", VA = "0x4AAC920")]
    public void ShowDetail()
    {
    }

    [Token(Token = "0x6015200")]
    [Address(RVA = "0x4AAC93C", Offset = "0x4AAC93C", VA = "0x4AAC93C")]
    private void ShowSkillDetail()
    {
    }

    [Token(Token = "0x6015201")]
    [Address(RVA = "0x4AAC958", Offset = "0x4AAC958", VA = "0x4AAC958")]
    public EquipmentAccessoryStatusView CreateStatusView(IAssetProvider assetProvider)
    {
      return (EquipmentAccessoryStatusView) null;
    }

    [Token(Token = "0x6015202")]
    [Address(RVA = "0x4AACA50", Offset = "0x4AACA50", VA = "0x4AACA50")]
    public DetailSkillListThumb GetDetailSkillListThumb() => (DetailSkillListThumb) null;

    [Token(Token = "0x6015203")]
    [Address(RVA = "0x4AACA58", Offset = "0x4AACA58", VA = "0x4AACA58")]
    public EquipmentAccessoryUI()
    {
    }
  }
}
