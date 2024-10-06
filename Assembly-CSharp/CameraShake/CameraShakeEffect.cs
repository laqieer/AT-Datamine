// Decompiled with JetBrains decompiler
// Type: CameraShake.CameraShakeEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace CameraShake
{
  [Token(Token = "0x20021D4")]
  public class CameraShakeEffect : MonoBehaviour
  {
    [Token(Token = "0x4008F22")]
    [FieldOffset(Offset = "0x18")]
    private float mSeedX;
    [Token(Token = "0x4008F23")]
    [FieldOffset(Offset = "0x1C")]
    private float mSeedY;
    [Token(Token = "0x4008F24")]
    [FieldOffset(Offset = "0x20")]
    private float mTime;
    [Token(Token = "0x4008F25")]
    [FieldOffset(Offset = "0x24")]
    public float Duration;
    [Token(Token = "0x4008F26")]
    [FieldOffset(Offset = "0x28")]
    public float FrequencyX;
    [Token(Token = "0x4008F27")]
    [FieldOffset(Offset = "0x2C")]
    public float FrequencyY;
    [Token(Token = "0x4008F28")]
    [FieldOffset(Offset = "0x30")]
    public float AmplitudeX;
    [Token(Token = "0x4008F29")]
    [FieldOffset(Offset = "0x34")]
    public float AmplitudeY;
    [Token(Token = "0x4008F2A")]
    [FieldOffset(Offset = "0x38")]
    private Quaternion initRotation;

    [Token(Token = "0x600CE97")]
    [Address(RVA = "0x4B65020", Offset = "0x4B65020", VA = "0x4B65020")]
    private void Awake()
    {
    }

    [Token(Token = "0x600CE98")]
    [Address(RVA = "0x4B6506C", Offset = "0x4B6506C", VA = "0x4B6506C")]
    private void Update()
    {
    }

    [Token(Token = "0x600CE99")]
    [Address(RVA = "0x4B65120", Offset = "0x4B65120", VA = "0x4B65120")]
    private void OnPreCull()
    {
    }

    [Token(Token = "0x600CE9A")]
    [Address(RVA = "0x4B65398", Offset = "0x4B65398", VA = "0x4B65398")]
    public CameraShakeEffect()
    {
    }
  }
}
