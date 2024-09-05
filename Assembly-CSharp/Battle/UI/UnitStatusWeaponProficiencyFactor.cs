// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitStatusWeaponProficiencyFactor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002363")]
  public sealed class UnitStatusWeaponProficiencyFactor : UnitStatusFactorBase
  {
    [Token(Token = "0x4009662")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image sword;
    [Token(Token = "0x4009663")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Image axe;
    [Token(Token = "0x4009664")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Image hammer;
    [Token(Token = "0x4009665")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Image spear;
    [Token(Token = "0x4009666")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Image bow;
    [Token(Token = "0x4009667")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Image gun;
    [Token(Token = "0x4009668")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Image grimoire;
    [Token(Token = "0x4009669")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Image cane;

    [Token(Token = "0x600D80A")]
    [Address(RVA = "0x1B8FB58", Offset = "0x1B8FB58", VA = "0x1B8FB58", Slot = "4")]
    public override void Initialize(UnitStatusFactorBase.Context context)
    {
    }

    [Token(Token = "0x600D80B")]
    [Address(RVA = "0x1B8FB6C", Offset = "0x1B8FB6C", VA = "0x1B8FB6C", Slot = "5")]
    public override void Set(UnitParameterData unit, BattlePlayerData owner)
    {
    }

    [Token(Token = "0x600D80C")]
    [Address(RVA = "0x1B8FB70", Offset = "0x1B8FB70", VA = "0x1B8FB70")]
    public UnitStatusWeaponProficiencyFactor()
    {
    }
  }
}
