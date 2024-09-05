// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDMissionRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x2001980")]
  public class FgGIDMissionRewardData
  {
    [Token(Token = "0x17001778")]
    public string RewardDisplayName
    {
      [Token(Token = "0x60091A5"), Address(RVA = "0x4D0B908", Offset = "0x4D0B908", VA = "0x4D0B908")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60091A6"), Address(RVA = "0x4D0B910", Offset = "0x4D0B910", VA = "0x4D0B910")] private set
      {
      }
    }

    [Token(Token = "0x17001779")]
    public long RewardQuantity
    {
      [Token(Token = "0x60091A7"), Address(RVA = "0x4D0B918", Offset = "0x4D0B918", VA = "0x4D0B918")] get
      {
        return new long();
      }
      [Token(Token = "0x60091A8"), Address(RVA = "0x4D0B920", Offset = "0x4D0B920", VA = "0x4D0B920")] private set
      {
      }
    }

    [Token(Token = "0x60091A9")]
    [Address(RVA = "0x4D0A218", Offset = "0x4D0A218", VA = "0x4D0A218")]
    public FgGIDMissionRewardData(string name, long quantity)
    {
    }

    [Token(Token = "0x60091AA")]
    [Address(RVA = "0x4D0B928", Offset = "0x4D0B928", VA = "0x4D0B928")]
    public static FgGIDMissionRewardData CreateByServerData(FggfcRewardEntityType serverData)
    {
      return (FgGIDMissionRewardData) null;
    }

    [Token(Token = "0x60091AB")]
    [Address(RVA = "0x4D09CB4", Offset = "0x4D09CB4", VA = "0x4D09CB4")]
    public static List<FgGIDMissionRewardData> CreateByServerData(
      IEnumerable<FggfcRewardEntityType> serverDatas)
    {
      return (List<FgGIDMissionRewardData>) null;
    }
  }
}
