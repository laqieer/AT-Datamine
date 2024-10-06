// Decompiled with JetBrains decompiler
// Type: Battle.Score.AIConstParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace Battle.Score
{
  [Token(Token = "0x2002471")]
  public struct AIConstParam
  {
    [Token(Token = "0x17002FEF")]
    public int Max
    {
      [Token(Token = "0x600DF7E"), Address(RVA = "0x201B014", Offset = "0x201B014", VA = "0x201B014")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x600DF7F"), Address(RVA = "0x201B01C", Offset = "0x201B01C", VA = "0x201B01C")] private set
      {
      }
    }

    [Token(Token = "0x17002FF0")]
    public int Attenuation
    {
      [Token(Token = "0x600DF80"), Address(RVA = "0x201B024", Offset = "0x201B024", VA = "0x201B024")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x600DF81"), Address(RVA = "0x201B02C", Offset = "0x201B02C", VA = "0x201B02C")] private set
      {
      }
    }

    [Token(Token = "0x17002FF1")]
    public int Min
    {
      [Token(Token = "0x600DF82"), Address(RVA = "0x201B034", Offset = "0x201B034", VA = "0x201B034")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x600DF83"), Address(RVA = "0x201B03C", Offset = "0x201B03C", VA = "0x201B03C")] private set
      {
      }
    }

    [Token(Token = "0x600DF84")]
    [Address(RVA = "0x201B008", Offset = "0x201B008", VA = "0x201B008")]
    public AIConstParam(int max, int attenuation, int min = 0)
    {
    }

    [Token(Token = "0x600DF85")]
    [Address(RVA = "0x201AEFC", Offset = "0x201AEFC", VA = "0x201AEFC")]
    public AIConstParam(Table table)
    {
    }
  }
}
