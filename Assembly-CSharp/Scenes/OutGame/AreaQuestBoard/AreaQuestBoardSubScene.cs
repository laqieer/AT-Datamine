// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.AreaQuestBoardSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using Scenes.OutGame.AreaQuestBoard.Top;
using Scenes.OutGame.AreaQuestBoard.Top.SideMenu;
using Scenes.QuestNodeTree;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard
{
  [Token(Token = "0x20038B5")]
  public class AreaQuestBoardSubScene : SubScene
  {
    [Token(Token = "0x400F7F7")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private AreaQuestBoardTopView topView;
    [Token(Token = "0x400F7F8")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private AreaQuestBoardSideMenu sideMenu;
    [Token(Token = "0x400F7F9")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400F7FA")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton backButton;
    [Token(Token = "0x400F7FB")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private QuestNodeTreeView treeView;
    [Token(Token = "0x400F7FC")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private AreaQuestBackgroundController bgController;
    [Token(Token = "0x400F7FD")]
    [FieldOffset(Offset = "0x88")]
    private IAreaQuestTopPresenter presenter;
    [Token(Token = "0x400F7FE")]
    [FieldOffset(Offset = "0x90")]
    private AreaQuestBoardTopModel model;
    [Token(Token = "0x400F7FF")]
    [FieldOffset(Offset = "0x98")]
    private AreaQuestBoardTopSideMenuPresenter sideMenuPresenter;
    [Token(Token = "0x400F800")]
    [FieldOffset(Offset = "0xA0")]
    private MapController mapController;
    [Token(Token = "0x400F801")]
    [FieldOffset(Offset = "0xA8")]
    private bool isEventAreaGroup;
    [Token(Token = "0x400F802")]
    [FieldOffset(Offset = "0xB0")]
    private Action onFinishEnableEffect;
    [Token(Token = "0x400F803")]
    [FieldOffset(Offset = "0xB8")]
    private AreaQuestBoardSubScene.SceneParam sceneParam;
    [Token(Token = "0x400F804")]
    [FieldOffset(Offset = "0xC0")]
    private bool InitializationSucceeded;
    [Token(Token = "0x400F805")]
    [FieldOffset(Offset = "0xC1")]
    private bool monitorPlayableAreaUpdateEnable;
    [Token(Token = "0x400F806")]
    [FieldOffset(Offset = "0xC2")]
    private bool monitorPlayableAreaUpdateNow;
    [Token(Token = "0x400F807")]
    [FieldOffset(Offset = "0xC8")]
    private List<(int areaId, bool isPlayable, bool isRequestAnim)> monitorChangedPlayableAreaList;

    [Token(Token = "0x601649D")]
    [Address(RVA = "0x2072E08", Offset = "0x2072E08", VA = "0x2072E08")]
    public static void ChangeSubScene(AreaQuestBoardSubScene.SceneParam param)
    {
    }

    [Token(Token = "0x601649E")]
    [Address(RVA = "0x2072EE8", Offset = "0x2072EE8", VA = "0x2072EE8", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x601649F")]
    [Address(RVA = "0x2073564", Offset = "0x2073564", VA = "0x2073564", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60164A0")]
    [Address(RVA = "0x20735F4", Offset = "0x20735F4", VA = "0x20735F4", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x60164A1")]
    [Address(RVA = "0x2073684", Offset = "0x2073684", VA = "0x2073684", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x60164A2")]
    [Address(RVA = "0x2073714", Offset = "0x2073714", VA = "0x2073714", Slot = "30")]
    protected override void BackKeyDownActionInSubScene()
    {
    }

    [Token(Token = "0x60164A3")]
    [Address(RVA = "0x2073878", Offset = "0x2073878", VA = "0x2073878", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x60164A4")]
    [Address(RVA = "0x2073908", Offset = "0x2073908", VA = "0x2073908")]
    public void OnSelectedNode(int nodeId, bool isActive)
    {
    }

    [Token(Token = "0x60164A5")]
    [Address(RVA = "0x2073E3C", Offset = "0x2073E3C", VA = "0x2073E3C")]
    public void OnJumpNode(int nodeId, Action onActionFinish)
    {
    }

    [Token(Token = "0x60164A6")]
    [Address(RVA = "0x2073FE4", Offset = "0x2073FE4", VA = "0x2073FE4")]
    public void OnChangeArea()
    {
    }

    [Token(Token = "0x60164A7")]
    [Address(RVA = "0x2073FEC", Offset = "0x2073FEC", VA = "0x2073FEC")]
    public void ChangeAreaFromFadeInStatus()
    {
    }

    [Token(Token = "0x60164A8")]
    [Address(RVA = "0x207400C", Offset = "0x207400C", VA = "0x207400C")]
    private IEnumerator ChangeAreaSequence() => (IEnumerator) null;

    [Token(Token = "0x60164A9")]
    [Address(RVA = "0x207409C", Offset = "0x207409C", VA = "0x207409C")]
    public void ChangeDifficultyType()
    {
    }

    [Token(Token = "0x60164AA")]
    [Address(RVA = "0x207436C", Offset = "0x207436C", VA = "0x207436C")]
    public void OnClickSubMenuButton(bool scenarioOnly)
    {
    }

    [Token(Token = "0x60164AB")]
    [Address(RVA = "0x2074374", Offset = "0x2074374", VA = "0x2074374")]
    private void ChangeScene(bool scenarioOnly)
    {
    }

    [Token(Token = "0x60164AC")]
    [Address(RVA = "0x2073718", Offset = "0x2073718", VA = "0x2073718")]
    private void OnBack()
    {
    }

    [Token(Token = "0x60164AD")]
    [Address(RVA = "0x2073CD0", Offset = "0x2073CD0", VA = "0x2073CD0")]
    private void OpenSubMenu(int nodeId)
    {
    }

    [Token(Token = "0x60164AE")]
    [Address(RVA = "0x20746DC", Offset = "0x20746DC", VA = "0x20746DC")]
    private void CloseSubMenu()
    {
    }

    [Token(Token = "0x60164AF")]
    [Address(RVA = "0x2073454", Offset = "0x2073454", VA = "0x2073454")]
    private void SpecialTaskForTransitionReason(AreaQuestBoardSubScene.SceneParam para)
    {
    }

    [Token(Token = "0x60164B0")]
    [Address(RVA = "0x2073DBC", Offset = "0x2073DBC", VA = "0x2073DBC")]
    private void PlayBackGroundMovie()
    {
    }

    [Token(Token = "0x60164B1")]
    [Address(RVA = "0x2074744", Offset = "0x2074744", VA = "0x2074744")]
    public void OnChangePlayableArea(int areaId, bool isPlayable, bool isRequestAnim)
    {
    }

    [Token(Token = "0x60164B2")]
    [Address(RVA = "0x2074834", Offset = "0x2074834", VA = "0x2074834")]
    private void MonitorPlayableAreaUpdateIfNeeded()
    {
    }

    [Token(Token = "0x60164B3")]
    [Address(RVA = "0x2074F84", Offset = "0x2074F84", VA = "0x2074F84")]
    private void OnInvalidPlayableAreaOpenSystemPopup(string message)
    {
    }

    [Token(Token = "0x60164B4")]
    [Address(RVA = "0x2075248", Offset = "0x2075248", VA = "0x2075248")]
    private void Update()
    {
    }

    [Token(Token = "0x60164B5")]
    [Address(RVA = "0x2075304", Offset = "0x2075304", VA = "0x2075304")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60164B6")]
    [Address(RVA = "0x2075350", Offset = "0x2075350", VA = "0x2075350")]
    public AreaQuestBoardSubScene()
    {
    }

    [Token(Token = "0x20038B6")]
    public class SceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x400F808")]
      [FieldOffset(Offset = "0x14")]
      public int TargetAreaGroupId;
      [Token(Token = "0x400F809")]
      [FieldOffset(Offset = "0x18")]
      public int SelectedAreaId;
      [Token(Token = "0x400F80A")]
      [FieldOffset(Offset = "0x1C")]
      public int SelectedAreaNodeId;
      [Token(Token = "0x400F80B")]
      [FieldOffset(Offset = "0x20")]
      public QuestDifficultyTypeEnum SelectedDiff;
      [Token(Token = "0x400F80C")]
      [FieldOffset(Offset = "0x24")]
      public AreaQuestBoardSubScene.SceneParam.TransitionReasonType TransitionReason;

      [Token(Token = "0x60164BE")]
      [Address(RVA = "0x2071F48", Offset = "0x2071F48", VA = "0x2071F48")]
      public static AreaQuestBoardSubScene.SceneParam NoParam()
      {
        return (AreaQuestBoardSubScene.SceneParam) null;
      }

      [Token(Token = "0x60164BF")]
      [Address(RVA = "0x2072EDC", Offset = "0x2072EDC", VA = "0x2072EDC")]
      public void SetCreatedBack(bool b)
      {
      }

      [Token(Token = "0x60164C0")]
      [Address(RVA = "0x20756A8", Offset = "0x20756A8", VA = "0x20756A8")]
      public SceneParam()
      {
      }

      [Token(Token = "0x20038B7")]
      public enum TransitionReasonType
      {
        [Token(Token = "0x400F80E")] Normal,
        [Token(Token = "0x400F80F")] AfterBattle,
        [Token(Token = "0x400F810")] AfterStoryPlay,
        [Token(Token = "0x400F811")] ItemSupplier,
      }
    }
  }
}
