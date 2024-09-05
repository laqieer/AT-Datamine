// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaEventQuest.CumulativeMissionCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.OutGameMenu;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.AreaEventQuest
{
  [Token(Token = "0x200392A")]
  internal class CumulativeMissionCell : MonoBehaviour
  {
    [Token(Token = "0x400F9DA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400F9DB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private StyleThumb styleThumb;
    [Token(Token = "0x400F9DC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private MnemnographThumb mnemnographThumb;
    [Token(Token = "0x400F9DD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI achievementCountText;
    [Token(Token = "0x400F9DE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI rewardAmountText;
    [Token(Token = "0x400F9DF")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image stampImage;
    [Token(Token = "0x400F9E0")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject achievementMask;

    [Token(Token = "0x601678E")]
    [Address(RVA = "0x42E51A0", Offset = "0x42E51A0", VA = "0x42E51A0")]
    public void UpdateRewardCell(
      TotalMissionDetailData detailData,
      TotalMissionTabType tabType,
      SpriteAtlas spriteAtlas,
      AssetCachedSpawner assetCachedSpawner,
      Action<RewardTypeEnum, int> openItemDetailAction)
    {
    }

    [Token(Token = "0x601678F")]
    [Address(RVA = "0x42E52EC", Offset = "0x42E52EC", VA = "0x42E52EC")]
    private void UpdateRewardIcon(
      TotalMissionRewardDetailData reward,
      AssetCachedSpawner assetCachedSpawner,
      Action<RewardTypeEnum, int> openItemDtetailAcion)
    {
    }

    [Token(Token = "0x6016790")]
    [Address(RVA = "0x42E56BC", Offset = "0x42E56BC", VA = "0x42E56BC")]
    private void SetStamp(
      TotalMissionDetailData detailData,
      TotalMissionTabType tabType,
      SpriteAtlas spriteAtlas)
    {
    }

    [Token(Token = "0x6016791")]
    [Address(RVA = "0x42E588C", Offset = "0x42E588C", VA = "0x42E588C")]
    public CumulativeMissionCell()
    {
    }
  }
}
