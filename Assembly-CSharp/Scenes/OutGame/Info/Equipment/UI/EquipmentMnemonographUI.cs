// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.UI.EquipmentMnemonographUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Skill;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Equipment.UI
{
  [Token(Token = "0x20035AE")]
  public class EquipmentMnemonographUI : MonoBehaviour
  {
    [Token(Token = "0x400E990")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GemListUI gem;
    [Token(Token = "0x400E991")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CurrentMaxGaugeUI level;
    [Token(Token = "0x400E992")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private EquipmentCombatPowerUI combatPower;
    [Token(Token = "0x400E993")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private EquipmentParametersUI parameters;
    [Token(Token = "0x400E994")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private DetailSkillListThumb detailSkillListThumb;
    [Token(Token = "0x400E995")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI partySkillDescription;

    [Token(Token = "0x14000212")]
    public event Action OnShowDetail
    {
      [Token(Token = "0x601520F"), Address(RVA = "0x4AACEF8", Offset = "0x4AACEF8", VA = "0x4AACEF8")] add
      {
      }
      [Token(Token = "0x6015210"), Address(RVA = "0x4AACF94", Offset = "0x4AACF94", VA = "0x4AACF94")] remove
      {
      }
    }

    [Token(Token = "0x14000213")]
    public event Action OnShowSkillDetail
    {
      [Token(Token = "0x6015211"), Address(RVA = "0x4AAD030", Offset = "0x4AAD030", VA = "0x4AAD030")] add
      {
      }
      [Token(Token = "0x6015212"), Address(RVA = "0x4AAD0CC", Offset = "0x4AAD0CC", VA = "0x4AAD0CC")] remove
      {
      }
    }

    [Token(Token = "0x6015213")]
    [Address(RVA = "0x4AAD168", Offset = "0x4AAD168", VA = "0x4AAD168")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6015214")]
    [Address(RVA = "0x4AAD224", Offset = "0x4AAD224", VA = "0x4AAD224")]
    public void ShowDetail()
    {
    }

    [Token(Token = "0x6015215")]
    [Address(RVA = "0x4AAD240", Offset = "0x4AAD240", VA = "0x4AAD240")]
    private void ShowSkillDetail()
    {
    }

    [Token(Token = "0x6015216")]
    [Address(RVA = "0x4AAD25C", Offset = "0x4AAD25C", VA = "0x4AAD25C")]
    public EquipmentMindEquipmentStatusView CreateStatusView(IAssetProvider assetProvider)
    {
      return (EquipmentMindEquipmentStatusView) null;
    }

    [Token(Token = "0x6015217")]
    [Address(RVA = "0x4AAD318", Offset = "0x4AAD318", VA = "0x4AAD318")]
    public DetailSkillListThumb GetDetailSkillListThumb() => (DetailSkillListThumb) null;

    [Token(Token = "0x6015218")]
    [Address(RVA = "0x4AAD320", Offset = "0x4AAD320", VA = "0x4AAD320")]
    public void OnChange(MindEquipment mindEquipment)
    {
    }

    [Token(Token = "0x6015219")]
    [Address(RVA = "0x4AAD3A0", Offset = "0x4AAD3A0", VA = "0x4AAD3A0")]
    public void OnChange(SkillModelBase skill)
    {
    }

    [Token(Token = "0x601521A")]
    [Address(RVA = "0x4AAD35C", Offset = "0x4AAD35C", VA = "0x4AAD35C")]
    public void OnChange(SkillDetailData skillDetailData)
    {
    }

    [Token(Token = "0x601521B")]
    [Address(RVA = "0x4AAD3D0", Offset = "0x4AAD3D0", VA = "0x4AAD3D0")]
    public EquipmentMnemonographUI()
    {
    }
  }
}
