// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.FirstClearRewardGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x200321E")]
  internal class FirstClearRewardGroup : MonoBehaviour
  {
    [Token(Token = "0x400D609")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private FirstClearRewardContent firstClearRewardContent;
    [Token(Token = "0x400D60A")]
    [FieldOffset(Offset = "0x20")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400D60B")]
    [FieldOffset(Offset = "0x28")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;

    [Token(Token = "0x60138BF")]
    [Address(RVA = "0x49C4E24", Offset = "0x49C4E24", VA = "0x49C4E24")]
    public void SetFirstClearReward(
      AssetCachedSpawner assetCachedSpawner,
      QuestInfo questInfo,
      ItemDetailPopupProvider itemDetailPopupGenerator)
    {
    }

    [Token(Token = "0x60138C0")]
    [Address(RVA = "0x49C527C", Offset = "0x49C527C", VA = "0x49C527C")]
    public FirstClearRewardGroup()
    {
    }
  }
}
