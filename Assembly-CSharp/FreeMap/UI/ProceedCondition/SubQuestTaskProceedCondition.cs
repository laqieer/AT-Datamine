// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ProceedCondition.SubQuestTaskProceedCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace FreeMap.UI.ProceedCondition
{
  [Token(Token = "0x200161A")]
  public class SubQuestTaskProceedCondition : IFreeMapProceedCondition
  {
    [Token(Token = "0x4006499")]
    [FieldOffset(Offset = "0x10")]
    private SubQuestData subquest;

    [Token(Token = "0x6007D40")]
    [Address(RVA = "0x21A7698", Offset = "0x21A7698", VA = "0x21A7698")]
    public SubQuestTaskProceedCondition(SubQuestData subquest)
    {
    }

    [Token(Token = "0x6007D41")]
    [Address(RVA = "0x21A76C0", Offset = "0x21A76C0", VA = "0x21A76C0", Slot = "4")]
    public bool CanProceed() => new bool();

    [Token(Token = "0x6007D42")]
    [Address(RVA = "0x21A76DC", Offset = "0x21A76DC", VA = "0x21A76DC", Slot = "5")]
    public bool CanProceed(out IFreeMapCannotProceedReason detail) => new bool();
  }
}
