// Decompiled with JetBrains decompiler
// Type: DynamicBone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000C2")]
[AddComponentMenu("Dynamic Bone/Dynamic Bone")]
public class DynamicBone : MonoBehaviour
{
  [Token(Token = "0x4000321")]
  [FieldOffset(Offset = "0x18")]
  public Transform m_Root;
  [Token(Token = "0x4000322")]
  [FieldOffset(Offset = "0x20")]
  public float m_UpdateRate;
  [Token(Token = "0x4000323")]
  [FieldOffset(Offset = "0x24")]
  public DynamicBone.UpdateMode m_UpdateMode;
  [Token(Token = "0x4000324")]
  [FieldOffset(Offset = "0x28")]
  [Range(0.0f, 1f)]
  public float m_Damping;
  [Token(Token = "0x4000325")]
  [FieldOffset(Offset = "0x30")]
  public AnimationCurve m_DampingDistrib;
  [Token(Token = "0x4000326")]
  [FieldOffset(Offset = "0x38")]
  [Range(0.0f, 1f)]
  public float m_Elasticity;
  [Token(Token = "0x4000327")]
  [FieldOffset(Offset = "0x40")]
  public AnimationCurve m_ElasticityDistrib;
  [Token(Token = "0x4000328")]
  [FieldOffset(Offset = "0x48")]
  [Range(0.0f, 1f)]
  public float m_Stiffness;
  [Token(Token = "0x4000329")]
  [FieldOffset(Offset = "0x50")]
  public AnimationCurve m_StiffnessDistrib;
  [Token(Token = "0x400032A")]
  [FieldOffset(Offset = "0x58")]
  [Range(0.0f, 1f)]
  public float m_Inert;
  [Token(Token = "0x400032B")]
  [FieldOffset(Offset = "0x60")]
  public AnimationCurve m_InertDistrib;
  [Token(Token = "0x400032C")]
  [FieldOffset(Offset = "0x68")]
  public float m_Radius;
  [Token(Token = "0x400032D")]
  [FieldOffset(Offset = "0x70")]
  public AnimationCurve m_RadiusDistrib;
  [Token(Token = "0x400032E")]
  [FieldOffset(Offset = "0x78")]
  public float m_EndLength;
  [Token(Token = "0x400032F")]
  [FieldOffset(Offset = "0x7C")]
  public Vector3 m_EndOffset;
  [Token(Token = "0x4000330")]
  [FieldOffset(Offset = "0x88")]
  public Vector3 m_Gravity;
  [Token(Token = "0x4000331")]
  [FieldOffset(Offset = "0x94")]
  public Vector3 m_Force;
  [Token(Token = "0x4000332")]
  [FieldOffset(Offset = "0xA0")]
  public List<DynamicBoneColliderBase> m_Colliders;
  [Token(Token = "0x4000333")]
  [FieldOffset(Offset = "0xA8")]
  public List<Transform> m_Exclusions;
  [Token(Token = "0x4000334")]
  [FieldOffset(Offset = "0xB0")]
  public DynamicBone.FreezeAxis m_FreezeAxis;
  [Token(Token = "0x4000335")]
  [FieldOffset(Offset = "0xB4")]
  public bool m_DistantDisable;
  [Token(Token = "0x4000336")]
  [FieldOffset(Offset = "0xB8")]
  public Transform m_ReferenceObject;
  [Token(Token = "0x4000337")]
  [FieldOffset(Offset = "0xC0")]
  public float m_DistanceToObject;
  [Token(Token = "0x4000338")]
  [FieldOffset(Offset = "0xC4")]
  private Vector3 m_LocalGravity;
  [Token(Token = "0x4000339")]
  [FieldOffset(Offset = "0xD0")]
  private Vector3 m_ObjectMove;
  [Token(Token = "0x400033A")]
  [FieldOffset(Offset = "0xDC")]
  private Vector3 m_ObjectPrevPosition;
  [Token(Token = "0x400033B")]
  [FieldOffset(Offset = "0xE8")]
  private float m_BoneTotalLength;
  [Token(Token = "0x400033C")]
  [FieldOffset(Offset = "0xEC")]
  private float m_ObjectScale;
  [Token(Token = "0x400033D")]
  [FieldOffset(Offset = "0xF0")]
  private float m_Time;
  [Token(Token = "0x400033E")]
  [FieldOffset(Offset = "0xF4")]
  private float m_Weight;
  [Token(Token = "0x400033F")]
  [FieldOffset(Offset = "0xF8")]
  private bool m_DistantDisabled;
  [Token(Token = "0x4000340")]
  [FieldOffset(Offset = "0x100")]
  private List<DynamicBone.Particle> m_Particles;

