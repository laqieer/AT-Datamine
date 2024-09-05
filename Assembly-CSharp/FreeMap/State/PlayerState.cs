// Decompiled with JetBrains decompiler
// Type: FreeMap.State.PlayerState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using FreeMap.State.ModeState;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State
{
  [Token(Token = "0x200179E")]
  public class PlayerState
  {
    [Token(Token = "0x400686D")]
    [FieldOffset(Offset = "0x10")]
    private PlayerControl control;
    [Token(Token = "0x400686E")]
    [FieldOffset(Offset = "0x18")]
    private readonly PlayerControl.Allow allow;
    [Token(Token = "0x400686F")]
    [FieldOffset(Offset = "0x20")]
    private readonly PlayerControl.Disallow disallow;
    [Token(Token = "0x4006870")]
    [FieldOffset(Offset = "0x28")]
    private AutoMoveDriven autoMoveDriven;

    [Token(Token = "0x17001549")]
    public bool IsAllow
    {
      [Token(Token = "0x600860E"), Address(RVA = "0x406EC34", Offset = "0x406EC34", VA = "0x406EC34")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600860F")]
    [Address(RVA = "0x406D134", Offset = "0x406D134", VA = "0x406D134")]
    public PlayerState(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x6008610")]
    [Address(RVA = "0x406D688", Offset = "0x406D688", VA = "0x406D688")]
    public void Update()
    {
    }

    [Token(Token = "0x6008611")]
    [Address(RVA = "0x406D41C", Offset = "0x406D41C", VA = "0x406D41C")]
    public void Allow()
    {
    }

    [Token(Token = "0x6008612")]
    [Address(RVA = "0x406D470", Offset = "0x406D470", VA = "0x406D470")]
    public void Disallow()
    {
    }

    [Token(Token = "0x6008613")]
    [Address(RVA = "0x406DE70", Offset = "0x406DE70", VA = "0x406DE70")]
    public void AutoMove(
      FreeMapStateManager entity,
      FreeMapUIParamBase target,
      IPlayerAreaOperationEvent playerOperation)
    {
    }

    [Token(Token = "0x6008614")]
    [Address(RVA = "0x406DEA0", Offset = "0x406DEA0", VA = "0x406DEA0")]
    public void CancelAutoMove()
    {
    }
  }
}
