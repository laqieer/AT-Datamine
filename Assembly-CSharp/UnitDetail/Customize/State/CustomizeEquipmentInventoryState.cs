// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.State.CustomizeEquipmentInventoryState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace UnitDetail.Customize.State
{
  [Token(Token = "0x20004EE")]
  public class CustomizeEquipmentInventoryState : CustomizeSubState
  {
    [Token(Token = "0x40019E1")]
    [FieldOffset(Offset = "0x20")]
    private bool isConnectApi;

    [Token(Token = "0x17000387")]
    public override UnitCustomizeStateHandler.SubStateIndices SubStateIndex
    {
      [Token(Token = "0x6001C27"), Address(RVA = "0x2C32E78", Offset = "0x2C32E78", VA = "0x2C32E78", Slot = "21")] get
      {
        return new UnitCustomizeStateHandler.SubStateIndices();
      }
    }

    [Token(Token = "0x17000388")]
    protected override UnitCustomizeStateHandler.SubStateIndices NextSubStateIndex
    {
      [Token(Token = "0x6001C28"), Address(RVA = "0x2C32E80", Offset = "0x2C32E80", VA = "0x2C32E80", Slot = "22")] get
      {
        return new UnitCustomizeStateHandler.SubStateIndices();
      }
    }

    [Token(Token = "0x17000389")]
    protected override UnitCustomizeStateHandler.SubStateIndices PrevSubStateIndex
    {
      [Token(Token = "0x6001C29"), Address(RVA = "0x2C32EC0", Offset = "0x2C32EC0", VA = "0x2C32EC0", Slot = "23")] get
      {
        return new UnitCustomizeStateHandler.SubStateIndices();
      }
    }

    [Token(Token = "0x6001C2A")]
    [Address(RVA = "0x2C32F00", Offset = "0x2C32F00", VA = "0x2C32F00", Slot = "5")]
    protected override void OnEnter(UnitDetailStateHandlerBase entity)
    {
    }

    [Token(Token = "0x6001C2B")]
    [Address(RVA = "0x2C32F54", Offset = "0x2C32F54", VA = "0x2C32F54", Slot = "7")]
    public override void Exit(UnitDetailStateHandlerBase entity)
    {
    }

    [Token(Token = "0x6001C2C")]
    [Address(RVA = "0x2C32FB0", Offset = "0x2C32FB0", VA = "0x2C32FB0", Slot = "9")]
    public override void OnBack()
    {
    }

    [Token(Token = "0x6001C2D")]
    [Address(RVA = "0x2C33054", Offset = "0x2C33054", VA = "0x2C33054", Slot = "24")]
    public override void OnFlickUp()
    {
    }

    [Token(Token = "0x6001C2E")]
    [Address(RVA = "0x2C33058", Offset = "0x2C33058", VA = "0x2C33058", Slot = "25")]
    public override void OnFlickDown()
    {
    }

    [Token(Token = "0x6001C2F")]
    [Address(RVA = "0x2C3305C", Offset = "0x2C3305C", VA = "0x2C3305C", Slot = "26")]
    public override void OnFlickLeft()
    {
    }

    [Token(Token = "0x6001C30")]
    [Address(RVA = "0x2C33060", Offset = "0x2C33060", VA = "0x2C33060", Slot = "27")]
    public override void OnFlickRight()
    {
    }

    [Token(Token = "0x6001C31")]
    [Address(RVA = "0x2C33064", Offset = "0x2C33064", VA = "0x2C33064", Slot = "29")]
    public override void OnConfrim(ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x6001C32")]
    [Address(RVA = "0x2C33148", Offset = "0x2C33148", VA = "0x2C33148", Slot = "28")]
    public override void OnSelect(ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x6001C33")]
    [Address(RVA = "0x2C33108", Offset = "0x2C33108", VA = "0x2C33108")]
    private IEnumerator ConnectToEquipAPI(ItemInfoBase itemInfo, Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6001C34")]
    [Address(RVA = "0x2C30048", Offset = "0x2C30048", VA = "0x2C30048")]
    public CustomizeEquipmentInventoryState()
    {
    }
  }
}
