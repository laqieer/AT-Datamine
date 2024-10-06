// Decompiled with JetBrains decompiler
// Type: UniversalRenderPipeline.Volumes.ChromaticAberrationVolume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

#nullable disable
namespace UniversalRenderPipeline.Volumes
{
  [Token(Token = "0x20003B7")]
  [VolumeComponentMenu("Staq/PostProcessing/ChromaticAberration")]
  public class ChromaticAberrationVolume : VolumeComponent, IPostProcessComponent
  {
    [Token(Token = "0x400160A")]
    [FieldOffset(Offset = "0x30")]
    public ClampedFloatParameter size;

    [Token(Token = "0x600159B")]
    [Address(RVA = "0x2482C74", Offset = "0x2482C74", VA = "0x2482C74", Slot = "8")]
    public bool IsActive() => new bool();

    [Token(Token = "0x600159C")]
    [Address(RVA = "0x2482CB0", Offset = "0x2482CB0", VA = "0x2482CB0", Slot = "9")]
    public bool IsTileCompatible() => new bool();

    [Token(Token = "0x17000238")]
    public float Size
    {
      [Token(Token = "0x600159D"), Address(RVA = "0x2482CB8", Offset = "0x2482CB8", VA = "0x2482CB8")] get
      {
        return new float();
      }
      [Token(Token = "0x600159E"), Address(RVA = "0x2482CD8", Offset = "0x2482CD8", VA = "0x2482CD8")] set
      {
      }
    }

    [Token(Token = "0x600159F")]
    [Address(RVA = "0x2482CFC", Offset = "0x2482CFC", VA = "0x2482CFC")]
    public ChromaticAberrationVolume()
    {
    }
  }
}
