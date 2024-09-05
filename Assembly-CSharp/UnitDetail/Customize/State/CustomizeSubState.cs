// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.State.CustomizeSubState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnitDetail.State;

#nullable disable
namespace UnitDetail.Customize.State
{
  [Token(Token = "0x20004F2")]
  public abstract class CustomizeSubState : UnitDetailSubState<UnitCustomizeStateHandler>
  {
    [Token(Token = "0x17000393")]
    public abstract UnitCustomizeStateHandler.SubStateIndices SubStateIndex { [Token(Token = "0x6001C46")] get; }

    [Token(Token = "0x17000394")]
    protected virtual UnitCustomizeStateHandler.SubStateIndices NextSubStateIndex
    {
      [Token(Token = "0x6001C47"), Address(RVA = "0x2C334A4", Offset = "0x2C334A4", VA = "0x2C334A4", Slot = "22")] get
      {
        return new UnitCustomizeStateHandler.SubStateIndices();
      }
    }

    [Token(Token = "0x17000395")]
    protected virtual UnitCustomizeStateHandler.SubStateIndices PrevSubStateIndex
    {
      [Token(Token = "0x6001C48"), Address(RVA = "0x2C334AC", Offset = "0x2C334AC", VA = "0x2C334AC", Slot = "23")] get
      {
        return new UnitCustomizeStateHandler.SubStateIndices();
      }
    }

    [Token(Token = "0x6001C49")]
    [Address(RVA = "0x2C334B4", Offset = "0x2C334B4", VA = "0x2C334B4", Slot = "8")]
    public override int GetStateType() => new int();

    [Token(Token = "0x6001C4A")]
    [Address(RVA = "0x2C334C4", Offset = "0x2C334C4", VA = "0x2C334C4", Slot = "24")]
    public virtual void OnFlickUp()
    {
    }

    [Token(Token = "0x6001C4B")]
    [Address(RVA = "0x2C33590", Offset = "0x2C33590", VA = "0x2C33590", Slot = "25")]
    public virtual void OnFlickDown()
    {
    }

    [Token(Token = "0x6001C4C")]
    [Address(RVA = "0x2C3365C", Offset = "0x2C3365C", VA = "0x2C3365C", Slot = "26")]
    public virtual void OnFlickLeft()
    {
    }

    [Token(Token = "0x6001C4D")]
    [Address(RVA = "0x2C336BC", Offset = "0x2C336BC", VA = "0x2C336BC", Slot = "27")]
    public virtual void OnFlickRight()
    {
    }

    [Token(Token = "0x6001C4E")]
    [Address(RVA = "0x2C3371C", Offset = "0x2C3371C", VA = "0x2C3371C", Slot = "28")]
    public virtual void OnSelect(ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x6001C4F")]
    [Address(RVA = "0x2C33720", Offset = "0x2C33720", VA = "0x2C33720", Slot = "29")]
    public virtual void OnConfrim(ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x6001C50")]
    [Address(RVA = "0x2C331B8", Offset = "0x2C331B8", VA = "0x2C331B8")]
    protected CustomizeSubState()
    {
    }
  }
}
