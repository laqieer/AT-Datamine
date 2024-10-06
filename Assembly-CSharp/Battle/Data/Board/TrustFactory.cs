// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.TrustFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002802")]
  public static class TrustFactory
  {
    [Token(Token = "0x600FAA0")]
    public static TrustData CreateFromUserTrust<THandler>(
      int id,
      UnitTrust trust,
      THandler handler)
      where THandler : ITrustDataHandler, ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (TrustData) null;
    }

    [Token(Token = "0x600FAA1")]
    public static TrustData CreateFromSchema<THandler>(staq.SaveSchema.TrustData schema, THandler handler) where THandler : ITrustDataHandler, ISkillDataHandler, IEffectHandler, IBadStatusEffectHandler
    {
      return (TrustData) null;
    }
  }
}
