// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.DrainEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200278C")]
  public abstract class DrainEffectData : EffectData
  {
    [Token(Token = "0x170034F2")]
    public EffectValue EffectValue
    {
      [Token(Token = "0x600F6E1"), Address(RVA = "0x1ED8848", Offset = "0x1ED8848", VA = "0x1ED8848")] get
      {
        return new EffectValue();
      }
      [Token(Token = "0x600F6E2"), Address(RVA = "0x1ED8850", Offset = "0x1ED8850", VA = "0x1ED8850")] private set
      {
      }
    }

    [Token(Token = "0x600F6E3")]
    [Address(RVA = "0x1ED8858", Offset = "0x1ED8858", VA = "0x1ED8858")]
    protected DrainEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F6E4")]
    [Address(RVA = "0x1ED8900", Offset = "0x1ED8900", VA = "0x1ED8900", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x200278D")]
    private enum ContextType
    {
      [Token(Token = "0x400A8AC")] ValueType,
      [Token(Token = "0x400A8AD")] Value,
    }
  }
}
