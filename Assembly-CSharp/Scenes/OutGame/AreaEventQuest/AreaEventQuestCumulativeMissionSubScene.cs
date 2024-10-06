// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaEventQuest.AreaEventQuestCumulativeMissionSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using GameCore.Scene;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using Scenes.OutGame.OutGameMenu.ShopDetail;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.AreaEventQuest
{
  [Token(Token = "0x200390F")]
  public class AreaEventQuestCumulativeMissionSubScene : SubScene
  {
    [Token(Token = "0x400F96E")]
    [FieldOffset(Offset = "0x58")]
    private AreaEventQuestCumulativeMissionSubScene.SceneParam sceneParam;
    [Token(Token = "0x400F96F")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400F970")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CanvasGroup sceneCG;
    [Token(Token = "0x400F971")]
    [FieldOffset(Offset = "0x70")]
    private AreaEventQuestCumulativeMissionView cumulativeMissionView;
    [Token(Token = "0x400F972")]
    [FieldOffset(Offset = "0x78")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x400F973")]
    [FieldOffset(Offset = "0x80")]
    private PopupBase itemDetailPopup;
    [Token(Token = "0x400F974")]
    [FieldOffset(Offset = "0x88")]
    private ShopItemDetailPopup otherItemDetailPopup;
    [Token(Token = "0x400F975")]
    [FieldOffset(Offset = "0x90")]
    private TotalMissionEventData totalMissionEventData;
    [Token(Token = "0x400F976")]
    [FieldOffset(Offset = "0x98")]
    private DateTime endAt;
    [Token(Token = "0x400F977")]
    [FieldOffset(Offset = "0xA0")]
    private readonly TimeSpan minTime;
    [Token(Token = "0x400F978")]
    [FieldOffset(Offset = "0xA8")]
    private List<TotalMissionTabType> tabTypes;
    [Token(Token = "0x400F979")]
    [FieldOffset(Offset = "0xB0")]
    private int currentTabId;

    [Token(Token = "0x170049BE")]
    public static string AssetBundleName
    {
      [Token(Token = "0x60166D3"), Address(RVA = "0x20859D8", Offset = "0x20859D8", VA = "0x20859D8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170049BF")]
    public static string AssetName
    {
      [Token(Token = "0x60166D4"), Address(RVA = "0x2085A18", Offset = "0x2085A18", VA = "0x2085A18")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60166D5")]
    [Address(RVA = "0x2085A58", Offset = "0x2085A58", VA = "0x2085A58")]
    public static void ChangeSubScene(int resourceId, int totalMissionEventId)
    {
    }

    [Token(Token = "0x60166D6")]
    [Address(RVA = "0x2085BF8", Offset = "0x2085BF8", VA = "0x2085BF8")]
    private static void OutSidePeriod()
    {
    }

    [Token(Token = "0x60166D7")]
    [Address(RVA = "0x2085DC0", Offset = "0x2085DC0", VA = "0x2085DC0")]
    private void Update()
    {
    }

    [Token(Token = "0x60166D8")]
    [Address(RVA = "0x2086118", Offset = "0x2086118", VA = "0x2086118", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x60166D9")]
    [Address(RVA = "0x208625C", Offset = "0x208625C", VA = "0x208625C", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60166DA")]
    [Address(RVA = "0x20862EC", Offset = "0x20862EC", VA = "0x20862EC", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x60166DB")]
    [Address(RVA = "0x2086354", Offset = "0x2086354", VA = "0x2086354", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x60166DC")]
    [Address(RVA = "0x2086490", Offset = "0x2086490", VA = "0x2086490")]
    public void SetOperationPossible(bool state)
    {
    }

    [Token(Token = "0x60166DD")]
    [Address(RVA = "0x2086388", Offset = "0x2086388", VA = "0x2086388")]
    private void OnClickBack()
    {
    }

    [Token(Token = "0x60166DE")]
    [Address(RVA = "0x20864B0", Offset = "0x20864B0", VA = "0x20864B0")]
    private IEnumerator PlayTimeline(UITimelineController.DirectionType type, Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60166DF")]
    [Address(RVA = "0x2086530", Offset = "0x2086530", VA = "0x2086530")]
    private void OnClickTab(int id)
    {
    }

    [Token(Token = "0x60166E0")]
    [Address(RVA = "0x2086644", Offset = "0x2086644", VA = "0x2086644")]
    private IEnumerator OnClickRecieve() => (IEnumerator) null;

    [Token(Token = "0x60166E1")]
    [Address(RVA = "0x20866AC", Offset = "0x20866AC", VA = "0x20866AC")]
    private IEnumerator ConnectList() => (IEnumerator) null;

    [Token(Token = "0x60166E2")]
    [Address(RVA = "0x208673C", Offset = "0x208673C", VA = "0x208673C")]
    private IEnumerator ConnectRecieve(
      Action<APITotal_missionAcceptResponse> finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60166E3")]
    [Address(RVA = "0x20867D8", Offset = "0x20867D8", VA = "0x20867D8")]
    private IEnumerator OpenRewardPopup(APITotal_missionAcceptResponse response)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60166E4")]
    [Address(RVA = "0x2086840", Offset = "0x2086840", VA = "0x2086840")]
    private IEnumerator ShowTransferPresentToaster(
      APITotal_missionAcceptResponse response,
      Action finishAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60166E5")]
    [Address(RVA = "0x20868B4", Offset = "0x20868B4", VA = "0x20868B4")]
    private static void ConvertToDisplayItemRewardInfoData(
      out List<DisplayItemRewardInfoData> infos,
      List<int> acceptedMissionIds)
    {
    }

    [Token(Token = "0x60166E6")]
    [Address(RVA = "0x2086D10", Offset = "0x2086D10", VA = "0x2086D10")]
    private void OnClickRewardItem(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x60166E7")]
    [Address(RVA = "0x2086FA4", Offset = "0x2086FA4", VA = "0x2086FA4")]
    private void OpenSingleItemDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x60166E8")]
    [Address(RVA = "0x2086E2C", Offset = "0x2086E2C", VA = "0x2086E2C")]
    private void OpenOtherDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x60166E9")]
    [Address(RVA = "0x2085E4C", Offset = "0x2085E4C", VA = "0x2085E4C")]
    private void UpdateLimitText()
    {
    }

    [Token(Token = "0x60166EA")]
    [Address(RVA = "0x2086FD4", Offset = "0x2086FD4", VA = "0x2086FD4")]
    private void PlayBGM()
    {
    }

    [Token(Token = "0x60166EB")]
    [Address(RVA = "0x2087180", Offset = "0x2087180", VA = "0x2087180")]
    public AreaEventQuestCumulativeMissionSubScene()
    {
    }

    [Token(Token = "0x2003910")]
    public class SceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x400F97A")]
      [FieldOffset(Offset = "0x14")]
      public int ResourceId;
      [Token(Token = "0x400F97B")]
      [FieldOffset(Offset = "0x18")]
      public int TotalMissionEventId;

      [Token(Token = "0x60166F2")]
      [Address(RVA = "0x2085D90", Offset = "0x2085D90", VA = "0x2085D90")]
      public SceneParam(int resourceId, int totalMissionEventId)
      {
      }
    }
  }
}
