// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.DLCBackground
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x20014AF")]
  public class DLCBackground : SingletonMonoBehaviour<DLCBackground>
  {
    [Token(Token = "0x4005EF1")]
    [FieldOffset(Offset = "0x1C")]
    protected readonly int BACKGROUND_MAX;
    [Token(Token = "0x4005EF2")]
    [FieldOffset(Offset = "0x20")]
    protected readonly long FILESIZE_LIMIT;
    [Token(Token = "0x4005EF3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int backgroundCount;
    [Token(Token = "0x4005EF4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Coroutine coroutine;
    [Token(Token = "0x4005EF5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private bool pause;
    [Token(Token = "0x4005EF6")]
    [FieldOffset(Offset = "0x39")]
    [SerializeField]
    private bool completed;
    [Token(Token = "0x4005EF7")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private int index;
    [Token(Token = "0x4005EF8")]
    [FieldOffset(Offset = "0x40")]
    private Dictionary<string, int> downloadFiles;
    [Token(Token = "0x4005EFA")]
    [FieldOffset(Offset = "0x50")]
    private bool cancelFlag;

    [Token(Token = "0x170011D5")]
    public bool IsBackgroudExecutable
    {
      [Token(Token = "0x600746F"), Address(RVA = "0x43EE9C8", Offset = "0x43EE9C8", VA = "0x43EE9C8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170011D6")]
    public bool IsExecuting
    {
      [Token(Token = "0x6007470"), Address(RVA = "0x43EEA64", Offset = "0x43EEA64", VA = "0x43EEA64")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170011D7")]
    public bool IsCompleted
    {
      [Token(Token = "0x6007471"), Address(RVA = "0x43EEA74", Offset = "0x43EEA74", VA = "0x43EEA74")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170011D8")]
    public float Progress
    {
      [Token(Token = "0x6007472"), Address(RVA = "0x43EEA7C", Offset = "0x43EEA7C", VA = "0x43EEA7C")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170011D9")]
    public long TotalSize
    {
      [Token(Token = "0x6007473"), Address(RVA = "0x43EEB24", Offset = "0x43EEB24", VA = "0x43EEB24")] get
      {
        return new long();
      }
      [Token(Token = "0x6007474"), Address(RVA = "0x43EEB2C", Offset = "0x43EEB2C", VA = "0x43EEB2C")] private set
      {
      }
    }

    [Token(Token = "0x6007475")]
    [Address(RVA = "0x43EEB34", Offset = "0x43EEB34", VA = "0x43EEB34")]
    public void StartDownload()
    {
    }

    [Token(Token = "0x6007476")]
    [Address(RVA = "0x43EEBDC", Offset = "0x43EEBDC", VA = "0x43EEBDC")]
    public void StopDownload()
    {
    }

    [Token(Token = "0x6007477")]
    [Address(RVA = "0x43EEC4C", Offset = "0x43EEC4C", VA = "0x43EEC4C")]
    public void RequestCancel()
    {
    }

    [Token(Token = "0x6007478")]
    [Address(RVA = "0x43EEB74", Offset = "0x43EEB74", VA = "0x43EEB74")]
    private IEnumerator BackgroundCoroutine() => (IEnumerator) null;

    [Token(Token = "0x6007479")]
    [Address(RVA = "0x43EEC80", Offset = "0x43EEC80", VA = "0x43EEC80")]
    public void PauseBackground(Action callback = null)
    {
    }

    [Token(Token = "0x600747A")]
    [Address(RVA = "0x43EEC94", Offset = "0x43EEC94", VA = "0x43EEC94")]
    public void ResumeBackground()
    {
    }

    [Token(Token = "0x600747B")]
    [Address(RVA = "0x43EECA4", Offset = "0x43EECA4", VA = "0x43EECA4")]
    public DLCBackground()
    {
    }
  }
}
