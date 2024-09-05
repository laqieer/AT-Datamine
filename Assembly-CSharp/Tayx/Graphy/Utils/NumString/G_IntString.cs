// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Utils.NumString.G_IntString
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Tayx.Graphy.Utils.NumString
{
  [Token(Token = "0x2000393")]
  public static class G_IntString
  {
    [Token(Token = "0x400150F")]
    [FieldOffset(Offset = "0x0")]
    private static string[] negativeBuffer;
    [Token(Token = "0x4001510")]
    [FieldOffset(Offset = "0x8")]
    private static string[] positiveBuffer;

    [Token(Token = "0x1700021E")]
    public static bool Inited
    {
      [Token(Token = "0x6001489"), Address(RVA = "0x2529898", Offset = "0x2529898", VA = "0x2529898")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700021F")]
    public static int MinValue
    {
      [Token(Token = "0x600148A"), Address(RVA = "0x2529930", Offset = "0x2529930", VA = "0x2529930")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000220")]
    public static int MaxValue
    {
      [Token(Token = "0x600148B"), Address(RVA = "0x252999C", Offset = "0x252999C", VA = "0x252999C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600148C")]
    [Address(RVA = "0x2529A04", Offset = "0x2529A04", VA = "0x2529A04")]
    public static void Init(int minNegativeValue, int maxPositiveValue)
    {
    }

    [Token(Token = "0x600148D")]
    [Address(RVA = "0x2529C48", Offset = "0x2529C48", VA = "0x2529C48")]
    public static string ToStringNonAlloc(this int value) => (string) null;

    [Token(Token = "0x600148E")]
    [Address(RVA = "0x2529D5C", Offset = "0x2529D5C", VA = "0x2529D5C")]
    static G_IntString()
    {
    }
  }
}
