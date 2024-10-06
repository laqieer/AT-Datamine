// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Unit.UI.UnitInfoUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.Info.Equipment.UI;
using Scenes.OutGame.Info.Skill.UI;
using Scenes.OutGame.Info.Style.UI;
using System;
using TeamOrganization;
using UI;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Info.Unit.UI
{
  [Token(Token = "0x200354F")]
  public class UnitInfoUI : MonoBehaviour
  {
    [Token(Token = "0x400E7D1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private StyleProfileUI styleProfile;
    [Token(Token = "0x400E7D2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private EquipmentParametersUI parameters;
    [Token(Token = "0x400E7D3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private AdditionalParametersUI additionalParameters;
    [Token(Token = "0x400E7D4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PartySlotView partySlotView;
    [Token(Token = "0x400E7D5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private StyleDotUI styleDot;
    [Token(Token = "0x400E7D6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextAccessor combatPower;
    [Token(Token = "0x400E7D7")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CurrentMaxGaugeUI unitHP;
    [Token(Token = "0x400E7D8")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private BarrierStockUI barrierStock;
    [Token(Token = "0x400E7D9")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private SkillListUI skillList;
    [Token(Token = "0x400E7DB")]
    [FieldOffset(Offset = "0x68")]
    protected bool isNeedLp;

    [Token(Token = "0x1400020B")]
    public event Action OnShowStyleCategory
    {
      [Token(Token = "0x6014EB0"), Address(RVA = "0x1B421CC", Offset = "0x1B421CC", VA = "0x1B421CC")] add
      {
      }
      [Token(Token = "0x6014EB1"), Address(RVA = "0x1B4B608", Offset = "0x1B4B608", VA = "0x1B4B608")] remove
      {
      }
    }

    [Token(Token = "0x6014EB2")]
    [Address(RVA = "0x1B4B6A4", Offset = "0x1B4B6A4", VA = "0x1B4B6A4")]
    public void Initialize(bool isNeedLp)
    {
    }

    [Token(Token = "0x6014EB3")]
    [Address(RVA = "0x1B4B6DC", Offset = "0x1B4B6DC", VA = "0x1B4B6DC")]
    public void ShowStyleCategory()
    {
    }

    [Token(Token = "0x6014EB4")]
    [Address(RVA = "0x1B4B6F8", Offset = "0x1B4B6F8", VA = "0x1B4B6F8")]
    public UnitInfoView CreateView(IAssetProvider assetProvider) => (UnitInfoView) null;

    [Token(Token = "0x6014EB5")]
    [Address(RVA = "0x1B4B86C", Offset = "0x1B4B86C", VA = "0x1B4B86C")]
    public UnitInfoUI()
    {
    }
  }
}
