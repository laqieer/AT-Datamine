// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Utils.NumString.G_FloatString
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Tayx.Graphy.Utils.NumString
{
  [Token(Token = "0x2000392")]
  public static class G_FloatString
  {
    [Token(Token = "0x400150B")]
    private const string floatFormat = "0.0";
    [Token(Token = "0x400150C")]
    [FieldOffset(Offset = "0x0")]
    private static float decimalMultiplier;
    [Token(Token = "0x400150D")]
    [FieldOffset(Offset = "0x8")]
    private static string[] negativeBuffer;
    [Token(Token = "0x400150E")]
    [FieldOffset(Offset = "0x10")]
    private static string[] positiveBuffer;

    [Token(Token = "0x1700021B")]
    public static bool Inited
    {
      [Token(Token = "0x600147D"), Address(RVA = "0x2528FFC", Offset = "0x2528FFC", VA = "0x2528FFC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700021C")]
    public static float MinValue
    {
      [Token(Token = "0x600147E"), Address(RVA = "0x2529094", Offset = "0x2529094", VA = "0x2529094")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700021D")]
    public static float MaxValue
    {
      [Token(Token = "0x600147F"), Address(RVA = "0x2529168", Offset = "0x2529168", VA = "0x2529168")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x6001480")]
    [Address(RVA = "0x25291D0", Offset = "0x25291D0", VA = "0x25291D0")]
    public static void Init(float minNegativeValue, float maxPositiveValue, int decimals = 1)
    {
    }

    [Token(Token = "0x6001481")]
    [Address(RVA = "0x2529564", Offset = "0x2529564", VA = "0x2529564")]
    public static string ToStringNonAlloc(this float value) => (string) null;

    [Token(Token = "0x6001482")]
    [Address(RVA = "0x25296A4", Offset = "0x25296A4", VA = "0x25296A4")]
    public static string ToStringNonAlloc(this float value, string format) => (string) null;

    [Token(Token = "0x6001483")]
    [Address(RVA = "0x25297E4", Offset = "0x25297E4", VA = "0x25297E4")]
    public static int ToInt(this float f) => new int();

    [Token(Token = "0x6001484")]
    [Address(RVA = "0x2529800", Offset = "0x2529800", VA = "0x2529800")]
    public static float ToFloat(this int i) => new float();

    [Token(Token = "0x6001485")]
    [Address(RVA = "0x2529488", Offset = "0x2529488", VA = "0x2529488")]
    private static int Pow(int f, int p) => new int();

    [Token(Token = "0x6001486")]
    [Address(RVA = "0x25294A4", Offset = "0x25294A4", VA = "0x25294A4")]
    private static int ToIndex(this float f) => new int();

    [Token(Token = "0x6001487")]
    [Address(RVA = "0x2529104", Offset = "0x2529104", VA = "0x2529104")]
    private static float FromIndex(this int i) => new float();

    [Token(Token = "0x6001488")]
    [Address(RVA = "0x2529808", Offset = "0x2529808", VA = "0x2529808")]
    static G_FloatString()
    {
    }
  }
}
