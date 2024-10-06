// Decompiled with JetBrains decompiler
// Type: DuelVirtualCameraSwitchFlowAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x200018A")]
[CreateAssetMenu(menuName = "Duel/Duel Camera Switch Flow Asset")]
public class DuelVirtualCameraSwitchFlowAsset : ScriptableObject
{
  [Token(Token = "0x4000A22")]
  [FieldOffset(Offset = "0x18")]
  public List<DuelVirtualCameraSwitchFlow> availableCameraList;
  [Token(Token = "0x4000A23")]
  [FieldOffset(Offset = "0x20")]
  public List<DuelVirtualCameraSwitchFlow> availableCameraListForEscape;

  [Token(Token = "0x6000AB4")]
  [Address(RVA = "0x4BBA418", Offset = "0x4BBA418", VA = "0x4BBA418")]
  public DuelVirtualCameraSwitchFlow GetRandomVirtualCameraSwitchFlow(bool isHit)
  {
    return (DuelVirtualCameraSwitchFlow) null;
  }

  [Token(Token = "0x6000AB5")]
  [Address(RVA = "0x4BBA5D8", Offset = "0x4BBA5D8", VA = "0x4BBA5D8")]
  public DuelVirtualCameraSwitchFlowAsset()
  {
  }
}
