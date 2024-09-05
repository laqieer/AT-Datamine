// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TargettableUnitTypeExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001404")]
  public static class TargettableUnitTypeExtension
  {
    [Token(Token = "0x60070EE")]
    [Address(RVA = "0x421CB68", Offset = "0x421CB68", VA = "0x421CB68")]
    public static IGridData GetEffectPoint(
      this TargettableUnitTypeEnum self,
      ITargettable activator,
      ITargettable target)
    {
      return (IGridData) null;
    }

    [Token(Token = "0x60070EF")]
    [Address(RVA = "0x421CC58", Offset = "0x421CC58", VA = "0x421CC58")]
    public static bool IsTargettable(
      this TargettableUnitTypeEnum self,
      BoardData board,
      ITargettable a,
      ITargettable b)
    {
      return new bool();
    }

    [Token(Token = "0x60070F0")]
    [Address(RVA = "0x421D158", Offset = "0x421D158", VA = "0x421D158")]
    private static bool IsTargettableDefault(
      this TargettableUnitTypeEnum self,
      BoardData board,
      ITargettable a,
      ITargettable b)
    {
      return new bool();
    }

    [Token(Token = "0x60070F1")]
    [Address(RVA = "0x421CD50", Offset = "0x421CD50", VA = "0x421CD50")]
    private static bool IsTargettableInConfusion(
      this TargettableUnitTypeEnum self,
      ITargettable a,
      ITargettable b)
    {
      return new bool();
    }

    [Token(Token = "0x60070F2")]
    [Address(RVA = "0x421CF40", Offset = "0x421CF40", VA = "0x421CF40")]
    private static bool IsTargettableInCharmed(
      this TargettableUnitTypeEnum self,
      BoardData board,
      ITargettable a,
      ITargettable b)
    {
      return new bool();
    }

    [Token(Token = "0x60070F3")]
    [Address(RVA = "0x421D464", Offset = "0x421D464", VA = "0x421D464")]
    public static bool IsTargettable(
      this TargettableUnitTypeEnum self,
      BattlePlayerData player,
      UnitParameterData target)
    {
      return new bool();
    }

    [Token(Token = "0x60070F4")]
    [Address(RVA = "0x421D57C", Offset = "0x421D57C", VA = "0x421D57C")]
    public static TargettableUnitTypeEnum GetTargetGroup(this TargettableUnitTypeEnum self)
    {
      return new TargettableUnitTypeEnum();
    }
  }
}
