// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Attend.AttendRewardListContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.Guild.Attend
{
  [Token(Token = "0x2002C48")]
  public class AttendRewardListContainer : MonoBehaviour
  {
    [Token(Token = "0x400BCAD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private InfiniteScrollView scrollView;
    [Token(Token = "0x400BCAE")]
    [FieldOffset(Offset = "0x20")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x400BCAF")]
    [FieldOffset(Offset = "0x28")]
    private ItemDetailPopupProvider itemDetailPopupProvider;
    [Token(Token = "0x400BCB0")]
    [FieldOffset(Offset = "0x30")]
    private List<AttendRewardListItem.AttendRewardCellData> listItems;

    [Token(Token = "0x60115AB")]
    [Address(RVA = "0x4E174D8", Offset = "0x4E174D8", VA = "0x4E174D8")]
    public void Set(
      AssetCachedSpawner spawner,
      ItemDetailPopupProvider provider,
      List<(int requiredAttend, List<GuildAttendRewardDescriptionData> rewards)> info)
    {
    }

    [Token(Token = "0x60115AC")]
    [Address(RVA = "0x4E1781C", Offset = "0x4E1781C", VA = "0x4E1781C")]
    private AttendRewardListItem.AttendRewardCellData CreateCellData(
      int requiredAttend,
      List<GuildAttendRewardDescriptionData> rewards)
    {
      return (AttendRewardListItem.AttendRewardCellData) null;
    }

    [Token(Token = "0x60115AD")]
    [Address(RVA = "0x4E17C4C", Offset = "0x4E17C4C", VA = "0x4E17C4C")]
    private void OnClickItem(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x60115AE")]
    [Address(RVA = "0x4E17C90", Offset = "0x4E17C90", VA = "0x4E17C90")]
    private void OpenOtherDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x60115AF")]
    [Address(RVA = "0x4E17794", Offset = "0x4E17794", VA = "0x4E17794")]
    public void Clear()
    {
    }

    [Token(Token = "0x60115B0")]
    [Address(RVA = "0x4E17E10", Offset = "0x4E17E10", VA = "0x4E17E10")]
    public AttendRewardListContainer()
    {
    }
  }
}
