// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.EmissionColor.MeshRendererModification
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners.EmissionColor
{
  [Token(Token = "0x2000522")]
  public class MeshRendererModification : RendererModification
  {
    [Token(Token = "0x4001B46")]
    [FieldOffset(Offset = "0x18")]
    private MeshRenderer meshRenderer;

    [Token(Token = "0x170003F1")]
    public override bool IsValid
    {
      [Token(Token = "0x6001DC5"), Address(RVA = "0x29FB374", Offset = "0x29FB374", VA = "0x29FB374", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170003F2")]
    private Material material
    {
      [Token(Token = "0x6001DC6"), Address(RVA = "0x29FB3D4", Offset = "0x29FB3D4", VA = "0x29FB3D4")] get
      {
        return (Material) null;
      }
    }

    [Token(Token = "0x6001DC7")]
    [Address(RVA = "0x29FB3F0", Offset = "0x29FB3F0", VA = "0x29FB3F0")]
    public MeshRendererModification(MeshRenderer meshRenderer)
    {
    }

    [Token(Token = "0x6001DC8")]
    [Address(RVA = "0x29F8720", Offset = "0x29F8720", VA = "0x29F8720")]
    public MeshRendererModification(MonoBehaviour monoBehaviour)
    {
    }

    [Token(Token = "0x6001DC9")]
    [Address(RVA = "0x29FB420", Offset = "0x29FB420", VA = "0x29FB420", Slot = "6")]
    public override void OnEnable()
    {
    }

    [Token(Token = "0x6001DCA")]
    [Address(RVA = "0x29FB480", Offset = "0x29FB480", VA = "0x29FB480", Slot = "7")]
    public override void SetColor(TweenEmissionColor entity, Color value)
    {
    }
  }
}
