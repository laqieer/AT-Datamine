﻿// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.IEffectHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002796")]
  public interface IEffectHandler
  {
    [Token(Token = "0x600F718")]
    EffectFactory GetEffectFactory();

    [Token(Token = "0x600F719")]
    bool TryGetEffect(int effect, out EffectData skillEffect);

    [Token(Token = "0x600F71A")]
    bool RegisterEffect(EffectData skillEffect);
  }
}
