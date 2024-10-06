// Decompiled with JetBrains decompiler
// Type: CameraTimeline.UICameraPostProcessEnableBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using staq.Camera;
using UnityEngine.Playables;

#nullable disable
namespace CameraTimeline
{
  [Token(Token = "0x20021D6")]
  public class UICameraPostProcessEnableBehaviour : PlayableBehaviour
  {
    [Token(Token = "0x4008F30")]
    [FieldOffset(Offset = "0x10")]
    public string TargetCameraTag;
    [Token(Token = "0x4008F31")]
    [FieldOffset(Offset = "0x18")]
    public bool IsForceEnable;
    [Token(Token = "0x4008F32")]
    [FieldOffset(Offset = "0x20")]
    private CameraStackManager cameraStackManager;
    [Token(Token = "0x4008F33")]
    [FieldOffset(Offset = "0x28")]
    private AppQualitySettings appQualitySettings;

    [Token(Token = "0x600CE9D")]
    [Address(RVA = "0x4B654A4", Offset = "0x4B654A4", VA = "0x4B654A4", Slot = "21")]
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
    }

    [Token(Token = "0x600CE9E")]
    [Address(RVA = "0x4B65584", Offset = "0x4B65584", VA = "0x4B65584", Slot = "18")]
    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x600CE9F")]
    [Address(RVA = "0x4B655B0", Offset = "0x4B655B0", VA = "0x4B655B0", Slot = "14")]
    public override void OnGraphStop(Playable playable)
    {
    }

    [Token(Token = "0x600CEA0")]
    [Address(RVA = "0x4B654B4", Offset = "0x4B654B4", VA = "0x4B654B4")]
    private void Start()
    {
    }

    [Token(Token = "0x600CEA1")]
    [Address(RVA = "0x4B655DC", Offset = "0x4B655DC", VA = "0x4B655DC")]
    private bool IsActive() => new bool();

    [Token(Token = "0x600CEA2")]
    [Address(RVA = "0x4B65670", Offset = "0x4B65670", VA = "0x4B65670")]
    public UICameraPostProcessEnableBehaviour()
    {
    }
  }
}
