// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ProceedCondition.FreeMapCannotProceedReason
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.ProceedCondition
{
  [Token(Token = "0x200161E")]
  public class FreeMapCannotProceedReason : IFreeMapCannotProceedReason
  {
    [Token(Token = "0x17001359")]
    public string Text
    {
      [Token(Token = "0x6007D4B"), Address(RVA = "0x21A7E98", Offset = "0x21A7E98", VA = "0x21A7E98", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007D4C")]
    [Address(RVA = "0x21A7EA0", Offset = "0x21A7EA0", VA = "0x21A7EA0")]
    private FreeMapCannotProceedReason(string text)
    {
    }

    [Token(Token = "0x6007D4D")]
    [Address(RVA = "0x21A762C", Offset = "0x21A762C", VA = "0x21A762C")]
    public static IFreeMapCannotProceedReason Cannot() => (IFreeMapCannotProceedReason) null;

    [Token(Token = "0x6007D4E")]
    [Address(RVA = "0x21A7CEC", Offset = "0x21A7CEC", VA = "0x21A7CEC")]
    public static IFreeMapCannotProceedReason NotFound() => (IFreeMapCannotProceedReason) null;

    [Token(Token = "0x6007D4F")]
    [Address(RVA = "0x21A7AB8", Offset = "0x21A7AB8", VA = "0x21A7AB8")]
    public static IFreeMapCannotProceedReason TermExpired() => (IFreeMapCannotProceedReason) null;

    [Token(Token = "0x6007D50")]
    [Address(RVA = "0x21A7C80", Offset = "0x21A7C80", VA = "0x21A7C80")]
    public static IFreeMapCannotProceedReason NotInTime() => (IFreeMapCannotProceedReason) null;

    [Token(Token = "0x6007D51")]
    [Address(RVA = "0x21A7F0C", Offset = "0x21A7F0C", VA = "0x21A7F0C")]
    public static IFreeMapCannotProceedReason LimitFullness() => (IFreeMapCannotProceedReason) null;
  }
}
