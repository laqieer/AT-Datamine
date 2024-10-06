// Decompiled with JetBrains decompiler
// Type: FreeMap.Sound.AudioListenerConrtol
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
namespace FreeMap.Sound
{
  [Token(Token = "0x2001843")]
  public class AudioListenerConrtol : 
    IFreeMapManagerAudioListenerAccess,
    IFreeMapRegistBackgroundCamera
  {
    [Token(Token = "0x40069D8")]
    [FieldOffset(Offset = "0x10")]
    private Camera cameraRef;
    [Token(Token = "0x40069D9")]
    [FieldOffset(Offset = "0x18")]
    private Transform targetRef;
    [Token(Token = "0x40069DA")]
    [FieldOffset(Offset = "0x20")]
    private float interpolationRate;
    [Token(Token = "0x40069DB")]
    [FieldOffset(Offset = "0x24")]
    private float currentInterpolationRate;
    [Token(Token = "0x40069DC")]
    [FieldOffset(Offset = "0x28")]
    private float changeInterpolationRateTime;
    [Token(Token = "0x40069DD")]
    [FieldOffset(Offset = "0x2C")]
    private float changeRateSpeed;
    [Token(Token = "0x40069DE")]
    [FieldOffset(Offset = "0x30")]
    private Vector3 listenerPointOffset;
    [Token(Token = "0x40069DF")]
    [FieldOffset(Offset = "0x3C")]
    private Vector3 currentListenerPointOffset;
    [Token(Token = "0x40069E0")]
    [FieldOffset(Offset = "0x48")]
    private float changeOffsetSpeed;
    [Token(Token = "0x40069E1")]
    [FieldOffset(Offset = "0x50")]
    private AkAudioListener lis;
    [Token(Token = "0x40069E2")]
    [FieldOffset(Offset = "0x58")]
    private GameObject gobj;
    [Token(Token = "0x40069E3")]
    private const string GAMEOBJECTNAME = "AudioListenerControll";

    [Token(Token = "0x600893E")]
    [Address(RVA = "0x43E3064", Offset = "0x43E3064", VA = "0x43E3064")]
    public AudioListenerConrtol()
    {
    }

    [Token(Token = "0x600893F")]
    [Address(RVA = "0x43E306C", Offset = "0x43E306C", VA = "0x43E306C")]
    public AudioListenerConrtol(Scene spawnScene)
    {
    }

    [Token(Token = "0x6008940")]
    [Address(RVA = "0x43E328C", Offset = "0x43E328C", VA = "0x43E328C")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6008941")]
    [Address(RVA = "0x43E3318", Offset = "0x43E3318", VA = "0x43E3318", Slot = "4")]
    public void SetTargetCamera(Camera cameraRef)
    {
    }

    [Token(Token = "0x6008942")]
    [Address(RVA = "0x43E3320", Offset = "0x43E3320", VA = "0x43E3320", Slot = "5")]
    public void SetTargetTransfrom(Transform targetRef)
    {
    }

    [Token(Token = "0x6008943")]
    [Address(RVA = "0x43E3328", Offset = "0x43E3328", VA = "0x43E3328")]
    public void SetAudioLisntenerEnable(bool enable)
    {
    }

    [Token(Token = "0x6008944")]
    [Address(RVA = "0x43E33C0", Offset = "0x43E33C0", VA = "0x43E33C0", Slot = "8")]
    public void AudioListenerUpdate()
    {
    }

    [Token(Token = "0x6008945")]
    [Address(RVA = "0x43E3644", Offset = "0x43E3644", VA = "0x43E3644", Slot = "6")]
    public void SetListenerPointParam(float rate, Vector3 offset)
    {
    }

    [Token(Token = "0x6008946")]
    [Address(RVA = "0x43E3658", Offset = "0x43E3658", VA = "0x43E3658", Slot = "7")]
    public void ChangeInterpolationRate(float rate, Vector3 offset, float time)
    {
    }

    [Token(Token = "0x6008947")]
    [Address(RVA = "0x43E3728", Offset = "0x43E3728", VA = "0x43E3728", Slot = "9")]
    public void RegistCamera(Camera camera)
    {
    }

    [Token(Token = "0x6008948")]
    [Address(RVA = "0x43E3730", Offset = "0x43E3730", VA = "0x43E3730", Slot = "10")]
    public void ExcludeCamera()
    {
    }
  }
}
