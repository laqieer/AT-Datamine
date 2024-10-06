// Decompiled with JetBrains decompiler
// Type: GameCore.Sound.AkGameObj3rdPersonCam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace GameCore.Sound
{
  [Token(Token = "0x2000C3E")]
  public class AkGameObj3rdPersonCam : AkGameObj
  {
    [Token(Token = "0x4003780")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Transform targetTransform;

    [Token(Token = "0x17000A33")]
    public Transform TargetTransform
    {
      [Token(Token = "0x6004669"), Address(RVA = "0x3516B78", Offset = "0x3516B78", VA = "0x3516B78")] set
      {
      }
    }

    [Token(Token = "0x600466A")]
    [Address(RVA = "0x3516B80", Offset = "0x3516B80", VA = "0x3516B80", Slot = "4")]
    public override Vector3 GetPosition() => new Vector3();

    [Token(Token = "0x600466B")]
    [Address(RVA = "0x3516C0C", Offset = "0x3516C0C", VA = "0x3516C0C")]
    public AkGameObj3rdPersonCam()
    {
    }
  }
}
