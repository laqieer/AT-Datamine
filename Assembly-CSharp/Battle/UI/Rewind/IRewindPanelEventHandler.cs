// Decompiled with JetBrains decompiler
// Type: Battle.UI.Rewind.IRewindPanelEventHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.UI.Rewind
{
  [Token(Token = "0x200244A")]
  public interface IRewindPanelEventHandler
  {
    [Token(Token = "0x600DE63")]
    void OnHideRewindPanel();

    [Token(Token = "0x600DE64")]
    void OnSelectRollbackTo(int index);

    [Token(Token = "0x600DE65")]
    void OnExecRollback(int index);

    [Token(Token = "0x600DE66")]
    void OnCancelRollback();

    [Token(Token = "0x600DE67")]
    void ShowBattleLogViewIntoRewind();

    [Token(Token = "0x600DE68")]
    void HideBattleLogViewIntoRewind();

    [Token(Token = "0x600DE69")]
    void SetActiveBattleLogView(bool isActive);
  }
}
