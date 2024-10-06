// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDMissionPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Network;
using Network.API;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x2001985")]
  public class FgGIDMissionPopup : MonoBehaviour
  {
    [Token(Token = "0x4006DAE")]
    private const string FgGShopURL = "https://shop.fg-games.co.jp/";
    [Token(Token = "0x4006DAF")]
    private const string ResourcePath = "UI/Common/Prefab/FgGID_Mission_Popup";
    [Token(Token = "0x4006DB0")]
    private const string CoinDetailPopupResourcePath = "UI/Common/Prefab/FgGID_CoinDetails_Popup";
    [Token(Token = "0x4006DB1")]
    private const string GetRewardPopupResourcePath = "UI/Common/Prefab/FgGID_GetReward_Popup";
    [Token(Token = "0x4006DB2")]
    [FieldOffset(Offset = "0x18")]
    [Header("FgGコインの簡易表示")]
    [SerializeField]
    private FgGIDSimpleCoinView simpleCoinView;
    [Token(Token = "0x4006DB3")]
    [FieldOffset(Offset = "0x20")]
    [Header("アプリアイコンのリスト表示用")]
    [SerializeField]
    private FgGIDMissionAppIconListView appIconListView;
    [Token(Token = "0x4006DB4")]
    [FieldOffset(Offset = "0x28")]
    [Header("ミッションのリスト表示用")]
    [SerializeField]
    private FgGIDMissionListView missionListView;
    [Token(Token = "0x4006DB5")]
    [FieldOffset(Offset = "0x30")]
    private FgGIDMissionDataManager manager;
    [Token(Token = "0x4006DB6")]
    [FieldOffset(Offset = "0x38")]
    private FgGIDMissionLoader loader;

    [Token(Token = "0x60091B8")]
    [Address(RVA = "0x4D0BF84", Offset = "0x4D0BF84", VA = "0x4D0BF84")]
    public static IEnumerator Create(Transform parent, Action<CommonPopup> onCreate)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60091B9")]
    public static IEnumerator Create<T>(string path, Transform parent, Action<T> onCreate) where T : MonoBehaviour
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60091BA")]
    [Address(RVA = "0x4D0C020", Offset = "0x4D0C020", VA = "0x4D0C020")]
    public void Initialize(Action onSuccess, Action onError)
    {
    }

    [Token(Token = "0x60091BB")]
    [Address(RVA = "0x4D0C0C4", Offset = "0x4D0C0C4", VA = "0x4D0C0C4")]
    private IEnumerator InitializeAsync(Action onSuccess, Action onError) => (IEnumerator) null;

    [Token(Token = "0x60091BC")]
    [Address(RVA = "0x4D0C168", Offset = "0x4D0C168", VA = "0x4D0C168")]
    private void OnSuccess(APIFggfcMissionResponse response, Action onSuccess)
    {
    }

    [Token(Token = "0x60091BD")]
    [Address(RVA = "0x4D0C6F0", Offset = "0x4D0C6F0", VA = "0x4D0C6F0")]
    private IEnumerator OnError(NetworkErrorResult networkErrorResult, Action errorCallback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60091BE")]
    [Address(RVA = "0x4D0C780", Offset = "0x4D0C780", VA = "0x4D0C780")]
    private void OnDetailCoinButtonClicked()
    {
    }

    [Token(Token = "0x60091BF")]
    [Address(RVA = "0x4D0C8B0", Offset = "0x4D0C8B0", VA = "0x4D0C8B0")]
    private void OnFgGIDCoinShopButtonClicked()
    {
    }

    [Token(Token = "0x60091C0")]
    [Address(RVA = "0x4D0C8F4", Offset = "0x4D0C8F4", VA = "0x4D0C8F4")]
    private void OnMissionRewardReceived(List<FgGIDMissionData> receivedMissions)
    {
    }

    [Token(Token = "0x60091C1")]
    [Address(RVA = "0x4D0CA68", Offset = "0x4D0CA68", VA = "0x4D0CA68")]
    public FgGIDMissionPopup()
    {
    }
  }
}
