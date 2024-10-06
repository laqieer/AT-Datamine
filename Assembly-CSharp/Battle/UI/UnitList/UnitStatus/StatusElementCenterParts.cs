// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitList.UnitStatus.StatusElementCenterParts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.UI.UnitList.UnitStatus
{
  [Token(Token = "0x2002444")]
  public class StatusElementCenterParts : UnitStatusFactorBase
  {
    [Token(Token = "0x4009B78")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton unitButton;
    [Token(Token = "0x4009B79")]
    [FieldOffset(Offset = "0x50")]
    [HideInInspector]
    [SerializeField]
    private UnitStatusTween tweener;
    [Token(Token = "0x4009B7A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UnitStatusBasicFactor basic;
    [Token(Token = "0x4009B7B")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UnitStatusElementFactor element;
    [Token(Token = "0x4009B7C")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private UnitStatusWeaponAttackTypeFactor weaponAttackType;
    [Token(Token = "0x4009B7D")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private UnitStatusBadStatusFactor badStatus;
    [Token(Token = "0x4009B7E")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private UnitStatusSpecialEffectFactor specialEffect;
    [Token(Token = "0x4009B7F")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private UnitStatusEquipmentFactor equipment;
    [Token(Token = "0x4009B80")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private UnitStatusBattleParamFactor battleParam;
    [Token(Token = "0x4009B81")]
    [FieldOffset(Offset = "0x90")]
    private List<(UnitStatusFactorBase.UnitListShowFactor factor, UnitStatusFactorBase panel)> factors;

    [Token(Token = "0x600DE4B")]
    [Address(RVA = "0x1E31038", Offset = "0x1E31038", VA = "0x1E31038", Slot = "4")]
    public override void Initialize(UnitStatusFactorBase.Context context)
    {
    }

    [Token(Token = "0x600DE4C")]
    [Address(RVA = "0x1E315C4", Offset = "0x1E315C4", VA = "0x1E315C4", Slot = "5")]
    public override void Set(UnitParameterData unit, BattlePlayerData owner)
    {
    }

    [Token(Token = "0x600DE4D")]
    [Address(RVA = "0x1E31780", Offset = "0x1E31780", VA = "0x1E31780", Slot = "6")]
    public override void SetFactor(UnitStatusFactorBase.UnitListShowFactor factor)
    {
    }

    [Token(Token = "0x600DE4E")]
    [Address(RVA = "0x1E31738", Offset = "0x1E31738", VA = "0x1E31738")]
    private void SetAlive(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DE4F")]
    [Address(RVA = "0x1E318E0", Offset = "0x1E318E0", VA = "0x1E318E0")]
    public StatusElementCenterParts()
    {
    }
  }
}
