// Decompiled with JetBrains decompiler
// Type: Home.HomeCharacterSpeakController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine.Playables;

#nullable disable
namespace Home
{
  [Token(Token = "0x2000B29")]
  public class HomeCharacterSpeakController
  {
    [Token(Token = "0x40032ED")]
    [FieldOffset(Offset = "0x10")]
    private HomeManager homeManager;
    [Token(Token = "0x40032EE")]
    private const string RESOURCE_TRACK_NAME_ANIMATION = "Act_Anim_Track";
    [Token(Token = "0x40032F1")]
    [FieldOffset(Offset = "0x1A")]
    private bool voiceEnd;
    [Token(Token = "0x40032F2")]
    [FieldOffset(Offset = "0x1B")]
    private bool speakable;
    [Token(Token = "0x40032F3")]
    [FieldOffset(Offset = "0x20")]
    private PlayableDirector PlayingPlayableDirector;

    [Token(Token = "0x17000931")]
    public bool IsSpeakingAnyone
    {
      [Token(Token = "0x6003F67"), Address(RVA = "0x2C1C6A4", Offset = "0x2C1C6A4", VA = "0x2C1C6A4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003F68"), Address(RVA = "0x2C1C6AC", Offset = "0x2C1C6AC", VA = "0x2C1C6AC")] private set
      {
      }
    }

    [Token(Token = "0x17000932")]
    private bool SuspendSignal
    {
      [Token(Token = "0x6003F69"), Address(RVA = "0x2C1C6B8", Offset = "0x2C1C6B8", VA = "0x2C1C6B8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003F6A"), Address(RVA = "0x2C1C6C0", Offset = "0x2C1C6C0", VA = "0x2C1C6C0")] set
      {
      }
    }

    [Token(Token = "0x6003F6B")]
    [Address(RVA = "0x2C1C6CC", Offset = "0x2C1C6CC", VA = "0x2C1C6CC")]
    public HomeCharacterSpeakController(HomeManager homeManager)
    {
    }

    [Token(Token = "0x6003F6C")]
    [Address(RVA = "0x2C1C6FC", Offset = "0x2C1C6FC", VA = "0x2C1C6FC")]
    public void SuspendVoice()
    {
    }

    [Token(Token = "0x6003F6D")]
    [Address(RVA = "0x2C1C710", Offset = "0x2C1C710", VA = "0x2C1C710")]
    public void SwitchSpeakable(bool state)
    {
    }

    [Token(Token = "0x6003F6E")]
    [Address(RVA = "0x2C1C7B4", Offset = "0x2C1C7B4", VA = "0x2C1C7B4")]
    public void Reset()
    {
    }

    [Token(Token = "0x6003F6F")]
    [Address(RVA = "0x2C1C85C", Offset = "0x2C1C85C", VA = "0x2C1C85C")]
    public IEnumerator Speak(
      HomeCharacterPosition position,
      HomeCharacterSerifType serifType,
      MotionType motionType,
      bool cameraUpdate = true)
    {
      return (IEnumerator) null;
    }
  }
}
