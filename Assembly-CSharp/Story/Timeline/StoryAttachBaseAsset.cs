// Decompiled with JetBrains decompiler
// Type: Story.Timeline.StoryAttachBaseAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Story.Timeline
{
  [Token(Token = "0x20005FD")]
  [Serializable]
  public class StoryAttachBaseAsset : PlayableAsset
  {
    [Token(Token = "0x4001DA6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ExposedReference<GameObject> additionalObject;
    [Token(Token = "0x4001DA7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool isMoveChild;
    [Token(Token = "0x4001DA8")]
    [FieldOffset(Offset = "0x29")]
    [SerializeField]
    private bool playOnAwake;
    [Token(Token = "0x4001DA9")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Vector3 localPosition;
    [Token(Token = "0x4001DAA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Vector3 localEulerAngles;

    [Token(Token = "0x170004F7")]
    public bool PlayOnAwake
    {
      [Token(Token = "0x60022CF"), Address(RVA = "0x2DA19D8", Offset = "0x2DA19D8", VA = "0x2DA19D8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60022D0")]
    [Address(RVA = "0x2DA19E0", Offset = "0x2DA19E0", VA = "0x2DA19E0", Slot = "6")]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject go) => new Playable();

    [Token(Token = "0x60022D1")]
    [Address(RVA = "0x2DA1AC8", Offset = "0x2DA1AC8", VA = "0x2DA1AC8")]
    public GameObject CreateAttachedObject(Playable playable) => (GameObject) null;

    [Token(Token = "0x60022D2")]
    [Address(RVA = "0x2DA1D9C", Offset = "0x2DA1D9C", VA = "0x2DA1D9C", Slot = "9")]
    protected virtual Transform GetAttachParent(Playable playable) => (Transform) null;

    [Token(Token = "0x60022D3")]
    [Address(RVA = "0x2DA1DA4", Offset = "0x2DA1DA4", VA = "0x2DA1DA4")]
    public StoryAttachBaseAsset()
    {
    }
  }
}
