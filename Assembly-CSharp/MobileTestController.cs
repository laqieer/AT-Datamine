// Decompiled with JetBrains decompiler
// Type: MobileTestController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000BE")]
public class MobileTestController : MonoBehaviour
{
  [Token(Token = "0x4000306")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Vector3 center;
  [Token(Token = "0x4000307")]
  [FieldOffset(Offset = "0x0")]
  private static readonly float DEFAULT_DISTANCE;
  [Token(Token = "0x4000308")]
  [FieldOffset(Offset = "0x4")]
  private static readonly float ROTATE_SPEED;
  [Token(Token = "0x4000309")]
  [FieldOffset(Offset = "0x8")]
  private static readonly float ZOOM_SPEED;
  [Token(Token = "0x400030A")]
  [FieldOffset(Offset = "0x24")]
  private Vector3 startPosition;
  [Token(Token = "0x400030B")]
  [FieldOffset(Offset = "0x30")]
  private Quaternion startRotation;
  [Token(Token = "0x400030C")]
  [FieldOffset(Offset = "0x40")]
  private Transform targetCamera;
  [Token(Token = "0x400030D")]
  [FieldOffset(Offset = "0x48")]
  private Transform targetLight;
  [Token(Token = "0x400030E")]
  [FieldOffset(Offset = "0x50")]
  private bool rotateLight;
  [Token(Token = "0x400030F")]
  [FieldOffset(Offset = "0x58")]
  private GUIStyle buttonStyle;
  [Token(Token = "0x4000310")]
  [FieldOffset(Offset = "0x60")]
  private GUIStyle toggleStyle;

  [Token(Token = "0x60005B0")]
  [Address(RVA = "0x44B55FC", Offset = "0x44B55FC", VA = "0x44B55FC")]
  private void Start()
  {
  }

  [Token(Token = "0x60005B1")]
  [Address(RVA = "0x44B57DC", Offset = "0x44B57DC", VA = "0x44B57DC")]
  private void Update()
  {
  }

  [Token(Token = "0x60005B2")]
  [Address(RVA = "0x44B5CE8", Offset = "0x44B5CE8", VA = "0x44B5CE8")]
  private void OnGUI()
  {
  }

  [Token(Token = "0x60005B3")]
  [Address(RVA = "0x44B5F80", Offset = "0x44B5F80", VA = "0x44B5F80")]
  public MobileTestController()
  {
  }

  [Token(Token = "0x60005B4")]
  [Address(RVA = "0x44B5F98", Offset = "0x44B5F98", VA = "0x44B5F98")]
  static MobileTestController()
  {
  }
}
