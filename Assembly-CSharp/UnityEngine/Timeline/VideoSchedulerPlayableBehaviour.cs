// Decompiled with JetBrains decompiler
// Type: UnityEngine.Timeline.VideoSchedulerPlayableBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine.Playables;

#nullable disable
namespace UnityEngine.Timeline
{
  [Token(Token = "0x2003F42")]
  public sealed class VideoSchedulerPlayableBehaviour : PlayableBehaviour
  {
    [Token(Token = "0x4011508")]
    [FieldOffset(Offset = "0x10")]
    private IEnumerable<TimelineClip> m_Clips;
    [Token(Token = "0x4011509")]
    [FieldOffset(Offset = "0x18")]
    private PlayableDirector m_Director;

    [Token(Token = "0x17005245")]
    internal PlayableDirector director
    {
      [Token(Token = "0x60198AD"), Address(RVA = "0x37486EC", Offset = "0x37486EC", VA = "0x37486EC")] get
      {
        return (PlayableDirector) null;
      }
      [Token(Token = "0x60198AE"), Address(RVA = "0x37486F4", Offset = "0x37486F4", VA = "0x37486F4")] set
      {
      }
    }

    [Token(Token = "0x17005246")]
    internal IEnumerable<TimelineClip> clips
    {
      [Token(Token = "0x60198AF"), Address(RVA = "0x37486FC", Offset = "0x37486FC", VA = "0x37486FC")] get
      {
        return (IEnumerable<TimelineClip>) null;
      }
      [Token(Token = "0x60198B0"), Address(RVA = "0x3748704", Offset = "0x3748704", VA = "0x3748704")] set
      {
      }
    }

    [Token(Token = "0x60198B1")]
    [Address(RVA = "0x374870C", Offset = "0x374870C", VA = "0x374870C", Slot = "21")]
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
    }

    [Token(Token = "0x60198B2")]
    [Address(RVA = "0x3748BC0", Offset = "0x3748BC0", VA = "0x3748BC0")]
    public VideoSchedulerPlayableBehaviour()
    {
    }
  }
}
