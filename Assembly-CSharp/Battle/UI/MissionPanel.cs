// Decompiled with JetBrains decompiler
// Type: Battle.UI.MissionPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Utility;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Battle;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002314")]
  [RequireComponent(typeof (MissionPanelTween))]
  public sealed class MissionPanel : MonoBehaviour
  {
    [Token(Token = "0x400946D")]
    [FieldOffset(Offset = "0x18")]
    [HideInInspector]
    [SerializeField]
    private MissionPanelTween tweener;
    [Token(Token = "0x400946E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private MissionCell missionCellTemplate;
    [Token(Token = "0x400946F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private MissionCell firstClearCell;
    [Token(Token = "0x4009470")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject storyMissionCellTitle;
    [Token(Token = "0x4009471")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject storyMissionCellRoot;
    [Token(Token = "0x4009472")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text storyMissionDetail;
    [Token(Token = "0x4009473")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Transform missionCellParent;
    [Token(Token = "0x4009474")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private int initialPoolingCount;
    [Token(Token = "0x4009475")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private int maxPoolingCount;
    [Token(Token = "0x4009476")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x4009477")]
    [FieldOffset(Offset = "0x60")]
    private ObjectPool<PoolableMissionCell, MissionCell> missionCellPool;
    [Token(Token = "0x4009478")]
    [FieldOffset(Offset = "0x68")]
    private HashSet<PoolableMissionCell> usingCells;
    [Token(Token = "0x4009479")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Vector2 ResetScrollPosition;

    [Token(Token = "0x600D64F")]
    [Address(RVA = "0x1D1CCB8", Offset = "0x1D1CCB8", VA = "0x1D1CCB8")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600D650")]
    [Address(RVA = "0x1D1CD88", Offset = "0x1D1CD88", VA = "0x1D1CD88")]
    public void Show(
      int firstClearId,
      bool isFirstClear,
      StoryBattleMissionData storyMission,
      IEnumerable<(IMissionData mission, bool isAlreadyClear)> missionParams)
    {
    }

    [Token(Token = "0x600D651")]
    [Address(RVA = "0x1D1D704", Offset = "0x1D1D704", VA = "0x1D1D704")]
    private void SetStoryMission(StoryBattleMissionData storyMission)
    {
    }

    [Token(Token = "0x600D652")]
    [Address(RVA = "0x1D1D848", Offset = "0x1D1D848", VA = "0x1D1D848")]
    public void Close()
    {
    }

    [Token(Token = "0x600D653")]
    [Address(RVA = "0x1D1DA8C", Offset = "0x1D1DA8C", VA = "0x1D1DA8C")]
    public MissionPanel()
    {
    }

    [Token(Token = "0x600D654")]
    [Address(RVA = "0x1D1DB14", Offset = "0x1D1DB14", VA = "0x1D1DB14")]
    static MissionPanel()
    {
    }
  }
}
