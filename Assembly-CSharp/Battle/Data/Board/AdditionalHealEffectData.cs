// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.AdditionalHealEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200276F")]
  public class AdditionalHealEffectData : EffectData
  {
    [Token(Token = "0x400A875")]
    [FieldOffset(Offset = "0x84")]
    public int healValue;

    [Token(Token = "0x170034BD")]
    public int ratio
    {
      [Token(Token = "0x600F663"), Address(RVA = "0x1ED63D4", Offset = "0x1ED63D4", VA = "0x1ED63D4")] get
      {
        return new int();
      }
      [Token(Token = "0x600F664"), Address(RVA = "0x1ED63DC", Offset = "0x1ED63DC", VA = "0x1ED63DC")] private set
      {
      }
    }

    [Token(Token = "0x600F665")]
    [Address(RVA = "0x1ED63E4", Offset = "0x1ED63E4", VA = "0x1ED63E4")]
    public static AdditionalHealEffectData Create(EffectSource source)
    {
      return (AdditionalHealEffectData) null;
    }

    [Token(Token = "0x600F666")]
    [Address(RVA = "0x1ED6480", Offset = "0x1ED6480", VA = "0x1ED6480")]
    protected AdditionalHealEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x2002770")]
    public enum ContextType
    {
      [Token(Token = "0x400A877")] Ratio,
    }
  }
}
