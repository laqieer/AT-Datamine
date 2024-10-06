// Decompiled with JetBrains decompiler
// Type: TeamOrganization.OrganizationCustomSkillSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007DF")]
  public class OrganizationCustomSkillSlot
  {
    [Token(Token = "0x17000692")]
    public CustomSkill CustomSkill
    {
      [Token(Token = "0x6002C80"), Address(RVA = "0x387EE08", Offset = "0x387EE08", VA = "0x387EE08")] get
      {
        return (CustomSkill) null;
      }
      [Token(Token = "0x6002C81"), Address(RVA = "0x387EE10", Offset = "0x387EE10", VA = "0x387EE10")] private set
      {
      }
    }

    [Token(Token = "0x6002C82")]
    [Address(RVA = "0x387EE18", Offset = "0x387EE18", VA = "0x387EE18")]
    public OrganizationCustomSkillSlot(CustomSkill customSkill)
    {
    }

    [Token(Token = "0x6002C83")]
    [Address(RVA = "0x387EE40", Offset = "0x387EE40", VA = "0x387EE40")]
    public void UnEquipment()
    {
    }

    [Token(Token = "0x6002C84")]
    [Address(RVA = "0x387EE48", Offset = "0x387EE48", VA = "0x387EE48")]
    public void SetCustomSkill(CustomSkill customSkill)
    {
    }

    [Token(Token = "0x17000693")]
    public bool IsEmpty
    {
      [Token(Token = "0x6002C85"), Address(RVA = "0x386BEA0", Offset = "0x386BEA0", VA = "0x386BEA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6002C86")]
    [Address(RVA = "0x387EE50", Offset = "0x387EE50", VA = "0x387EE50")]
    public bool CheckAttention(OrganizationCustomSkillSlot checkSlot) => new bool();
  }
}
