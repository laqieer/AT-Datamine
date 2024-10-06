// Decompiled with JetBrains decompiler
// Type: Story.Timeline.StoryAttachCharacterAsset
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
  [Token(Token = "0x20005FF")]
  [Serializable]
  public class StoryAttachCharacterAsset : StoryAttachBaseAsset
  {
    [Token(Token = "0x4001DAD")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private string characterTrackName;
    [Token(Token = "0x4001DAE")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private HumanBodyBones partsType;

    [Token(Token = "0x60022D8")]
    [Address(RVA = "0x2DA1F88", Offset = "0x2DA1F88", VA = "0x2DA1F88", Slot = "6")]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject go) => new Playable();

    [Token(Token = "0x60022D9")]
    [Address(RVA = "0x2DA2070", Offset = "0x2DA2070", VA = "0x2DA2070", Slot = "9")]
    protected override Transform GetAttachParent(Playable playable) => (Transform) null;

    [Token(Token = "0x60022DA")]
    [Address(RVA = "0x2DA24A4", Offset = "0x2DA24A4", VA = "0x2DA24A4")]
    public StoryAttachCharacterAsset()
    {
    }
  }
}
