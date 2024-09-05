// Decompiled with JetBrains decompiler
// Type: TeamOrganization.CustomSkillSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007A9")]
  public class CustomSkillSlot : MonoBehaviour
  {
    [Token(Token = "0x40023B0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CustomSkillSlotUI slotUI;
    [Token(Token = "0x40023B1")]
    [FieldOffset(Offset = "0x20")]
    private OrganizationCustomSkillSlot customSkill;

    [Token(Token = "0x6002B36")]
    [Address(RVA = "0x386BE74", Offset = "0x386BE74", VA = "0x386BE74")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6002B37")]
    [Address(RVA = "0x386BE78", Offset = "0x386BE78", VA = "0x386BE78")]
    public void UpdateView(OrganizationCustomSkillSlot organizationEquipment)
    {
    }

    [Token(Token = "0x6002B38")]
    [Address(RVA = "0x386BEB0", Offset = "0x386BEB0", VA = "0x386BEB0")]
    public void Empty()
    {
    }

    [Token(Token = "0x6002B39")]
    [Address(RVA = "0x386BF58", Offset = "0x386BF58", VA = "0x386BF58")]
    public void Default()
    {
    }

    [Token(Token = "0x6002B3A")]
    [Address(RVA = "0x386C190", Offset = "0x386C190", VA = "0x386C190")]
    public void UpdateAttentionIcon(bool isAttention)
    {
    }

    [Token(Token = "0x6002B3B")]
    [Address(RVA = "0x386C1B8", Offset = "0x386C1B8", VA = "0x386C1B8")]
    public bool CheckAttention(CustomSkillSlot checkSlot) => new bool();

    [Token(Token = "0x6002B3C")]
    [Address(RVA = "0x386C268", Offset = "0x386C268", VA = "0x386C268")]
    public CustomSkillSlot()
    {
    }
  }
}
