// Decompiled with JetBrains decompiler
// Type: QuestRewardCustomSkillUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20001E9")]
public class QuestRewardCustomSkillUI : MonoBehaviour
{
  [Token(Token = "0x4000AEE")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Text skillName;
  [Token(Token = "0x4000AEF")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private CustomSkillIcon icon;
  [Token(Token = "0x4000AF0")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private AssetCachedSpawner spawner;
  [Token(Token = "0x4000AF1")]
  [FieldOffset(Offset = "0x30")]
  private bool isActivate;

  [Token(Token = "0x170000E5")]
  public CustomSkillIcon Icon
  {
    [Token(Token = "0x6000C2E"), Address(RVA = "0x4C73AD4", Offset = "0x4C73AD4", VA = "0x4C73AD4")] get
    {
      return (CustomSkillIcon) null;
    }
  }

  [Token(Token = "0x6000C2F")]
  [Address(RVA = "0x4C73ADC", Offset = "0x4C73ADC", VA = "0x4C73ADC")]
  public void Show()
  {
  }

  [Token(Token = "0x6000C30")]
  [Address(RVA = "0x4C73B10", Offset = "0x4C73B10", VA = "0x4C73B10")]
  public void Hide()
  {
  }

  [Token(Token = "0x6000C31")]
  [Address(RVA = "0x4C73B34", Offset = "0x4C73B34", VA = "0x4C73B34")]
  public void SetReward(StorySubquestRewardSetData reward)
  {
  }

  [Token(Token = "0x6000C32")]
  [Address(RVA = "0x4C73B70", Offset = "0x4C73B70", VA = "0x4C73B70")]
  public void SetCustomSkill(string name, int customSkillId)
  {
  }

  [Token(Token = "0x6000C33")]
  [Address(RVA = "0x4C73BF4", Offset = "0x4C73BF4", VA = "0x4C73BF4")]
  private IEnumerator CreateIcon(int customSkillId) => (IEnumerator) null;

  [Token(Token = "0x6000C34")]
  [Address(RVA = "0x4C73C94", Offset = "0x4C73C94", VA = "0x4C73C94")]
  public QuestRewardCustomSkillUI()
  {
  }
}
