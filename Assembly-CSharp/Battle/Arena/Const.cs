// Decompiled with JetBrains decompiler
// Type: Battle.Arena.Const
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Arena
{
  [Token(Token = "0x200281C")]
  public class Const
  {
    [Token(Token = "0x400AB30")]
    public const int UserPlayerId = 1;
    [Token(Token = "0x400AB31")]
    public const int EnemyPlayerId = 2;
    [Token(Token = "0x400AB32")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Dictionary<(int playerId1, int playerId2), CorrelationType> correlationTemplateMap;
    [Token(Token = "0x400AB33")]
    [FieldOffset(Offset = "0x8")]
    public static readonly Dictionary<int, List<int>> ForceDic;

    [Token(Token = "0x17003777")]
    public static IReadOnlyDictionary<(int playerId1, int playerId2), CorrelationType> CorrelationTemplateMap
    {
      [Token(Token = "0x600FC83"), Address(RVA = "0x4424B60", Offset = "0x4424B60", VA = "0x4424B60")] get
      {
        return (IReadOnlyDictionary<(int, int), CorrelationType>) null;
      }
    }

    [Token(Token = "0x600FC84")]
    [Address(RVA = "0x4424BB8", Offset = "0x4424BB8", VA = "0x4424BB8")]
    public Const()
    {
    }

    [Token(Token = "0x600FC85")]
    [Address(RVA = "0x4424BC0", Offset = "0x4424BC0", VA = "0x4424BC0")]
    static Const()
    {
    }
  }
}
