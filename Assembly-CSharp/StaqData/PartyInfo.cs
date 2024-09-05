// Decompiled with JetBrains decompiler
// Type: StaqData.PartyInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2001FEF")]
  public class PartyInfo
  {
    [Token(Token = "0x4008844")]
    private const int Invalid = -1;

    [Token(Token = "0x17002759")]
    public int SlotNumber
    {
      [Token(Token = "0x600BDF0"), Address(RVA = "0x1FFC9C4", Offset = "0x1FFC9C4", VA = "0x1FFC9C4")] get
      {
        return new int();
      }
      [Token(Token = "0x600BDF1"), Address(RVA = "0x1FFC9CC", Offset = "0x1FFC9CC", VA = "0x1FFC9CC")] private set
      {
      }
    }

    [Token(Token = "0x600BDF2")]
    [Address(RVA = "0x1FFC9D4", Offset = "0x1FFC9D4", VA = "0x1FFC9D4")]
    public void Include(int slot)
    {
    }

    [Token(Token = "0x600BDF3")]
    [Address(RVA = "0x1FFC9DC", Offset = "0x1FFC9DC", VA = "0x1FFC9DC")]
    public void Exclude()
    {
    }

    [Token(Token = "0x600BDF4")]
    [Address(RVA = "0x1FFC9E8", Offset = "0x1FFC9E8", VA = "0x1FFC9E8")]
    public bool IsMember() => new bool();

    [Token(Token = "0x600BDF5")]
    [Address(RVA = "0x1FFC9F8", Offset = "0x1FFC9F8", VA = "0x1FFC9F8")]
    public PartyInfo()
    {
    }
  }
}
