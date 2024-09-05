// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.NullBadStatusEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027CE")]
  public class NullBadStatusEffectData : EffectData
  {
    [Token(Token = "0x400A980")]
    [FieldOffset(Offset = "0x80")]
    public int group;
    [Token(Token = "0x400A981")]
    [FieldOffset(Offset = "0x88")]
    private string groupText;

    [Token(Token = "0x170035B1")]
    public override string DisplayName
    {
      [Token(Token = "0x600F8B0"), Address(RVA = "0x44BC370", Offset = "0x44BC370", VA = "0x44BC370", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600F8B1")]
    [Address(RVA = "0x44BC384", Offset = "0x44BC384", VA = "0x44BC384")]
    public static NullBadStatusEffectData Create(EffectSource source)
    {
      return (NullBadStatusEffectData) null;
    }

    [Token(Token = "0x600F8B2")]
    [Address(RVA = "0x44BC420", Offset = "0x44BC420", VA = "0x44BC420")]
    protected NullBadStatusEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F8B3")]
    [Address(RVA = "0x44BC574", Offset = "0x44BC574", VA = "0x44BC574", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x20027CF")]
    public enum ContextType
    {
      [Token(Token = "0x400A983")] nullBadStatusGroup,
    }
  }
}
