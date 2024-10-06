// Decompiled with JetBrains decompiler
// Type: TeamOrganization.OrganizationItemSetSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x200078A")]
  public class OrganizationItemSetSlot
  {
    [Token(Token = "0x40022C3")]
    private const int ItemLimit = 15;

    [Token(Token = "0x17000654")]
    public Expendable Expendable
    {
      [Token(Token = "0x6002A46"), Address(RVA = "0x3500770", Offset = "0x3500770", VA = "0x3500770")] get
      {
        return (Expendable) null;
      }
      [Token(Token = "0x6002A47"), Address(RVA = "0x3500778", Offset = "0x3500778", VA = "0x3500778")] private set
      {
      }
    }

    [Token(Token = "0x17000655")]
    public bool IsEmpty
    {
      [Token(Token = "0x6002A48"), Address(RVA = "0x3500528", Offset = "0x3500528", VA = "0x3500528")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000656")]
    public int Index
    {
      [Token(Token = "0x6002A49"), Address(RVA = "0x3500780", Offset = "0x3500780", VA = "0x3500780")] get
      {
        return new int();
      }
      [Token(Token = "0x6002A4A"), Address(RVA = "0x3500788", Offset = "0x3500788", VA = "0x3500788")] set
      {
      }
    }

    [Token(Token = "0x6002A4B")]
    [Address(RVA = "0x35002B0", Offset = "0x35002B0", VA = "0x35002B0")]
    public OrganizationItemSetSlot(Expendable expendable, int index)
    {
    }

    [Token(Token = "0x6002A4C")]
    [Address(RVA = "0x35002E0", Offset = "0x35002E0", VA = "0x35002E0")]
    public OrganizationItemSetSlot(int index)
    {
    }

    [Token(Token = "0x6002A4D")]
    [Address(RVA = "0x35006C4", Offset = "0x35006C4", VA = "0x35006C4")]
    public void UnExpendable()
    {
    }

    [Token(Token = "0x6002A4E")]
    [Address(RVA = "0x35006BC", Offset = "0x35006BC", VA = "0x35006BC")]
    public void SetEquipment(Expendable expendable)
    {
    }

    [Token(Token = "0x6002A4F")]
    [Address(RVA = "0x35006CC", Offset = "0x35006CC", VA = "0x35006CC")]
    public bool CheckDifference(Expendable expendable) => new bool();
  }
}
