// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.InitialiazerForPsBattleAdv
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.PsBattleAdv.Data;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002762")]
  public class InitialiazerForPsBattleAdv : IBoardInitializer
  {
    [Token(Token = "0x400A859")]
    [FieldOffset(Offset = "0x10")]
    private PsBattleAdvData data;
    [Token(Token = "0x400A85A")]
    [FieldOffset(Offset = "0x18")]
    private MapEditorData mapEditorData;

    [Token(Token = "0x600F63E")]
    [Address(RVA = "0x1ED40F8", Offset = "0x1ED40F8", VA = "0x1ED40F8")]
    public InitialiazerForPsBattleAdv(PsBattleAdvData data)
    {
    }

    [Token(Token = "0x600F63F")]
    [Address(RVA = "0x1ED4130", Offset = "0x1ED4130", VA = "0x1ED4130", Slot = "4")]
    public void Initialize(BoardData board)
    {
    }
  }
}
