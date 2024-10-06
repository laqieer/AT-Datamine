// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenUV
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Tween.Tweeners
{
  [Token(Token = "0x200051D")]
  [AddComponentMenu("Tween/Tweeners/Tween UV")]
  public class TweenUV : UITweener
  {
    [Token(Token = "0x4001B38")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Vector2 fromOffset;
    [Token(Token = "0x4001B39")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Vector2 fromTiling;
    [Token(Token = "0x4001B3A")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Vector2 toOffset;
    [Token(Token = "0x4001B3B")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Vector2 toTiling;
    [Token(Token = "0x4001B3C")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private string shaderPropatyName;
    [Token(Token = "0x4001B3D")]
    [FieldOffset(Offset = "0x90")]
    private bool cached;
    [Token(Token = "0x4001B3E")]
    [FieldOffset(Offset = "0x98")]
    private Material[] materials;

    [Token(Token = "0x170003E3")]
    public Vector2 FromOffset
    {
      [Token(Token = "0x6001DA0"), Address(RVA = "0x29FAB9C", Offset = "0x29FAB9C", VA = "0x29FAB9C")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001DA1"), Address(RVA = "0x29FABA4", Offset = "0x29FABA4", VA = "0x29FABA4")] set
      {
      }
    }

    [Token(Token = "0x170003E4")]
    public Vector2 FromTiling
    {
      [Token(Token = "0x6001DA2"), Address(RVA = "0x29FABAC", Offset = "0x29FABAC", VA = "0x29FABAC")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001DA3"), Address(RVA = "0x29FABB4", Offset = "0x29FABB4", VA = "0x29FABB4")] set
      {
      }
    }

    [Token(Token = "0x170003E5")]
    public Vector2 ToOffset
    {
      [Token(Token = "0x6001DA4"), Address(RVA = "0x29FABBC", Offset = "0x29FABBC", VA = "0x29FABBC")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001DA5"), Address(RVA = "0x29FABC4", Offset = "0x29FABC4", VA = "0x29FABC4")] set
      {
      }
    }

    [Token(Token = "0x170003E6")]
    public Vector2 ToTiling
    {
      [Token(Token = "0x6001DA6"), Address(RVA = "0x29FABCC", Offset = "0x29FABCC", VA = "0x29FABCC")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6001DA7"), Address(RVA = "0x29FABD4", Offset = "0x29FABD4", VA = "0x29FABD4")] set
      {
      }
    }

    [Token(Token = "0x170003E7")]
    public string ShaderPropatyName
    {
      [Token(Token = "0x6001DA8"), Address(RVA = "0x29FABDC", Offset = "0x29FABDC", VA = "0x29FABDC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6001DA9"), Address(RVA = "0x29FABE4", Offset = "0x29FABE4", VA = "0x29FABE4")] set
      {
      }
    }

    [Token(Token = "0x170003E8")]
    private Material[] Materials
    {
      [Token(Token = "0x6001DAA"), Address(RVA = "0x29FABEC", Offset = "0x29FABEC", VA = "0x29FABEC")] get
      {
        return (Material[]) null;
      }
    }

    [Token(Token = "0x6001DAB")]
    [Address(RVA = "0x29FAC10", Offset = "0x29FAC10", VA = "0x29FAC10")]
    private void Cache()
    {
    }

    [Token(Token = "0x6001DAC")]
    [Address(RVA = "0x29FAD50", Offset = "0x29FAD50", VA = "0x29FAD50", Slot = "8")]
    protected override void OnUpdate(float factor, bool isFinished)
    {
    }

    [Token(Token = "0x6001DAD")]
    [Address(RVA = "0x29FAE4C", Offset = "0x29FAE4C", VA = "0x29FAE4C")]
    private void UpdateMaterial(Material material, Vector2 offset, Vector2 scale)
    {
    }

    [Token(Token = "0x6001DAE")]
    [Address(RVA = "0x29FAEA4", Offset = "0x29FAEA4", VA = "0x29FAEA4")]
    public TweenUV()
    {
    }
  }
}
