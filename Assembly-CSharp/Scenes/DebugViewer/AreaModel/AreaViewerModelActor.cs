// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaModel.AreaViewerModelActor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Text;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaModel
{
  [Token(Token = "0x2002F87")]
  public class AreaViewerModelActor : IAreaViewerModel, IDebugViewerModel
  {
    [Token(Token = "0x400CB66")]
    private const int ActorUnitId = 101009002;

    [Token(Token = "0x17003EC7")]
    private string AssetBundleName
    {
      [Token(Token = "0x6012951"), Address(RVA = "0x212C0E8", Offset = "0x212C0E8", VA = "0x212C0E8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17003EC8")]
    private string AssetName
    {
      [Token(Token = "0x6012952"), Address(RVA = "0x212C0F8", Offset = "0x212C0F8", VA = "0x212C0F8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17003EC9")]
    private GameObject Actor
    {
      [Token(Token = "0x6012953"), Address(RVA = "0x212C108", Offset = "0x212C108", VA = "0x212C108")] set
      {
      }
      [Token(Token = "0x6012954"), Address(RVA = "0x212C110", Offset = "0x212C110", VA = "0x212C110")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17003ECA")]
    private Transform ActorParent
    {
      [Token(Token = "0x6012955"), Address(RVA = "0x212C118", Offset = "0x212C118", VA = "0x212C118")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17003ECB")]
    private Transform TrackingTarget
    {
      [Token(Token = "0x6012956"), Address(RVA = "0x212C120", Offset = "0x212C120", VA = "0x212C120")] set
      {
      }
      [Token(Token = "0x6012957"), Address(RVA = "0x212C128", Offset = "0x212C128", VA = "0x212C128")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17003ECC")]
    private Vector3 Anchor
    {
      [Token(Token = "0x6012958"), Address(RVA = "0x212C130", Offset = "0x212C130", VA = "0x212C130")] set
      {
      }
      [Token(Token = "0x6012959"), Address(RVA = "0x212C13C", Offset = "0x212C13C", VA = "0x212C13C")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x17003ECD")]
    public BindingParam<Vector3> OffsetPosition
    {
      [Token(Token = "0x601295A"), Address(RVA = "0x212C148", Offset = "0x212C148", VA = "0x212C148")] private set
      {
      }
      [Token(Token = "0x601295B"), Address(RVA = "0x212C150", Offset = "0x212C150", VA = "0x212C150")] get
      {
        return (BindingParam<Vector3>) null;
      }
    }

    [Token(Token = "0x17003ECE")]
    public BindingParam<float> Angle
    {
      [Token(Token = "0x601295C"), Address(RVA = "0x212C158", Offset = "0x212C158", VA = "0x212C158")] private set
      {
      }
      [Token(Token = "0x601295D"), Address(RVA = "0x212C160", Offset = "0x212C160", VA = "0x212C160")] get
      {
        return (BindingParam<float>) null;
      }
    }

    [Token(Token = "0x17003ECF")]
    public BindingParam<bool> IsTracking
    {
      [Token(Token = "0x601295E"), Address(RVA = "0x212C168", Offset = "0x212C168", VA = "0x212C168")] private set
      {
      }
      [Token(Token = "0x601295F"), Address(RVA = "0x212C170", Offset = "0x212C170", VA = "0x212C170")] get
      {
        return (BindingParam<bool>) null;
      }
    }

    [Token(Token = "0x17003ED0")]
    private Vector3 TrackingBasePosition
    {
      [Token(Token = "0x6012960"), Address(RVA = "0x212C178", Offset = "0x212C178", VA = "0x212C178")] get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x6012961")]
    [Address(RVA = "0x212B5D0", Offset = "0x212B5D0", VA = "0x212B5D0")]
    public AreaViewerModelActor(Transform actorParent)
    {
    }

    [Token(Token = "0x6012962")]
    [Address(RVA = "0x212C278", Offset = "0x212C278", VA = "0x212C278", Slot = "4")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6012963")]
    [Address(RVA = "0x212C2E0", Offset = "0x212C2E0", VA = "0x212C2E0", Slot = "5")]
    public void Update()
    {
    }

    [Token(Token = "0x6012964")]
    [Address(RVA = "0x212C47C", Offset = "0x212C47C", VA = "0x212C47C", Slot = "6")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6012965")]
    [Address(RVA = "0x212C50C", Offset = "0x212C50C", VA = "0x212C50C")]
    private void LoadedActor(GameObject actor)
    {
    }

    [Token(Token = "0x6012966")]
    [Address(RVA = "0x212BDA8", Offset = "0x212BDA8", VA = "0x212BDA8")]
    public void SetTrackingTarget(Transform target)
    {
    }

    [Token(Token = "0x6012967")]
    [Address(RVA = "0x212B7D4", Offset = "0x212B7D4", VA = "0x212B7D4")]
    public StringBuilder GetFullInfo(StringBuilder sb) => (StringBuilder) null;
  }
}
