// Decompiled with JetBrains decompiler
// Type: Gacha.Timeline.GachaStyleImageFocusPlayableMixerBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace Gacha.Timeline
{
  [Token(Token = "0x200159C")]
  public class GachaStyleImageFocusPlayableMixerBehaviour : PlayableBehaviour
  {
    [Token(Token = "0x170012C9")]
    public TimelineClip[] Clips
    {
      [Token(Token = "0x6007A79"), Address(RVA = "0x229CD24", Offset = "0x229CD24", VA = "0x229CD24")] get
      {
        return (TimelineClip[]) null;
      }
      [Token(Token = "0x6007A7A"), Address(RVA = "0x229CD2C", Offset = "0x229CD2C", VA = "0x229CD2C")] set
      {
      }
    }

    [Token(Token = "0x170012CA")]
    public PlayableDirector Director
    {
      [Token(Token = "0x6007A7B"), Address(RVA = "0x229CD34", Offset = "0x229CD34", VA = "0x229CD34")] get
      {
        return (PlayableDirector) null;
      }
      [Token(Token = "0x6007A7C"), Address(RVA = "0x229CD3C", Offset = "0x229CD3C", VA = "0x229CD3C")] set
      {
      }
    }

    [Token(Token = "0x6007A7D")]
    [Address(RVA = "0x229CD44", Offset = "0x229CD44", VA = "0x229CD44", Slot = "21")]
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
    }

    [Token(Token = "0x6007A7E")]
    [Address(RVA = "0x229CF28", Offset = "0x229CF28", VA = "0x229CF28")]
    public GachaStyleImageFocusPlayableMixerBehaviour()
    {
    }
  }
}
