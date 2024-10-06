// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2LinkageAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Animation;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003E13")]
  [RequireComponent(typeof (FreeAnimatorController))]
  [ExecuteAlways]
  public class Adv2LinkageAnimation : MonoBehaviour
  {
    [Token(Token = "0x4011063")]
    [FieldOffset(Offset = "0x18")]
    public string BaseLayerName;
    [Token(Token = "0x4011064")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected Adv2AnimationPack linkagePack;
    [Token(Token = "0x4011065")]
    [FieldOffset(Offset = "0x28")]
    protected List<string> playingKeys;
    [Token(Token = "0x4011066")]
    [FieldOffset(Offset = "0x30")]
    protected List<Adv2LinkageAnimation.GroupParam> playingValues;
    [Token(Token = "0x4011067")]
    [FieldOffset(Offset = "0x38")]
    protected List<Adv2LinkageAnimation.ReserveParam> baseReserve;
    [Token(Token = "0x4011068")]
    [FieldOffset(Offset = "0x40")]
    protected FreeAnimatorController system;

    [Token(Token = "0x1700514C")]
    public Adv2AnimationPack LinkagePack
    {
      [Token(Token = "0x6018FF4"), Address(RVA = "0x2CBABF8", Offset = "0x2CBABF8", VA = "0x2CBABF8")] set
      {
      }
    }

    [Token(Token = "0x1700514D")]
    public float SystemChangeTime
    {
      [Token(Token = "0x6018FF5"), Address(RVA = "0x2CBAC00", Offset = "0x2CBAC00", VA = "0x2CBAC00")] get
      {
        return new float();
      }
      [Token(Token = "0x6018FF6"), Address(RVA = "0x2CBAC08", Offset = "0x2CBAC08", VA = "0x2CBAC08")] set
      {
      }
    }

    [Token(Token = "0x6018FF7")]
    [Address(RVA = "0x2CB4B8C", Offset = "0x2CB4B8C", VA = "0x2CB4B8C")]
    public string RequestAnimation(
      string baseKey,
      float transitionDuration,
      float playSpeed,
      bool isLoopBase,
      Adv2Manager.OnProccessSignal signal)
    {
      return (string) null;
    }

    [Token(Token = "0x6018FF8")]
    [Address(RVA = "0x2CBB078", Offset = "0x2CBB078", VA = "0x2CBB078")]
    public void ReserveAnimation(
      string baseKey,
      float transitionDuration,
      float playSpeed,
      bool isLoopBase)
    {
    }

    [Token(Token = "0x6018FF9")]
    [Address(RVA = "0x2CBB364", Offset = "0x2CBB364", VA = "0x2CBB364")]
    protected void SetReserveAnimation(float extraSeconds, Adv2Manager.OnProccessSignal signal)
    {
    }

    [Token(Token = "0x6018FFA")]
    [Address(RVA = "0x2CB464C", Offset = "0x2CB464C", VA = "0x2CB464C")]
    public string RequestLinkAnimation(
      string linkTag,
      string animationTag,
      float transitionDuration,
      float playSpeed,
      ClipPlayMode playMode,
      Adv2Manager.OnProccessSignal signal)
    {
      return (string) null;
    }

    [Token(Token = "0x6018FFB")]
    [Address(RVA = "0x2CB4394", Offset = "0x2CB4394", VA = "0x2CB4394")]
    public void RemoveAnimation(string clipTag)
    {
    }

    [Token(Token = "0x6018FFC")]
    [Address(RVA = "0x2CBB684", Offset = "0x2CBB684", VA = "0x2CBB684")]
    public void FreeAnimatorControllerChangeControll(bool flag)
    {
    }

    [Token(Token = "0x6018FFD")]
    [Address(RVA = "0x2CBB6AC", Offset = "0x2CBB6AC", VA = "0x2CBB6AC")]
    public void SetClipWeight(string clipTag, float weight)
    {
    }

    [Token(Token = "0x6018FFE")]
    [Address(RVA = "0x2CBB818", Offset = "0x2CBB818", VA = "0x2CBB818")]
    private void UpdateGroup(
      int index,
      float deltaTime,
      Dictionary<string, float> baseWeightList,
      bool checkSignal)
    {
    }

    [Token(Token = "0x6018FFF")]
    [Address(RVA = "0x2CBBE20", Offset = "0x2CBBE20", VA = "0x2CBBE20")]
    private void Update()
    {
    }

    [Token(Token = "0x6019000")]
    [Address(RVA = "0x2CBBF0C", Offset = "0x2CBBF0C", VA = "0x2CBBF0C")]
    public Adv2LinkageAnimation()
    {
    }

    [Token(Token = "0x2003E14")]
    public class ReserveLinagePack
    {
      [Token(Token = "0x401106A")]
      [FieldOffset(Offset = "0x10")]
      public Adv2AnimationPack AnimationPack;

      [Token(Token = "0x6019001")]
      [Address(RVA = "0x2CBA9D0", Offset = "0x2CBA9D0", VA = "0x2CBA9D0")]
      public ReserveLinagePack()
      {
      }
    }

    [Token(Token = "0x2003E15")]
    [Serializable]
    protected class ReserveParam
    {
      [Token(Token = "0x401106B")]
      [FieldOffset(Offset = "0x10")]
      public string BaseKey;
      [Token(Token = "0x401106C")]
      [FieldOffset(Offset = "0x18")]
      public float TransitionDuration;
      [Token(Token = "0x401106D")]
      [FieldOffset(Offset = "0x1C")]
      public float PlaySpeed;
      [Token(Token = "0x401106E")]
      [FieldOffset(Offset = "0x20")]
      public bool IsLoopBase;

      [Token(Token = "0x6019002")]
      [Address(RVA = "0x2CBB35C", Offset = "0x2CBB35C", VA = "0x2CBB35C")]
      public ReserveParam()
      {
      }
    }

    [Token(Token = "0x2003E16")]
    [Serializable]
    protected class ClipParam : AnimationClipParam
    {
      [Token(Token = "0x401106F")]
      [FieldOffset(Offset = "0x38")]
      public Adv2Manager.OnProccessSignal Signal;
      [Token(Token = "0x4011070")]
      [FieldOffset(Offset = "0x40")]
      public Adv2LinkageAnimation.ClipParam.OnFinishPlayOne FinishPlayOneFunc;

      [Token(Token = "0x6019003")]
      [Address(RVA = "0x2CBC048", Offset = "0x2CBC048", VA = "0x2CBC048")]
      public ClipParam()
      {
      }

      [Token(Token = "0x6019004")]
      [Address(RVA = "0x2CBC0D8", Offset = "0x2CBC0D8", VA = "0x2CBC0D8")]
      private void Callback(AnimationClipParam param)
      {
      }

      [Token(Token = "0x2003E17")]
      public delegate void OnFinishPlayOne(float extraSeconds, Adv2Manager.OnProccessSignal signal);
    }

    [Token(Token = "0x2003E18")]
    [Serializable]
    protected class GroupParam
    {
      [Token(Token = "0x4011071")]
      [FieldOffset(Offset = "0x10")]
      public List<string> Keys;
      [Token(Token = "0x4011072")]
      [FieldOffset(Offset = "0x18")]
      public List<Adv2LinkageAnimation.ClipParam> Values;

      [Token(Token = "0x6019009")]
      [Address(RVA = "0x2CBACD0", Offset = "0x2CBACD0", VA = "0x2CBACD0")]
      public string Add(
        string baseTag,
        string linkTag,
        float transitionDuration,
        float playDuration,
        float playSpeed,
        ClipPlayMode playMode,
        Adv2Manager.OnProccessSignal signal)
      {
        return (string) null;
      }

      [Token(Token = "0x601900A")]
      [Address(RVA = "0x2CBB3FC", Offset = "0x2CBB3FC", VA = "0x2CBB3FC")]
      public void RemoveAll(string baseTag)
      {
      }

      [Token(Token = "0x601900B")]
      [Address(RVA = "0x2CBB534", Offset = "0x2CBB534", VA = "0x2CBB534")]
      public void Remove(string baseTag)
      {
      }

      [Token(Token = "0x601900C")]
      [Address(RVA = "0x2CBAC10", Offset = "0x2CBAC10", VA = "0x2CBAC10")]
      public GroupParam()
      {
      }
    }
  }
}
