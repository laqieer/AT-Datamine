// Decompiled with JetBrains decompiler
// Type: Battle.UI.ICommandPanelEventHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002332")]
  public interface ICommandPanelEventHandler
  {
    [Token(Token = "0x600D72E")]
    void OnPushTurnEnd();

    [Token(Token = "0x600D72F")]
    void OnPushUseItem();

    [Token(Token = "0x600D730")]
    void OnPushRewind();

    [Token(Token = "0x600D731")]
    void OnPushLog();
  }
}
