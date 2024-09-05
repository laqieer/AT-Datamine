// Decompiled with JetBrains decompiler
// Type: Story.Timeline.StoryAttachBaseBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Story.Timeline
{
  [Token(Token = "0x20005FE")]
  public class StoryAttachBaseBehaviour : PlayableBehaviour
  {
    [Token(Token = "0x4001DAB")]
    [FieldOffset(Offset = "0x10")]
    public StoryAttachBaseAsset MyAsset;
    [Token(Token = "0x4001DAC")]
    [FieldOffset(Offset = "0x18")]
    private GameObject attachedObject;

    [Token(Token = "0x60022D4")]
    [Address(RVA = "0x2DA1DB4", Offset = "0x2DA1DB4", VA = "0x2DA1DB4", Slot = "17")]
    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x60022D5")]
    [Address(RVA = "0x2DA1EF0", Offset = "0x2DA1EF0", VA = "0x2DA1EF0", Slot = "18")]
    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x60022D6")]
    [Address(RVA = "0x2DA1F7C", Offset = "0x2DA1F7C", VA = "0x2DA1F7C", Slot = "20")]
    public override void PrepareFrame(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x60022D7")]
    [Address(RVA = "0x2DA1F80", Offset = "0x2DA1F80", VA = "0x2DA1F80")]
    public StoryAttachBaseBehaviour()
    {
    }
  }
}
