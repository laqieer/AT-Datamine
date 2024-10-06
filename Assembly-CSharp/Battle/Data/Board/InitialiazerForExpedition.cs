// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.InitialiazerForExpedition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Expedition.Data;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002761")]
  public class InitialiazerForExpedition : IBoardInitializer
  {
    [Token(Token = "0x400A857")]
    [FieldOffset(Offset = "0x10")]
    private ExpeditionBattleData data;
    [Token(Token = "0x400A858")]
    [FieldOffset(Offset = "0x18")]
    private MapEditorData mapEditorData;

    [Token(Token = "0x600F63C")]
    [Address(RVA = "0x1ED3E2C", Offset = "0x1ED3E2C", VA = "0x1ED3E2C")]
    public InitialiazerForExpedition(ExpeditionBattleData data)
    {
    }

    [Token(Token = "0x600F63D")]
    [Address(RVA = "0x1ED3E64", Offset = "0x1ED3E64", VA = "0x1ED3E64", Slot = "4")]
    public void Initialize(BoardData board)
    {
    }
  }
}
