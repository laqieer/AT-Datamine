// Decompiled with JetBrains decompiler
// Type: Battle.UniteStratagem.UIAnimationController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Battle.UniteStratagem
{
  [Token(Token = "0x20022AC")]
  [RequireComponent(typeof (PlayableDirector))]
  public class UIAnimationController : MonoBehaviour
  {
    [Token(Token = "0x400921D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayableDirector playable;

    [Token(Token = "0x17002DD3")]
    public bool IsPlaying
    {
      [Token(Token = "0x600D375"), Address(RVA = "0x19D6EE8", Offset = "0x19D6EE8", VA = "0x19D6EE8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D376")]
    [Address(RVA = "0x19D6F0C", Offset = "0x19D6F0C", VA = "0x19D6F0C")]
    public void Prepare(int requiredCountForPlaying)
    {
    }

    [Token(Token = "0x600D377")]
    [Address(RVA = "0x19D7124", Offset = "0x19D7124", VA = "0x19D7124")]
    public void Play()
    {
    }

    [Token(Token = "0x600D378")]
    [Address(RVA = "0x19D7110", Offset = "0x19D7110", VA = "0x19D7110")]
    public void Stop()
    {
    }

    [Token(Token = "0x600D379")]
    [Address(RVA = "0x19D7138", Offset = "0x19D7138", VA = "0x19D7138")]
    public UIAnimationController()
    {
    }
  }
}
