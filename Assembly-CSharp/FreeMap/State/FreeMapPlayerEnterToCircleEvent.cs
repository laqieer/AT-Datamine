// Decompiled with JetBrains decompiler
// Type: FreeMap.State.FreeMapPlayerEnterToCircleEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.UI;
using FreeMap.UI.ColliderEvent;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State
{
  [Token(Token = "0x2001791")]
  public class FreeMapPlayerEnterToCircleEvent : IFreeMapPlayerInstanceColliderEvent
  {
    [Token(Token = "0x4006844")]
    [FieldOffset(Offset = "0x10")]
    private FreeMapIconEventHandler iconEventHandler;

    [Token(Token = "0x6008594")]
    [Address(RVA = "0x406CB5C", Offset = "0x406CB5C", VA = "0x406CB5C")]
    public FreeMapPlayerEnterToCircleEvent(FreeMapIconEventHandler iconEventHandler)
    {
    }

    [Token(Token = "0x6008595")]
    [Address(RVA = "0x406CB84", Offset = "0x406CB84", VA = "0x406CB84", Slot = "4")]
    public void OnEnter(FreeMapPlayerInstance player, IFreeMapColliderEventObject colliderObject)
    {
    }
  }
}
