// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.State.SubStateWeaponsTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnitEquipmentView.UI;

#nullable disable
namespace UnitEquipmentView.State
{
  [Token(Token = "0x200048C")]
  public class SubStateWeaponsTop : SubState
  {
    [Token(Token = "0x17000315")]
    public override bool IsLockedPanelChange
    {
      [Token(Token = "0x600198C"), Address(RVA = "0x2C2223C", Offset = "0x2C2223C", VA = "0x2C2223C", Slot = "16")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600198D")]
    [Address(RVA = "0x2C22244", Offset = "0x2C22244", VA = "0x2C22244", Slot = "15")]
    protected override StateHandler.SubStateIndex GetSubStateIndex()
    {
      return new StateHandler.SubStateIndex();
    }

    [Token(Token = "0x600198E")]
    [Address(RVA = "0x2C2224C", Offset = "0x2C2224C", VA = "0x2C2224C", Slot = "5")]
    protected override void OnEnter(UnitEquipmentModify entity)
    {
    }

    [Token(Token = "0x600198F")]
    [Address(RVA = "0x2C22318", Offset = "0x2C22318", VA = "0x2C22318", Slot = "6")]
    public override void Execute(UnitEquipmentModify entity, float deltaTime)
    {
    }

    [Token(Token = "0x6001990")]
    [Address(RVA = "0x2C2231C", Offset = "0x2C2231C", VA = "0x2C2231C", Slot = "7")]
    public override void Exit(UnitEquipmentModify entity)
    {
    }

    [Token(Token = "0x6001991")]
    [Address(RVA = "0x2C22320", Offset = "0x2C22320", VA = "0x2C22320", Slot = "18")]
    public override void OnSelectBelongingsItem(ItemEasyDataUI item)
    {
    }

    [Token(Token = "0x6001992")]
    [Address(RVA = "0x2C2239C", Offset = "0x2C2239C", VA = "0x2C2239C", Slot = "19")]
    public override void OnSelectEquippedItem(ItemEasyDataUI selectEquippedItem)
    {
    }

    [Token(Token = "0x6001993")]
    [Address(RVA = "0x2C223F0", Offset = "0x2C223F0", VA = "0x2C223F0", Slot = "17")]
    public override void OnBack()
    {
    }

    [Token(Token = "0x6001994")]
    [Address(RVA = "0x2C2106C", Offset = "0x2C2106C", VA = "0x2C2106C")]
    public SubStateWeaponsTop()
    {
    }
  }
}
