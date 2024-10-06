// Decompiled with JetBrains decompiler
// Type: Battle.Score.Score
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Score
{
  [Token(Token = "0x2002494")]
  public class Score
  {
    [Token(Token = "0x17003033")]
    public ScoreTypeEnum ScoreType
    {
      [Token(Token = "0x600E07A"), Address(RVA = "0x2029EC0", Offset = "0x2029EC0", VA = "0x2029EC0")] get
      {
        return new ScoreTypeEnum();
      }
      [Token(Token = "0x600E07B"), Address(RVA = "0x2029EC8", Offset = "0x2029EC8", VA = "0x2029EC8")] private set
      {
      }
    }

    [Token(Token = "0x17003034")]
    public int Value
    {
      [Token(Token = "0x600E07C"), Address(RVA = "0x2029ED0", Offset = "0x2029ED0", VA = "0x2029ED0")] get
      {
        return new int();
      }
      [Token(Token = "0x600E07D"), Address(RVA = "0x2029ED8", Offset = "0x2029ED8", VA = "0x2029ED8")] private set
      {
      }
    }

    [Token(Token = "0x17003035")]
    public string Log
    {
      [Token(Token = "0x600E07E"), Address(RVA = "0x2029EE0", Offset = "0x2029EE0", VA = "0x2029EE0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E07F"), Address(RVA = "0x2029EE8", Offset = "0x2029EE8", VA = "0x2029EE8")] private set
      {
      }
    }

    [Token(Token = "0x600E080")]
    [Address(RVA = "0x201BF40", Offset = "0x201BF40", VA = "0x201BF40")]
    public Score(ScoreTypeEnum scoreType, int value, string log = "")
    {
    }

    [Token(Token = "0x600E081")]
    [Address(RVA = "0x2020ED4", Offset = "0x2020ED4", VA = "0x2020ED4")]
    public void Update(int value, string log = "")
    {
    }
  }
}
