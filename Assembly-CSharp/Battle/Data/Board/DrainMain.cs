// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.DrainMain
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200278E")]
  public class DrainMain : EffectData
  {
    [Token(Token = "0x170034F3")]
    public EffectValue EffectValue
    {
      [Token(Token = "0x600F6E5"), Address(RVA = "0x1ED897C", Offset = "0x1ED897C", VA = "0x1ED897C")] get
      {
        return new EffectValue();
      }
      [Token(Token = "0x600F6E6"), Address(RVA = "0x1ED8984", Offset = "0x1ED8984", VA = "0x1ED8984")] private set
      {
      }
    }

    [Token(Token = "0x600F6E7")]
    [Address(RVA = "0x1ED898C", Offset = "0x1ED898C", VA = "0x1ED898C")]
    public static DrainMain Create(EffectSource source) => (DrainMain) null;

    [Token(Token = "0x600F6E8")]
    [Address(RVA = "0x1ED8A28", Offset = "0x1ED8A28", VA = "0x1ED8A28")]
    public DrainMain(EffectSource source)
    {
    }

    [Token(Token = "0x200278F")]
    private enum ContextType
    {
      [Token(Token = "0x400A8B0")] Value,
    }
  }
}
