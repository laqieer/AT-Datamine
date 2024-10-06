// Decompiled with JetBrains decompiler
// Type: UnitDetail.Viewer.State.Viewer2DState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitDetail.Viewer.State
{
  [Token(Token = "0x20004C8")]
  public class Viewer2DState : ViewerSubState
  {
    [Token(Token = "0x1700034D")]
    public override UnitViewerStateHandler.SubStateIndices SubStateIndex
    {
      [Token(Token = "0x6001B12"), Address(RVA = "0x2C2B7E8", Offset = "0x2C2B7E8", VA = "0x2C2B7E8", Slot = "21")] get
      {
        return new UnitViewerStateHandler.SubStateIndices();
      }
    }

    [Token(Token = "0x1700034E")]
    protected override UnitViewerStateHandler.SubStateIndices NextSubStateIndex
    {
      [Token(Token = "0x6001B13"), Address(RVA = "0x2C2B7F0", Offset = "0x2C2B7F0", VA = "0x2C2B7F0", Slot = "22")] get
      {
        return new UnitViewerStateHandler.SubStateIndices();
      }
    }

    [Token(Token = "0x1700034F")]
    protected override UnitViewerBase Viewer
    {
      [Token(Token = "0x6001B14"), Address(RVA = "0x2C2B7F8", Offset = "0x2C2B7F8", VA = "0x2C2B7F8", Slot = "23")] get
      {
        return (UnitViewerBase) null;
      }
    }

    [Token(Token = "0x6001B15")]
    [Address(RVA = "0x2C2B858", Offset = "0x2C2B858", VA = "0x2C2B858", Slot = "25")]
    protected override void OnBackImpl()
    {
    }

    [Token(Token = "0x6001B16")]
    [Address(RVA = "0x2C29094", Offset = "0x2C29094", VA = "0x2C29094")]
    public Viewer2DState()
    {
    }
  }
}
