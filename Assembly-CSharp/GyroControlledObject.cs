// Decompiled with JetBrains decompiler
// Type: GyroControlledObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002CB")]
public abstract class GyroControlledObject : MonoBehaviour
{
  [Token(Token = "0x6001178")]
  public abstract void OnLerp(float? tX, float? tY);

  [Token(Token = "0x6001179")]
  public abstract void OnControllerStop();

  [Token(Token = "0x600117A")]
  public abstract void OnControllerStart();

  [Token(Token = "0x600117B")]
  [Address(RVA = "0x1BF2EDC", Offset = "0x1BF2EDC", VA = "0x1BF2EDC")]
  protected GyroControlledObject()
  {
  }
}
