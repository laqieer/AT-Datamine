// Decompiled with JetBrains decompiler
// Type: LoginBonus.LoginBonusRewardUIParamExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using System.Collections.Generic;
using UI.MultipleItemDetail;

#nullable disable
namespace LoginBonus
{
  [Token(Token = "0x2000AE5")]
  public static class LoginBonusRewardUIParamExtension
  {
    [Token(Token = "0x6003E16")]
    [Address(RVA = "0x2C079BC", Offset = "0x2C079BC", VA = "0x2C079BC")]
    public static IEnumerable<LoginBonusSingleRewardUIParam> ToSingleRewardUIParams(
      this ILoginBonusRewardUIParam param)
    {
      return (IEnumerable<LoginBonusSingleRewardUIParam>) null;
    }

    [Token(Token = "0x6003E17")]
    [Address(RVA = "0x2C13DF0", Offset = "0x2C13DF0", VA = "0x2C13DF0")]
    public static List<DisplayItemRewardInfoData> ToDisplayItemRewardInfoData(
      this IEnumerable<ILoginBonusRewardUIParam> prameters)
    {
      return (List<DisplayItemRewardInfoData>) null;
    }

    [Token(Token = "0x6003E18")]
    [Address(RVA = "0x2C07B7C", Offset = "0x2C07B7C", VA = "0x2C07B7C")]
    public static IEnumerable<MultipleItemDetailParamater> ToMultipleItemDetailParamaters(
      this IEnumerable<LoginBonusSingleRewardUIParam> prameters)
    {
      return (IEnumerable<MultipleItemDetailParamater>) null;
    }
  }
}
