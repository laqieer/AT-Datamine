// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.SupportSkillActivateModifierEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027CA")]
  public class SupportSkillActivateModifierEffectData : ModifierEffectData
  {
    [Token(Token = "0x400A97B")]
    [FieldOffset(Offset = "0x94")]
    private SupportSkillActivateModifierEffectData.ContextIndexInfo contextIndexInfo;

    [Token(Token = "0x170035AD")]
    protected override ModifierEffectData.IContextIndexInfo BaseContextInfo
    {
      [Token(Token = "0x600F8A3"), Address(RVA = "0x44BC05C", Offset = "0x44BC05C", VA = "0x44BC05C", Slot = "8")] get
      {
        return (ModifierEffectData.IContextIndexInfo) null;
      }
    }

    [Token(Token = "0x600F8A4")]
    [Address(RVA = "0x44BC0B8", Offset = "0x44BC0B8", VA = "0x44BC0B8")]
    public static SupportSkillActivateModifierEffectData Create(EffectSource source)
    {
      return (SupportSkillActivateModifierEffectData) null;
    }

    [Token(Token = "0x600F8A5")]
    [Address(RVA = "0x44BC144", Offset = "0x44BC144", VA = "0x44BC144")]
    public SupportSkillActivateModifierEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F8A6")]
    [Address(RVA = "0x44BC1D8", Offset = "0x44BC1D8", VA = "0x44BC1D8", Slot = "10")]
    protected override void CreateParameterTextMap()
    {
    }

    [Token(Token = "0x600F8A7")]
    [Address(RVA = "0x44BC1DC", Offset = "0x44BC1DC", VA = "0x44BC1DC", Slot = "9")]
    public override string GetDisplayName(int key = 0) => (string) null;

    [Token(Token = "0x20027CB")]
    private struct ContextIndexInfo : ModifierEffectData.IContextIndexInfo
    {
      [Token(Token = "0x170035AE")]
      public int ValueType
      {
        [Token(Token = "0x600F8A8"), Address(RVA = "0x44BC1E8", Offset = "0x44BC1E8", VA = "0x44BC1E8", Slot = "4")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F8A9"), Address(RVA = "0x44BC1F0", Offset = "0x44BC1F0", VA = "0x44BC1F0")] set
        {
        }
      }

      [Token(Token = "0x170035AF")]
      public int Value
      {
        [Token(Token = "0x600F8AA"), Address(RVA = "0x44BC1F8", Offset = "0x44BC1F8", VA = "0x44BC1F8")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600F8AB"), Address(RVA = "0x44BC200", Offset = "0x44BC200", VA = "0x44BC200")] set
        {
        }
      }
    }
  }
}
