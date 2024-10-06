// Decompiled with JetBrains decompiler
// Type: StaqData.StyleExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002102")]
  public static class StyleExtension
  {
    [Token(Token = "0x600C93A")]
    [Address(RVA = "0x1B9C794", Offset = "0x1B9C794", VA = "0x1B9C794")]
    public static float GetRarityGrowthRate(this Style style) => new float();

    [Token(Token = "0x600C93B")]
    [Address(RVA = "0x1B9C830", Offset = "0x1B9C830", VA = "0x1B9C830")]
    public static float GetLevelupParameterGrowthRate(this Style style) => new float();

    [Token(Token = "0x600C93C")]
    [Address(RVA = "0x1B9C8DC", Offset = "0x1B9C8DC", VA = "0x1B9C8DC")]
    public static float ClacRarityPoint(this Style style) => new float();

    [Token(Token = "0x600C93D")]
    [Address(RVA = "0x1B9C990", Offset = "0x1B9C990", VA = "0x1B9C990")]
    public static float ClacLevelParameterPoint(this Style style) => new float();

    [Token(Token = "0x600C93E")]
    [Address(RVA = "0x1B9CA44", Offset = "0x1B9CA44", VA = "0x1B9CA44")]
    public static float ClacAbilityBoardReleasePoint(this Style style) => new float();

    [Token(Token = "0x600C93F")]
    [Address(RVA = "0x1B9CB00", Offset = "0x1B9CB00", VA = "0x1B9CB00")]
    public static StyleTrainingRankData CalcMatchTrainingRankData(this Style style)
    {
      return (StyleTrainingRankData) null;
    }
  }
}
