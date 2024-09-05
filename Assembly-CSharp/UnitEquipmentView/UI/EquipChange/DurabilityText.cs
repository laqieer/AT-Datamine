// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.EquipChange.DurabilityText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitEquipmentView.UI.EquipChange
{
  [Token(Token = "0x2000481")]
  public struct DurabilityText
  {
    [Token(Token = "0x4001847")]
    [FieldOffset(Offset = "0x0")]
    private DurabilityFormatter formatter;
    [Token(Token = "0x4001848")]
    [FieldOffset(Offset = "0x8")]
    private Durability durability;

    [Token(Token = "0x600193C")]
    [Address(RVA = "0x2491E50", Offset = "0x2491E50", VA = "0x2491E50")]
    public DurabilityText(DurabilityFormatter formatter, Durability durability)
    {
    }

    [Token(Token = "0x600193D")]
    [Address(RVA = "0x2494230", Offset = "0x2494230", VA = "0x2494230", Slot = "3")]
    public override string ToString() => (string) null;
  }
}
