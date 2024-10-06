// Decompiled with JetBrains decompiler
// Type: Battle.Data.ICorrectableParameter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002725")]
  public interface ICorrectableParameter<T>
  {
    [Token(Token = "0x170033D7")]
    T BaseParam { [Token(Token = "0x600F366")] get; }

    [Token(Token = "0x170033D8")]
    T Calculated { [Token(Token = "0x600F367")] get; }

    [Token(Token = "0x170033D9")]
    T TotalOffset { [Token(Token = "0x600F368")] get; }

    [Token(Token = "0x170033DA")]
    T FixedOffset { [Token(Token = "0x600F369")] get; }

    [Token(Token = "0x170033DB")]
    T RatedOffset { [Token(Token = "0x600F36A")] get; }

    [Token(Token = "0x600F36B")]
    void CalcParameters();

    [Token(Token = "0x600F36C")]
    void ResetParameters();
  }
}
