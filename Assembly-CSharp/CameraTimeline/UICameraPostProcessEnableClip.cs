// Decompiled with JetBrains decompiler
// Type: CameraTimeline.UICameraPostProcessEnableClip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using staq.Camera;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace CameraTimeline
{
  [Token(Token = "0x20021D7")]
  public class UICameraPostProcessEnableClip : PlayableAsset
  {
    [Token(Token = "0x4008F34")]
    [FieldOffset(Offset = "0x18")]
    [Tag("PostProcessをかけるカメラの Tag を指定します")]
    [SerializeField]
    private string targetCameraTag;
    [Token(Token = "0x4008F35")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool IsForceEnable;

    [Token(Token = "0x600CEA3")]
    [Address(RVA = "0x4B656C0", Offset = "0x4B656C0", VA = "0x4B656C0", Slot = "6")]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
      return new Playable();
    }

    [Token(Token = "0x600CEA4")]
    [Address(RVA = "0x4B657B4", Offset = "0x4B657B4", VA = "0x4B657B4")]
    public UICameraPostProcessEnableClip()
    {
    }
  }
}
