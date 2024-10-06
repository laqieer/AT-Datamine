// Decompiled with JetBrains decompiler
// Type: Battle.Grid.IGridEventHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.EventSystems;

#nullable disable
namespace Battle.Grid
{
  [Token(Token = "0x2002538")]
  public interface IGridEventHandler
  {
    [Token(Token = "0x600E5F7")]
    void OnPointerDownGrid(GridObject grid, PointerEventData eventData);

    [Token(Token = "0x600E5F8")]
    void OnPointerUpGrid(GridObject grid, PointerEventData eventData);

    [Token(Token = "0x600E5F9")]
    void OnPointerExitGrid(GridObject grid, PointerEventData eventData);
  }
}
