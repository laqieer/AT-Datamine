// Decompiled with JetBrains decompiler
// Type: Scenes.Home.HomeSuspendResume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Network;
using Network.API;
using Network.Param;
using Scenes.Title;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.Home
{
  [Token(Token = "0x2002AD6")]
  public class HomeSuspendResume
  {
    [Token(Token = "0x400B645")]
    [FieldOffset(Offset = "0x10")]
    protected AbilityBoardCheckPopup abilityBoardCheckPopupPrefab;
    [Token(Token = "0x400B646")]
    [FieldOffset(Offset = "0x18")]
    protected AbilityBoardCheckPopup abilityBoardCheckPopup;
    [Token(Token = "0x400B647")]
    [FieldOffset(Offset = "0x20")]
    private BattlePauseDataPopup BattlePauseDataPopupPrefab;
    [Token(Token = "0x400B648")]
    [FieldOffset(Offset = "0x28")]
    private BattlePauseDataPopup BattlePauseDataPopup;
    [Token(Token = "0x400B649")]
    [FieldOffset(Offset = "0x30")]
    private PopupHandle optionPendingPopup;
    [Token(Token = "0x400B64A")]
    [FieldOffset(Offset = "0x38")]
    private CommonButtonContent optionButtonContent;
    [Token(Token = "0x400B64B")]
    public const string BattlePauseDataPrefabName = "Com_Popup_Base_L_RestartConfirmation";
    [Token(Token = "0x400B64C")]
    public const string BattlePauseDataAssetBundleName = "ui_page_home_prefab";
    [Token(Token = "0x400B64D")]
    [FieldOffset(Offset = "0x40")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x170039E4")]
    public bool AwayFromHome
    {
      [Token(Token = "0x6010BDD"), Address(RVA = "0x4BDAD08", Offset = "0x4BDAD08", VA = "0x4BDAD08")] get
      {
        return new bool();
      }
      [Token(Token = "0x6010BDE"), Address(RVA = "0x4BDAD10", Offset = "0x4BDAD10", VA = "0x4BDAD10")] private set
      {
      }
    }

    [Token(Token = "0x6010BDF")]
    [Address(RVA = "0x4BDAD1C", Offset = "0x4BDAD1C", VA = "0x4BDAD1C")]
    public HomeSuspendResume(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6010BE0")]
    [Address(RVA = "0x4BDAD44", Offset = "0x4BDAD44", VA = "0x4BDAD44")]
    public IEnumerator SuspendResumeAsync() => (IEnumerator) null;

    [Token(Token = "0x6010BE1")]
    [Address(RVA = "0x4BDADD4", Offset = "0x4BDADD4", VA = "0x4BDADD4")]
    public void BackKeyDownAction()
    {
    }

    [Token(Token = "0x6010BE2")]
    [Address(RVA = "0x4BDAEFC", Offset = "0x4BDAEFC", VA = "0x4BDAEFC")]
    public bool IsAnyOpenSuspendResumePopup() => new bool();

    [Token(Token = "0x6010BE3")]
    private IEnumerator LoadPrefabAsync<T>(
      string assetBundleName,
      string assetName,
      Action<T> onFinish)
      where T : MonoBehaviour
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010BE4")]
    [Address(RVA = "0x4BDAFA0", Offset = "0x4BDAFA0", VA = "0x4BDAFA0")]
    private IEnumerator OpenBattlePopup() => (IEnumerator) null;

    [Token(Token = "0x6010BE5")]
    [Address(RVA = "0x4BDB030", Offset = "0x4BDB030", VA = "0x4BDB030")]
    private IEnumerator ExecuteBattleResume(BoardData boardData) => (IEnumerator) null;

    [Token(Token = "0x6010BE6")]
    [Address(RVA = "0x4BDB0CC", Offset = "0x4BDB0CC", VA = "0x4BDB0CC")]
    private IEnumerator ExecuteBattleRetreat(BoardData boardData) => (IEnumerator) null;

    [Token(Token = "0x6010BE7")]
    [Address(RVA = "0x4BDB168", Offset = "0x4BDB168", VA = "0x4BDB168")]
    private IEnumerator OnBattleRetreatError(NetworkErrorResult networkErrorResult)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010BE8")]
    [Address(RVA = "0x4BDB1F8", Offset = "0x4BDB1F8", VA = "0x4BDB1F8")]
    private IEnumerator OpenAbilityBoardPopup() => (IEnumerator) null;

    [Token(Token = "0x6010BE9")]
    [Address(RVA = "0x4BDB288", Offset = "0x4BDB288", VA = "0x4BDB288")]
    private IEnumerator WaitOptionPendingConfirmPopup() => (IEnumerator) null;

    [Token(Token = "0x6010BEA")]
    [Address(RVA = "0x4BDB318", Offset = "0x4BDB318", VA = "0x4BDB318")]
    private IEnumerator OpenWeaponOptionChange(PlayerWeaponOptionChangePending pending)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010BEB")]
    [Address(RVA = "0x4BDB3B4", Offset = "0x4BDB3B4", VA = "0x4BDB3B4")]
    private IEnumerator OpenAccessoryOptionChange(PlayerAccessoriesOptionChangePending pending)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010BEC")]
    [Address(RVA = "0x4BDB450", Offset = "0x4BDB450", VA = "0x4BDB450")]
    private void TransitionBattle(APIBattleResumeResponse response, BoardData boardData)
    {
    }

    [Token(Token = "0x6010BED")]
    [Address(RVA = "0x4BDB650", Offset = "0x4BDB650", VA = "0x4BDB650")]
    private void OnAwayFromHome()
    {
    }

    [Token(Token = "0x6010BEE")]
    [Address(RVA = "0x4BDB630", Offset = "0x4BDB630", VA = "0x4BDB630")]
    private DeckTypeEnum ConvertDeckSlotToDeckTypeEnum(int slotNum) => new DeckTypeEnum();
  }
}
