// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ProceedCondition.SubQuestReceiptProceedCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.ProceedCondition
{
  [Token(Token = "0x2001619")]
  public class SubQuestReceiptProceedCondition : IFreeMapProceedCondition
  {
    [Token(Token = "0x4006498")]
    [FieldOffset(Offset = "0x10")]
    private int subquestID;

    [Token(Token = "0x6007D3D")]
    [Address(RVA = "0x21A7508", Offset = "0x21A7508", VA = "0x21A7508")]
    public SubQuestReceiptProceedCondition(int subquestID)
    {
    }

    [Token(Token = "0x6007D3E")]
    [Address(RVA = "0x21A7530", Offset = "0x21A7530", VA = "0x21A7530", Slot = "4")]
    public bool CanProceed() => new bool();

    [Token(Token = "0x6007D3F")]
    [Address(RVA = "0x21A754C", Offset = "0x21A754C", VA = "0x21A754C", Slot = "5")]
    public bool CanProceed(out IFreeMapCannotProceedReason reason) => new bool();
  }
}
