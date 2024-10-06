// Decompiled with JetBrains decompiler
// Type: Story.KizunaQuest.KizunaQuestRankupInfoListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Story.KizunaQuest
{
  [Token(Token = "0x2000691")]
  public class KizunaQuestRankupInfoListItem : MonoBehaviour
  {
    [Token(Token = "0x4001F85")]
    [FieldOffset(Offset = "0x18")]
    private readonly Dictionary<int, string> tweenMap;
    [Token(Token = "0x4001F86")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4001F87")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RectTransform itemIconParent;
    [Token(Token = "0x4001F88")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text rankNumTxt;
    [Token(Token = "0x4001F89")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject skillInfoLayout;
    [Token(Token = "0x4001F8A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject abilityInfoLayout;
    [Token(Token = "0x4001F8B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject skillInfoCloneOrigin;
    [Token(Token = "0x4001F8C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject abilityInfoCloneOrigin;
    [Token(Token = "0x4001F8D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject rewardReceivedCover;

    [Token(Token = "0x6002572")]
    [Address(RVA = "0x2F39500", Offset = "0x2F39500", VA = "0x2F39500")]
    public void PlayAnim(
      KizunaQuestRankupInfoListItem.TweenKeyType tweenKey)
    {
    }

    [Token(Token = "0x6002573")]
    [Address(RVA = "0x2F3957C", Offset = "0x2F3957C", VA = "0x2F3957C")]
    public void SetData(
      bool isFirstReward,
      int rank,
      IReadOnlyCollection<StoryCommunicationRewardSetData> rewardDatas,
      bool isReceived,
      GameObject iconPrefab,
      CommuSkillTempLevelContainer commuSkillTempLv,
      AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6002574")]
    [Address(RVA = "0x2F3A4CC", Offset = "0x2F3A4CC", VA = "0x2F3A4CC")]
    public KizunaQuestRankupInfoListItem()
    {
    }

    [Token(Token = "0x2000692")]
    public enum TweenKeyType
    {
      [Token(Token = "0x4001F8F")] Normal,
      [Token(Token = "0x4001F90")] Second,
      [Token(Token = "0x4001F91")] LongLine,
      [Token(Token = "0x4001F92")] HalfLine,
    }
  }
}
