// Decompiled with JetBrains decompiler
// Type: Story.KizunaQuest.KizunaQuestRewardInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Story.KizunaQuest
{
  [Token(Token = "0x2000693")]
  public class KizunaQuestRewardInfo : MonoBehaviour
  {
    [Token(Token = "0x4001F93")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private KizunaQuestRewardInfo.RankUpInfo rankUpInfo;
    [Token(Token = "0x4001F94")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private KizunaQuestRewardInfo.RankUpRewardInfo rankUpRewardInfo;

    [Token(Token = "0x6002575")]
    [Address(RVA = "0x2F36404", Offset = "0x2F36404", VA = "0x2F36404")]
    public void Set(Communication commuData, GameObject iconPrefab, AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6002576")]
    [Address(RVA = "0x2F3B39C", Offset = "0x2F3B39C", VA = "0x2F3B39C")]
    public KizunaQuestRewardInfo()
    {
    }

    [Token(Token = "0x2000694")]
    [Serializable]
    public class RankUpInfo
    {
      [Token(Token = "0x4001F95")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private Text beforeRankTxt;
      [Token(Token = "0x4001F96")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private GameObject afterRankGroupObj;
      [Token(Token = "0x4001F97")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private Text afterRankTxt;
      [Token(Token = "0x4001F98")]
      [FieldOffset(Offset = "0x28")]
      [SerializeField]
      private Slider rankGaugeSlider;
      [Token(Token = "0x4001F99")]
      [FieldOffset(Offset = "0x30")]
      [SerializeField]
      private GameObject rankupDescriptionInfo;
      [Token(Token = "0x4001F9A")]
      [FieldOffset(Offset = "0x38")]
      [SerializeField]
      private TextMeshProUGUI rankupDescription;
      [Token(Token = "0x4001F9B")]
      [FieldOffset(Offset = "0x40")]
      [SerializeField]
      private GameObject canRankupGo;

      [Token(Token = "0x6002577")]
      [Address(RVA = "0x2F3A60C", Offset = "0x2F3A60C", VA = "0x2F3A60C")]
      public void Set(Communication commuData)
      {
      }

      [Token(Token = "0x6002578")]
      [Address(RVA = "0x2F3B3A4", Offset = "0x2F3B3A4", VA = "0x2F3B3A4")]
      public RankUpInfo()
      {
      }
    }

    [Token(Token = "0x2000695")]
    [Serializable]
    public class RankUpRewardInfo
    {
      [Token(Token = "0x4001F9C")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private RectTransform itemIconParent;
      [Token(Token = "0x4001F9D")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private GameObject nothingObj;
      [Token(Token = "0x4001F9E")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private GameObject skillInfoLayout;
      [Token(Token = "0x4001F9F")]
      [FieldOffset(Offset = "0x28")]
      [SerializeField]
      private GameObject abilityInfoLayout;
      [Token(Token = "0x4001FA0")]
      [FieldOffset(Offset = "0x30")]
      [SerializeField]
      private GameObject skillInfoCloneOrigin;
      [Token(Token = "0x4001FA1")]
      [FieldOffset(Offset = "0x38")]
      [SerializeField]
      private GameObject abilityInfoCloneOrigin;

      [Token(Token = "0x6002579")]
      [Address(RVA = "0x2F3A78C", Offset = "0x2F3A78C", VA = "0x2F3A78C")]
      public void Set(Communication commuData, GameObject iconPrefab, AssetCachedSpawner spawner)
      {
      }

      [Token(Token = "0x600257A")]
      [Address(RVA = "0x2F3B3AC", Offset = "0x2F3B3AC", VA = "0x2F3B3AC")]
      public RankUpRewardInfo()
      {
      }
    }
  }
}
