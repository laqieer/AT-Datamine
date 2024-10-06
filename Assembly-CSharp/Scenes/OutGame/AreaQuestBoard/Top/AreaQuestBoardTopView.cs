// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.AreaQuestBoardTopView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.APRecovery;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top
{
  [Token(Token = "0x20038E3")]
  internal class AreaQuestBoardTopView : MonoBehaviour
  {
    [Token(Token = "0x400F8D9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("タイムライン")]
    private UITimelineController timelineController;
    [Token(Token = "0x400F8DA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("BG")]
    private AreaQuestBackgroundController backgroundController;
    [Token(Token = "0x400F8DB")]
    [FieldOffset(Offset = "0x28")]
    [Space(10f)]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400F8DC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Header("APGauge")]
    private ApRecoveryHeader apHeader;
    [Token(Token = "0x400F8DD")]
    [FieldOffset(Offset = "0x38")]
    [Header("難易度変更ボタン")]
    [SerializeField]
    private DifficultyToggleGroup difficultyToggleGroup;
    [Token(Token = "0x400F8DE")]
    [FieldOffset(Offset = "0x40")]
    [Header("シナリオスキップ設定変更ボタン")]
    [SerializeField]
    private ScenarioSkipToggle scenarioSkipToggle;
    [Token(Token = "0x400F8DF")]
    [FieldOffset(Offset = "0x48")]
    [Header("ノードジャンプボタン")]
    [SerializeField]
    private GameObject jumpContentsRoot;
    [Token(Token = "0x400F8E0")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private JumpNodeButton nodeJumpButtonCloneBase;
    [Token(Token = "0x400F8E1")]
    [FieldOffset(Offset = "0x58")]
    private readonly List<JumpNodeButton> jumpNodeButtons;
    [Token(Token = "0x400F8E2")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    [Header("エリア切替ボタンの親")]
    private Transform areaChaneButtonParent;
    [Token(Token = "0x400F8E3")]
    [FieldOffset(Offset = "0x68")]
    private readonly List<AreaChangeButton> areaChangeButtons;
    [Token(Token = "0x400F8E4")]
    [FieldOffset(Offset = "0x70")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x17004996")]
    public List<AreaChangeButton> AreaChangeButtons
    {
      [Token(Token = "0x60165E0"), Address(RVA = "0x20804DC", Offset = "0x20804DC", VA = "0x20804DC")] get
      {
        return (List<AreaChangeButton>) null;
      }
    }

    [Token(Token = "0x60165E1")]
    [Address(RVA = "0x20804E4", Offset = "0x20804E4", VA = "0x20804E4")]
    public void SetAssetCachedSpawner(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x60165E2")]
    [Address(RVA = "0x207C568", Offset = "0x207C568", VA = "0x207C568")]
    public IEnumerator InitializeAsync(List<AreaQuestBoardTopModel.AssetBundlePath> paths)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60165E3")]
    [Address(RVA = "0x2080514", Offset = "0x2080514", VA = "0x2080514")]
    private IEnumerator CreateAreaButton(List<AreaQuestBoardTopModel.AssetBundlePath> paths)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60165E4")]
    [Address(RVA = "0x207A6A4", Offset = "0x207A6A4", VA = "0x207A6A4")]
    public void Setup()
    {
    }

    [Token(Token = "0x60165E5")]
    [Address(RVA = "0x20745A8", Offset = "0x20745A8", VA = "0x20745A8")]
    public void SetInteractable(bool flag)
    {
    }

    [Token(Token = "0x60165E6")]
    [Address(RVA = "0x20770C4", Offset = "0x20770C4", VA = "0x20770C4")]
    public void PlayInTopSubScene(Action onFinishAnim)
    {
    }

    [Token(Token = "0x60165E7")]
    [Address(RVA = "0x2076964", Offset = "0x2076964", VA = "0x2076964")]
    public void PlayOutTopSubScene(Action onFinishAnim)
    {
    }

    [Token(Token = "0x60165E8")]
    [Address(RVA = "0x2074EF8", Offset = "0x2074EF8", VA = "0x2074EF8")]
    public IEnumerator PlayUnlockAreaDirection(
      int currentAreaId,
      List<int> requestUnlockAreaIds,
      Action onDirectionFinish = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60165E9")]
    [Address(RVA = "0x207BE40", Offset = "0x207BE40", VA = "0x207BE40")]
    public void PlayChangeAreaIn(Action onRefreshView)
    {
    }

    [Token(Token = "0x60165EA")]
    [Address(RVA = "0x2076470", Offset = "0x2076470", VA = "0x2076470")]
    public void PlayChangeAreaOut(Action onFinish = null)
    {
    }

    [Token(Token = "0x60165EB")]
    [Address(RVA = "0x20805F0", Offset = "0x20805F0", VA = "0x20805F0")]
    public void PlayBackGroundMovie(int movieId)
    {
    }

    [Token(Token = "0x60165EC")]
    [Address(RVA = "0x208060C", Offset = "0x208060C", VA = "0x208060C")]
    public void MoveLeftBackGroundMovie()
    {
    }

    [Token(Token = "0x60165ED")]
    [Address(RVA = "0x2080628", Offset = "0x2080628", VA = "0x2080628")]
    public void MoveRightBackGroundMovie()
    {
    }

    [Token(Token = "0x60165EE")]
    [Address(RVA = "0x2076FE0", Offset = "0x2076FE0", VA = "0x2076FE0")]
    public void PlayBGM(string bgmPackName, string bgmEventName)
    {
    }

    [Token(Token = "0x60165EF")]
    [Address(RVA = "0x2073ACC", Offset = "0x2073ACC", VA = "0x2073ACC")]
    public void ShowToasterLockNode(int nodeId)
    {
    }

    [Token(Token = "0x60165F0")]
    [Address(RVA = "0x2080644", Offset = "0x2080644", VA = "0x2080644")]
    public void ShowToasterAreaLock(int areaId)
    {
    }

    [Token(Token = "0x60165F1")]
    [Address(RVA = "0x2080780", Offset = "0x2080780", VA = "0x2080780")]
    public void ShowLockDifficulty(int nextDifficultyId)
    {
    }

    [Token(Token = "0x60165F2")]
    [Address(RVA = "0x2075A30", Offset = "0x2075A30", VA = "0x2075A30")]
    public void ChangeArea(AreaQuestAreaData nextAreaData)
    {
    }

    [Token(Token = "0x60165F3")]
    [Address(RVA = "0x207AF84", Offset = "0x207AF84", VA = "0x207AF84")]
    public void DisableDifficultyButton()
    {
    }

    [Token(Token = "0x60165F4")]
    [Address(RVA = "0x207AFB0", Offset = "0x207AFB0", VA = "0x207AFB0")]
    public void SetupDifficulty(
      int selectedDifficultyId,
      int unlockHighestDifficultyId,
      Action<int> onChangeDifficulty)
    {
    }

    [Token(Token = "0x60165F5")]
    [Address(RVA = "0x207BEE0", Offset = "0x207BEE0", VA = "0x207BEE0")]
    public void DifficultyChange(int nextDifficultyId)
    {
    }

    [Token(Token = "0x60165F6")]
    [Address(RVA = "0x207B21C", Offset = "0x207B21C", VA = "0x207B21C")]
    public void SetupScenarioSkipSetting(bool initOn, Action<bool> onClick)
    {
    }

    [Token(Token = "0x60165F7")]
    [Address(RVA = "0x207C1B8", Offset = "0x207C1B8", VA = "0x207C1B8")]
    public void ScenarioSkipSettingChange(bool On)
    {
    }

    [Token(Token = "0x60165F8")]
    [Address(RVA = "0x207B950", Offset = "0x207B950", VA = "0x207B950")]
    public void DisableJumpButtonRoot()
    {
    }

    [Token(Token = "0x60165F9")]
    [Address(RVA = "0x2080CC0", Offset = "0x2080CC0", VA = "0x2080CC0")]
    public void ChangeEnableJumpButtonEffect(
      int nextJumpGroupId,
      QuestDifficultyTypeEnum selectedDifficulty)
    {
    }

    [Token(Token = "0x60165FA")]
    [Address(RVA = "0x207B984", Offset = "0x207B984", VA = "0x207B984")]
    public JumpNodeButton GetJumpNodeButton() => (JumpNodeButton) null;

    [Token(Token = "0x60165FB")]
    [Address(RVA = "0x207C250", Offset = "0x207C250", VA = "0x207C250")]
    public void AllDisableJumpButton()
    {
    }

    [Token(Token = "0x60165FC")]
    [Address(RVA = "0x2080F44", Offset = "0x2080F44", VA = "0x2080F44")]
    private JumpNodeButton GetDisableJumpButton() => (JumpNodeButton) null;

    [Token(Token = "0x60165FD")]
    [Address(RVA = "0x208106C", Offset = "0x208106C", VA = "0x208106C")]
    public AreaQuestBoardTopView()
    {
    }
  }
}
