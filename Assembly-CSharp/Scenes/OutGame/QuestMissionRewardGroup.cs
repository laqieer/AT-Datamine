// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestMissionRewardGroup
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
  [Token(Token = "0x2003235")]
  internal class QuestMissionRewardGroup : MonoBehaviour
  {
    [Token(Token = "0x400D67B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private QuestMissionRewardContent questMissionRewardContent;
    [Token(Token = "0x400D67C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject blank;
    [Token(Token = "0x400D67D")]
    [FieldOffset(Offset = "0x28")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400D67E")]
    [FieldOffset(Offset = "0x30")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;

    [Token(Token = "0x6013938")]
    [Address(RVA = "0x460AC88", Offset = "0x460AC88", VA = "0x460AC88")]
    public void SetQuestClearReward(
      AssetCachedSpawner assetCachedSpawner,
      QuestInfo questInfo,
      ItemDetailPopupProvider itemDetailPopupGenerator)
    {
    }

    [Token(Token = "0x6013939")]
    [Address(RVA = "0x460CF88", Offset = "0x460CF88", VA = "0x460CF88")]
    public QuestMissionRewardGroup()
    {
    }
  }
}
