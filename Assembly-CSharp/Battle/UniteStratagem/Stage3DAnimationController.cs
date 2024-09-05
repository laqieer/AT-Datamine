// Decompiled with JetBrains decompiler
// Type: Battle.UniteStratagem.Stage3DAnimationController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace Battle.UniteStratagem
{
  [Token(Token = "0x20022A9")]
  [RequireComponent(typeof (PlayableDirector))]
  public class Stage3DAnimationController : MonoBehaviour
  {
    [Token(Token = "0x4009210")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [HideInInspector]
    private PlayableDirector playable;
    [Token(Token = "0x4009211")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string characterTrackName;

    [Token(Token = "0x17002DD1")]
    public bool IsPlaying
    {
      [Token(Token = "0x600D362"), Address(RVA = "0x19D6444", Offset = "0x19D6444", VA = "0x19D6444")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D363")]
    [Address(RVA = "0x19D6468", Offset = "0x19D6468", VA = "0x19D6468")]
    public void Prepare(GameObject character)
    {
    }

    [Token(Token = "0x600D364")]
    [Address(RVA = "0x19D6788", Offset = "0x19D6788", VA = "0x19D6788")]
    private void SetGenericBindingTo(Object sourceKeyObject, Object value)
    {
    }

    [Token(Token = "0x600D365")]
    [Address(RVA = "0x19D6824", Offset = "0x19D6824", VA = "0x19D6824")]
    private void SetMutedFlagToTracksElementAt(
      IEnumerable<TrackAsset> tracks,
      int at,
      int count,
      bool flag)
    {
    }

    [Token(Token = "0x600D366")]
    [Address(RVA = "0x19D68A0", Offset = "0x19D68A0", VA = "0x19D68A0")]
    public void Play()
    {
    }

    [Token(Token = "0x600D367")]
    [Address(RVA = "0x19D68B4", Offset = "0x19D68B4", VA = "0x19D68B4")]
    public void Stop()
    {
    }

    [Token(Token = "0x600D368")]
    [Address(RVA = "0x19D68C8", Offset = "0x19D68C8", VA = "0x19D68C8")]
    public Stage3DAnimationController()
    {
    }
  }
}
