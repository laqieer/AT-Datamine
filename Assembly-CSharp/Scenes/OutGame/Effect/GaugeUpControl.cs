// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Effect.GaugeUpControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Effect
{
  [Token(Token = "0x20036F8")]
  public class GaugeUpControl
  {
    [Token(Token = "0x400F00C")]
    [FieldOffset(Offset = "0x10")]
    private MonoBehaviour mono;
    [Token(Token = "0x400F00D")]
    [FieldOffset(Offset = "0x18")]
    private List<GaugeUpControl.Unit> units;
    [Token(Token = "0x400F00E")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<string, int> dicSingleSePlayCount;
    [Token(Token = "0x400F00F")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<string, GaugeUpControl.SeUnit> dicLoopSePlayCount;

    [Token(Token = "0x6015A6D")]
    [Address(RVA = "0x1D826BC", Offset = "0x1D826BC", VA = "0x1D826BC")]
    public GaugeUpControl(MonoBehaviour mono)
    {
    }

    [Token(Token = "0x6015A6E")]
    [Address(RVA = "0x1D827D4", Offset = "0x1D827D4", VA = "0x1D827D4", Slot = "1")]
    ~GaugeUpControl()
    {
    }

    [Token(Token = "0x6015A6F")]
    [Address(RVA = "0x1D82DB4", Offset = "0x1D82DB4", VA = "0x1D82DB4")]
    public void Play(
      Slider slider,
      float startValue,
      float endValue,
      int upCount,
      Action<int> onCount,
      Action onFinish,
      string seGauge = null,
      string seCount = null,
      float duration = 1f)
    {
    }

    [Token(Token = "0x6015A70")]
    [Address(RVA = "0x1D82F14", Offset = "0x1D82F14", VA = "0x1D82F14")]
    private IEnumerator DoPlay(GaugeUpControl.Unit unit) => (IEnumerator) null;

    [Token(Token = "0x6015A71")]
    [Address(RVA = "0x1D82FB0", Offset = "0x1D82FB0", VA = "0x1D82FB0")]
    private bool PlaySE(string se, bool isLoop = false) => new bool();

    [Token(Token = "0x6015A72")]
    [Address(RVA = "0x1D83184", Offset = "0x1D83184", VA = "0x1D83184")]
    private void StopSE(string se)
    {
    }

    [Token(Token = "0x6015A73")]
    [Address(RVA = "0x1D832A4", Offset = "0x1D832A4", VA = "0x1D832A4")]
    private string PlaySEPerFrame(string se) => (string) null;

    [Token(Token = "0x6015A74")]
    [Address(RVA = "0x1D83488", Offset = "0x1D83488", VA = "0x1D83488")]
    private void ClearSEPerFrame(string handleName)
    {
    }

    [Token(Token = "0x6015A75")]
    [Address(RVA = "0x1D82908", Offset = "0x1D82908", VA = "0x1D82908")]
    public void Skip()
    {
    }

    [Token(Token = "0x1700479C")]
    public bool IsPlaying
    {
      [Token(Token = "0x6015A76"), Address(RVA = "0x1D8356C", Offset = "0x1D8356C", VA = "0x1D8356C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x20036F9")]
    private class Unit
    {
      [Token(Token = "0x400F010")]
      [FieldOffset(Offset = "0x10")]
      public Slider target;
      [Token(Token = "0x400F011")]
      [FieldOffset(Offset = "0x18")]
      public float startValue;
      [Token(Token = "0x400F012")]
      [FieldOffset(Offset = "0x1C")]
      public float endValue;
      [Token(Token = "0x400F013")]
      [FieldOffset(Offset = "0x20")]
      public float duration;
      [Token(Token = "0x400F014")]
      [FieldOffset(Offset = "0x24")]
      public int upCount;
      [Token(Token = "0x400F015")]
      [FieldOffset(Offset = "0x28")]
      public string seGauge;
      [Token(Token = "0x400F016")]
      [FieldOffset(Offset = "0x30")]
      public string seCount;
      [Token(Token = "0x400F017")]
      [FieldOffset(Offset = "0x38")]
      public Action<int> onCount;
      [Token(Token = "0x400F018")]
      [FieldOffset(Offset = "0x40")]
      public Action onFinish;

      [Token(Token = "0x1700479D")]
      public Coroutine Coroutine
      {
        [Token(Token = "0x6015A77"), Address(RVA = "0x1D835B4", Offset = "0x1D835B4", VA = "0x1D835B4")] get
        {
          return (Coroutine) null;
        }
        [Token(Token = "0x6015A78"), Address(RVA = "0x1D835BC", Offset = "0x1D835BC", VA = "0x1D835BC")] set
        {
        }
      }

      [Token(Token = "0x1700479E")]
      public bool isPlayingSE
      {
        [Token(Token = "0x6015A79"), Address(RVA = "0x1D835C4", Offset = "0x1D835C4", VA = "0x1D835C4")] get
        {
          return new bool();
        }
        [Token(Token = "0x6015A7A"), Address(RVA = "0x1D835CC", Offset = "0x1D835CC", VA = "0x1D835CC")] set
        {
        }
      }

      [Token(Token = "0x1700479F")]
      public int Count
      {
        [Token(Token = "0x6015A7B"), Address(RVA = "0x1D835D8", Offset = "0x1D835D8", VA = "0x1D835D8")] get
        {
          return new int();
        }
        [Token(Token = "0x6015A7C"), Address(RVA = "0x1D835E0", Offset = "0x1D835E0", VA = "0x1D835E0")] set
        {
        }
      }

      [Token(Token = "0x6015A7D")]
      [Address(RVA = "0x1D82F0C", Offset = "0x1D82F0C", VA = "0x1D82F0C")]
      public Unit()
      {
      }
    }

    [Token(Token = "0x20036FA")]
    private class SeUnit
    {
      [Token(Token = "0x400F01C")]
      [FieldOffset(Offset = "0x10")]
      public uint handle;
      [Token(Token = "0x400F01D")]
      [FieldOffset(Offset = "0x14")]
      public int count;

      [Token(Token = "0x6015A7E")]
      [Address(RVA = "0x1D8317C", Offset = "0x1D8317C", VA = "0x1D8317C")]
      public SeUnit()
      {
      }
    }
  }
}
