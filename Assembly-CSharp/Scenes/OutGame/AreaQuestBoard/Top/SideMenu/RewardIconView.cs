// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.SideMenu.RewardIconView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top.SideMenu
{
  [Token(Token = "0x2003902")]
  internal class RewardIconView : MonoBehaviour
  {
    [Token(Token = "0x400F93D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon icon;

    [Token(Token = "0x6016698")]
    [Address(RVA = "0x20833CC", Offset = "0x20833CC", VA = "0x20833CC")]
    public void SetItemIcon(
      BattleRewardDescriptionData data,
      Action<RewardTypeEnum, int> openItemDetailAction,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6016699")]
    [Address(RVA = "0x2083540", Offset = "0x2083540", VA = "0x2083540")]
    public void SetItemIcon(
      StaqData.RewardData data,
      Action<RewardTypeEnum, int> openItemDetailAction,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x601669A")]
    [Address(RVA = "0x20836B4", Offset = "0x20836B4", VA = "0x20836B4")]
    public RewardIconView()
    {
    }
  }
}
