// Decompiled with JetBrains decompiler
// Type: Scenes.Story.Obliviae.ObliviaeQuestStageDetailPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story.Obliviae
{
  [Token(Token = "0x2002E63")]
  public class ObliviaeQuestStageDetailPanel : MonoBehaviour
  {
    [Token(Token = "0x400C705")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400C706")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400C707")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400C708")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton questDetailButton;
    [Token(Token = "0x400C709")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton sortieButton;
    [Token(Token = "0x400C70A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [Header("初回/クリア/ミッション/ドロップ順で入れること")]
    private ObliviaeQuestStageDetailRewardList[] rewardContentList;
    [Token(Token = "0x400C70B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private ObliviaeQuestStageThumbnail stageThumbnail;
    [Token(Token = "0x400C70C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Text challengeCountText;
    [Token(Token = "0x400C70D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private ScrollRect rewardScrollRect;
    [Token(Token = "0x400C70E")]
    [FieldOffset(Offset = "0x60")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400C70F")]
    [FieldOffset(Offset = "0x68")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x400C710")]
    [FieldOffset(Offset = "0x70")]
    private Action onClickClose;
    [Token(Token = "0x400C711")]
    [FieldOffset(Offset = "0x78")]
    private StoryObliviaeQuestData obliviaeQuestData;

    [Token(Token = "0x17003D9B")]
    private bool IsEnableButton
    {
      [Token(Token = "0x6012209"), Address(RVA = "0x458AD64", Offset = "0x458AD64", VA = "0x458AD64")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601220A")]
    [Address(RVA = "0x458AE04", Offset = "0x458AE04", VA = "0x458AE04")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x601220B")]
    [Address(RVA = "0x458ABA8", Offset = "0x458ABA8", VA = "0x458ABA8")]
    public IEnumerator Initialize(
      int totalClearCount,
      AssetCachedSpawner assetCachedSpawner,
      Action onClickClose)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601220C")]
    [Address(RVA = "0x4589858", Offset = "0x4589858", VA = "0x4589858")]
    public void Setup(StoryObliviaeQuestData obliviaeQuestData)
    {
    }

    [Token(Token = "0x601220D")]
    [Address(RVA = "0x45897F0", Offset = "0x45897F0", VA = "0x45897F0")]
    public void Show(Action callback = null)
    {
    }

    [Token(Token = "0x601220E")]
    [Address(RVA = "0x458AFC8", Offset = "0x458AFC8", VA = "0x458AFC8")]
    public void Hide(Action callback = null)
    {
    }

    [Token(Token = "0x601220F")]
    [Address(RVA = "0x458B0B8", Offset = "0x458B0B8", VA = "0x458B0B8")]
    private void Update()
    {
    }

    [Token(Token = "0x6012210")]
    [Address(RVA = "0x458AE48", Offset = "0x458AE48", VA = "0x458AE48")]
    private void SetupScroll(StoryObliviaeQuestData obliviaeQuestData)
    {
    }

    [Token(Token = "0x6012211")]
    [Address(RVA = "0x458C718", Offset = "0x458C718", VA = "0x458C718")]
    private IEnumerator ItemDetailInit() => (IEnumerator) null;

    [Token(Token = "0x6012212")]
    [Address(RVA = "0x458C7A8", Offset = "0x458C7A8", VA = "0x458C7A8")]
    private void OpenItemDetail(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6012213")]
    [Address(RVA = "0x458C7F8", Offset = "0x458C7F8", VA = "0x458C7F8")]
    private void CloseDetailPopup()
    {
    }

    [Token(Token = "0x6012214")]
    [Address(RVA = "0x458C80C", Offset = "0x458C80C", VA = "0x458C80C")]
    private void GotoSortie(StoryObliviaeQuestData quest)
    {
    }

    [Token(Token = "0x6012215")]
    [Address(RVA = "0x458C980", Offset = "0x458C980", VA = "0x458C980")]
    private void OnClickQuestDetail(int questId)
    {
    }

    [Token(Token = "0x6012216")]
    [Address(RVA = "0x458CA34", Offset = "0x458CA34", VA = "0x458CA34")]
    private IEnumerator OpenQuestDetailPopup(int questId) => (IEnumerator) null;

    [Token(Token = "0x6012217")]
    [Address(RVA = "0x458CAD4", Offset = "0x458CAD4", VA = "0x458CAD4")]
    private void OnClickClose()
    {
    }

    [Token(Token = "0x6012218")]
    [Address(RVA = "0x458BD80", Offset = "0x458BD80", VA = "0x458BD80")]
    private ObliviaeQuestStageDetailRewardData[] GetDropRewards(StoryObliviaeQuestData questData)
    {
      return (ObliviaeQuestStageDetailRewardData[]) null;
    }

    [Token(Token = "0x6012219")]
    [Address(RVA = "0x458B5E4", Offset = "0x458B5E4", VA = "0x458B5E4")]
    private ObliviaeQuestStageDetailRewardData[] GetMissionRewards(StoryObliviaeQuestData questData)
    {
      return (ObliviaeQuestStageDetailRewardData[]) null;
    }

    [Token(Token = "0x601221A")]
    [Address(RVA = "0x458B13C", Offset = "0x458B13C", VA = "0x458B13C")]
    private ObliviaeQuestStageDetailRewardData[] GetClearRewards(
      StoryObliviaeQuestData questData,
      bool isFirstClear)
    {
      return (ObliviaeQuestStageDetailRewardData[]) null;
    }

    [Token(Token = "0x601221B")]
    [Address(RVA = "0x458CB6C", Offset = "0x458CB6C", VA = "0x458CB6C")]
    public ObliviaeQuestStageDetailPanel()
    {
    }

    [Token(Token = "0x2002E64")]
    public enum RewardType
    {
      [Token(Token = "0x400C713")] FirstClear,
      [Token(Token = "0x400C714")] Clear,
      [Token(Token = "0x400C715")] Mission,
      [Token(Token = "0x400C716")] Drop,
      [Token(Token = "0x400C717")] Max,
    }
  }
}
