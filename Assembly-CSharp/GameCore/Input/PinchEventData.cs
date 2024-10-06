// Decompiled with JetBrains decompiler
// Type: GameCore.Input.PinchEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.Input
{
  [Token(Token = "0x2001452")]
  public struct PinchEventData
  {
    [Token(Token = "0x4005DAD")]
    [FieldOffset(Offset = "0x0")]
    public Vector2 startPinchCenter;
    [Token(Token = "0x4005DAE")]
    [FieldOffset(Offset = "0x8")]
    public Vector2 distance;
    [Token(Token = "0x4005DAF")]
    [FieldOffset(Offset = "0x10")]
    public bool isPinchOut;
  }
}
