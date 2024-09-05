// Decompiled with JetBrains decompiler
// Type: Battle.BoardDeserializer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using staq.SaveSchema;

#nullable disable
namespace Battle
{
  [Token(Token = "0x2002260")]
  public class BoardDeserializer
  {
    [Token(Token = "0x600D0CA")]
    [Address(RVA = "0x4CDE620", Offset = "0x4CDE620", VA = "0x4CDE620")]
    public Battle.Data.Board.BoardData Deserialize(staq.SaveSchema.BoardData schema)
    {
      return (Battle.Data.Board.BoardData) null;
    }

    [Token(Token = "0x600D0CB")]
    [Address(RVA = "0x4CDEE54", Offset = "0x4CDEE54", VA = "0x4CDEE54")]
    public Battle.Data.Board.BoardData Deserialize(
      staq.SaveSchema.BoardData schema,
      Battle.Data.Board.SceneParameter sceneParam,
      Battle.Data.Board.BattleData battleData)
    {
      return (Battle.Data.Board.BoardData) null;
    }

    [Token(Token = "0x600D0CC")]
    [Address(RVA = "0x4CDE7C0", Offset = "0x4CDE7C0", VA = "0x4CDE7C0")]
    private void DeserializeBoard(ref Battle.Data.Board.BoardData board, Battle.Data.Board.BattleData battleData, staq.SaveSchema.BoardData schema)
    {
    }

    [Token(Token = "0x600D0CD")]
    [Address(RVA = "0x4CDEF18", Offset = "0x4CDEF18", VA = "0x4CDEF18")]
    private void LoadAllUnitParams(Battle.Data.Board.BoardData board, staq.SaveSchema.BoardData schema)
    {
    }

    [Token(Token = "0x600D0CE")]
    [Address(RVA = "0x4CDF2FC", Offset = "0x4CDF2FC", VA = "0x4CDF2FC")]
    public void SanityCheck(RollbackData schema, Battle.Data.Board.SceneParameter sceneParam, Battle.Data.Board.BattleData battleData)
    {
    }

    [Token(Token = "0x600D0CF")]
    [Address(RVA = "0x4CDF4D0", Offset = "0x4CDF4D0", VA = "0x4CDF4D0")]
    public void SanityCheck(BattleLogDataList schema, Battle.Data.Board.SceneParameter sceneParam)
    {
    }

    [Token(Token = "0x600D0D0")]
    [Address(RVA = "0x4CDF684", Offset = "0x4CDF684", VA = "0x4CDF684")]
    public BoardDeserializer()
    {
    }
  }
}
