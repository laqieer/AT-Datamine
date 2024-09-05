// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestMissionRewardContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003233")]
  internal class QuestMissionRewardContent : MonoBehaviour
  {
    [Token(Token = "0x400D674")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject clearIcon;
    [Token(Token = "0x400D675")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text missionName;
    [Token(Token = "0x400D676")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text itemName;
    [Token(Token = "0x400D677")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text itemNum;
    [Token(Token = "0x400D678")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ItemIcon itemIcon;

    [Token(Token = "0x6013934")]
    [Address(RVA = "0x460C904", Offset = "0x460C904", VA = "0x460C904")]
    public void SetMissionReward(
      AssetCachedSpawner assetCachedSpawner,
      BattleMissionData mission,
      ItemDetailPopupProvider itemDetailPopupGenerator,
      bool isClear)
    {
    }

    [Token(Token = "0x6013935")]
    [Address(RVA = "0x460CE48", Offset = "0x460CE48", VA = "0x460CE48")]
    public QuestMissionRewardContent()
    {
    }
  }
}
