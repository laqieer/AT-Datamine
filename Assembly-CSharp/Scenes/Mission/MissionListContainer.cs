// Decompiled with JetBrains decompiler
// Type: Scenes.Mission.MissionListContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.Mission
{
  [Token(Token = "0x2002A8F")]
  public class MissionListContainer : MonoBehaviour
  {
    [Token(Token = "0x400B51C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject _nothingObj;
    [Token(Token = "0x400B51D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private InfiniteScrollView _scrollView;
    [Token(Token = "0x400B51E")]
    [FieldOffset(Offset = "0x28")]
    public GameObject tran;
    [Token(Token = "0x400B51F")]
    [FieldOffset(Offset = "0x30")]
    private List<MissionListItem.MissionCellData> _missionListItems;
    [Token(Token = "0x400B520")]
    [FieldOffset(Offset = "0x38")]
    private AssetCachedSpawner _assetCachedSpawner;
    [Token(Token = "0x400B521")]
    [FieldOffset(Offset = "0x40")]
    private ItemDetailPopupProvider _itemDetailPopupProvider;
    [Token(Token = "0x400B522")]
    [FieldOffset(Offset = "0x48")]
    private Action<int> _onReceive;

    [Token(Token = "0x6010A84")]
    [Address(RVA = "0x4BCD9A4", Offset = "0x4BCD9A4", VA = "0x4BCD9A4")]
    private void Awake()
    {
    }

    [Token(Token = "0x6010A85")]
    [Address(RVA = "0x4BCD9A8", Offset = "0x4BCD9A8", VA = "0x4BCD9A8")]
    public void Initialize(MissionSubScene subScene, Action<int> onReceive)
    {
    }

    [Token(Token = "0x6010A86")]
    [Address(RVA = "0x4BCD9C8", Offset = "0x4BCD9C8", VA = "0x4BCD9C8")]
    public void Set(List<PlayerMissionProgressType> missionList)
    {
    }

    [Token(Token = "0x6010A87")]
    [Address(RVA = "0x4BCDDA4", Offset = "0x4BCDDA4", VA = "0x4BCDDA4")]
    public void Clear()
    {
    }

    [Token(Token = "0x6010A88")]
    [Address(RVA = "0x4BCDE3C", Offset = "0x4BCDE3C", VA = "0x4BCDE3C")]
    private IEnumerator ResetScrollBar() => (IEnumerator) null;

    [Token(Token = "0x6010A89")]
    [Address(RVA = "0x4BCDECC", Offset = "0x4BCDECC", VA = "0x4BCDECC")]
    private void OnClickItem(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6010A8A")]
    [Address(RVA = "0x4BCDF10", Offset = "0x4BCDF10", VA = "0x4BCDF10")]
    private void OpenOtherDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6010A8B")]
    [Address(RVA = "0x4BCE090", Offset = "0x4BCE090", VA = "0x4BCE090")]
    private void OnReceive(int missionId)
    {
    }

    [Token(Token = "0x6010A8C")]
    [Address(RVA = "0x4BCE0AC", Offset = "0x4BCE0AC", VA = "0x4BCE0AC")]
    public MissionListContainer()
    {
    }
  }
}
