// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.CorrelationDataBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200276B")]
  public abstract class CorrelationDataBase
  {
    [Token(Token = "0x400A86B")]
    protected const CorrelationType DefaultCorrelation = CorrelationType.Frendly;
    [Token(Token = "0x400A86C")]
    [FieldOffset(Offset = "0x10")]
    private HashSet<int> playerList;
    [Token(Token = "0x400A86E")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<(int playerId1, int playerId2), CorrelationType> correlationDic;

    [Token(Token = "0x170034BC")]
    public List<(int playerId1, int playerId2, CorrelationType correlation)> Correlations
    {
      [Token(Token = "0x600F655"), Address(RVA = "0x1ED5878", Offset = "0x1ED5878", VA = "0x1ED5878")] get
      {
        return (List<(int, int, CorrelationType)>) null;
      }
      [Token(Token = "0x600F656"), Address(RVA = "0x1ED5880", Offset = "0x1ED5880", VA = "0x1ED5880")] private set
      {
      }
    }

    [Token(Token = "0x600F657")]
    [Address(RVA = "0x1ECE6F0", Offset = "0x1ECE6F0", VA = "0x1ECE6F0")]
    public void AddPlayerId(int id)
    {
    }

    [Token(Token = "0x600F658")]
    [Address(RVA = "0x1ECE780", Offset = "0x1ECE780", VA = "0x1ECE780")]
    public void Clear()
    {
    }

    [Token(Token = "0x600F659")]
    [Address(RVA = "0x1ED5CD8", Offset = "0x1ED5CD8", VA = "0x1ED5CD8")]
    public CorrelationType GetCorrelation(int playerId1, int playerId2) => new CorrelationType();

    [Token(Token = "0x600F65A")]
    [Address(RVA = "0x1ECFD1C", Offset = "0x1ECFD1C", VA = "0x1ECFD1C")]
    public CorrelationDataBase.PersonalCorrelation GetPersonalCorrelation(
      BattlePlayerData playerData)
    {
      return new CorrelationDataBase.PersonalCorrelation();
    }

    [Token(Token = "0x600F65B")]
    [Address(RVA = "0x1ED5888", Offset = "0x1ED5888", VA = "0x1ED5888")]
    private void RemapCorrelations()
    {
    }

    [Token(Token = "0x600F65C")]
    protected abstract CorrelationType GenerateCorrelation(int playerId1, int playerId2);

    [Token(Token = "0x600F65D")]
    [Address(RVA = "0x1ED5E64", Offset = "0x1ED5E64", VA = "0x1ED5E64", Slot = "5")]
    public virtual CorrelationDataBase DeepCopy() => (CorrelationDataBase) null;

    [Token(Token = "0x600F65E")]
    [Address(RVA = "0x1ED5FE4", Offset = "0x1ED5FE4", VA = "0x1ED5FE4")]
    protected CorrelationDataBase()
    {
    }

    [Token(Token = "0x200276C")]
    public struct PersonalCorrelation
    {
      [Token(Token = "0x400A86F")]
      [FieldOffset(Offset = "0x0")]
      public int playerId;
      [Token(Token = "0x400A870")]
      [FieldOffset(Offset = "0x8")]
      public int[] frendlyPlayeIds;
      [Token(Token = "0x400A871")]
      [FieldOffset(Offset = "0x10")]
      public int[] hostilePlayeIds;
    }
  }
}
