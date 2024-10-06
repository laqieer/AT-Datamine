// Decompiled with JetBrains decompiler
// Type: Home.HomeSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Cinemachine;
using GameCore;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Home
{
  [Token(Token = "0x2000B42")]
  public class HomeSet : MonoBehaviour
  {
    [Token(Token = "0x4003389")]
    [FieldOffset(Offset = "0x18")]
    public GameObject CharaPosGroup;
    [Token(Token = "0x400338A")]
    [FieldOffset(Offset = "0x20")]
    public GameObject CameraGroup;
    [Token(Token = "0x400338B")]
    [FieldOffset(Offset = "0x28")]
    public GameObject TouchGroup;
    [Token(Token = "0x400338C")]
    [FieldOffset(Offset = "0x30")]
    public GameObject charaMain;
    [Token(Token = "0x400338D")]
    [FieldOffset(Offset = "0x38")]
    public GameObject charaSub1;
    [Token(Token = "0x400338E")]
    [FieldOffset(Offset = "0x40")]
    public GameObject charaSub2;
    [Token(Token = "0x400338F")]
    [FieldOffset(Offset = "0x48")]
    public GameObject charaSub3;
    [Token(Token = "0x4003390")]
    [FieldOffset(Offset = "0x50")]
    public CinemachineVirtualCamera mainCharaCamera;
    [Token(Token = "0x4003391")]
    [FieldOffset(Offset = "0x58")]
    public CinemachineVirtualCamera sub1CharaCamera;
    [Token(Token = "0x4003392")]
    [FieldOffset(Offset = "0x60")]
    public CinemachineVirtualCamera sub2CharaCamera;
    [Token(Token = "0x4003393")]
    [FieldOffset(Offset = "0x68")]
    public CinemachineVirtualCamera sub3CharaCamera;
    [Token(Token = "0x4003394")]
    [FieldOffset(Offset = "0x70")]
    public CinemachineVirtualCamera loginBonusCamera;
    [Token(Token = "0x4003395")]
    [FieldOffset(Offset = "0x78")]
    public CinemachineVirtualCamera eventMainCamera;
    [Token(Token = "0x4003396")]
    [FieldOffset(Offset = "0x80")]
    public CinemachineVirtualCamera eventPosterCamera;
    [Token(Token = "0x4003397")]
    [FieldOffset(Offset = "0x88")]
    private AppQualitySettings qualitySettings;

    [Token(Token = "0x6004028")]
    [Address(RVA = "0x2A243F8", Offset = "0x2A243F8", VA = "0x2A243F8")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6004029")]
    [Address(RVA = "0x2A244C4", Offset = "0x2A244C4", VA = "0x2A244C4")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600402A")]
    [Address(RVA = "0x2A2454C", Offset = "0x2A2454C", VA = "0x2A2454C")]
    public HomeSet()
    {
    }
  }
}
