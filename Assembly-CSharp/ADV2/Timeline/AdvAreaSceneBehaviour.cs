// Decompiled with JetBrains decompiler
// Type: ADV2.Timeline.AdvAreaSceneBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine.Playables;

#nullable disable
namespace ADV2.Timeline
{
  [Token(Token = "0x2003E63")]
  [Serializable]
  public class AdvAreaSceneBehaviour : PlayableBehaviour
  {
    [Token(Token = "0x40111CA")]
    [FieldOffset(Offset = "0x10")]
    public string scenename;
    [Token(Token = "0x40111CB")]
    [FieldOffset(Offset = "0x18")]
    private Adv2BindTrack adv2BindTrack;
    [Token(Token = "0x40111CC")]
    [FieldOffset(Offset = "0x20")]
    private int clipId;

    [Token(Token = "0x60191BB")]
    [Address(RVA = "0x2CF146C", Offset = "0x2CF146C", VA = "0x2CF146C")]
    public void Initialize(Adv2BindTrack bindTarget, int clipId)
    {
    }

    [Token(Token = "0x60191BC")]
    [Address(RVA = "0x2CF1590", Offset = "0x2CF1590", VA = "0x2CF1590", Slot = "15")]
    public override void OnPlayableCreate(Playable playable)
    {
    }

    [Token(Token = "0x60191BD")]
    [Address(RVA = "0x2CF1598", Offset = "0x2CF1598", VA = "0x2CF1598", Slot = "13")]
    public override void OnGraphStart(Playable playable)
    {
    }

    [Token(Token = "0x60191BE")]
    [Address(RVA = "0x2CF15A0", Offset = "0x2CF15A0", VA = "0x2CF15A0", Slot = "17")]
    public override void OnBehaviourPlay(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x60191BF")]
    [Address(RVA = "0x2CF1720", Offset = "0x2CF1720", VA = "0x2CF1720", Slot = "18")]
    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
    }

    [Token(Token = "0x60191C0")]
    [Address(RVA = "0x2CF1864", Offset = "0x2CF1864", VA = "0x2CF1864")]
    public AdvAreaSceneBehaviour()
    {
    }
  }
}
