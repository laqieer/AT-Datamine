// Decompiled with JetBrains decompiler
// Type: Battle.Grid.IGridEventDispatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.EventSystems;

#nullable disable
namespace Battle.Grid
{
  [Token(Token = "0x2002537")]
  public interface IGridEventDispatcher
  {
    [Token(Token = "0x600E5F4")]
    void DispatchPointerDownGrid(PointerEventData eventData);

    [Token(Token = "0x600E5F5")]
    void DispatchPointerUpGrid(PointerEventData eventData);

    [Token(Token = "0x600E5F6")]
    void DispatchPointerExitGrid(PointerEventData eventData);
  }
}
