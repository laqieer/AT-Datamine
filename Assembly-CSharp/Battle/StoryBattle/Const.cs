// Decompiled with JetBrains decompiler
// Type: Battle.StoryBattle.Const
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.StoryBattle
{
  [Token(Token = "0x20025CD")]
  public class Const
  {
    [Token(Token = "0x400A299")]
    public const int UserPlayerId = 1;
    [Token(Token = "0x400A29A")]
    public const int GuestPlayerId = 2;
    [Token(Token = "0x400A29B")]
    public const int EnemyPlayerId = 3;
    [Token(Token = "0x400A29C")]
    public const int ThirdPlayerId = 4;
    [Token(Token = "0x400A29D")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Dictionary<(int playerId1, int playerId2), CorrelationType> correlationTemplateMap;
    [Token(Token = "0x400A29E")]
    [FieldOffset(Offset = "0x8")]
    public static readonly Dictionary<int, List<int>> ForceDic;

    [Token(Token = "0x170031D4")]
    public static IReadOnlyDictionary<(int playerId1, int playerId2), CorrelationType> CorrelationTemplateMap
    {
      [Token(Token = "0x600E962"), Address(RVA = "0x4C497E8", Offset = "0x4C497E8", VA = "0x4C497E8")] get
      {
        return (IReadOnlyDictionary<(int, int), CorrelationType>) null;
      }
    }

    [Token(Token = "0x600E963")]
    [Address(RVA = "0x4C49840", Offset = "0x4C49840", VA = "0x4C49840")]
    public Const()
    {
    }

    [Token(Token = "0x600E964")]
    [Address(RVA = "0x4C49848", Offset = "0x4C49848", VA = "0x4C49848")]
    static Const()
    {
    }
  }
}
