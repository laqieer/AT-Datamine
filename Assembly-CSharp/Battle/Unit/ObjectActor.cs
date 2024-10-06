// Decompiled with JetBrains decompiler
// Type: Battle.Unit.ObjectActor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Unit
{
  [Token(Token = "0x20022EA")]
  public class ObjectActor : Actor
  {
    [Token(Token = "0x600D581")]
    [Address(RVA = "0x1D15064", Offset = "0x1D15064", VA = "0x1D15064", Slot = "47")]
    protected override void InitializeInternal(
      IActorViewData actorViewData,
      BattleConfigAsset config)
    {
    }

    [Token(Token = "0x600D582")]
    [Address(RVA = "0x1D15068", Offset = "0x1D15068", VA = "0x1D15068", Slot = "48")]
    protected override void InternalPlayAnimation(
      Actor.AnimationType animation,
      Actor.Direction direction,
      bool resetTime)
    {
    }

    [Token(Token = "0x600D583")]
    [Address(RVA = "0x1D1506C", Offset = "0x1D1506C", VA = "0x1D1506C", Slot = "66")]
    public override void PlayDefaultAnimation()
    {
    }

    [Token(Token = "0x600D584")]
    [Address(RVA = "0x1D15070", Offset = "0x1D15070", VA = "0x1D15070")]
    public ObjectActor()
    {
    }
  }
}
