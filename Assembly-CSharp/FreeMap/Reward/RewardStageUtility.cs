// Decompiled with JetBrains decompiler
// Type: FreeMap.Reward.RewardStageUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.Reward
{
  [Token(Token = "0x2001851")]
  public static class RewardStageUtility
  {
    [Token(Token = "0x600897E")]
    [Address(RVA = "0x43E552C", Offset = "0x43E552C", VA = "0x43E552C")]
    public static bool IsRewardStageTarget(RewardData data) => new bool();

    [Token(Token = "0x600897F")]
    [Address(RVA = "0x43E554C", Offset = "0x43E554C", VA = "0x43E554C")]
    public static List<DisplayItemRewardInfoData> ConvertToDisplayRewardInfos(
      IEnumerable<RewardData> dataList)
    {
      return (List<DisplayItemRewardInfoData>) null;
    }
  }
}
