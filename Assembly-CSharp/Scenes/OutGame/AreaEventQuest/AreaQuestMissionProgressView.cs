// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaEventQuest.AreaQuestMissionProgressView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.ScenarioQuest.EventMission;
using System;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.AreaEventQuest
{
  [Token(Token = "0x2003945")]
  public class AreaQuestMissionProgressView : MissionProgressView
  {
    [Token(Token = "0x6016835")]
    [Address(RVA = "0x42EAD70", Offset = "0x42EAD70", VA = "0x42EAD70", Slot = "4")]
    public override void Initialize(
      List<RewardConditionData> rewardConditions,
      int progressPoint,
      int maxPoint,
      Action<bool, int> onClickTreasure)
    {
    }

    [Token(Token = "0x6016836")]
    [Address(RVA = "0x42EADB8", Offset = "0x42EADB8", VA = "0x42EADB8", Slot = "5")]
    protected override void CreateAndUpdateTresure(Action<bool, int> getProgressAction)
    {
    }

    [Token(Token = "0x6016837")]
    [Address(RVA = "0x42EB2C0", Offset = "0x42EB2C0", VA = "0x42EB2C0")]
    public AreaQuestMissionProgressView()
    {
    }
  }
}
