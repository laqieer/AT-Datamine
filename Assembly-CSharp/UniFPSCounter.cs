// Decompiled with JetBrains decompiler
// Type: UniFPSCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200031C")]
public class UniFPSCounter : MonoBehaviour
{
  [Token(Token = "0x4001290")]
  [FieldOffset(Offset = "0x18")]
  private int screenLongSide;
  [Token(Token = "0x4001291")]
  [FieldOffset(Offset = "0x1C")]
  private Rect boxRect;
  [Token(Token = "0x4001292")]
  [FieldOffset(Offset = "0x30")]
  private GUIStyle style;
  [Token(Token = "0x4001293")]
  [FieldOffset(Offset = "0x38")]
  private int frameCount;
  [Token(Token = "0x4001294")]
  [FieldOffset(Offset = "0x3C")]
  private float elapsedTime;
  [Token(Token = "0x4001295")]
  [FieldOffset(Offset = "0x40")]
  private double frameRate;

  [Token(Token = "0x60012AD")]
  [Address(RVA = "0x285C370", Offset = "0x285C370", VA = "0x285C370")]
  private void Awake()
  {
  }

  [Token(Token = "0x60012AE")]
  [Address(RVA = "0x285C4EC", Offset = "0x285C4EC", VA = "0x285C4EC")]
  private void Update()
  {
  }

  [Token(Token = "0x60012AF")]
  [Address(RVA = "0x285C3E4", Offset = "0x285C3E4", VA = "0x285C3E4")]
  private void UpdateUISize()
  {
  }

  [Token(Token = "0x60012B0")]
  [Address(RVA = "0x285C5D4", Offset = "0x285C5D4", VA = "0x285C5D4")]
  private void OnGUI()
  {
  }

  [Token(Token = "0x60012B1")]
  [Address(RVA = "0x285C6E0", Offset = "0x285C6E0", VA = "0x285C6E0")]
  public UniFPSCounter()
  {
  }
}
