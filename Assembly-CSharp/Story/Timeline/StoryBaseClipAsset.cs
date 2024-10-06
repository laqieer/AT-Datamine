// Decompiled with JetBrains decompiler
// Type: Story.Timeline.StoryBaseClipAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Story.Timeline
{
  [Token(Token = "0x2000603")]
  public class StoryBaseClipAsset : PlayableAsset
  {
    [Token(Token = "0x4001DB5")]
    [FieldOffset(Offset = "0x18")]
    private StoryBaseTrack ownerTrack;

    [Token(Token = "0x170004F8")]
    public StoryBaseTrack OwnerTrack
    {
      [Token(Token = "0x60022DF"), Address(RVA = "0x2DA269C", Offset = "0x2DA269C", VA = "0x2DA269C")] get
      {
        return (StoryBaseTrack) null;
      }
      [Token(Token = "0x60022E0"), Address(RVA = "0x2DA26A4", Offset = "0x2DA26A4", VA = "0x2DA26A4")] set
      {
      }
    }

    [Token(Token = "0x60022E1")]
    [Address(RVA = "0x2DA26AC", Offset = "0x2DA26AC", VA = "0x2DA26AC", Slot = "6")]
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
      return new Playable();
    }

    [Token(Token = "0x60022E2")]
    [Address(RVA = "0x2DA2814", Offset = "0x2DA2814", VA = "0x2DA2814", Slot = "9")]
    public virtual string GetDisplayClipName() => (string) null;

    [Token(Token = "0x60022E3")]
    [Address(RVA = "0x2DA27A4", Offset = "0x2DA27A4", VA = "0x2DA27A4")]
    protected void LinkStoryBaseClipBehaviour(
      StoryBaseClipBehaviour myBehaviour,
      PlayableGraph graph,
      GameObject owner)
    {
    }

    [Token(Token = "0x60022E4")]
    [Address(RVA = "0x2DA2854", Offset = "0x2DA2854", VA = "0x2DA2854")]
    public StoryBaseClipAsset()
    {
    }
  }
}
