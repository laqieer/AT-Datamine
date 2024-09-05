// Decompiled with JetBrains decompiler
// Type: Battle.Utility.UnitParamUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using StaqData;
using UnityEngine;

#nullable disable
namespace Battle.Utility
{
  [Token(Token = "0x20022D8")]
  public static class UnitParamUtility
  {
    [Token(Token = "0x4009340")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Vector3 UnitPositionBaseOffset;

    [Token(Token = "0x600D47C")]
    [Address(RVA = "0x19E7558", Offset = "0x19E7558", VA = "0x19E7558")]
    public static Vector3 CalcUnitPositionOffsetFromUnitGridSize(
      IReadableUnitGridShapeData data,
      float gridWidth,
      float gridHeight,
      float groundOffset)
    {
      return new Vector3();
    }

    [Token(Token = "0x600D47D")]
    [Address(RVA = "0x19E7768", Offset = "0x19E7768", VA = "0x19E7768")]
    public static Vector3 GetUnderGridPosition(IReadableUnitGridShapeData data, float groundOffset)
    {
      return new Vector3();
    }

    [Token(Token = "0x600D47E")]
    [Address(RVA = "0x19E1D3C", Offset = "0x19E1D3C", VA = "0x19E1D3C")]
    public static int CalcUnitOffsetRate(
      UnitParameterData unit1,
      BattlePlayerData player1,
      UnitParameterData unit2,
      BattlePlayerData player2,
      BattleParameterType paramType)
    {
      return new int();
    }

    [Token(Token = "0x600D47F")]
    [Address(RVA = "0x19E77D4", Offset = "0x19E77D4", VA = "0x19E77D4")]
    public static int CalcUnitOffsetRate(
      ParameterModel unit1,
      StyleData style1,
      ParameterModel unit2,
      StyleData style2,
      BattleParameterType paramType)
    {
      return new int();
    }

    [Token(Token = "0x600D480")]
    [Address(RVA = "0x19E7C44", Offset = "0x19E7C44", VA = "0x19E7C44")]
    static UnitParamUtility()
    {
    }
  }
}
