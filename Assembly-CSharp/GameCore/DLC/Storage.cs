// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.Storage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x20014D6")]
  public class Storage
  {
    [Token(Token = "0x6007587")]
    [Address(RVA = "0x43EF888", Offset = "0x43EF888", VA = "0x43EF888")]
    public static bool IsFreeDiscSpace(long size) => new bool();

    [Token(Token = "0x6007588")]
    [Address(RVA = "0x43E9960", Offset = "0x43E9960", VA = "0x43E9960")]
    public static bool IsFreeMinimumDiscSpace() => new bool();

    [Token(Token = "0x6007589")]
    [Address(RVA = "0x43F51B4", Offset = "0x43F51B4", VA = "0x43F51B4")]
    public static long GetFreeDiscSpace() => new long();

    [Token(Token = "0x600758A")]
    [Address(RVA = "0x43F97D0", Offset = "0x43F97D0", VA = "0x43F97D0")]
    private static long GetFreeSpace() => new long();

    [Token(Token = "0x600758B")]
    [Address(RVA = "0x43F99B8", Offset = "0x43F99B8", VA = "0x43F99B8")]
    public Storage()
    {
    }
  }
}
