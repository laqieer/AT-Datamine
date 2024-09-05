// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ProceedCondition.SubQuestAutoMoveProceedCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace FreeMap.UI.ProceedCondition
{
  [Token(Token = "0x200161B")]
  public class SubQuestAutoMoveProceedCondition : IFreeMapProceedCondition
  {
    [Token(Token = "0x400649A")]
    [FieldOffset(Offset = "0x10")]
    private SubQuestData subquest;
    [Token(Token = "0x400649B")]
    [FieldOffset(Offset = "0x18")]
    private SubQuestReceiptProceedCondition receiptCondition;
    [Token(Token = "0x400649C")]
    [FieldOffset(Offset = "0x20")]
    private SubQuestTaskProceedCondition taskCondition;

    [Token(Token = "0x6007D45")]
    [Address(RVA = "0x21A7D58", Offset = "0x21A7D58", VA = "0x21A7D58")]
    public SubQuestAutoMoveProceedCondition(SubQuestData subquest)
    {
    }

    [Token(Token = "0x6007D46")]
    [Address(RVA = "0x21A7E14", Offset = "0x21A7E14", VA = "0x21A7E14", Slot = "4")]
    public bool CanProceed() => new bool();

    [Token(Token = "0x6007D47")]
    [Address(RVA = "0x21A7E30", Offset = "0x21A7E30", VA = "0x21A7E30", Slot = "5")]
    public bool CanProceed(out IFreeMapCannotProceedReason reason) => new bool();
  }
}
