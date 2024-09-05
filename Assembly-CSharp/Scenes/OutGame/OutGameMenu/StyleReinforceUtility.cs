// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleReinforceUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003AA2")]
  public class StyleReinforceUtility
  {
    [Token(Token = "0x60170E0")]
    [Address(RVA = "0x2CE2E00", Offset = "0x2CE2E00", VA = "0x2CE2E00")]
    public static List<string> GetUpParameterList(
      BasicParameter initParam,
      StyleLimitBreakStatusData before,
      StyleLimitBreakStatusData after)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x60170E1")]
    [Address(RVA = "0x2CE3570", Offset = "0x2CE3570", VA = "0x2CE3570")]
    public static int[] GetUpParameter(
      BasicParameter initParam,
      RarityStyleData before,
      RarityStyleData after)
    {
      return (int[]) null;
    }

    [Token(Token = "0x60170E2")]
    [Address(RVA = "0x2CE3444", Offset = "0x2CE3444", VA = "0x2CE3444")]
    private static int GetUpParamValue(int initValue, int before, int after) => new int();

    [Token(Token = "0x60170E3")]
    [Address(RVA = "0x2CE382C", Offset = "0x2CE382C", VA = "0x2CE382C")]
    public static List<string> GetRarityUpReward(RarityStyleData before, RarityStyleData after)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x60170E4")]
    [Address(RVA = "0x2CE3B6C", Offset = "0x2CE3B6C", VA = "0x2CE3B6C")]
    public static Dictionary<int, List<string>> GetRarityUpRewardForEffect(
      RarityStyleData before,
      RarityStyleData after)
    {
      return (Dictionary<int, List<string>>) null;
    }

    [Token(Token = "0x60170E5")]
    [Address(RVA = "0x2CE4288", Offset = "0x2CE4288", VA = "0x2CE4288")]
    public static List<string> GetSkillName(Style style, int before, int after)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x60170E6")]
    [Address(RVA = "0x2CE44DC", Offset = "0x2CE44DC", VA = "0x2CE44DC")]
    public StyleReinforceUtility()
    {
    }
  }
}
