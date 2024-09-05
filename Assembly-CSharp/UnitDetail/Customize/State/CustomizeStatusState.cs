// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.State.CustomizeStatusState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitDetail.Customize.State
{
  [Token(Token = "0x20004F1")]
  public class CustomizeStatusState : CustomizeSubState
  {
    [Token(Token = "0x17000390")]
    public override UnitCustomizeStateHandler.SubStateIndices SubStateIndex
    {
      [Token(Token = "0x6001C41"), Address(RVA = "0x2C3342C", Offset = "0x2C3342C", VA = "0x2C3342C", Slot = "21")] get
      {
        return new UnitCustomizeStateHandler.SubStateIndices();
      }
    }

    [Token(Token = "0x17000391")]
    protected override UnitCustomizeStateHandler.SubStateIndices NextSubStateIndex
    {
      [Token(Token = "0x6001C42"), Address(RVA = "0x2C33434", Offset = "0x2C33434", VA = "0x2C33434", Slot = "22")] get
      {
        return new UnitCustomizeStateHandler.SubStateIndices();
      }
    }

    [Token(Token = "0x17000392")]
    protected override UnitCustomizeStateHandler.SubStateIndices PrevSubStateIndex
    {
      [Token(Token = "0x6001C43"), Address(RVA = "0x2C3343C", Offset = "0x2C3343C", VA = "0x2C3343C", Slot = "23")] get
      {
        return new UnitCustomizeStateHandler.SubStateIndices();
      }
    }

    [Token(Token = "0x6001C44")]
    [Address(RVA = "0x2C33444", Offset = "0x2C33444", VA = "0x2C33444", Slot = "9")]
    public override void OnBack()
    {
    }

    [Token(Token = "0x6001C45")]
    [Address(RVA = "0x2C30040", Offset = "0x2C30040", VA = "0x2C30040")]
    public CustomizeStatusState()
    {
    }
  }
}
