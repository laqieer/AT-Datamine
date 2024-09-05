// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.State.CustomizeSkillState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitDetail.Customize.State
{
  [Token(Token = "0x20004F0")]
  public class CustomizeSkillState : CustomizeSubState
  {
    [Token(Token = "0x1700038D")]
    public override UnitCustomizeStateHandler.SubStateIndices SubStateIndex
    {
      [Token(Token = "0x6001C3C"), Address(RVA = "0x2C333B4", Offset = "0x2C333B4", VA = "0x2C333B4", Slot = "21")] get
      {
        return new UnitCustomizeStateHandler.SubStateIndices();
      }
    }

    [Token(Token = "0x1700038E")]
    protected override UnitCustomizeStateHandler.SubStateIndices NextSubStateIndex
    {
      [Token(Token = "0x6001C3D"), Address(RVA = "0x2C333BC", Offset = "0x2C333BC", VA = "0x2C333BC", Slot = "22")] get
      {
        return new UnitCustomizeStateHandler.SubStateIndices();
      }
    }

    [Token(Token = "0x1700038F")]
    protected override UnitCustomizeStateHandler.SubStateIndices PrevSubStateIndex
    {
      [Token(Token = "0x6001C3E"), Address(RVA = "0x2C333C4", Offset = "0x2C333C4", VA = "0x2C333C4", Slot = "23")] get
      {
        return new UnitCustomizeStateHandler.SubStateIndices();
      }
    }

    [Token(Token = "0x6001C3F")]
    [Address(RVA = "0x2C333CC", Offset = "0x2C333CC", VA = "0x2C333CC", Slot = "9")]
    public override void OnBack()
    {
    }

    [Token(Token = "0x6001C40")]
    [Address(RVA = "0x2C3004C", Offset = "0x2C3004C", VA = "0x2C3004C")]
    public CustomizeSkillState()
    {
    }
  }
}
