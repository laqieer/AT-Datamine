// Decompiled with JetBrains decompiler
// Type: Story.Timeline.StoryBaseClipBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Playables;

#nullable disable
namespace Story.Timeline
{
  [Token(Token = "0x2000604")]
  public class StoryBaseClipBehaviour : PlayableBehaviour
  {
    [Token(Token = "0x4001DB6")]
    [FieldOffset(Offset = "0x10")]
    private StoryBaseClipAsset linkAsset;
    [Token(Token = "0x4001DB7")]
    [FieldOffset(Offset = "0x18")]
    private PlayableDirector ownerDirector;

    [Token(Token = "0x170004F9")]
    public StoryBaseClipAsset LinkAsset
    {
      [Token(Token = "0x60022E5"), Address(RVA = "0x2DA285C", Offset = "0x2DA285C", VA = "0x2DA285C")] get
      {
        return (StoryBaseClipAsset) null;
      }
      [Token(Token = "0x60022E6"), Address(RVA = "0x2DA2864", Offset = "0x2DA2864", VA = "0x2DA2864")] set
      {
      }
    }

    [Token(Token = "0x170004FA")]
    public PlayableDirector OwnerDirector
    {
      [Token(Token = "0x60022E7"), Address(RVA = "0x2DA286C", Offset = "0x2DA286C", VA = "0x2DA286C")] get
      {
        return (PlayableDirector) null;
      }
      [Token(Token = "0x60022E8"), Address(RVA = "0x2DA2874", Offset = "0x2DA2874", VA = "0x2DA2874")] set
      {
      }
    }

    [Token(Token = "0x60022E9")]
    [Address(RVA = "0x2DA287C", Offset = "0x2DA287C", VA = "0x2DA287C")]
    public PlayableDirector GetDirector(Playable myPlayable) => (PlayableDirector) null;

    [Token(Token = "0x60022EA")]
    public T GetObjectBindingTrack<T>() where T : class => (T) null;

    [Token(Token = "0x60022EB")]
    [Address(RVA = "0x2DA293C", Offset = "0x2DA293C", VA = "0x2DA293C")]
    public StoryBaseClipBehaviour()
    {
    }
  }
}
