// Decompiled with JetBrains decompiler
// Type: ADV2.Playables.PlayableDirectorBehaviourBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace ADV2.Playables
{
  [Token(Token = "0x2003E8D")]
  public abstract class PlayableDirectorBehaviourBase : MonoBehaviour
  {
    [Token(Token = "0x4011281")]
    [FieldOffset(Offset = "0x18")]
    private PlayableDirector directorEntity;

    [Token(Token = "0x170051B4")]
    protected PlayableDirector director
    {
      [Token(Token = "0x60192E2"), Address(RVA = "0x2D0194C", Offset = "0x2D0194C", VA = "0x2D0194C")] get
      {
        return (PlayableDirector) null;
      }
    }

    [Token(Token = "0x60192E3")]
    [Address(RVA = "0x2D019E0", Offset = "0x2D019E0", VA = "0x2D019E0", Slot = "4")]
    public virtual void Play()
    {
    }

    [Token(Token = "0x60192E4")]
    [Address(RVA = "0x2D019FC", Offset = "0x2D019FC", VA = "0x2D019FC", Slot = "5")]
    public virtual void Stop()
    {
    }

    [Token(Token = "0x60192E5")]
    [Address(RVA = "0x2D01A18", Offset = "0x2D01A18", VA = "0x2D01A18")]
    protected PlayableDirectorBehaviourBase()
    {
    }
  }
}
