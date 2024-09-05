// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustPlayStorePurchase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x2003FF4")]
  public class AdjustPlayStorePurchase
  {
    [Token(Token = "0x4011876")]
    [FieldOffset(Offset = "0x10")]
    internal string productId;
    [Token(Token = "0x4011877")]
    [FieldOffset(Offset = "0x18")]
    internal string purchaseToken;

    [Token(Token = "0x6019C25")]
    [Address(RVA = "0x3B3A4E0", Offset = "0x3B3A4E0", VA = "0x3B3A4E0")]
    public AdjustPlayStorePurchase(string productId, string purchaseToken)
    {
    }
  }
}
