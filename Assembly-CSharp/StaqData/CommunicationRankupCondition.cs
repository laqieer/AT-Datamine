// Decompiled with JetBrains decompiler
// Type: StaqData.CommunicationRankupCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020AC")]
  public static class CommunicationRankupCondition
  {
    [Token(Token = "0x600C5CB")]
    [Address(RVA = "0x1A05E48", Offset = "0x1A05E48", VA = "0x1A05E48")]
    public static bool ReachedAll(int commuID, int rank) => new bool();

    [Token(Token = "0x600C5CC")]
    [Address(RVA = "0x1A05EB4", Offset = "0x1A05EB4", VA = "0x1A05EB4")]
    public static bool ReachedActiveCondition(int commuID, int rank) => new bool();

    [Token(Token = "0x600C5CD")]
    [Address(RVA = "0x1A074D0", Offset = "0x1A074D0", VA = "0x1A074D0")]
    public static bool ReachedExistingRank(int commuID, int rank) => new bool();

    [Token(Token = "0x600C5CE")]
    [Address(RVA = "0x1A05F34", Offset = "0x1A05F34", VA = "0x1A05F34")]
    public static bool ReachedRelationShip(int commuID, int rank) => new bool();

    [Token(Token = "0x600C5CF")]
    [Address(RVA = "0x1A07574", Offset = "0x1A07574", VA = "0x1A07574")]
    public static bool ReachedHumanParameter(int commuID, int rank) => new bool();

    [Token(Token = "0x600C5D0")]
    [Address(RVA = "0x1A079B0", Offset = "0x1A079B0", VA = "0x1A079B0")]
    public static string GetRankupConditionHintText(Communication commuData) => (string) null;

    [Token(Token = "0x600C5D1")]
    [Address(RVA = "0x1A07C94", Offset = "0x1A07C94", VA = "0x1A07C94")]
    public static string GetRankupConditionHintTextLines(Communication commuData) => (string) null;

    [Token(Token = "0x600C5D2")]
    [Address(RVA = "0x1A07B48", Offset = "0x1A07B48", VA = "0x1A07B48")]
    public static string SplitConditions(
      List<StoryCommunicationRankupConditionData> conditions,
      string chara = ",")
    {
      return (string) null;
    }

    [Token(Token = "0x600C5D3")]
    [Address(RVA = "0x1A071CC", Offset = "0x1A071CC", VA = "0x1A071CC")]
    public static bool ReachedRankupRouteAndTerm(int commuID, int rank) => new bool();
  }
}
