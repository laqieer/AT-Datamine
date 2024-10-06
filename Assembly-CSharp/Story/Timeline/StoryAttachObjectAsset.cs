// Decompiled with JetBrains decompiler
// Type: Story.Timeline.StoryAttachObjectAsset
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
  [Token(Token = "0x2000600")]
  [Serializable]
  public class StoryAttachObjectAsset : StoryAttachBaseAsset
  {
    [Token(Token = "0x4001DAF")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private StoryAttachObjectAsset.AttachScene attachSceneType;
    [Token(Token = "0x4001DB0")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private string attachObjectName;

    [Token(Token = "0x60022DB")]
    [Address(RVA = "0x2DA24B4", Offset = "0x2DA24B4", VA = "0x2DA24B4", Slot = "6")]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject go) => new Playable();

    [Token(Token = "0x60022DC")]
    [Address(RVA = "0x2DA259C", Offset = "0x2DA259C", VA = "0x2DA259C", Slot = "9")]
    protected override Transform GetAttachParent(Playable playable) => (Transform) null;

    [Token(Token = "0x60022DD")]
    [Address(RVA = "0x2DA2634", Offset = "0x2DA2634", VA = "0x2DA2634")]
    public StoryAttachObjectAsset()
    {
    }

    [Token(Token = "0x2000601")]
    public enum AttachScene
    {
      [Token(Token = "0x4001DB2")] Map,
      [Token(Token = "0x4001DB3")] Placement,
      [Token(Token = "0x4001DB4")] None,
    }
  }
}
