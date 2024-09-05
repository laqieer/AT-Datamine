// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.ParameterTypeEnumExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x2003347")]
  internal static class ParameterTypeEnumExtension
  {
    [Token(Token = "0x400DE2B")]
    [FieldOffset(Offset = "0x0")]
    private static Func<string, string> GetText;

    [Token(Token = "0x6014263")]
    [Address(RVA = "0x1E04B30", Offset = "0x1E04B30", VA = "0x1E04B30")]
    public static string GetLocalizedText(this ParameterTypeEnum parameterTypeEnum)
    {
      return (string) null;
    }

    [Token(Token = "0x6014264")]
    [Address(RVA = "0x1E0525C", Offset = "0x1E0525C", VA = "0x1E0525C")]
    public static int GetParameterValue(
      this ParameterTypeEnum parameterTypeEnum,
      StyleParameter styleParameter)
    {
      return new int();
    }

    [Token(Token = "0x6014265")]
    [Address(RVA = "0x1E052F4", Offset = "0x1E052F4", VA = "0x1E052F4")]
    public static int GetElementResistValue(
      this ParameterTypeEnum parameterTypeEnum,
      StyleParameter styleParameter)
    {
      return new int();
    }

    [Token(Token = "0x6014266")]
    [Address(RVA = "0x1E054D8", Offset = "0x1E054D8", VA = "0x1E054D8")]
    public static int GetAtkTypeResistValue(
      this ParameterTypeEnum parameterTypeEnum,
      StyleParameter styleParameter)
    {
      return new int();
    }

    [Token(Token = "0x6014267")]
    [Address(RVA = "0x1E05684", Offset = "0x1E05684", VA = "0x1E05684")]
    static ParameterTypeEnumExtension()
    {
    }
  }
}
