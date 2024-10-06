// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.EventMissionView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.ScenarioQuest.EventMission
{
  [Token(Token = "0x200299F")]
  public class EventMissionView : MissionView
  {
    [Token(Token = "0x400B149")]
    [FieldOffset(Offset = "0x38")]
    [Header("グローバルボタン")]
    [SerializeField]
    private CommonButton globalButton;
    [Token(Token = "0x400B14A")]
    [FieldOffset(Offset = "0x40")]
    [Header("左側")]
    [Header("キャラクター表示オブジェクト")]
    [Space(5f)]
    [SerializeField]
    private EventMissionOneCharacterView eventMissionOneCharacterView;
    [Token(Token = "0x400B14B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private EventMissionTwoCharacterView eventMissionTwoCharacterView;
    [Token(Token = "0x400B14C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private EventMissionThreeCharacterView eventMissionThreeCharacterView;
    [Token(Token = "0x400B14D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    [Space(5f)]
    [Header("右上側 イベントミッション進捗")]
    private EventMissionProgressView eventMissionProgressView;

    [Token(Token = "0x6010597")]
    [Address(RVA = "0x48810D4", Offset = "0x48810D4", VA = "0x48810D4")]
    public void SetCharacter(
      int characterNum,
      int firstStyleId = 0,
      int secondStyleId = 0,
      int thirdStyleId = 0)
    {
    }

    [Token(Token = "0x6010598")]
    [Address(RVA = "0x4881158", Offset = "0x4881158", VA = "0x4881158")]
    public void SetRewardConditions(
      List<RewardConditionData> rewardConditions,
      int progressPoint,
      int maxPoint,
      Action<bool, int> onClickTreasure)
    {
    }

    [Token(Token = "0x6010599")]
    [Address(RVA = "0x4881174", Offset = "0x4881174", VA = "0x4881174")]
    private void GlobalButtonSetting()
    {
    }

    [Token(Token = "0x601059A")]
    [Address(RVA = "0x4881280", Offset = "0x4881280", VA = "0x4881280")]
    public EventMissionView()
    {
    }
  }
}
