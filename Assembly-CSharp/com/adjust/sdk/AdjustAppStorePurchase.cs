// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustAppStorePurchase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x2003FE9")]
  public class AdjustAppStorePurchase
  {
    [Token(Token = "0x40117FD")]
    [FieldOffset(Offset = "0x10")]
    internal string transactionId;
    [Token(Token = "0x40117FE")]
    [FieldOffset(Offset = "0x18")]
    internal string productId;
    [Token(Token = "0x40117FF")]
    [FieldOffset(Offset = "0x20")]
    internal string receipt;

    [Token(Token = "0x6019BA4")]
    [Address(RVA = "0x379AF78", Offset = "0x379AF78", VA = "0x379AF78")]
    public AdjustAppStorePurchase(string transactionId, string productId, string receipt)
    {
    }
  }
}
