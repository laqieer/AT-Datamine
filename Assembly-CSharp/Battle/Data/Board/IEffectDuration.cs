// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.IEffectDuration
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200279D")]
  public interface IEffectDuration
  {
    [Token(Token = "0x1700352C")]
    bool IsExpire { [Token(Token = "0x600F760")] get; }

    [Token(Token = "0x1700352D")]
    List<int> Contexts { [Token(Token = "0x600F761")] get; }

    [Token(Token = "0x600F762")]
    void Initialize(List<int> contexts);

    [Token(Token = "0x600F763")]
    void Reset(int effectedTurnNumber, int effectedPhaseIndex);

    [Token(Token = "0x600F764")]
    void Update(int turnNumber, int phaseIndex);
  }
}
