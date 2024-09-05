// Decompiled with JetBrains decompiler
// Type: DuelVirtualCameraSwitchFlow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x200018C")]
[Serializable]
public class DuelVirtualCameraSwitchFlow
{
  [Token(Token = "0x4000A26")]
  [FieldOffset(Offset = "0x10")]
  public float weight;
  [Token(Token = "0x4000A27")]
  [FieldOffset(Offset = "0x14")]
  public DuelTurnActions.VirtualCameraType attackTimelineStartVC;
  [Token(Token = "0x4000A28")]
  [FieldOffset(Offset = "0x18")]
  public DuelTurnActions.VirtualCameraType escapeStartVC;
  [Token(Token = "0x4000A29")]
  [FieldOffset(Offset = "0x1C")]
  public DuelTurnActions.VirtualCameraType beforeHittingTargetVC;

  [Token(Token = "0x6000AB9")]
  [Address(RVA = "0x4BBA6FC", Offset = "0x4BBA6FC", VA = "0x4BBA6FC")]
  public DuelVirtualCameraSwitchFlow()
  {
  }
}
