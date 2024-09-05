// Decompiled with JetBrains decompiler
// Type: FPSCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000B7")]
public class FPSCounter : MonoBehaviour
{
  [Token(Token = "0x40002F9")]
  [FieldOffset(Offset = "0x18")]
  private GUIStyle style;
  [Token(Token = "0x40002FA")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private float m_updateInterval;
  [Token(Token = "0x40002FB")]
  [FieldOffset(Offset = "0x24")]
  private float m_accum;
  [Token(Token = "0x40002FC")]
  [FieldOffset(Offset = "0x28")]
  private int m_frames;
  [Token(Token = "0x40002FD")]
  [FieldOffset(Offset = "0x2C")]
  private float m_timeleft;
  [Token(Token = "0x40002FE")]
  [FieldOffset(Offset = "0x30")]
  private float m_fps;

  [Token(Token = "0x6000597")]
  [Address(RVA = "0x44B46B0", Offset = "0x44B46B0", VA = "0x44B46B0")]
  private void Start()
  {
  }

  [Token(Token = "0x6000598")]
  [Address(RVA = "0x44B4794", Offset = "0x44B4794", VA = "0x44B4794")]
  private void Update()
  {
  }

  [Token(Token = "0x6000599")]
  [Address(RVA = "0x44B4814", Offset = "0x44B4814", VA = "0x44B4814")]
  private void OnGUI()
  {
  }

  [Token(Token = "0x600059A")]
  [Address(RVA = "0x44B4908", Offset = "0x44B4908", VA = "0x44B4908")]
  public FPSCounter()
  {
  }
}
