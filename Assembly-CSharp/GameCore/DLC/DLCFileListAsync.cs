// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.DLCFileListAsync
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x20014B3")]
  public class DLCFileListAsync : SingletonMonoBehaviour<DLCFileListAsync>
  {
    [Token(Token = "0x4005F06")]
    [FieldOffset(Offset = "0x20")]
    private Coroutine main;
    [Token(Token = "0x4005F07")]
    [FieldOffset(Offset = "0x28")]
    private Coroutine sub;

    [Token(Token = "0x6007489")]
    [Address(RVA = "0x43EF8E0", Offset = "0x43EF8E0", VA = "0x43EF8E0")]
    public void Begin(
      AssetBundleManager.DlcSplitNumber[] include,
      bool branch,
      UnityAction<List<long>> result)
    {
    }

    [Token(Token = "0x600748A")]
    [Address(RVA = "0x43EF9AC", Offset = "0x43EF9AC", VA = "0x43EF9AC")]
    private IEnumerator Calc(
      AssetBundleManager.DlcSplitNumber[] include,
      bool branch,
      UnityAction<List<long>> result)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600748B")]
    [Address(RVA = "0x43EF96C", Offset = "0x43EF96C", VA = "0x43EF96C")]
    public void Cancel()
    {
    }

    [Token(Token = "0x600748C")]
    [Address(RVA = "0x43EFA68", Offset = "0x43EFA68", VA = "0x43EFA68")]
    public void End()
    {
    }

    [Token(Token = "0x170011DC")]
    public bool IsEnd
    {
      [Token(Token = "0x600748D"), Address(RVA = "0x43EF94C", Offset = "0x43EF94C", VA = "0x43EF94C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600748E")]
    [Address(RVA = "0x43EFB44", Offset = "0x43EFB44", VA = "0x43EFB44")]
    public DLCFileListAsync()
    {
    }
  }
}
