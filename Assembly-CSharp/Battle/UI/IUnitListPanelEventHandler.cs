﻿// Decompiled with JetBrains decompiler
// Type: Battle.UI.IUnitListPanelEventHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002339")]
  public interface IUnitListPanelEventHandler
  {
    [Token(Token = "0x600D75A")]
    void OnSelectUnitEvent(UnitParameterData unit);
  }
}
