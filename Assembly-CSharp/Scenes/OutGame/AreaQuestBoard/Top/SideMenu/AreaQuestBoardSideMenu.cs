// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.SideMenu.AreaQuestBoardSideMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top.SideMenu
{
  [Token(Token = "0x20038FE")]
  public class AreaQuestBoardSideMenu : MonoBehaviour
  {
    [Token(Token = "0x400F927")]
    [FieldOffset(Offset = "0x18")]
    [Header("タイムライン")]
    [SerializeField]
    private PlayableDirector inPlayable;
    [Token(Token = "0x400F928")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayableDirector outPlayable;
    [Token(Token = "0x400F929")]
    [FieldOffset(Offset = "0x28")]
    [Header("表示物")]
    [SerializeField]
    private SideMenuInfo sideMenuInfo;
    [Token(Token = "0x400F92A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton detailButton;
    [Token(Token = "0x400F92B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CanvasGroup infoCG;
    [Token(Token = "0x400F92C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [Header("遷移ボタン")]
    private CommonButton scenarioButton;
    [Token(Token = "0x400F92D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton sortieButton;
    [Token(Token = "0x400F92E")]
    [FieldOffset(Offset = "0x50")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400F92F")]
    [FieldOffset(Offset = "0x58")]
    private AreaQuestInfo questInfo;
    [Token(Token = "0x400F930")]
    [FieldOffset(Offset = "0x60")]
    private int areaNodeQuestId;
    [Token(Token = "0x400F931")]
    [FieldOffset(Offset = "0x64")]
    private bool isDisplay;
    [Token(Token = "0x400F932")]
    [FieldOffset(Offset = "0x68")]
    private Action<QuestInfo> openQuestDetailAction;
    [Token(Token = "0x400F933")]
    [FieldOffset(Offset = "0x70")]
    private Action<RewardTypeEnum, int> openItemDetailAction;

    [Token(Token = "0x170049AF")]
    public bool IsDisPlay
    {
      [Token(Token = "0x601667C"), Address(RVA = "0x20823E0", Offset = "0x20823E0", VA = "0x20823E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601667D")]
    [Address(RVA = "0x207F728", Offset = "0x207F728", VA = "0x207F728")]
    public void Initialize(
      AssetCachedSpawner assetCachedSpawner,
      Action<bool> changeSceneAction,
      Action<QuestInfo> openQuestDetailAction,
      Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x601667E")]
    [Address(RVA = "0x20745C8", Offset = "0x20745C8", VA = "0x20745C8")]
    public void Open(int areaNodeQuestId, bool isPlayableAdv, bool isEvent)
    {
    }

    [Token(Token = "0x601667F")]
    [Address(RVA = "0x2082508", Offset = "0x2082508", VA = "0x2082508")]
    private IEnumerator OpenAsync(Action finishAction = null) => (IEnumerator) null;

    [Token(Token = "0x6016680")]
    [Address(RVA = "0x207F938", Offset = "0x207F938", VA = "0x207F938")]
    public void Refresh(int areaNodeQuestId, bool isPlayableAdv, bool isEvent)
    {
    }

    [Token(Token = "0x6016681")]
    [Address(RVA = "0x207471C", Offset = "0x207471C", VA = "0x207471C")]
    public void Close(Action finishAction = null)
    {
    }

    [Token(Token = "0x6016682")]
    [Address(RVA = "0x20825A4", Offset = "0x20825A4", VA = "0x20825A4")]
    private IEnumerator CloseAsync(Action finishAction = null) => (IEnumerator) null;

    [Token(Token = "0x6016683")]
    [Address(RVA = "0x2082640", Offset = "0x2082640", VA = "0x2082640")]
    private void OnClickDetail()
    {
    }

    [Token(Token = "0x6016684")]
    [Address(RVA = "0x20823F0", Offset = "0x20823F0", VA = "0x20823F0")]
    private void UpdateSideMenu(int areaNodeQuestId, bool isEvent)
    {
    }

    [Token(Token = "0x6016685")]
    [Address(RVA = "0x208302C", Offset = "0x208302C", VA = "0x208302C")]
    public AreaQuestBoardSideMenu()
    {
    }
  }
}
