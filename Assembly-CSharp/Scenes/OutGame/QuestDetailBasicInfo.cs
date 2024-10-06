// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestDetailBasicInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.Story.Common;
using StaqData;
using System.Collections;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x200322B")]
  internal class QuestDetailBasicInfo : MonoBehaviour
  {
    [Token(Token = "0x400D648")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mapName;
    [Token(Token = "0x400D649")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private WeatherIcon weatherIcon;
    [Token(Token = "0x400D64A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text recommendPower;
    [Token(Token = "0x400D64B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ClearConditionGroup clearConditionGroup;
    [Token(Token = "0x400D64C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private FailedConditionGroup failedConditionGroup;
    [Token(Token = "0x400D64D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private FirstClearRewardGroup firstClearRewardGroup;
    [Token(Token = "0x400D64E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private QuestMissionRewardGroup questMissionRewardGroup;
    [Token(Token = "0x400D64F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private QuestClearRewardGroup questClearRewardGroup;
    [Token(Token = "0x400D650")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private DropTreasureGroup dropTreasureGroup;
    [Token(Token = "0x400D651")]
    [FieldOffset(Offset = "0x60")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400D652")]
    [FieldOffset(Offset = "0x68")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;

    [Token(Token = "0x6013916")]
    [Address(RVA = "0x460A9D8", Offset = "0x460A9D8", VA = "0x460A9D8")]
    public IEnumerator SetData(AssetCachedSpawner assetCachedSpawner, QuestInfo questInfo)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6013917")]
    [Address(RVA = "0x460AA7C", Offset = "0x460AA7C", VA = "0x460AA7C")]
    public QuestDetailBasicInfo()
    {
    }
  }
}
