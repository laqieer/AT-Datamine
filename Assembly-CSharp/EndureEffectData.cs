// Decompiled with JetBrains decompiler
// Type: EndureEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x20000E6")]
public class EndureEffectData : EffectData
{
  [Token(Token = "0x4000419")]
  [FieldOffset(Offset = "0x80")]
  private EffectValue HpConditions;

  [Token(Token = "0x60006B1")]
  [Address(RVA = "0x4186460", Offset = "0x4186460", VA = "0x4186460")]
  public static EndureEffectData Create(EffectSource source) => (EndureEffectData) null;

  [Token(Token = "0x60006B2")]
  [Address(RVA = "0x41864FC", Offset = "0x41864FC", VA = "0x41864FC")]
  protected EndureEffectData(EffectSource source)
  {
  }

  [Token(Token = "0x60006B3")]
  [Address(RVA = "0x41865C4", Offset = "0x41865C4", VA = "0x41865C4", Slot = "6")]
  public override bool CanTriggerEffect(UnitParameterData target) => new bool();

  [Token(Token = "0x20000E7")]
  public enum ContextType
  {
    [Token(Token = "0x400041B")] PutOperationCount,
    [Token(Token = "0x400041C")] ValueType,
    [Token(Token = "0x400041D")] Value,
  }
}
