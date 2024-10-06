// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitStatusEquipmentFactor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;
using UI.Utilities.SerializeUI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002355")]
  public sealed class UnitStatusEquipmentFactor : UnitStatusFactorBase
  {
    [Token(Token = "0x4009615")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private EquipmentThumbnailViewController currentWeapon;
    [Token(Token = "0x4009616")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text durable;
    [Token(Token = "0x4009617")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text range;
    [Token(Token = "0x4009618")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private List<ImageContainer> subWeaponIcons;
    [Token(Token = "0x4009619")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private EquipmentThumbnailViewController accessory;
    [Token(Token = "0x400961A")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private MnemnographThumbnailViewController mindEquipment;
    [Token(Token = "0x400961B")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text trust;

    [Token(Token = "0x600D7CC")]
    [Address(RVA = "0x1B8C0A0", Offset = "0x1B8C0A0", VA = "0x1B8C0A0", Slot = "4")]
    public override void Initialize(UnitStatusFactorBase.Context context)
    {
    }

    [Token(Token = "0x600D7CD")]
    [Address(RVA = "0x1B8C160", Offset = "0x1B8C160", VA = "0x1B8C160", Slot = "5")]
    public override void Set(UnitParameterData unit, BattlePlayerData owner)
    {
    }

    [Token(Token = "0x600D7CE")]
    [Address(RVA = "0x1B8C598", Offset = "0x1B8C598", VA = "0x1B8C598")]
    private void SetRange(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D7CF")]
    [Address(RVA = "0x1B8C700", Offset = "0x1B8C700", VA = "0x1B8C700")]
    public UnitStatusEquipmentFactor()
    {
    }
  }
}
