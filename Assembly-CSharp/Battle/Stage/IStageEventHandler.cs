// Decompiled with JetBrains decompiler
// Type: Battle.Stage.IStageEventHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Grid;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Stage
{
  [Token(Token = "0x200246E")]
  public interface IStageEventHandler
  {
    [Token(Token = "0x600DF59")]
    void OnSelectGrid(GridObject targetGrid);

    [Token(Token = "0x600DF5A")]
    void OnHoldGrid(GridObject targetGrid);
  }
}
