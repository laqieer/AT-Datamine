// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.MoveModifierEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027C8")]
  public class MoveModifierEffectData : ModifierEffectData
  {
    [Token(Token = "0x400A979")]
    [FieldOffset(Offset = "0x94")]
    private MoveModifierEffectData.ContextIndexInfo contextIndexInfo;

    [Token(Token = "0x170035AB")]
    protected override ModifierEffectData.IContextIndexInfo BaseContextInfo
    {
      [Token(Token = "0x600F89A"), Address(RVA = "0x44BBD24", Offset = "0x44BBD24", VA = "0x44BBD24", Slot = "8")] get
      {
        return (ModifierEffectData.IContextIndexInfo) null;
      }
    }

    [Token(Token = "0x600F89B")]
    [Address(RVA = "0x44BBD80", Offset = "0x44BBD80", VA = "0x44BBD80")]
    public static MoveModifierEffectData Create(EffectSource source)
    {
      return (MoveModifierEffectData) null;
    }

    [Token(Token = "0x600F89C")]
    [Address(RVA = "0x44BBE0C", Offset = "0x44BBE0C", VA = "0x44BBE0C")]
    protected MoveModifierEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F89D")]
    [Address(RVA = "0x44BBF28", Offset = "0x44BBF28", VA = "0x44BBF28", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x600F89E")]
    [Address(RVA = "0x44BBF8C", Offset = "0x44BBF8C", VA = "0x44BBF8C", Slot = "10")]
    protected override void CreateParameterTextMap()
    {
    }

    [Token(Token = "0x600F89F")]
    [Address(RVA = "0x44BBF90", Offset = "0x44BBF90", VA = "0x44BBF90", Slot = "9")]
    public override string GetDisplayName(int key = 0) => (string) null;

    [Token(Token = "0x600F8A0")]
    [Address(RVA = "0x44BBF9C", Offset = "0x44BBF9C", VA = "0x44BBF9C")]
    public int GetEffectValue() => new int();

    [Token(Token = "0x20027C9")]
    private struct ContextIndexInfo : ModifierEffectData.IContextIndexInfo
    {
      [Token(Token = "0x170035AC")]
      public int ValueType
      {
        [Token(Token = "0x600F8A1"), Address(RVA = "0x44BC04C", Offset = "0x44BC04C", VA = "0x44BC04C", Slot = "4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F8A2"), Address(RVA = "0x44BC054", Offset = "0x44BC054", VA = "0x44BC054")] set
        {
        }
      }
    }
  }
}
