// Decompiled with JetBrains decompiler
// Type: Battle.Debug.BattleDebugContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Diagnostics;

#nullable disable
namespace Battle.Debug
{
  [Token(Token = "0x20025CB")]
  public abstract class BattleDebugContent : IBattleDebugContent
  {
    [Token(Token = "0x170031D3")]
    public abstract bool IsValid { [Token(Token = "0x600E95A")] get; }

    [Token(Token = "0x600E95B")]
    [Address(RVA = "0x4C49650", Offset = "0x4C49650", VA = "0x4C49650", Slot = "5")]
    public void OnGUI()
    {
    }

    [Token(Token = "0x600E95C")]
    [Address(RVA = "0x4C49654", Offset = "0x4C49654", VA = "0x4C49654", Slot = "9")]
    public virtual bool OnGUI(UnitParameterData unit) => new bool();

    [Token(Token = "0x600E95D")]
    [Address(RVA = "0x4C4965C", Offset = "0x4C4965C", VA = "0x4C4965C", Slot = "10")]
    public virtual bool OnGUI(GridData grid) => new bool();

    [Token(Token = "0x600E95E")]
    [Conditional("UNITY_EDITOR")]
    protected abstract void OnGUIImpl();

    [Token(Token = "0x600E95F")]
    [Address(RVA = "0x4C49664", Offset = "0x4C49664", VA = "0x4C49664")]
    protected BattleDebugContent()
    {
    }
  }
}
