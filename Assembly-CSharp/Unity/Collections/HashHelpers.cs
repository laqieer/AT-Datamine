// Decompiled with JetBrains decompiler
// Type: Unity.Collections.HashHelpers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Runtime.ConstrainedExecution;

#nullable disable
namespace Unity.Collections
{
  [Token(Token = "0x20019A7")]
  public static class HashHelpers
  {
    [Token(Token = "0x4006E24")]
    public const int HashPrime = 101;
    [Token(Token = "0x4006E25")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int[] primes;
    [Token(Token = "0x4006E26")]
    public const int MaxPrimeArrayLength = 2146435069;

    [Token(Token = "0x6009260")]
    [Address(RVA = "0x4D103DC", Offset = "0x4D103DC", VA = "0x4D103DC")]
    [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
    public static bool IsPrime(int candidate) => new bool();

    [Token(Token = "0x6009261")]
    [Address(RVA = "0x4D1048C", Offset = "0x4D1048C", VA = "0x4D1048C")]
    [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
    public static int GetPrime(int min) => new int();

    [Token(Token = "0x6009262")]
    [Address(RVA = "0x4D1060C", Offset = "0x4D1060C", VA = "0x4D1060C")]
    public static int GetMinPrime() => new int();

    [Token(Token = "0x6009263")]
    [Address(RVA = "0x4D1067C", Offset = "0x4D1067C", VA = "0x4D1067C")]
    public static int ExpandPrime(int oldSize) => new int();

    [Token(Token = "0x6009264")]
    [Address(RVA = "0x4D10700", Offset = "0x4D10700", VA = "0x4D10700")]
    static HashHelpers()
    {
    }
  }
}
