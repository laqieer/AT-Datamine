// Decompiled with JetBrains decompiler
// Type: UnitySingleton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000A4")]
public abstract class UnitySingleton : BaseBehaviour
{
  [Token(Token = "0x400028F")]
  [FieldOffset(Offset = "0x0")]
  private static readonly Dictionary<System.Type, UnitySingleton> instances;
  [Token(Token = "0x4000290")]
  [FieldOffset(Offset = "0x8")]
  private static readonly Dictionary<System.Type, Dictionary<MonoBehaviour, Action<UnitySingleton>>> instanceListeners;

  [Token(Token = "0x17000046")]
  protected bool IsInstanceReady
  {
    [Token(Token = "0x6000553"), Address(RVA = "0x44B130C", Offset = "0x44B130C", VA = "0x44B130C")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000554"), Address(RVA = "0x44B1314", Offset = "0x44B1314", VA = "0x44B1314")] private set
    {
    }
  }

  [Token(Token = "0x6000555")]
  [Address(RVA = "0x44B1320", Offset = "0x44B1320", VA = "0x44B1320")]
  private void RegisterAsSingleInstanceAndInit()
  {
  }

  [Token(Token = "0x6000556")]
  [Address(RVA = "0x44B13BC", Offset = "0x44B13BC", VA = "0x44B13BC")]
  private void InnerInit()
  {
  }

  [Token(Token = "0x6000557")]
  private static S GetOrCreateInstanceOnGameObject<S>(System.Type type) where S : CodeGeneratedSingleton
  {
    return (S) null;
  }

  [Token(Token = "0x6000558")]
  [Address(RVA = "0x44B1458", Offset = "0x44B1458", VA = "0x44B1458")]
  private void NotifyInstanceListeners()
  {
  }

  [Token(Token = "0x6000559")]
  [Address(RVA = "0x44B1668", Offset = "0x44B1668", VA = "0x44B1668")]
  protected void DeclareAsReady()
  {
  }

  [Token(Token = "0x600055A")]
  protected static S GetSynchronousCodeGeneratedInstance<S>() where S : CodeGeneratedSingleton
  {
    return (S) null;
  }

  [Token(Token = "0x600055B")]
  public static void DoWithCodeGeneratedInstance<C>(
    MonoBehaviour sender,
    Action<C> whatToDoWithInstanceWhenItsReady)
    where C : CodeGeneratedSingleton
  {
  }

  [Token(Token = "0x600055C")]
  public static void DoWithSceneInstance<S>(
    MonoBehaviour sender,
    Action<S> whatToDoWithInstanceWhenItsReady)
    where S : SceneSingleton
  {
  }

  [Token(Token = "0x600055D")]
  private static void DoWithExistingInstance<S>(
    MonoBehaviour sender,
    Action<S> whatToDoWithInstanceWhenItsReady)
    where S : UnitySingleton
  {
  }

  [Token(Token = "0x600055E")]
  [Address(RVA = "0x44B1674", Offset = "0x44B1674", VA = "0x44B1674", Slot = "5")]
  protected override sealed void Start()
  {
  }

  [Token(Token = "0x600055F")]
  [Address(RVA = "0x44B1A7C", Offset = "0x44B1A7C", VA = "0x44B1A7C", Slot = "7")]
  protected virtual void SetReadyAndNotifyAfterRegistering()
  {
  }

  [Token(Token = "0x6000560")]
  [Address(RVA = "0x44B1A88", Offset = "0x44B1A88", VA = "0x44B1A88", Slot = "6")]
  protected override void OnDestroy()
  {
  }

  [Token(Token = "0x6000561")]
  [Address(RVA = "0x44ADD4C", Offset = "0x44ADD4C", VA = "0x44ADD4C", Slot = "8")]
  protected virtual void InitAfterRegisteringAsSingleInstance()
  {
  }

  [Token(Token = "0x17000047")]
  protected virtual bool DontDestroySingleton
  {
    [Token(Token = "0x6000562"), Address(RVA = "0x44B1BF8", Offset = "0x44B1BF8", VA = "0x44B1BF8", Slot = "9")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000563")]
  [Address(RVA = "0x44B12AC", Offset = "0x44B12AC", VA = "0x44B12AC")]
  protected UnitySingleton()
  {
  }

  [Token(Token = "0x6000564")]
  [Address(RVA = "0x44B1C00", Offset = "0x44B1C00", VA = "0x44B1C00")]
  static UnitySingleton()
  {
  }
}
