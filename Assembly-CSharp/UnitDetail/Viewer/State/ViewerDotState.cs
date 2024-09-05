// Decompiled with JetBrains decompiler
// Type: UnitDetail.Viewer.State.ViewerDotState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitDetail.Viewer.State
{
  [Token(Token = "0x20004C9")]
  public class ViewerDotState : ViewerSubState
  {
    [Token(Token = "0x17000350")]
    public override UnitViewerStateHandler.SubStateIndices SubStateIndex
    {
      [Token(Token = "0x6001B17"), Address(RVA = "0x2C2B9B8", Offset = "0x2C2B9B8", VA = "0x2C2B9B8", Slot = "21")] get
      {
        return new UnitViewerStateHandler.SubStateIndices();
      }
    }

    [Token(Token = "0x17000351")]
    protected override UnitViewerStateHandler.SubStateIndices NextSubStateIndex
    {
      [Token(Token = "0x6001B18"), Address(RVA = "0x2C2B9C0", Offset = "0x2C2B9C0", VA = "0x2C2B9C0", Slot = "22")] get
      {
        return new UnitViewerStateHandler.SubStateIndices();
      }
    }

    [Token(Token = "0x17000352")]
    protected override UnitViewerBase Viewer
    {
      [Token(Token = "0x6001B19"), Address(RVA = "0x2C2B9C8", Offset = "0x2C2B9C8", VA = "0x2C2B9C8", Slot = "23")] get
      {
        return (UnitViewerBase) null;
      }
    }

    [Token(Token = "0x6001B1A")]
    [Address(RVA = "0x2C2BA28", Offset = "0x2C2BA28", VA = "0x2C2BA28", Slot = "24")]
    public override void OnUpdateMotionList()
    {
    }

    [Token(Token = "0x6001B1B")]
    [Address(RVA = "0x2C2BAC4", Offset = "0x2C2BAC4", VA = "0x2C2BAC4", Slot = "25")]
    protected override void OnBackImpl()
    {
    }

    [Token(Token = "0x6001B1C")]
    [Address(RVA = "0x2C29098", Offset = "0x2C29098", VA = "0x2C29098")]
    public ViewerDotState()
    {
    }
  }
}
