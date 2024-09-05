// Decompiled with JetBrains decompiler
// Type: Scenes.ScenarioQuest.EventMission.MissionProgressView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

#nullable disable
namespace Scenes.ScenarioQuest.EventMission
{
  [Token(Token = "0x20029A1")]
  public class MissionProgressView : MonoBehaviour
  {
    [Token(Token = "0x400B150")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("ポイント表示")]
    protected TextMeshProUGUI topProgressPoint;
    [Token(Token = "0x400B151")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected TextMeshProUGUI bottomProgressPoint;
    [Token(Token = "0x400B152")]
    [FieldOffset(Offset = "0x28")]
    [FormerlySerializedAs("TresureAreaRoot")]
    [SerializeField]
    protected RectTransform tresureAreaRoot;
    [Token(Token = "0x400B153")]
    [FieldOffset(Offset = "0x30")]
    [Header("ゲージ")]
    [Space(5f)]
    [SerializeField]
    protected Image gaugeFill;
    [Token(Token = "0x400B154")]
    [FieldOffset(Offset = "0x38")]
    protected List<EventMissionTreasure> treasureList;
    [Token(Token = "0x400B155")]
    [FieldOffset(Offset = "0x40")]
    protected Dictionary<int, EventMissionTreasure> dicTreasure;
    [Token(Token = "0x400B156")]
    [FieldOffset(Offset = "0x48")]
    protected List<RewardConditionData> rewardDataList;
    [Token(Token = "0x400B157")]
    [FieldOffset(Offset = "0x50")]
    protected float tresureBoxAreaWidth;
    [Token(Token = "0x400B158")]
    protected const int ProgressOffset = -3;
    [Token(Token = "0x400B159")]
    protected const int TreasureOffset = 4;

    [Token(Token = "0x601059E")]
    [Address(RVA = "0x4881300", Offset = "0x4881300", VA = "0x4881300", Slot = "4")]
    public virtual void Initialize(
      List<RewardConditionData> rewardConditions,
      int progressPoint,
      int maxPoint,
      Action<bool, int> onClickTreasure)
    {
    }

    [Token(Token = "0x601059F")]
    [Address(RVA = "0x4881404", Offset = "0x4881404", VA = "0x4881404", Slot = "5")]
    protected virtual void CreateAndUpdateTresure(Action<bool, int> getProgressAction)
    {
    }

    [Token(Token = "0x60105A0")]
    [Address(RVA = "0x4881408", Offset = "0x4881408", VA = "0x4881408")]
    protected void CreateGauge(int progressPoint)
    {
    }

    [Token(Token = "0x60105A1")]
    [Address(RVA = "0x48817A4", Offset = "0x48817A4", VA = "0x48817A4")]
    private IEnumerator SetGaugeFill(float from, float to) => (IEnumerator) null;

    [Token(Token = "0x60105A2")]
    [Address(RVA = "0x4881848", Offset = "0x4881848", VA = "0x4881848")]
    public MissionProgressView()
    {
    }
  }
}
