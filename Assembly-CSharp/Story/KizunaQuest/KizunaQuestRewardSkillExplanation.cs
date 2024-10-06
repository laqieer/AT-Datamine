// Decompiled with JetBrains decompiler
// Type: Story.KizunaQuest.KizunaQuestRewardSkillExplanation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace Story.KizunaQuest
{
  [Token(Token = "0x2000697")]
  internal class KizunaQuestRewardSkillExplanation : MonoBehaviour
  {
    [Token(Token = "0x4001FA9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject BeforeInfo;
    [Token(Token = "0x4001FAA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI BeforeExplanation;
    [Token(Token = "0x4001FAB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI AfterExplanation;
    [Token(Token = "0x4001FAC")]
    public const string SkillExplanationAssetName = "Parts_SkillExplanation";

    [Token(Token = "0x600257F")]
    [Address(RVA = "0x2F3A2FC", Offset = "0x2F3A2FC", VA = "0x2F3A2FC")]
    public void InitCommuSkill(CommunicationSkillData data, int level)
    {
    }

    [Token(Token = "0x6002580")]
    [Address(RVA = "0x2F3B458", Offset = "0x2F3B458", VA = "0x2F3B458")]
    public KizunaQuestRewardSkillExplanation()
    {
    }
  }
}
