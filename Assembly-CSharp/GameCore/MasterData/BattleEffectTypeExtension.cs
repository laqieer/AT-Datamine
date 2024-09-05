// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleEffectTypeExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013F3")]
  public static class BattleEffectTypeExtension
  {
    [Token(Token = "0x4005CE6")]
    [FieldOffset(Offset = "0x0")]
    public static readonly BattleEffectTypeEnum[] Values;
    [Token(Token = "0x4005CE7")]
    [FieldOffset(Offset = "0x8")]
    private static Func<string, string> GetText;
    [Token(Token = "0x4005CE8")]
    [FieldOffset(Offset = "0x10")]
    private static Dictionary<(BattleEffectTypeEnum, int), Func<string>> effectNameDic;

    [Token(Token = "0x6006FFB")]
    [Address(RVA = "0x4207DF8", Offset = "0x4207DF8", VA = "0x4207DF8")]
    public static bool IsAffectingToParameter(this EffectData self) => new bool();

    [Token(Token = "0x6006FFC")]
    [Address(RVA = "0x4207F88", Offset = "0x4207F88", VA = "0x4207F88")]
    public static bool IsAffectingToSubParameter(this BattleEffectTypeEnum self) => new bool();

    [Token(Token = "0x6006FFD")]
    [Address(RVA = "0x42080E0", Offset = "0x42080E0", VA = "0x42080E0")]
    public static bool NeedCalcEffectValue(this BattleEffectTypeEnum self) => new bool();

    [Token(Token = "0x6006FFE")]
    [Address(RVA = "0x42081A4", Offset = "0x42081A4", VA = "0x42081A4")]
    public static bool CanAddAsStatusEffect(this BattleEffectTypeEnum self) => new bool();

    [Token(Token = "0x6006FFF")]
    [Address(RVA = "0x4208224", Offset = "0x4208224", VA = "0x4208224")]
    public static bool IsMoveEffect(this BattleEffectTypeEnum self) => new bool();

    [Token(Token = "0x6007000")]
    [Address(RVA = "0x4208258", Offset = "0x4208258", VA = "0x4208258")]
    static BattleEffectTypeExtension()
    {
    }
  }
}
