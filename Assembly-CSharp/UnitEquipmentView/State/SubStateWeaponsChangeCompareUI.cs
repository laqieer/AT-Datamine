// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.State.SubStateWeaponsChangeCompareUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnitEquipmentView.UI;

#nullable disable
namespace UnitEquipmentView.State
{
  [Token(Token = "0x200048A")]
  public class SubStateWeaponsChangeCompareUI : SubState, WeaponsEquipChangeUI.IUIEvent
  {
    [Token(Token = "0x6001975")]
    [Address(RVA = "0x2C21A0C", Offset = "0x2C21A0C", VA = "0x2C21A0C", Slot = "4")]
    protected override void OnInitialize(UnitEquipmentModify entity)
    {
    }

    [Token(Token = "0x6001976")]
    [Address(RVA = "0x2C21A38", Offset = "0x2C21A38", VA = "0x2C21A38", Slot = "5")]
    protected override void OnEnter(UnitEquipmentModify entity)
    {
    }

    [Token(Token = "0x6001977")]
    [Address(RVA = "0x2C21B1C", Offset = "0x2C21B1C", VA = "0x2C21B1C", Slot = "6")]
    public override void Execute(UnitEquipmentModify entity, float deltaTime)
    {
    }

    [Token(Token = "0x6001978")]
    [Address(RVA = "0x2C21B20", Offset = "0x2C21B20", VA = "0x2C21B20", Slot = "7")]
    public override void Exit(UnitEquipmentModify entity)
    {
    }

    [Token(Token = "0x6001979")]
    [Address(RVA = "0x2C21B48", Offset = "0x2C21B48", VA = "0x2C21B48", Slot = "15")]
    protected override StateHandler.SubStateIndex GetSubStateIndex()
    {
      return new StateHandler.SubStateIndex();
    }

    [Token(Token = "0x600197A")]
    [Address(RVA = "0x2C21B50", Offset = "0x2C21B50", VA = "0x2C21B50", Slot = "24")]
    private void UnitEquipmentView\u002EUI\u002EWeaponsEquipChangeUI\u002EIUIEvent\u002EOnExecute()
    {
    }

    [Token(Token = "0x600197B")]
    [Address(RVA = "0x2C21B8C", Offset = "0x2C21B8C", VA = "0x2C21B8C", Slot = "23")]
    private void UnitEquipmentView\u002EUI\u002EWeaponsEquipChangeUI\u002EIUIEvent\u002EOnCancel()
    {
    }

    [Token(Token = "0x600197C")]
    [Address(RVA = "0x2C21BD4", Offset = "0x2C21BD4", VA = "0x2C21BD4", Slot = "17")]
    public override void OnBack()
    {
    }

    [Token(Token = "0x600197D")]
    [Address(RVA = "0x2C21B90", Offset = "0x2C21B90", VA = "0x2C21B90")]
    private void Cancel()
    {
    }

    [Token(Token = "0x600197E")]
    [Address(RVA = "0x2C21074", Offset = "0x2C21074", VA = "0x2C21074")]
    public SubStateWeaponsChangeCompareUI()
    {
    }
  }
}
