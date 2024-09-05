// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.MissionView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x200374E")]
  public sealed class MissionView : ResultViewBase
  {
    [Token(Token = "0x400F184")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string showName;
    [Token(Token = "0x400F185")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string hideName;
    [Token(Token = "0x400F186")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400F187")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private MissionCell missionCell;
    [Token(Token = "0x400F188")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private RectTransform missionCellParent_First;
    [Token(Token = "0x400F189")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private RectTransform missionCellParent_Sub;
    [Token(Token = "0x400F18A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private RectTransform missionCellParent_Main;
    [Token(Token = "0x400F18B")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject missionSubTitle_On;
    [Token(Token = "0x400F18C")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400F18D")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private float stampWaitTime;
    [Token(Token = "0x400F18F")]
    [FieldOffset(Offset = "0x80")]
    private List<MissionCell> missionInstances;
    [Token(Token = "0x400F190")]
    [FieldOffset(Offset = "0x88")]
    private List<MissionCell> subMissionInstances;
    [Token(Token = "0x400F191")]
    [FieldOffset(Offset = "0x90")]
    private (int masterId, bool isClear, bool playAnimation)[] missionData;
    [Token(Token = "0x400F192")]
    [FieldOffset(Offset = "0x98")]
    private (int masterId, bool isClear, bool playAnimation)[] subMissionData;

    [Token(Token = "0x1400021B")]
    public event UnityAction<int> LongPressEvent
    {
      [Token(Token = "0x6015C6E"), Address(RVA = "0x1B29CF4", Offset = "0x1B29CF4", VA = "0x1B29CF4")] add
      {
      }
      [Token(Token = "0x6015C6F"), Address(RVA = "0x1B29DA4", Offset = "0x1B29DA4", VA = "0x1B29DA4")] remove
      {
      }
    }

    [Token(Token = "0x6015C70")]
    [Address(RVA = "0x1B29E54", Offset = "0x1B29E54", VA = "0x1B29E54")]
    public void Initialize(
      BattleResultSubScene subScene,
      (int masterId, bool isClear, bool playAnimation)[] missionData,
      (int masterId, bool isClear, bool playAnimation)[] subMissionData)
    {
    }

    [Token(Token = "0x6015C71")]
    [Address(RVA = "0x1B2A13C", Offset = "0x1B2A13C", VA = "0x1B2A13C")]
    public void SetData(
      (int masterId, bool isClear, bool playAnimation)[] missionData,
      (int masterId, bool isClear, bool playAnimation)[] subMissionData)
    {
    }

    [Token(Token = "0x6015C72")]
    [Address(RVA = "0x1B2A144", Offset = "0x1B2A144", VA = "0x1B2A144", Slot = "6")]
    public override void Play()
    {
    }

    [Token(Token = "0x6015C73")]
    [Address(RVA = "0x1B2A6E0", Offset = "0x1B2A6E0", VA = "0x1B2A6E0", Slot = "7")]
    public override void Skip()
    {
    }

    [Token(Token = "0x6015C74")]
    [Address(RVA = "0x1B2A864", Offset = "0x1B2A864", VA = "0x1B2A864")]
    public void OnClick()
    {
    }

    [Token(Token = "0x6015C75")]
    [Address(RVA = "0x1B2A884", Offset = "0x1B2A884", VA = "0x1B2A884", Slot = "8")]
    protected override IEnumerator ExecutePlayFlow() => (IEnumerator) null;

    [Token(Token = "0x6015C76")]
    [Address(RVA = "0x1B2A914", Offset = "0x1B2A914", VA = "0x1B2A914")]
    public MissionView()
    {
    }
  }
}
