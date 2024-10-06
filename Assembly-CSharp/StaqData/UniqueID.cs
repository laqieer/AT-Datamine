// Decompiled with JetBrains decompiler
// Type: StaqData.UniqueID
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020F9")]
  public struct UniqueID
  {
    [Token(Token = "0x4008BA5")]
    [FieldOffset(Offset = "0x0")]
    public static UniqueID Default;

    [Token(Token = "0x17002B3E")]
    public string ID
    {
      [Token(Token = "0x600C81E"), Address(RVA = "0x1CE1728", Offset = "0x1CE1728", VA = "0x1CE1728")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600C81F"), Address(RVA = "0x1CE1730", Offset = "0x1CE1730", VA = "0x1CE1730")] private set
      {
      }
    }

    [Token(Token = "0x600C820")]
    [Address(RVA = "0x1CE1738", Offset = "0x1CE1738", VA = "0x1CE1738")]
    public UniqueID(object id)
    {
    }

    [Token(Token = "0x600C821")]
    [Address(RVA = "0x1CE17CC", Offset = "0x1CE17CC", VA = "0x1CE17CC")]
    public bool Equal(UniqueID uniqueID) => new bool();

    [Token(Token = "0x600C822")]
    [Address(RVA = "0x1CE1834", Offset = "0x1CE1834", VA = "0x1CE1834", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600C823")]
    [Address(RVA = "0x1CE1888", Offset = "0x1CE1888", VA = "0x1CE1888")]
    public static bool IsDefault(string id) => new bool();

    [Token(Token = "0x600C824")]
    [Address(RVA = "0x1CE18EC", Offset = "0x1CE18EC", VA = "0x1CE18EC")]
    public static bool Valid(object id) => new bool();

    [Token(Token = "0x600C825")]
    [Address(RVA = "0x1CE195C", Offset = "0x1CE195C", VA = "0x1CE195C")]
    public static bool Valid(UniqueID uniqueID) => new bool();

    [Token(Token = "0x600C826")]
    [Address(RVA = "0x1CE19B0", Offset = "0x1CE19B0", VA = "0x1CE19B0")]
    static UniqueID()
    {
    }
  }
}
