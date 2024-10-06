// Decompiled with JetBrains decompiler
// Type: TeamOrganization.EquipSetSkillSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using TMPro;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007CF")]
  public class EquipSetSkillSlot : MonoBehaviour
  {
    [Token(Token = "0x4002476")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI skillLevelText;
    [Token(Token = "0x4002477")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI skillTitleText;

    [Token(Token = "0x6002C28")]
    [Address(RVA = "0x3878BC0", Offset = "0x3878BC0", VA = "0x3878BC0")]
    public void UpdateSkillView(string skillLevel, string skillName)
    {
    }

    [Token(Token = "0x6002C29")]
    [Address(RVA = "0x3878C10", Offset = "0x3878C10", VA = "0x3878C10")]
    public EquipSetSkillSlot()
    {
    }
  }
}
