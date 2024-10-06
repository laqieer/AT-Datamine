// Decompiled with JetBrains decompiler
// Type: WindAnimation.WindManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace WindAnimation
{
  [Token(Token = "0x2003F14")]
  public class WindManager : MonoBehaviour
  {
    [Token(Token = "0x401148A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string windBoneModelTagName;
    [Token(Token = "0x401148B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string windAnimTagName;
    [Token(Token = "0x401148C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<GameObject> windBoneModelList;
    [Token(Token = "0x401148D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<WindAnimationController> windAnimList;
    [Token(Token = "0x401148E")]
    [FieldOffset(Offset = "0x38")]
    private WindPowerParameterRange windPowerParamRange;
    [Token(Token = "0x401148F")]
    [FieldOffset(Offset = "0x40")]
    private WindAffectedBoneManager windAffectedBoneManager;

    [Token(Token = "0x17005214")]
    public WindPowerParameterRange WindPowerParamRange
    {
      [Token(Token = "0x60197C5"), Address(RVA = "0x37442A0", Offset = "0x37442A0", VA = "0x37442A0")] get
      {
        return (WindPowerParameterRange) null;
      }
    }

    [Token(Token = "0x60197C6")]
    [Address(RVA = "0x37442A8", Offset = "0x37442A8", VA = "0x37442A8")]
    private void Awake()
    {
    }

    [Token(Token = "0x60197C7")]
    [Address(RVA = "0x37442AC", Offset = "0x37442AC", VA = "0x37442AC")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60197C8")]
    [Address(RVA = "0x37446B4", Offset = "0x37446B4", VA = "0x37446B4")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60197C9")]
    [Address(RVA = "0x37446CC", Offset = "0x37446CC", VA = "0x37446CC")]
    private void Update()
    {
    }

    [Token(Token = "0x60197CA")]
    [Address(RVA = "0x37446E4", Offset = "0x37446E4", VA = "0x37446E4")]
    public void RegistWindParameter(ref WindCommonParameter parameter)
    {
    }

    [Token(Token = "0x60197CB")]
    [Address(RVA = "0x37446FC", Offset = "0x37446FC", VA = "0x37446FC")]
    public void RegistWindParameter(List<string> targetNameList, WindCommonParameter parameter)
    {
    }

    [Token(Token = "0x60197CC")]
    [Address(RVA = "0x3743E38", Offset = "0x3743E38", VA = "0x3743E38")]
    public void SetWindParameterEvent(WindAnimationController component)
    {
    }

    [Token(Token = "0x60197CD")]
    [Address(RVA = "0x374206C", Offset = "0x374206C", VA = "0x374206C")]
    public void AddWindBoneModel(GameObject obj)
    {
    }

    [Token(Token = "0x60197CE")]
    [Address(RVA = "0x374488C", Offset = "0x374488C", VA = "0x374488C")]
    private void RemoveUnreferencedWindBones()
    {
    }

    [Token(Token = "0x60197CF")]
    [Address(RVA = "0x37449AC", Offset = "0x37449AC", VA = "0x37449AC")]
    public WindManager()
    {
    }
  }
}
