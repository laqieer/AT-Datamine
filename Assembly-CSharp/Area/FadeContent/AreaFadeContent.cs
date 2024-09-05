// Decompiled with JetBrains decompiler
// Type: Area.FadeContent.AreaFadeContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Area.FadeContent
{
  [Token(Token = "0x200284B")]
  public class AreaFadeContent : AreaFadeContentBase
  {
    [Token(Token = "0x400ABC6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<BoxCollider> colliderList;
    [Token(Token = "0x400ABC7")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<Renderer> fadeRendererList;

    [Token(Token = "0x600FDC4")]
    [Address(RVA = "0x4430C00", Offset = "0x4430C00", VA = "0x4430C00")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600FDC5")]
    [Address(RVA = "0x4430F90", Offset = "0x4430F90", VA = "0x4430F90")]
    public void RegisterBoxCollider(BoxCollider collider)
    {
    }

    [Token(Token = "0x600FDC6")]
    [Address(RVA = "0x4431064", Offset = "0x4431064", VA = "0x4431064")]
    public void RegisterBoxColloderList(BoxCollider[] colliderArray)
    {
    }

    [Token(Token = "0x600FDC7")]
    [Address(RVA = "0x4431180", Offset = "0x4431180", VA = "0x4431180")]
    public void RegisterRendererList(Renderer[] rendererArray)
    {
    }

    [Token(Token = "0x600FDC8")]
    [Address(RVA = "0x443129C", Offset = "0x443129C", VA = "0x443129C")]
    public bool Contains(Vector3 point) => new bool();

    [Token(Token = "0x600FDC9")]
    [Address(RVA = "0x4431460", Offset = "0x4431460", VA = "0x4431460")]
    public bool IntersectRay(Ray ray, float distance) => new bool();

    [Token(Token = "0x600FDCA")]
    [Address(RVA = "0x443163C", Offset = "0x443163C", VA = "0x443163C")]
    public AreaFadeContent()
    {
    }
  }
}
