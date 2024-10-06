// Decompiled with JetBrains decompiler
// Type: Area.FadeContent.AreaFadeContentManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Area.FadeContent
{
  [Token(Token = "0x200284F")]
  public class AreaFadeContentManager : MonoBehaviour
  {
    [Token(Token = "0x400ABD7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<AreaFadeContent> fadeContentList;
    [Token(Token = "0x400ABD8")]
    [FieldOffset(Offset = "0x20")]
    private List<AreaFadeContent> fadeOutContentList;
    [Token(Token = "0x400ABD9")]
    [FieldOffset(Offset = "0x28")]
    private List<AreaFadeContent> fadeInContentList;
    [Token(Token = "0x400ABDA")]
    private const float InvertRayDirection = 1f;
    [Token(Token = "0x400ABDB")]
    [FieldOffset(Offset = "0x30")]
    public bool isEnableContentFade;

    [Token(Token = "0x600FDE6")]
    [Address(RVA = "0x44325F0", Offset = "0x44325F0", VA = "0x44325F0")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600FDE7")]
    [Address(RVA = "0x44327DC", Offset = "0x44327DC", VA = "0x44327DC")]
    public void ShowAll()
    {
    }

    [Token(Token = "0x600FDE8")]
    [Address(RVA = "0x443298C", Offset = "0x443298C", VA = "0x443298C")]
    public void HideAll()
    {
    }

    [Token(Token = "0x600FDE9")]
    [Address(RVA = "0x4432B3C", Offset = "0x4432B3C", VA = "0x4432B3C")]
    public void AreaFadeUpdate(Camera camera, Vector3 lookAtPoint)
    {
    }

    [Token(Token = "0x600FDEA")]
    [Address(RVA = "0x4432F0C", Offset = "0x4432F0C", VA = "0x4432F0C")]
    public void Release()
    {
    }

    [Token(Token = "0x600FDEB")]
    [Address(RVA = "0x44330F4", Offset = "0x44330F4", VA = "0x44330F4")]
    public AreaFadeContentManager()
    {
    }
  }
}
