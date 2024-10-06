// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.IItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027EC")]
  public interface IItemData
  {
    [Token(Token = "0x170035ED")]
    ItemTypeEnum ItemType { [Token(Token = "0x600F955")] get; }

    [Token(Token = "0x170035EE")]
    int ItemId { [Token(Token = "0x600F956")] get; }

    [Token(Token = "0x170035EF")]
    int Amount { [Token(Token = "0x600F957")] get; }

    [Token(Token = "0x170035F0")]
    int MaxAmount { [Token(Token = "0x600F958")] get; }

    [Token(Token = "0x170035F1")]
    string Name { [Token(Token = "0x600F959")] get; }
  }
}
