// Decompiled with JetBrains decompiler
// Type: TeamOrganization.PartySlotAttentionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007FC")]
  public class PartySlotAttentionData
  {
    [Token(Token = "0x170006D4")]
    public bool AttentionStyle
    {
      [Token(Token = "0x6002DA8"), Address(RVA = "0x3A89D3C", Offset = "0x3A89D3C", VA = "0x3A89D3C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002DA9"), Address(RVA = "0x3A89D44", Offset = "0x3A89D44", VA = "0x3A89D44")] private set
      {
      }
    }

    [Token(Token = "0x170006D5")]
    public bool[] AttentionEquips
    {
      [Token(Token = "0x6002DAA"), Address(RVA = "0x3A89D50", Offset = "0x3A89D50", VA = "0x3A89D50")] get
      {
        return (bool[]) null;
      }
      [Token(Token = "0x6002DAB"), Address(RVA = "0x3A89D58", Offset = "0x3A89D58", VA = "0x3A89D58")] private set
      {
      }
    }

    [Token(Token = "0x170006D6")]
    public bool[] AttentionCustomSkills
    {
      [Token(Token = "0x6002DAC"), Address(RVA = "0x3A89D60", Offset = "0x3A89D60", VA = "0x3A89D60")] get
      {
        return (bool[]) null;
      }
      [Token(Token = "0x6002DAD"), Address(RVA = "0x3A89D68", Offset = "0x3A89D68", VA = "0x3A89D68")] private set
      {
      }
    }

    [Token(Token = "0x6002DAE")]
    [Address(RVA = "0x3A858EC", Offset = "0x3A858EC", VA = "0x3A858EC")]
    public PartySlotAttentionData()
    {
    }

    [Token(Token = "0x6002DAF")]
    [Address(RVA = "0x3A89D70", Offset = "0x3A89D70", VA = "0x3A89D70")]
    public bool GetAttentionEquip() => new bool();

    [Token(Token = "0x6002DB0")]
    [Address(RVA = "0x3A89DC8", Offset = "0x3A89DC8", VA = "0x3A89DC8")]
    public void SetStyle(bool flag)
    {
    }

    [Token(Token = "0x6002DB1")]
    [Address(RVA = "0x3A89DD8", Offset = "0x3A89DD8", VA = "0x3A89DD8")]
    public void SetEquip(int index, bool flag)
    {
    }

    [Token(Token = "0x6002DB2")]
    [Address(RVA = "0x3A89E10", Offset = "0x3A89E10", VA = "0x3A89E10")]
    public void SetCustomSkill(int index, bool flag)
    {
    }

    [Token(Token = "0x6002DB3")]
    [Address(RVA = "0x3A89E48", Offset = "0x3A89E48", VA = "0x3A89E48")]
    public bool IsAttentionAny() => new bool();
  }
}
