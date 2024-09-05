// Decompiled with JetBrains decompiler
// Type: UnityEngine.Timeline.UrlVideoSchedulerPlayableBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine.Playables;

#nullable disable
namespace UnityEngine.Timeline
{
  [Token(Token = "0x2003F3E")]
  public sealed class UrlVideoSchedulerPlayableBehaviour : PlayableBehaviour
  {
    [Token(Token = "0x40114F5")]
    [FieldOffset(Offset = "0x10")]
    private IEnumerable<TimelineClip> m_Clips;
    [Token(Token = "0x40114F6")]
    [FieldOffset(Offset = "0x18")]
    private PlayableDirector m_Director;

    [Token(Token = "0x17005243")]
    internal PlayableDirector director
    {
      [Token(Token = "0x6019895"), Address(RVA = "0x37473D4", Offset = "0x37473D4", VA = "0x37473D4")] get
      {
        return (PlayableDirector) null;
      }
      [Token(Token = "0x6019896"), Address(RVA = "0x37473DC", Offset = "0x37473DC", VA = "0x37473DC")] set
      {
      }
    }

    [Token(Token = "0x17005244")]
    internal IEnumerable<TimelineClip> clips
    {
      [Token(Token = "0x6019897"), Address(RVA = "0x37473E4", Offset = "0x37473E4", VA = "0x37473E4")] get
      {
        return (IEnumerable<TimelineClip>) null;
      }
      [Token(Token = "0x6019898"), Address(RVA = "0x37473EC", Offset = "0x37473EC", VA = "0x37473EC")] set
      {
      }
    }

    [Token(Token = "0x6019899")]
    [Address(RVA = "0x37473F4", Offset = "0x37473F4", VA = "0x37473F4", Slot = "21")]
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
    }

    [Token(Token = "0x601989A")]
    [Address(RVA = "0x37478A8", Offset = "0x37478A8", VA = "0x37478A8")]
    public UrlVideoSchedulerPlayableBehaviour()
    {
    }
  }
}
