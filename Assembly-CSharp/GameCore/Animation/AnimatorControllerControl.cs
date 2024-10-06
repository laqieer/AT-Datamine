// Decompiled with JetBrains decompiler
// Type: GameCore.Animation.AnimatorControllerControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Animations;

#nullable disable
namespace GameCore.Animation
{
  [Token(Token = "0x20014DD")]
  public class AnimatorControllerControl : IChildPlayableAPI
  {
    [Token(Token = "0x4005FF0")]
    [FieldOffset(Offset = "0x18")]
    protected RuntimeAnimatorController runtimeAnimatorController;
    [Token(Token = "0x4005FF1")]
    [FieldOffset(Offset = "0x20")]
    protected AnimatorControllerPlayable playable;

    [Token(Token = "0x17001223")]
    public int ConnectIndex
    {
      [Token(Token = "0x60075BA"), Address(RVA = "0x43FA7A0", Offset = "0x43FA7A0", VA = "0x43FA7A0")] private set
      {
      }
      [Token(Token = "0x60075BB"), Address(RVA = "0x43FA7A8", Offset = "0x43FA7A8", VA = "0x43FA7A8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60075BC")]
    [Address(RVA = "0x43FA7B0", Offset = "0x43FA7B0", VA = "0x43FA7B0")]
    public AnimatorControllerControl()
    {
    }

    [Token(Token = "0x60075BD")]
    [Address(RVA = "0x43FA7B8", Offset = "0x43FA7B8", VA = "0x43FA7B8")]
    public AnimatorControllerControl(
      AnimationMixerPlayable rootPlayable,
      RuntimeAnimatorController controller,
      float weight)
    {
    }

    [Token(Token = "0x60075BE")]
    [Address(RVA = "0x43FA80C", Offset = "0x43FA80C", VA = "0x43FA80C")]
    public void Initialize(
      AnimationMixerPlayable rootPlayable,
      RuntimeAnimatorController controller,
      float weight)
    {
    }

    [Token(Token = "0x60075BF")]
    [Address(RVA = "0x43FA9F0", Offset = "0x43FA9F0", VA = "0x43FA9F0", Slot = "5")]
    public bool IsValid() => new bool();

    [Token(Token = "0x60075C0")]
    [Address(RVA = "0x43FAA38", Offset = "0x43FAA38", VA = "0x43FAA38")]
    public void ResetTrigger(string name)
    {
    }

    [Token(Token = "0x60075C1")]
    [Address(RVA = "0x43FAAD8", Offset = "0x43FAAD8", VA = "0x43FAAD8")]
    public void SetTrigger(string name)
    {
    }

    [Token(Token = "0x60075C2")]
    [Address(RVA = "0x43FAB78", Offset = "0x43FAB78", VA = "0x43FAB78")]
    public void SetBool(string name, bool value)
    {
    }

    [Token(Token = "0x60075C3")]
    [Address(RVA = "0x43FAC20", Offset = "0x43FAC20", VA = "0x43FAC20")]
    public bool GetBool(string name) => new bool();

    [Token(Token = "0x60075C4")]
    [Address(RVA = "0x43FACC4", Offset = "0x43FACC4", VA = "0x43FACC4")]
    public void SetFloat(string name, float value)
    {
    }

    [Token(Token = "0x60075C5")]
    [Address(RVA = "0x43FAD78", Offset = "0x43FAD78", VA = "0x43FAD78")]
    public float GetFloat(string name) => new float();

    [Token(Token = "0x60075C6")]
    [Address(RVA = "0x43FAE1C", Offset = "0x43FAE1C", VA = "0x43FAE1C")]
    public void Play(string stateName)
    {
    }

    [Token(Token = "0x17001224")]
    public int layerCount
    {
      [Token(Token = "0x60075C7"), Address(RVA = "0x43FAEBC", Offset = "0x43FAEBC", VA = "0x43FAEBC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60075C8")]
    [Address(RVA = "0x43FAF4C", Offset = "0x43FAF4C", VA = "0x43FAF4C")]
    public string GetLayerName(int layerIndex) => (string) null;

    [Token(Token = "0x60075C9")]
    [Address(RVA = "0x43FB00C", Offset = "0x43FB00C", VA = "0x43FB00C")]
    public bool IsInTransition(int layerIndex) => new bool();

    [Token(Token = "0x60075CA")]
    [Address(RVA = "0x43FB0B0", Offset = "0x43FB0B0", VA = "0x43FB0B0")]
    public void SetSpeed(float speed)
    {
    }

    [Token(Token = "0x60075CB")]
    [Address(RVA = "0x43FB108", Offset = "0x43FB108", VA = "0x43FB108")]
    public void Destroy()
    {
    }

    [Token(Token = "0x60075CC")]
    [Address(RVA = "0x43FB204", Offset = "0x43FB204", VA = "0x43FB204")]
    public AnimatorControllerControl.Handle GetHandle() => new AnimatorControllerControl.Handle();

    [Token(Token = "0x20014DE")]
    public struct Handle
    {
      [Token(Token = "0x4005FF2")]
      [FieldOffset(Offset = "0x0")]
      public static AnimatorControllerControl.Handle Default;
      [Token(Token = "0x4005FF3")]
      [FieldOffset(Offset = "0x0")]
      public int connectIndex;

      [Token(Token = "0x60075CD")]
      [Address(RVA = "0x43FB20C", Offset = "0x43FB20C", VA = "0x43FB20C")]
      static Handle()
      {
      }
    }
  }
}
