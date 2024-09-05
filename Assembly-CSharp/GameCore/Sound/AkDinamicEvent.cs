// Decompiled with JetBrains decompiler
// Type: GameCore.Sound.AkDinamicEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using AK.Wwise;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.Sound
{
  [Token(Token = "0x2000C3C")]
  [RequireComponent(typeof (AkGameObj))]
  public class AkDinamicEvent : AkTriggerHandler
  {
    [Token(Token = "0x4003773")]
    [FieldOffset(Offset = "0x2C")]
    public AkActionOnEventType actionOnEventType;
    [Token(Token = "0x4003774")]
    [FieldOffset(Offset = "0x30")]
    public AkCurveInterpolation curveInterpolation;
    [Token(Token = "0x4003775")]
    [FieldOffset(Offset = "0x34")]
    public bool enableActionOnEvent;
    [Token(Token = "0x4003776")]
    [FieldOffset(Offset = "0x35")]
    public bool useCallbacks;
    [Token(Token = "0x4003777")]
    [FieldOffset(Offset = "0x38")]
    public List<AkDinamicEvent.CallbackData> Callbacks;
    [Token(Token = "0x4003778")]
    [FieldOffset(Offset = "0x40")]
    public uint playingId;
    [Token(Token = "0x4003779")]
    [FieldOffset(Offset = "0x48")]
    public GameObject soundEmitterObject;
    [Token(Token = "0x400377A")]
    [FieldOffset(Offset = "0x50")]
    public float transitionDuration;
    [Token(Token = "0x400377B")]
    [FieldOffset(Offset = "0x58")]
    private AkEventCallbackMsg EventCallbackMsg;
    [Token(Token = "0x400377C")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private string eventName;

    [Token(Token = "0x6004659")]
    [Address(RVA = "0x3516454", Offset = "0x3516454", VA = "0x3516454", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600465A")]
    [Address(RVA = "0x35164D4", Offset = "0x35164D4", VA = "0x35164D4")]
    private void Callback(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info)
    {
    }

    [Token(Token = "0x600465B")]
    [Address(RVA = "0x3516628", Offset = "0x3516628", VA = "0x3516628", Slot = "4")]
    public override void HandleEvent(GameObject in_gameObject)
    {
    }

    [Token(Token = "0x17000A32")]
    public string Name
    {
      [Token(Token = "0x600465C"), Address(RVA = "0x3516A50", Offset = "0x3516A50", VA = "0x3516A50")] private set
      {
      }
      [Token(Token = "0x600465D"), Address(RVA = "0x3516A58", Offset = "0x3516A58", VA = "0x3516A58")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600465E")]
    [Address(RVA = "0x3516A60", Offset = "0x3516A60", VA = "0x3516A60")]
    public bool IsValid() => new bool();

    [Token(Token = "0x600465F")]
    [Address(RVA = "0x3516A80", Offset = "0x3516A80", VA = "0x3516A80")]
    public void Setup(string name)
    {
    }

    [Token(Token = "0x6004660")]
    [Address(RVA = "0x3516A88", Offset = "0x3516A88", VA = "0x3516A88")]
    public void Stop(int _transitionDuration)
    {
    }

    [Token(Token = "0x6004661")]
    [Address(RVA = "0x3516AA0", Offset = "0x3516AA0", VA = "0x3516AA0")]
    public void Stop(int _transitionDuration, AkCurveInterpolation _curveInterpolation)
    {
    }

    [Token(Token = "0x6004662")]
    [Address(RVA = "0x35169CC", Offset = "0x35169CC", VA = "0x35169CC")]
    protected uint Post(GameObject gameObject) => new uint();

    [Token(Token = "0x6004663")]
    [Address(RVA = "0x3516918", Offset = "0x3516918", VA = "0x3516918")]
    protected uint Post(
      GameObject gameObject,
      uint flags,
      AkCallbackManager.EventCallback callback,
      object cookie = null)
    {
      return new uint();
    }

    [Token(Token = "0x6004664")]
    [Address(RVA = "0x3516AB8", Offset = "0x3516AB8", VA = "0x3516AB8")]
    protected void Stop(
      GameObject gameObject,
      int transitionDuration = 0,
      AkCurveInterpolation curveInterpolation = AkCurveInterpolation.AkCurveInterpolation_Linear)
    {
    }

    [Token(Token = "0x6004665")]
    [Address(RVA = "0x3516868", Offset = "0x3516868", VA = "0x3516868")]
    protected void ExecuteAction(
      GameObject gameObject,
      AkActionOnEventType actionOnEventType,
      int transitionDuration,
      AkCurveInterpolation curveInterpolation)
    {
    }

    [Token(Token = "0x6004666")]
    [Address(RVA = "0x3516AC8", Offset = "0x3516AC8", VA = "0x3516AC8")]
    public AkDinamicEvent()
    {
    }

    [Token(Token = "0x2000C3D")]
    [Serializable]
    public class CallbackData
    {
      [Token(Token = "0x400377D")]
      [FieldOffset(Offset = "0x10")]
      public CallbackFlags Flags;
      [Token(Token = "0x400377E")]
      [FieldOffset(Offset = "0x18")]
      public string FunctionName;
      [Token(Token = "0x400377F")]
      [FieldOffset(Offset = "0x20")]
      public GameObject GameObject;

      [Token(Token = "0x6004667")]
      [Address(RVA = "0x3516580", Offset = "0x3516580", VA = "0x3516580")]
      public void CallFunction(AkEventCallbackMsg eventCallbackMsg)
      {
      }

      [Token(Token = "0x6004668")]
      [Address(RVA = "0x3516B70", Offset = "0x3516B70", VA = "0x3516B70")]
      public CallbackData()
      {
      }
    }
  }
}
