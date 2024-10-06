// Decompiled with JetBrains decompiler
// Type: EyeBlendShapesController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000D0")]
[Serializable]
public class EyeBlendShapesController : MonoBehaviour
{
  [Token(Token = "0x4000375")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  protected SkinnedMeshRenderer eyeRenderer;
  [Token(Token = "0x4000376")]
  [FieldOffset(Offset = "0x20")]
  protected Transform rootTransform;
  [Token(Token = "0x4000377")]
  [FieldOffset(Offset = "0x28")]
  protected Transform baseTransform;
  [Token(Token = "0x4000378")]
  [FieldOffset(Offset = "0x30")]
  protected Transform lookTransform;
  [Token(Token = "0x4000379")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  protected Vector3 lookForward;
  [Token(Token = "0x400037A")]
  [FieldOffset(Offset = "0x44")]
  [SerializeField]
  protected float lookAngleCoefL;
  [Token(Token = "0x400037B")]
  [FieldOffset(Offset = "0x48")]
  [SerializeField]
  protected float lookAngleCoefR;
  [Token(Token = "0x400037C")]
  [FieldOffset(Offset = "0x4C")]
  [SerializeField]
  protected float lookAngleCoefU;
  [Token(Token = "0x400037D")]
  [FieldOffset(Offset = "0x50")]
  [SerializeField]
  protected float lookAngleCoefD;
  [Token(Token = "0x400037E")]
  [FieldOffset(Offset = "0x58")]
  [SerializeField]
  protected EyeBlendShapesController.FloatRange lookAngleRangeV;
  [Token(Token = "0x400037F")]
  [FieldOffset(Offset = "0x60")]
  [SerializeField]
  protected EyeBlendShapesController.FloatRange lookAngleRangeH;
  [Token(Token = "0x4000380")]
  [FieldOffset(Offset = "0x68")]
  [SerializeField]
  protected Transform lookTarget;
  [Token(Token = "0x4000381")]
  [FieldOffset(Offset = "0x70")]
  [SerializeField]
  [Range(0.0f, 1f)]
  protected float hilightScale;
  [Token(Token = "0x4000382")]
  [FieldOffset(Offset = "0x74")]
  [SerializeField]
  protected float hilightShiningSpeed;
  [Token(Token = "0x4000383")]
  [FieldOffset(Offset = "0x78")]
  protected float hilightShining;
  [Token(Token = "0x4000384")]
  [FieldOffset(Offset = "0x7C")]
  [Range(0.0f, 1f)]
  [SerializeField]
  protected float eyeScale;
  [Token(Token = "0x4000385")]
  [FieldOffset(Offset = "0x80")]
  [Range(0.0f, 1f)]
  [SerializeField]
  protected float pupilsScale;

  [Token(Token = "0x1700004A")]
  public SkinnedMeshRenderer EyeRenderer
  {
    [Token(Token = "0x600060D"), Address(RVA = "0x417EA10", Offset = "0x417EA10", VA = "0x417EA10")] set
    {
    }
    [Token(Token = "0x600060E"), Address(RVA = "0x417ECF8", Offset = "0x417ECF8", VA = "0x417ECF8")] get
    {
      return (SkinnedMeshRenderer) null;
    }
  }

  [Token(Token = "0x1700004B")]
  public Vector3 CenterOffset
  {
    [Token(Token = "0x600060F"), Address(RVA = "0x417ED00", Offset = "0x417ED00", VA = "0x417ED00")] set
    {
    }
  }

  [Token(Token = "0x1700004C")]
  public Vector3 LookForward
  {
    [Token(Token = "0x6000610"), Address(RVA = "0x417ED1C", Offset = "0x417ED1C", VA = "0x417ED1C")] set
    {
    }
  }

  [Token(Token = "0x1700004D")]
  public EyeBlendShapesController.FloatRange LookAngleRangeV
  {
    [Token(Token = "0x6000611"), Address(RVA = "0x417ED58", Offset = "0x417ED58", VA = "0x417ED58")] get
    {
      return (EyeBlendShapesController.FloatRange) null;
    }
  }

  [Token(Token = "0x1700004E")]
  public EyeBlendShapesController.FloatRange LookAngleRangeH
  {
    [Token(Token = "0x6000612"), Address(RVA = "0x417ED60", Offset = "0x417ED60", VA = "0x417ED60")] get
    {
      return (EyeBlendShapesController.FloatRange) null;
    }
  }

  [Token(Token = "0x1700004F")]
  public Vector2 LookAngle
  {
    [Token(Token = "0x6000613"), Address(RVA = "0x417ED68", Offset = "0x417ED68", VA = "0x417ED68")] set
    {
    }
    [Token(Token = "0x6000614"), Address(RVA = "0x417EE28", Offset = "0x417EE28", VA = "0x417EE28")] get
    {
      return new Vector2();
    }
  }

  [Token(Token = "0x17000050")]
  public Transform LookTarget
  {
    [Token(Token = "0x6000615"), Address(RVA = "0x417EE70", Offset = "0x417EE70", VA = "0x417EE70")] set
    {
    }
  }

  [Token(Token = "0x17000051")]
  public float HilightScale
  {
    [Token(Token = "0x6000616"), Address(RVA = "0x417EE78", Offset = "0x417EE78", VA = "0x417EE78")] set
    {
    }
  }

  [Token(Token = "0x17000052")]
  public float HilightShiningSpeed
  {
    [Token(Token = "0x6000617"), Address(RVA = "0x417EEB4", Offset = "0x417EEB4", VA = "0x417EEB4")] set
    {
    }
  }

  [Token(Token = "0x17000053")]
  public float EyeScale
  {
    [Token(Token = "0x6000618"), Address(RVA = "0x417EEEC", Offset = "0x417EEEC", VA = "0x417EEEC")] set
    {
    }
  }

  [Token(Token = "0x17000054")]
  public float PupilsScale
  {
    [Token(Token = "0x6000619"), Address(RVA = "0x417EF28", Offset = "0x417EF28", VA = "0x417EF28")] set
    {
    }
  }

  [Token(Token = "0x600061A")]
  [Address(RVA = "0x417EFC4", Offset = "0x417EFC4", VA = "0x417EFC4")]
  public void SetLookAngleCoef(float left, float right, float up, float down)
  {
  }

  [Token(Token = "0x600061B")]
  [Address(RVA = "0x417EFD0", Offset = "0x417EFD0", VA = "0x417EFD0")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600061C")]
  [Address(RVA = "0x417F0D4", Offset = "0x417F0D4", VA = "0x417F0D4")]
  private void Update()
  {
  }

  [Token(Token = "0x600061D")]
  [Address(RVA = "0x417F2BC", Offset = "0x417F2BC", VA = "0x417F2BC")]
  private void OnDrawGizmos()
  {
  }

  [Token(Token = "0x600061E")]
  [Address(RVA = "0x417F410", Offset = "0x417F410", VA = "0x417F410")]
  public EyeBlendShapesController()
  {
  }

  [Token(Token = "0x20000D1")]
  protected enum BlendShapeIndex
  {
    [Token(Token = "0x4000387")] Mov_L,
    [Token(Token = "0x4000388")] Mov_R,
    [Token(Token = "0x4000389")] Mov_U,
    [Token(Token = "0x400038A")] Mov_D,
    [Token(Token = "0x400038B")] Pu_Small,
    [Token(Token = "0x400038C")] Pu_Open,
    [Token(Token = "0x400038D")] Pu_Close,
    [Token(Token = "0x400038E")] Hi_Fade,
    [Token(Token = "0x400038F")] Hi_All_Shining,
  }

  [Token(Token = "0x20000D2")]
  [Serializable]
  public class FloatRange
  {
    [Token(Token = "0x4000390")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    protected float minValue;
    [Token(Token = "0x4000391")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    protected float maxValue;

    [Token(Token = "0x17000055")]
    public float MinValue
    {
      [Token(Token = "0x600061F"), Address(RVA = "0x417F4A4", Offset = "0x417F4A4", VA = "0x417F4A4")] set
      {
      }
    }

    [Token(Token = "0x17000056")]
    public float MaxValue
    {
      [Token(Token = "0x6000620"), Address(RVA = "0x417F4AC", Offset = "0x417F4AC", VA = "0x417F4AC")] set
      {
      }
    }

    [Token(Token = "0x6000621")]
    [Address(RVA = "0x417EE10", Offset = "0x417EE10", VA = "0x417EE10")]
    public float Round(float value) => new float();

    [Token(Token = "0x6000622")]
    [Address(RVA = "0x417F49C", Offset = "0x417F49C", VA = "0x417F49C")]
    public FloatRange()
    {
    }
  }
}
