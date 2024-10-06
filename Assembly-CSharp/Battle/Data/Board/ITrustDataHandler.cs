// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.ITrustDataHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002800")]
  public interface ITrustDataHandler
  {
    [Token(Token = "0x600FA7E")]
    int CreateTrustId();

    [Token(Token = "0x600FA7F")]
    bool TryGetTrust(int id, out TrustData trust);

    [Token(Token = "0x600FA80")]
    bool RegisterTrust(TrustData trust);
  }
}
