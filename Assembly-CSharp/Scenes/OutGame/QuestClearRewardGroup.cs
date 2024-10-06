// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestClearRewardGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003228")]
  internal class QuestClearRewardGroup : MonoBehaviour
  {
    [Token(Token = "0x400D642")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400D643")]
    [FieldOffset(Offset = "0x20")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400D644")]
    [FieldOffset(Offset = "0x28")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;

    [Token(Token = "0x6013911")]
    [Address(RVA = "0x49CB3F4", Offset = "0x49CB3F4", VA = "0x49CB3F4")]
    public void SetQuestClearReward(
      AssetCachedSpawner assetCachedSpawner,
      QuestInfo questInfo,
      ItemDetailPopupProvider itemDetailPopupGenerator)
    {
    }

    [Token(Token = "0x6013912")]
    [Address(RVA = "0x49CB93C", Offset = "0x49CB93C", VA = "0x49CB93C")]
    public QuestClearRewardGroup()
    {
    }
  }
}
