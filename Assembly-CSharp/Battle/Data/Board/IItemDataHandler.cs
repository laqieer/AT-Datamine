// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.IItemDataHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027ED")]
  public interface IItemDataHandler
  {
    [Token(Token = "0x600F95A")]
    bool TryGetItem(int id, out ItemData item);

    [Token(Token = "0x600F95B")]
    bool RegisterItem(ItemData item);
  }
}
