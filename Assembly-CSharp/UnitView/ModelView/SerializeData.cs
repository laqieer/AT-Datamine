// Decompiled with JetBrains decompiler
// Type: UnitView.ModelView.SerializeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnitView.Camera;
using UnitView.ModelView.UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace UnitView.ModelView
{
  [Token(Token = "0x20003CB")]
  [Serializable]
  public class SerializeData
  {
    [Token(Token = "0x400164A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400164B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Controller cameraController;
    [Token(Token = "0x400164C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Background bg;
    [Token(Token = "0x400164D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Background viewerBg;
    [Token(Token = "0x400164E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject viewerBgObject;
    [Token(Token = "0x400164F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Transform bgOrientationRoot;
    [Token(Token = "0x4001650")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private RawImage arImage;

    [Token(Token = "0x17000257")]
    public UITweenGroup TweenGroup
    {
      [Token(Token = "0x6001619"), Address(RVA = "0x24858D4", Offset = "0x24858D4", VA = "0x24858D4")] get
      {
        return (UITweenGroup) null;
      }
    }

    [Token(Token = "0x17000258")]
    public Controller CameraController
    {
      [Token(Token = "0x600161A"), Address(RVA = "0x24858DC", Offset = "0x24858DC", VA = "0x24858DC")] get
      {
        return (Controller) null;
      }
    }

    [Token(Token = "0x17000259")]
    public Background BG
    {
      [Token(Token = "0x600161B"), Address(RVA = "0x24858E4", Offset = "0x24858E4", VA = "0x24858E4")] get
      {
        return (Background) null;
      }
    }

    [Token(Token = "0x1700025A")]
    public Background ViewerBG
    {
      [Token(Token = "0x600161C"), Address(RVA = "0x24858EC", Offset = "0x24858EC", VA = "0x24858EC")] get
      {
        return (Background) null;
      }
    }

    [Token(Token = "0x1700025B")]
    public GameObject ViewerBgObject
    {
      [Token(Token = "0x600161D"), Address(RVA = "0x24858F4", Offset = "0x24858F4", VA = "0x24858F4")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x1700025C")]
    public Transform BGOrientationRoot
    {
      [Token(Token = "0x600161E"), Address(RVA = "0x24858FC", Offset = "0x24858FC", VA = "0x24858FC")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x1700025D")]
    public RawImage ArImage
    {
      [Token(Token = "0x600161F"), Address(RVA = "0x2485904", Offset = "0x2485904", VA = "0x2485904")] get
      {
        return (RawImage) null;
      }
    }

    [Token(Token = "0x6001620")]
    [Address(RVA = "0x248590C", Offset = "0x248590C", VA = "0x248590C")]
    public SerializeData()
    {
    }
  }
}
