// Decompiled with JetBrains decompiler
// Type: StaqData.Parameters.Element
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace StaqData.Parameters
{
  [Token(Token = "0x20021B2")]
  public class Element
  {
    [Token(Token = "0x4008ED3")]
    [FieldOffset(Offset = "0x18")]
    public int NumericInt;
    [Token(Token = "0x4008ED4")]
    [FieldOffset(Offset = "0x1C")]
    public float NumericFloat;
    [Token(Token = "0x4008ED5")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Element.DefaultElement Default;

    [Token(Token = "0x17002CE8")]
    public string Name
    {
      [Token(Token = "0x600CDE0"), Address(RVA = "0x4B600E8", Offset = "0x4B600E8", VA = "0x4B600E8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600CDE1"), Address(RVA = "0x4B600F0", Offset = "0x4B600F0", VA = "0x4B600F0")] protected set
      {
      }
    }

    [Token(Token = "0x600CDE2")]
    [Address(RVA = "0x4B600F8", Offset = "0x4B600F8", VA = "0x4B600F8")]
    public Element()
    {
    }

    [Token(Token = "0x600CDE3")]
    [Address(RVA = "0x4B60150", Offset = "0x4B60150", VA = "0x4B60150")]
    static Element()
    {
    }

    [Token(Token = "0x20021B3")]
    public class DefaultElement : Element
    {
      [Token(Token = "0x600CDE4")]
      [Address(RVA = "0x4B601C4", Offset = "0x4B601C4", VA = "0x4B601C4")]
      public DefaultElement()
      {
      }
    }
  }
}
