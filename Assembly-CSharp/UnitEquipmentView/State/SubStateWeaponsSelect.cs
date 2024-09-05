// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.State.SubStateWeaponsSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnitEquipmentView.UI;

#nullable disable
namespace UnitEquipmentView.State
{
  [Token(Token = "0x200048B")]
  public class SubStateWeaponsSelect : SubState
  {
    [Token(Token = "0x600197F")]
    [Address(RVA = "0x2C21BD8", Offset = "0x2C21BD8", VA = "0x2C21BD8", Slot = "15")]
    protected override StateHandler.SubStateIndex GetSubStateIndex()
    {
      return new StateHandler.SubStateIndex();
    }

    [Token(Token = "0x6001980")]
    [Address(RVA = "0x2C21BE0", Offset = "0x2C21BE0", VA = "0x2C21BE0", Slot = "6")]
    public override void Execute(UnitEquipmentModify entity, float deltaTime)
    {
    }

    [Token(Token = "0x6001981")]
    [Address(RVA = "0x2C21BE4", Offset = "0x2C21BE4", VA = "0x2C21BE4", Slot = "7")]
    public override void Exit(UnitEquipmentModify entity)
    {
    }

    [Token(Token = "0x6001982")]
    [Address(RVA = "0x2C21BE8", Offset = "0x2C21BE8", VA = "0x2C21BE8", Slot = "20")]
    public override void OnUpdateEquipItem(ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x6001983")]
    [Address(RVA = "0x2C21D08", Offset = "0x2C21D08", VA = "0x2C21D08", Slot = "18")]
    public override void OnSelectBelongingsItem(ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x6001984")]
    [Address(RVA = "0x2C21E20", Offset = "0x2C21E20", VA = "0x2C21E20", Slot = "19")]
    public override void OnSelectEquippedItem(ItemEasyDataUI selectEquippedItem)
    {
    }

    [Token(Token = "0x6001985")]
    [Address(RVA = "0x2C21F9C", Offset = "0x2C21F9C", VA = "0x2C21F9C")]
    private void ReselectEquipped(ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x6001986")]
    [Address(RVA = "0x2C21DB4", Offset = "0x2C21DB4", VA = "0x2C21DB4")]
    private void ReselectBelongingItem(ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x6001987")]
    [Address(RVA = "0x2C21FFC", Offset = "0x2C21FFC", VA = "0x2C21FFC", Slot = "21")]
    protected override void OnSelectInventoryItem(ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x6001988")]
    [Address(RVA = "0x2C221D8", Offset = "0x2C221D8", VA = "0x2C221D8")]
    private void ExchangeDirect()
    {
    }

    [Token(Token = "0x6001989")]
    [Address(RVA = "0x2C21FDC", Offset = "0x2C21FDC", VA = "0x2C21FDC")]
    private void ExchangeCompared()
    {
    }

    [Token(Token = "0x600198A")]
    [Address(RVA = "0x2C22214", Offset = "0x2C22214", VA = "0x2C22214", Slot = "17")]
    public override void OnBack()
    {
    }

    [Token(Token = "0x600198B")]
    [Address(RVA = "0x2C21070", Offset = "0x2C21070", VA = "0x2C21070")]
    public SubStateWeaponsSelect()
    {
    }
  }
}
