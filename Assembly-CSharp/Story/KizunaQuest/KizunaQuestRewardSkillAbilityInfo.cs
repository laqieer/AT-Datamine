// Decompiled with JetBrains decompiler
// Type: Story.KizunaQuest.KizunaQuestRewardSkillAbilityInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Story.KizunaQuest
{
  [Token(Token = "0x2000696")]
  public class KizunaQuestRewardSkillAbilityInfo : MonoBehaviour
  {
    [Token(Token = "0x4001FA2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject abilityParant;
    [Token(Token = "0x4001FA3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI abilityText;
    [Token(Token = "0x4001FA4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject skillParent;
    [Token(Token = "0x4001FA5")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject skillThumbParent;
    [Token(Token = "0x4001FA6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject skillThumb;
    [Token(Token = "0x4001FA7")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text skillLevelText;
    [Token(Token = "0x4001FA8")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI skillNameText;

    [Token(Token = "0x600257B")]
    [Address(RVA = "0x2F3A0F4", Offset = "0x2F3A0F4", VA = "0x2F3A0F4")]
    public void InitAbility(StoryAbilityData data)
    {
    }

    [Token(Token = "0x600257C")]
    [Address(RVA = "0x2F3B3B4", Offset = "0x2F3B3B4", VA = "0x2F3B3B4")]
    public void LoadCommuSkillImage(
      CommunicationSkillData data,
      AssetCachedSpawner spawner,
      bool isStartRequest = true)
    {
    }

    [Token(Token = "0x600257D")]
    [Address(RVA = "0x2F3A168", Offset = "0x2F3A168", VA = "0x2F3A168")]
    public void InitCommuSkill(
      CommunicationSkillData data,
      AssetCachedSpawner spawner,
      int level,
      bool isStartRequest = true)
    {
    }

    [Token(Token = "0x600257E")]
    [Address(RVA = "0x2F3B450", Offset = "0x2F3B450", VA = "0x2F3B450")]
    public KizunaQuestRewardSkillAbilityInfo()
    {
    }
  }
}
