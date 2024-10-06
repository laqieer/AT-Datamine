// Decompiled with JetBrains decompiler
// Type: StaqData.QuestInfoMissions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002076")]
  public class QuestInfoMissions
  {
    [Token(Token = "0x4008A35")]
    [FieldOffset(Offset = "0x10")]
    private List<QuestMissionInfo> infos;

    [Token(Token = "0x600C454")]
    [Address(RVA = "0x19F14B8", Offset = "0x19F14B8", VA = "0x19F14B8")]
    public QuestInfoMissions(IReadOnlyList<BattleMissionData> missions, int targetQuestId)
    {
    }

    [Token(Token = "0x600C455")]
    [Address(RVA = "0x19F6868", Offset = "0x19F6868", VA = "0x19F6868")]
    public List<QuestMissionInfo> GetInfos() => (List<QuestMissionInfo>) null;

    [Token(Token = "0x2002077")]
    private class MissionStatus : QuestMissionInfo.IPlayMissionState
    {
      [Token(Token = "0x4008A36")]
      [FieldOffset(Offset = "0x10")]
      private int targetQuestId;
      [Token(Token = "0x4008A37")]
      [FieldOffset(Offset = "0x14")]
      private int missionId;

      [Token(Token = "0x600C456")]
      [Address(RVA = "0x19F683C", Offset = "0x19F683C", VA = "0x19F683C")]
      public MissionStatus(int targetQuestId, int missionId)
      {
      }

      [Token(Token = "0x600C457")]
      [Address(RVA = "0x19F6870", Offset = "0x19F6870", VA = "0x19F6870", Slot = "4")]
      private bool StaqData\u002EQuestMissionInfo\u002EIPlayMissionState\u002EIsCleard()
      {
        return new bool();
      }
    }
  }
}
