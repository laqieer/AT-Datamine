// Decompiled with JetBrains decompiler
// Type: EyeMaterialController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000D3")]
[Serializable]
public class EyeMaterialController : MonoBehaviour
{
  [Token(Token = "0x4000392")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  protected EyeMaterialController.EyeBall rightEye;
  [Token(Token = "0x4000393")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  protected EyeMaterialController.EyeBall leftEye;
  [Token(Token = "0x4000394")]
  [FieldOffset(Offset = "0x28")]
  [SerializeField]
  protected Transform lookTarget;
  [Token(Token = "0x4000395")]
  [FieldOffset(Offset = "0x30")]
  protected int pupilTexID;

  [Token(Token = "0x17000057")]
  public EyeMaterialController.EyeBall RightEye
  {
    [Token(Token = "0x6000623"), Address(RVA = "0x417F4B4", Offset = "0x417F4B4", VA = "0x417F4B4")] get
    {
      return (EyeMaterialController.EyeBall) null;
    }
  }

  [Token(Token = "0x17000058")]
  public EyeMaterialController.EyeBall LeftEye
  {
    [Token(Token = "0x6000624"), Address(RVA = "0x417F4BC", Offset = "0x417F4BC", VA = "0x417F4BC")] get
    {
      return (EyeMaterialController.EyeBall) null;
    }
  }

  [Token(Token = "0x17000059")]
  public Transform LookTarget
  {
    [Token(Token = "0x6000625"), Address(RVA = "0x417F4C4", Offset = "0x417F4C4", VA = "0x417F4C4")] set
    {
    }
  }

  [Token(Token = "0x6000626")]
  [Address(RVA = "0x417F4CC", Offset = "0x417F4CC", VA = "0x417F4CC")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000627")]
  [Address(RVA = "0x417F51C", Offset = "0x417F51C", VA = "0x417F51C")]
  private void Update()
  {
  }

  [Token(Token = "0x6000628")]
  [Address(RVA = "0x417FDC8", Offset = "0x417FDC8", VA = "0x417FDC8")]
  private void OnDrawGizmos()
  {
  }

  [Token(Token = "0x6000629")]
  [Address(RVA = "0x417FF38", Offset = "0x417FF38", VA = "0x417FF38")]
  public EyeMaterialController()
  {
  }

  [Token(Token = "0x20000D4")]
  [Serializable]
  public class FloatRange
  {
    [Token(Token = "0x4000396")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    protected float minValue;
    [Token(Token = "0x4000397")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    protected float maxValue;

    [Token(Token = "0x1700005A")]
    public float MinValue
    {
      [Token(Token = "0x600062A"), Address(RVA = "0x4180204", Offset = "0x4180204", VA = "0x4180204")] set
      {
      }
    }

    [Token(Token = "0x1700005B")]
    public float MaxValue
    {
      [Token(Token = "0x600062B"), Address(RVA = "0x418020C", Offset = "0x418020C", VA = "0x418020C")] set
      {
      }
    }

    [Token(Token = "0x600062C")]
    [Address(RVA = "0x4180214", Offset = "0x4180214", VA = "0x4180214")]
    public float Round(float value) => new float();

    [Token(Token = "0x600062D")]
    [Address(RVA = "0x418022C", Offset = "0x418022C", VA = "0x418022C")]
    public FloatRange()
    {
    }
  }

  [Token(Token = "0x20000D5")]
  [Serializable]
  public class EyeBall
  {
    [Token(Token = "0x4000398")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    protected SkinnedMeshRenderer eyeRenderer;
    [Token(Token = "0x4000399")]
    [FieldOffset(Offset = "0x18")]
    protected Transform rootTransform;
    [Token(Token = "0x400039A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected Vector3 centerOffset;
    [Token(Token = "0x400039B")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    protected Vector3 baseDirection;
    [Token(Token = "0x400039C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    protected Vector2 lookAngleConvert;
    [Token(Token = "0x400039D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    protected EyeMaterialController.FloatRange lookAngleRangeV;
    [Token(Token = "0x400039E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    protected EyeMaterialController.FloatRange lookAngleRangeH;
    [Token(Token = "0x400039F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    protected Vector2 scalePupil;
    [Token(Token = "0x40003A0")]
    [FieldOffset(Offset = "0x58")]
    protected Vector3 centerWorld;
    [Token(Token = "0x40003A1")]
    [FieldOffset(Offset = "0x64")]
    protected Vector3 baseDirectionWorld;
    [Token(Token = "0x40003A2")]
    [FieldOffset(Offset = "0x70")]
    protected Vector3 targetDirectionWorld;
    [Token(Token = "0x40003A3")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    protected Vector2 lookAngle;

    [Token(Token = "0x1700005C")]
    public SkinnedMeshRenderer EyeRenderer
    {
      [Token(Token = "0x600062E"), Address(RVA = "0x4180234", Offset = "0x4180234", VA = "0x4180234")] set
      {
      }
    }

    [Token(Token = "0x1700005D")]
    public Vector3 CenterOffset
    {
      [Token(Token = "0x600062F"), Address(RVA = "0x41802E8", Offset = "0x41802E8", VA = "0x41802E8")] set
      {
      }
    }

    [Token(Token = "0x1700005E")]
    public Vector3 BaseDirection
    {
      [Token(Token = "0x6000630"), Address(RVA = "0x41802F4", Offset = "0x41802F4", VA = "0x41802F4")] set
      {
      }
    }

    [Token(Token = "0x1700005F")]
    public Vector2 LookAngleConvert
    {
      [Token(Token = "0x6000631"), Address(RVA = "0x4180300", Offset = "0x4180300", VA = "0x4180300")] set
      {
      }
    }

    [Token(Token = "0x17000060")]
    public EyeMaterialController.FloatRange LookAngleRangeV
    {
      [Token(Token = "0x6000632"), Address(RVA = "0x4180308", Offset = "0x4180308", VA = "0x4180308")] get
      {
        return (EyeMaterialController.FloatRange) null;
      }
    }

    [Token(Token = "0x17000061")]
    public EyeMaterialController.FloatRange LookAngleRangeH
    {
      [Token(Token = "0x6000633"), Address(RVA = "0x4180310", Offset = "0x4180310", VA = "0x4180310")] get
      {
        return (EyeMaterialController.FloatRange) null;
      }
    }

    [Token(Token = "0x17000062")]
    public Vector2 ScalePupil
    {
      [Token(Token = "0x6000634"), Address(RVA = "0x4180318", Offset = "0x4180318", VA = "0x4180318")] set
      {
      }
    }

    [Token(Token = "0x17000063")]
    public Vector2 LookAngle
    {
      [Token(Token = "0x6000635"), Address(RVA = "0x4180320", Offset = "0x4180320", VA = "0x4180320")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6000636"), Address(RVA = "0x4180328", Offset = "0x4180328", VA = "0x4180328")] set
      {
      }
    }

    [Token(Token = "0x6000637")]
    [Address(RVA = "0x417F558", Offset = "0x417F558", VA = "0x417F558")]
    public void Update(int pupilTexID, Transform lookTarget)
    {
    }

    [Token(Token = "0x6000638")]
    [Address(RVA = "0x417FDF4", Offset = "0x417FDF4", VA = "0x417FDF4")]
    public void OnDrawGizmos()
    {
    }

    [Token(Token = "0x6000639")]
    [Address(RVA = "0x417FFB4", Offset = "0x417FFB4", VA = "0x417FFB4")]
    public EyeBall()
    {
    }
  }
}