  [Token(Token = "0x60005C4")]
  [Address(RVA = "0x44B7800", Offset = "0x44B7800", VA = "0x44B7800")]
  private void Start()
  {
  }

  [Token(Token = "0x60005C5")]
  [Address(RVA = "0x44B7970", Offset = "0x44B7970", VA = "0x44B7970")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x60005C6")]
  [Address(RVA = "0x44B79C4", Offset = "0x44B79C4", VA = "0x44B79C4")]
  private void Update()
  {
  }

  [Token(Token = "0x60005C7")]
  [Address(RVA = "0x44B79F4", Offset = "0x44B79F4", VA = "0x44B79F4")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x60005C8")]
  [Address(RVA = "0x44B79A0", Offset = "0x44B79A0", VA = "0x44B79A0")]
  private void PreUpdate()
  {
  }

  [Token(Token = "0x60005C9")]
  [Address(RVA = "0x44B7A44", Offset = "0x44B7A44", VA = "0x44B7A44")]
  private void CheckDistance()
  {
  }

  [Token(Token = "0x60005CA")]
  [Address(RVA = "0x44B7FCC", Offset = "0x44B7FCC", VA = "0x44B7FCC")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60005CB")]
  [Address(RVA = "0x44B7FD0", Offset = "0x44B7FD0", VA = "0x44B7FD0")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x60005CC")]
  [Address(RVA = "0x44B7FD4", Offset = "0x44B7FD4", VA = "0x44B7FD4")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x60005CD")]
  [Address(RVA = "0x44B8080", Offset = "0x44B8080", VA = "0x44B8080")]
  private void OnDrawGizmosSelected()
  {
  }

  [Token(Token = "0x60005CE")]
  [Address(RVA = "0x44B8210", Offset = "0x44B8210", VA = "0x44B8210")]
  public void SetWeight(float w)
  {
  }

  [Token(Token = "0x60005CF")]
  [Address(RVA = "0x44B8260", Offset = "0x44B8260", VA = "0x44B8260")]
  public void ResetWeight(float w)
  {
  }

  [Token(Token = "0x60005D0")]
  [Address(RVA = "0x44B8268", Offset = "0x44B8268", VA = "0x44B8268")]
  public float GetWeight() => new float();

  [Token(Token = "0x60005D1")]
  [Address(RVA = "0x44B8270", Offset = "0x44B8270", VA = "0x44B8270")]
  public void Reset()
  {
  }

  [Token(Token = "0x60005D2")]
  [Address(RVA = "0x44B7BBC", Offset = "0x44B7BBC", VA = "0x44B7BBC")]
  private void UpdateDynamicBones(float t)
  {
  }

  [Token(Token = "0x60005D3")]
  [Address(RVA = "0x44B7804", Offset = "0x44B7804", VA = "0x44B7804")]
  private void SetupParticles()
  {
  }

  [Token(Token = "0x60005D4")]
  [Address(RVA = "0x44B9208", Offset = "0x44B9208", VA = "0x44B9208")]
  private void AppendParticles(Transform b, int parentIndex, float boneLength)
  {
  }

  [Token(Token = "0x60005D5")]
  [Address(RVA = "0x44B97D0", Offset = "0x44B97D0", VA = "0x44B97D0")]
  public void UpdateParameters()
  {
  }

  [Token(Token = "0x60005D6")]
  [Address(RVA = "0x44B7D80", Offset = "0x44B7D80", VA = "0x44B7D80")]
  private void InitTransforms()
  {
  }

  [Token(Token = "0x60005D7")]
  [Address(RVA = "0x44B7E84", Offset = "0x44B7E84", VA = "0x44B7E84")]
  private void ResetParticlesPosition()
  {
  }

  [Token(Token = "0x60005D8")]
  [Address(RVA = "0x44B8288", Offset = "0x44B8288", VA = "0x44B8288")]
  private void UpdateParticles1()
  {
  }

  [Token(Token = "0x60005D9")]
  [Address(RVA = "0x44B84EC", Offset = "0x44B84EC", VA = "0x44B84EC")]
  private void UpdateParticles2()
  {
  }

  [Token(Token = "0x60005DA")]
  [Address(RVA = "0x44B8B08", Offset = "0x44B8B08", VA = "0x44B8B08")]
  private void SkipUpdateParticles()
  {
  }

  [Token(Token = "0x60005DB")]
  [Address(RVA = "0x44B9B68", Offset = "0x44B9B68", VA = "0x44B9B68")]
  private static Vector3 MirrorVector(Vector3 v, Vector3 axis) => new Vector3();

  [Token(Token = "0x60005DC")]
  [Address(RVA = "0x44B8FAC", Offset = "0x44B8FAC", VA = "0x44B8FAC")]
  private void ApplyParticlesToTransforms()
  {
  }

  [Token(Token = "0x60005DD")]
  [Address(RVA = "0x44B9B9C", Offset = "0x44B9B9C", VA = "0x44B9B9C")]
  public DynamicBone()
  {
  }

  [Token(Token = "0x20000C3")]
  public enum UpdateMode
  {
    [Token(Token = "0x4000342")] Normal,
    [Token(Token = "0x4000343")] AnimatePhysics,
    [Token(Token = "0x4000344")] UnscaledTime,
  }

  [Token(Token = "0x20000C4")]
  public enum FreezeAxis
  {
    [Token(Token = "0x4000346")] None,
    [Token(Token = "0x4000347")] X,
    [Token(Token = "0x4000348")] Y,
    [Token(Token = "0x4000349")] Z,
  }

  [Token(Token = "0x20000C5")]
  private class Particle
  {
    [Token(Token = "0x400034A")]
    [FieldOffset(Offset = "0x10")]
    public Transform m_Transform;
    [Token(Token = "0x400034B")]
    [FieldOffset(Offset = "0x18")]
    public int m_ParentIndex;
    [Token(Token = "0x400034C")]
    [FieldOffset(Offset = "0x1C")]
    public float m_Damping;
    [Token(Token = "0x400034D")]
    [FieldOffset(Offset = "0x20")]
    public float m_Elasticity;
    [Token(Token = "0x400034E")]
    [FieldOffset(Offset = "0x24")]
    public float m_Stiffness;
    [Token(Token = "0x400034F")]
    [FieldOffset(Offset = "0x28")]
    public float m_Inert;
    [Token(Token = "0x4000350")]
    [FieldOffset(Offset = "0x2C")]
    public float m_Radius;
    [Token(Token = "0x4000351")]
    [FieldOffset(Offset = "0x30")]
    public float m_BoneLength;
    [Token(Token = "0x4000352")]
    [FieldOffset(Offset = "0x34")]
    public Vector3 m_Position;
    [Token(Token = "0x4000353")]
    [FieldOffset(Offset = "0x40")]
    public Vector3 m_PrevPosition;
    [Token(Token = "0x4000354")]
    [FieldOffset(Offset = "0x4C")]
    public Vector3 m_EndOffset;
    [Token(Token = "0x4000355")]
    [FieldOffset(Offset = "0x58")]
    public Vector3 m_InitLocalPosition;
    [Token(Token = "0x4000356")]
    [FieldOffset(Offset = "0x64")]
    public Quaternion m_InitLocalRotation;

    [Token(Token = "0x60005DE")]
    [Address(RVA = "0x44B9A8C", Offset = "0x44B9A8C", VA = "0x44B9A8C")]
    public Particle()
    {
    }
  }
}
