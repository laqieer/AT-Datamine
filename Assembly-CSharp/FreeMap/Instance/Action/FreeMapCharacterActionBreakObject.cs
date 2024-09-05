// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Action.FreeMapCharacterActionBreakObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Animation;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance.Action
{
  [Token(Token = "0x2001912")]
  public class FreeMapCharacterActionBreakObject : FreeMapCharacterActionAnimatorBase
  {
    [Token(Token = "0x4006C49")]
    [FieldOffset(Offset = "0x18")]
    public string StateName;
    [Token(Token = "0x4006C4A")]
    private const string StateFlag = "bBreakObject";
    [Token(Token = "0x4006C4C")]
    [FieldOffset(Offset = "0x28")]
    private FreeMapCharacterActionBreakObject.EventReceiver breakReceiver;

    [Token(Token = "0x1400012D")]
    public event FreeMapCharacterActionBreakObject.BreakTimingCallback OnBreak
    {
      [Token(Token = "0x6008E91"), Address(RVA = "0x4B029E0", Offset = "0x4B029E0", VA = "0x4B029E0")] add
      {
      }
      [Token(Token = "0x6008E92"), Address(RVA = "0x4B02A7C", Offset = "0x4B02A7C", VA = "0x4B02A7C")] remove
      {
      }
    }

    [Token(Token = "0x6008E93")]
    [Address(RVA = "0x4B02B18", Offset = "0x4B02B18", VA = "0x4B02B18", Slot = "8")]
    protected override void Enter(FreeMapSideRuntimeAnimatorControl controller)
    {
    }

    [Token(Token = "0x6008E94")]
    [Address(RVA = "0x4B02DD8", Offset = "0x4B02DD8", VA = "0x4B02DD8", Slot = "9")]
    public override bool Execute(FreeMapCharacterAnimatorMotion motion, float deltaTime)
    {
      return new bool();
    }

    [Token(Token = "0x6008E95")]
    [Address(RVA = "0x4B02E58", Offset = "0x4B02E58", VA = "0x4B02E58", Slot = "11")]
    protected override void Exit(FreeMapSideRuntimeAnimatorControl controller)
    {
    }

    [Token(Token = "0x6008E96")]
    [Address(RVA = "0x4B03004", Offset = "0x4B03004", VA = "0x4B03004", Slot = "12")]
    public override bool IsMatchAnimationName(string boolName, string stateName) => new bool();

    [Token(Token = "0x6008E97")]
    [Address(RVA = "0x4B03088", Offset = "0x4B03088", VA = "0x4B03088")]
    private void BreakObjectAnimeEvent()
    {
    }

    [Token(Token = "0x6008E98")]
    [Address(RVA = "0x4B030A4", Offset = "0x4B030A4", VA = "0x4B030A4")]
    public FreeMapCharacterActionBreakObject()
    {
    }

    [Token(Token = "0x2001913")]
    public delegate void BreakTimingCallback();

    [Token(Token = "0x2001914")]
    private class EventReceiver : MonoBehaviour
    {
      [Token(Token = "0x1400012E")]
      public event FreeMapCharacterActionBreakObject.BreakTimingCallback BreakTimingEvent
      {
        [Token(Token = "0x6008E9D"), Address(RVA = "0x4B02D3C", Offset = "0x4B02D3C", VA = "0x4B02D3C")] add
        {
        }
        [Token(Token = "0x6008E9E"), Address(RVA = "0x4B02F68", Offset = "0x4B02F68", VA = "0x4B02F68")] remove
        {
        }
      }

      [Token(Token = "0x6008E9F")]
      [Address(RVA = "0x4B03134", Offset = "0x4B03134", VA = "0x4B03134")]
      private void BreakTiming()
      {
      }

      [Token(Token = "0x6008EA0")]
      [Address(RVA = "0x4B03150", Offset = "0x4B03150", VA = "0x4B03150")]
      public EventReceiver()
      {
      }
    }
  }
}
