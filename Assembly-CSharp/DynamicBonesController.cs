// Decompiled with JetBrains decompiler
// Type: DynamicBonesController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000CC")]
public class DynamicBonesController : MonoBehaviour
{
  [Token(Token = "0x400036D")]
  private const int nomalizeDelayCountMax = 3;
  [Token(Token = "0x400036E")]
  [FieldOffset(Offset = "0x18")]
  private int nomalizeDelayCount;
  [Token(Token = "0x400036F")]
  [FieldOffset(Offset = "0x20")]
  private List<DynamicBonesController.DynamicBoneParameter> parameterList;

  [Token(Token = "0x60005F3")]
  [Address(RVA = "0x417D9D0", Offset = "0x417D9D0", VA = "0x417D9D0")]
  private void Awake()
  {
  }

  [Token(Token = "0x60005F4")]
  [Address(RVA = "0x417DB54", Offset = "0x417DB54", VA = "0x417DB54")]
  private void Start()
  {
  }

  [Token(Token = "0x60005F5")]
  [Address(RVA = "0x417DCB4", Offset = "0x417DCB4", VA = "0x417DCB4")]
  private void Update()
  {
  }

  [Token(Token = "0x60005F6")]
  [Address(RVA = "0x417DE18", Offset = "0x417DE18", VA = "0x417DE18")]
  public void SetLOD(GameObject target, float distance)
  {
  }

  [Token(Token = "0x60005F7")]
  [Address(RVA = "0x417E020", Offset = "0x417E020", VA = "0x417E020")]
  public void SetDynamicBones(int value)
  {
  }

  [Token(Token = "0x60005F8")]
  [Address(RVA = "0x417E304", Offset = "0x417E304", VA = "0x417E304")]
  public void SetOffDynamicBones()
  {
  }

  [Token(Token = "0x60005F9")]
  [Address(RVA = "0x417DB58", Offset = "0x417DB58", VA = "0x417DB58")]
  public void NormalizeElasticity()
  {
  }

  [Token(Token = "0x60005FA")]
  [Address(RVA = "0x417E334", Offset = "0x417E334", VA = "0x417E334")]
  public void ForceStart()
  {
  }

  [Token(Token = "0x60005FB")]
  [Address(RVA = "0x417E3A8", Offset = "0x417E3A8", VA = "0x417E3A8")]
  public void ForceUpdate()
  {
  }

  [Token(Token = "0x60005FC")]
  [Address(RVA = "0x417DCD0", Offset = "0x417DCD0", VA = "0x417DCD0")]
  private void RestoreElasticity()
  {
  }

  [Token(Token = "0x60005FD")]
  [Address(RVA = "0x417E1A8", Offset = "0x417E1A8", VA = "0x417E1A8")]
  private void ResetDynamicBone()
  {
  }

  [Token(Token = "0x60005FE")]
  [Address(RVA = "0x417E3F4", Offset = "0x417E3F4", VA = "0x417E3F4")]
  public DynamicBonesController()
  {
  }

  [Token(Token = "0x20000CD")]
  private class DynamicBoneParameter
  {
    [Token(Token = "0x4000371")]
    [FieldOffset(Offset = "0x18")]
    private float inert;
    [Token(Token = "0x4000372")]
    [FieldOffset(Offset = "0x1C")]
    private float elasticity;
    [Token(Token = "0x4000373")]
    private const float maxValue = 1f;

    [Token(Token = "0x17000049")]
    public DynamicBone DynamicBone
    {
      [Token(Token = "0x60005FF"), Address(RVA = "0x417E470", Offset = "0x417E470", VA = "0x417E470")] get
      {
        return (DynamicBone) null;
      }
      [Token(Token = "0x6000600"), Address(RVA = "0x417E478", Offset = "0x417E478", VA = "0x417E478")] private set
      {
      }
    }

    [Token(Token = "0x6000601")]
    [Address(RVA = "0x417DB14", Offset = "0x417DB14", VA = "0x417DB14")]
    public DynamicBoneParameter(DynamicBone dynamicBone)
    {
    }

    [Token(Token = "0x6000602")]
    [Address(RVA = "0x417E30C", Offset = "0x417E30C", VA = "0x417E30C")]
    public void SetIgnoreElasticity()
    {
    }

    [Token(Token = "0x6000603")]
    [Address(RVA = "0x417E3C4", Offset = "0x417E3C4", VA = "0x417E3C4")]
    public void RestoreElasticity()
    {
    }
  }
}
