// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.ElementChainEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027AC")]
  public class ElementChainEffectData : EffectData
  {
    [Token(Token = "0x17003551")]
    public int Value
    {
      [Token(Token = "0x600F7C4"), Address(RVA = "0x1EDDB38", Offset = "0x1EDDB38", VA = "0x1EDDB38")] get
      {
        return new int();
      }
      [Token(Token = "0x600F7C5"), Address(RVA = "0x1EDDB40", Offset = "0x1EDDB40", VA = "0x1EDDB40")] private set
      {
      }
    }

    [Token(Token = "0x600F7C6")]
    [Address(RVA = "0x1EDDB48", Offset = "0x1EDDB48", VA = "0x1EDDB48")]
    private ElementChainEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x20027AD")]
    public enum ContextType
    {
      [Token(Token = "0x400A91B")] Value,
    }
  }
}
