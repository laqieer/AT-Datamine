// Decompiled with JetBrains decompiler
// Type: Scenes.Mission.MissionListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.Param;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Mission
{
  [Token(Token = "0x2002A93")]
  public class MissionListItem : InfiniteCellBase
  {
    [Token(Token = "0x400B52B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI missionName;
    [Token(Token = "0x400B52C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI missionProgress;
    [Token(Token = "0x400B52D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI missionProgress2;
    [Token(Token = "0x400B52E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private MissionItemTimeView timeLimit;
    [Token(Token = "0x400B52F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton receiveBtn;
    [Token(Token = "0x400B530")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton noFinishBtn;
    [Token(Token = "0x400B531")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text receiveText;
    [Token(Token = "0x400B532")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private RectTransform gauge;
    [Token(Token = "0x400B533")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private UITweenGroup tg;
    [Token(Token = "0x400B534")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private ItemIcon[] itemIcon;
    [Token(Token = "0x400B535")]
    [FieldOffset(Offset = "0x78")]
    private bool isInitialized;
    [Token(Token = "0x400B536")]
    [FieldOffset(Offset = "0x80")]
    private PlayerMissionProgressType missionProgressType;
    [Token(Token = "0x400B537")]
    [FieldOffset(Offset = "0x88")]
    private bool isMissionCleared;
    [Token(Token = "0x400B538")]
    [FieldOffset(Offset = "0x89")]
    private bool isMissionAccepted;

    [Token(Token = "0x6010A97")]
    [Address(RVA = "0x4BCE4CC", Offset = "0x4BCE4CC", VA = "0x4BCE4CC")]
    private void Start()
    {
    }

    [Token(Token = "0x6010A98")]
    [Address(RVA = "0x4BCE4D0", Offset = "0x4BCE4D0", VA = "0x4BCE4D0")]
    private void Update()
    {
    }

    [Token(Token = "0x6010A99")]
    [Address(RVA = "0x4BCE784", Offset = "0x4BCE784", VA = "0x4BCE784")]
    public void SetData(
      AssetCachedSpawner assetCachedSpawner,
      PlayerMissionProgressType progressType,
      Action<RewardTypeEnum, int> onClick,
      Action<int> onReceive)
    {
    }

    [Token(Token = "0x6010A9A")]
    [Address(RVA = "0x4BCE520", Offset = "0x4BCE520", VA = "0x4BCE520")]
    private TimeSpan? LimitTime(PlayerMissionProgressType mission, bool isClear) => new TimeSpan?();

    [Token(Token = "0x6010A9B")]
    [Address(RVA = "0x4BCF120", Offset = "0x4BCF120", VA = "0x4BCF120", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6010A9C")]
    [Address(RVA = "0x4BCF1C0", Offset = "0x4BCF1C0", VA = "0x4BCF1C0")]
    public MissionListItem()
    {
    }

    [Token(Token = "0x2002A94")]
    public class MissionCellData
    {
      [Token(Token = "0x400B539")]
      [FieldOffset(Offset = "0x10")]
      public AssetCachedSpawner AssetCachedSpawner;
      [Token(Token = "0x400B53A")]
      [FieldOffset(Offset = "0x18")]
      public PlayerMissionProgressType ProgressType;
      [Token(Token = "0x400B53B")]
      [FieldOffset(Offset = "0x20")]
      public Action<RewardTypeEnum, int> OnClick;
      [Token(Token = "0x400B53C")]
      [FieldOffset(Offset = "0x28")]
      public Action<int> OnReceive;

      [Token(Token = "0x6010A9D")]
      [Address(RVA = "0x4BCDE34", Offset = "0x4BCDE34", VA = "0x4BCDE34")]
      public MissionCellData()
      {
      }
    }
  }
}
