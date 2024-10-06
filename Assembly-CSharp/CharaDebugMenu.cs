// Decompiled with JetBrains decompiler
// Type: CharaDebugMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000302")]
public class CharaDebugMenu : MonoBehaviour
{
  [Token(Token = "0x40011C8")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private GameObject camera;
  [Token(Token = "0x40011C9")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  private GameObject dirLight;
  [Token(Token = "0x40011CA")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  private GameObject changeMenu;
  [Token(Token = "0x40011CB")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private Slider fovChange;
  [Token(Token = "0x40011CC")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  private Slider lightRot;
  [Token(Token = "0x40011CD")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private Text fovText;
  [Token(Token = "0x40011CE")]
  [FieldOffset(Offset = "0x48")]
  [SerializeField]
  private Text lightText;
  [Token(Token = "0x40011CF")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  private Camera cam;
  [Token(Token = "0x40011D0")]
  [FieldOffset(Offset = "0x58")]
  [SerializeField]
  private Light light;
  [Token(Token = "0x40011D1")]
  [FieldOffset(Offset = "0x60")]
  private float rotAngle;
  [Token(Token = "0x40011D2")]
  [FieldOffset(Offset = "0x64")]
  private Vector2 pivotPoint;

  [Token(Token = "0x600125D")]
  [Address(RVA = "0x27E079C", Offset = "0x27E079C", VA = "0x27E079C")]
  private void Start()
  {
  }

  [Token(Token = "0x600125E")]
  [Address(RVA = "0x27E0838", Offset = "0x27E0838", VA = "0x27E0838")]
  public void ResetCamera()
  {
  }

  [Token(Token = "0x600125F")]
  [Address(RVA = "0x27E0974", Offset = "0x27E0974", VA = "0x27E0974")]
  public void RotationLight()
  {
  }

  [Token(Token = "0x6001260")]
  [Address(RVA = "0x27E0A5C", Offset = "0x27E0A5C", VA = "0x27E0A5C")]
  public void SetCameraFov()
  {
  }

  [Token(Token = "0x6001261")]
  [Address(RVA = "0x27E0B24", Offset = "0x27E0B24", VA = "0x27E0B24")]
  public void ShowCharaMenu()
  {
  }

  [Token(Token = "0x6001262")]
  [Address(RVA = "0x27E0B44", Offset = "0x27E0B44", VA = "0x27E0B44")]
  private void OnGUI()
  {
  }

  [Token(Token = "0x6001263")]
  [Address(RVA = "0x27E0CC0", Offset = "0x27E0CC0", VA = "0x27E0CC0")]
  public CharaDebugMenu()
  {
  }
}
