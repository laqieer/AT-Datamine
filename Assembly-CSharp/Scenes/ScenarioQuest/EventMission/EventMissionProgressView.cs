// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.EventMissionProgressView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

#nullable disable
namespace Scenes.ScenarioQuest.EventMission
{
  [Token(Token = "0x2002997")]
  public class EventMissionProgressView : MissionProgressView
  {
    [Token(Token = "0x400B12C")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    [Header("宝箱")]
    [FormerlySerializedAs("TresurePrefab")]
    private EventMissionTreasure tresurePrefab;

    [Token(Token = "0x601056F")]
    [Address(RVA = "0x47623C4", Offset = "0x47623C4", VA = "0x47623C4")]
    public new void Initialize(
      List<RewardConditionData> rewardConditions,
      int progressPoint,
      int maxPoint,
      Action<bool, int> onClickTreasure)
    {
    }

    [Token(Token = "0x6010570")]
    [Address(RVA = "0x476240C", Offset = "0x476240C", VA = "0x476240C", Slot = "5")]
    protected override void CreateAndUpdateTresure(Action<bool, int> getProgressAction)
    {
    }

    [Token(Token = "0x6010571")]
    [Address(RVA = "0x47629D4", Offset = "0x47629D4", VA = "0x47629D4")]
    public EventMissionProgressView()
    {
    }
  }
}
