// Decompiled with JetBrains decompiler
// Type: UnitView.UI.FooterFunctions.ChangeUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitView.UI.FooterFunctions
{
  [Token(Token = "0x200040E")]
  [Serializable]
  public class ChangeUnit : IFunction
  {
    [Token(Token = "0x4001710")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject changeUnitRoot;
    [Token(Token = "0x4001711")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button left;
    [Token(Token = "0x4001712")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button right;
    [Token(Token = "0x4001713")]
    [FieldOffset(Offset = "0x28")]
    private ChangeUnit.IEventListener listener;

    [Token(Token = "0x600170D")]
    [Address(RVA = "0x248A304", Offset = "0x248A304", VA = "0x248A304")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600170E")]
    [Address(RVA = "0x248A3F4", Offset = "0x248A3F4", VA = "0x248A3F4")]
    public void Register(ChangeUnit.IEventListener listener)
    {
    }

    [Token(Token = "0x600170F")]
    [Address(RVA = "0x248A3FC", Offset = "0x248A3FC", VA = "0x248A3FC")]
    private void OnSelectLeft()
    {
    }

    [Token(Token = "0x6001710")]
    [Address(RVA = "0x248A49C", Offset = "0x248A49C", VA = "0x248A49C")]
    private void OnSelectRight()
    {
    }

    [Token(Token = "0x6001711")]
    [Address(RVA = "0x248A540", Offset = "0x248A540", VA = "0x248A540", Slot = "4")]
    private void UnitView\u002EUI\u002EFooterFunctions\u002EIFunction\u002EShow()
    {
    }

    [Token(Token = "0x6001712")]
    [Address(RVA = "0x248A560", Offset = "0x248A560", VA = "0x248A560", Slot = "5")]
    private void UnitView\u002EUI\u002EFooterFunctions\u002EIFunction\u002EHide()
    {
    }

    [Token(Token = "0x6001713")]
    [Address(RVA = "0x24899AC", Offset = "0x24899AC", VA = "0x24899AC")]
    public ChangeUnit()
    {
    }

    [Token(Token = "0x200040F")]
    public interface IEventListener
    {
      [Token(Token = "0x6001714")]
      void OnPrev();

      [Token(Token = "0x6001715")]
      void OnNext();
    }
  }
}
