// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.State.CustomizeEquipmentTopState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnitDetail.Customize.State
{
  [Token(Token = "0x20004EF")]
  public class CustomizeEquipmentTopState : CustomizeSubState
  {
    [Token(Token = "0x1700038A")]
    public override UnitCustomizeStateHandler.SubStateIndices SubStateIndex
    {
      [Token(Token = "0x6001C36"), Address(RVA = "0x2C332C4", Offset = "0x2C332C4", VA = "0x2C332C4", Slot = "21")] get
      {
        return new UnitCustomizeStateHandler.SubStateIndices();
      }
    }

    [Token(Token = "0x1700038B")]
    protected override UnitCustomizeStateHandler.SubStateIndices NextSubStateIndex
    {
      [Token(Token = "0x6001C37"), Address(RVA = "0x2C332CC", Offset = "0x2C332CC", VA = "0x2C332CC", Slot = "22")] get
      {
        return new UnitCustomizeStateHandler.SubStateIndices();
      }
    }

    [Token(Token = "0x1700038C")]
    protected override UnitCustomizeStateHandler.SubStateIndices PrevSubStateIndex
    {
      [Token(Token = "0x6001C38"), Address(RVA = "0x2C332D4", Offset = "0x2C332D4", VA = "0x2C332D4", Slot = "23")] get
      {
        return new UnitCustomizeStateHandler.SubStateIndices();
      }
    }

    [Token(Token = "0x6001C39")]
    [Address(RVA = "0x2C332DC", Offset = "0x2C332DC", VA = "0x2C332DC", Slot = "9")]
    public override void OnBack()
    {
    }

    [Token(Token = "0x6001C3A")]
    [Address(RVA = "0x2C3333C", Offset = "0x2C3333C", VA = "0x2C3333C", Slot = "28")]
    public override void OnSelect(ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x6001C3B")]
    [Address(RVA = "0x2C30044", Offset = "0x2C30044", VA = "0x2C30044")]
    public CustomizeEquipmentTopState()
    {
    }
  }
}
