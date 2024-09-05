// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2CameraOffset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E0E")]
  public class Adv2CameraOffset : MonoBehaviour
  {
    [Token(Token = "0x4011046")]
    [FieldOffset(Offset = "0x18")]
    private Adv2Object target;
    [Token(Token = "0x4011047")]
    [FieldOffset(Offset = "0x20")]
    private Transform head;
    [Token(Token = "0x4011048")]
    [FieldOffset(Offset = "0x28")]
    private float modelHeightStand;
    [Token(Token = "0x4011049")]
    [FieldOffset(Offset = "0x2C")]
    private float modelHeightSit;

    [Token(Token = "0x17005142")]
    public bool DontCameraOffset
    {
      [Token(Token = "0x6018FAA"), Address(RVA = "0x2CB881C", Offset = "0x2CB881C", VA = "0x2CB881C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018FAB"), Address(RVA = "0x2CB8824", Offset = "0x2CB8824", VA = "0x2CB8824")] set
      {
      }
    }

    [Token(Token = "0x6018FAC")]
    [Address(RVA = "0x2CB7BB8", Offset = "0x2CB7BB8", VA = "0x2CB7BB8")]
    public void Initialize(Adv2Object target)
    {
    }

    [Token(Token = "0x6018FAD")]
    [Address(RVA = "0x2CB7DF4", Offset = "0x2CB7DF4", VA = "0x2CB7DF4")]
    public void SetOffset()
    {
    }

    [Token(Token = "0x6018FAE")]
    [Address(RVA = "0x2CB7FC4", Offset = "0x2CB7FC4", VA = "0x2CB7FC4")]
    public void CopyOffset(Transform target)
    {
    }

    [Token(Token = "0x6018FAF")]
    [Address(RVA = "0x2CB8830", Offset = "0x2CB8830", VA = "0x2CB8830")]
    public Adv2CameraOffset()
    {
    }
  }
}
