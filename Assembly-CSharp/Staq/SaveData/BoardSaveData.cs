// Decompiled with JetBrains decompiler
// Type: staq.SaveData.BoardSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using staq.SaveSchema;

#nullable disable
namespace staq.SaveData
{
  [Token(Token = "0x2003CF9")]
  public class BoardSaveData
  {
    [Token(Token = "0x17005010")]
    private string Path
    {
      [Token(Token = "0x6018808"), Address(RVA = "0x293A1D4", Offset = "0x293A1D4", VA = "0x293A1D4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6018809")]
    [Address(RVA = "0x293A244", Offset = "0x293A244", VA = "0x293A244")]
    public void Delete()
    {
    }

    [Token(Token = "0x601880A")]
    [Address(RVA = "0x293A248", Offset = "0x293A248", VA = "0x293A248")]
    public void DeleteStoryBattle()
    {
    }

    [Token(Token = "0x601880B")]
    [Address(RVA = "0x293A308", Offset = "0x293A308", VA = "0x293A308")]
    public bool Save(string fileName, Battle.Data.Board.BoardData board) => new bool();

    [Token(Token = "0x601880C")]
    [Address(RVA = "0x293A574", Offset = "0x293A574", VA = "0x293A574")]
    public bool SaveOnlyBoard(string fileName, Battle.Data.Board.BoardData board) => new bool();

    [Token(Token = "0x601880D")]
    [Address(RVA = "0x293A654", Offset = "0x293A654", VA = "0x293A654")]
    public Battle.Data.Board.BoardData Load(string fileName) => (Battle.Data.Board.BoardData) null;

    [Token(Token = "0x601880E")]
    [Address(RVA = "0x293A86C", Offset = "0x293A86C", VA = "0x293A86C")]
    public RollbackData LoadRollback(string fileName) => new RollbackData();

    [Token(Token = "0x601880F")]
    [Address(RVA = "0x293A948", Offset = "0x293A948", VA = "0x293A948")]
    public BattleLogDataList LoadBattleLog(string fileName) => new BattleLogDataList();

    [Token(Token = "0x6018810")]
    [Address(RVA = "0x293A2D8", Offset = "0x293A2D8", VA = "0x293A2D8")]
    public void Delete(string fileName)
    {
    }

    [Token(Token = "0x6018811")]
    [Address(RVA = "0x293A790", Offset = "0x293A790", VA = "0x293A790")]
    private staq.SaveSchema.BoardData LoadBoard(string fileName) => new staq.SaveSchema.BoardData();

    [Token(Token = "0x6018812")]
    [Address(RVA = "0x293A49C", Offset = "0x293A49C", VA = "0x293A49C")]
    public bool WriteFile(string fileName, byte[] bytes) => new bool();

    [Token(Token = "0x6018813")]
    [Address(RVA = "0x293AA24", Offset = "0x293AA24", VA = "0x293AA24")]
    private byte[] LoadFile(string fileName) => (byte[]) null;

    [Token(Token = "0x6018814")]
    [Address(RVA = "0x293AA38", Offset = "0x293AA38", VA = "0x293AA38")]
    private string GetFullPath(string fileName) => (string) null;

    [Token(Token = "0x6018815")]
    [Address(RVA = "0x293AA88", Offset = "0x293AA88", VA = "0x293AA88")]
    public BoardSaveData()
    {
    }
  }
}
