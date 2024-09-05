// Decompiled with JetBrains decompiler
// Type: Story.StoryArchive.ActionContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Story.StoryArchive
{
  [Token(Token = "0x200061E")]
  public class ActionContext
  {
    [Token(Token = "0x1700050C")]
    public bool IsInSequence
    {
      [Token(Token = "0x600235A"), Address(RVA = "0x2DA5884", Offset = "0x2DA5884", VA = "0x2DA5884")] get
      {
        return new bool();
      }
      [Token(Token = "0x600235B"), Address(RVA = "0x2DA588C", Offset = "0x2DA588C", VA = "0x2DA588C")] set
      {
      }
    }

    [Token(Token = "0x1700050D")]
    public ViewStateMachine ViewStateMachine
    {
      [Token(Token = "0x600235C"), Address(RVA = "0x2DA5898", Offset = "0x2DA5898", VA = "0x2DA5898")] get
      {
        return (ViewStateMachine) null;
      }
      [Token(Token = "0x600235D"), Address(RVA = "0x2DA58A0", Offset = "0x2DA58A0", VA = "0x2DA58A0")] private set
      {
      }
    }

    [Token(Token = "0x1700050E")]
    public Transform RootTransform
    {
      [Token(Token = "0x600235E"), Address(RVA = "0x2DA58A8", Offset = "0x2DA58A8", VA = "0x2DA58A8")] get
      {
        return (Transform) null;
      }
      [Token(Token = "0x600235F"), Address(RVA = "0x2DA58B0", Offset = "0x2DA58B0", VA = "0x2DA58B0")] set
      {
      }
    }

    [Token(Token = "0x1700050F")]
    public GameObject CoroutineWorker
    {
      [Token(Token = "0x6002360"), Address(RVA = "0x2DA58B8", Offset = "0x2DA58B8", VA = "0x2DA58B8")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17000510")]
    public Action ExitProcess
    {
      [Token(Token = "0x6002361"), Address(RVA = "0x2DA58D4", Offset = "0x2DA58D4", VA = "0x2DA58D4")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6002362"), Address(RVA = "0x2DA58DC", Offset = "0x2DA58DC", VA = "0x2DA58DC")] private set
      {
      }
    }

    [Token(Token = "0x17000511")]
    public SceneController SceneController
    {
      [Token(Token = "0x6002363"), Address(RVA = "0x2DA58E4", Offset = "0x2DA58E4", VA = "0x2DA58E4")] get
      {
        return (SceneController) null;
      }
      [Token(Token = "0x6002364"), Address(RVA = "0x2DA58EC", Offset = "0x2DA58EC", VA = "0x2DA58EC")] private set
      {
      }
    }

    [Token(Token = "0x6002365")]
    [Address(RVA = "0x2DA57A0", Offset = "0x2DA57A0", VA = "0x2DA57A0")]
    public ActionContext(
      Transform rootTransform,
      ViewStateMachine viewStateMachine,
      Action exitProcess)
    {
    }

    [Token(Token = "0x6002366")]
    [Address(RVA = "0x2DA58FC", Offset = "0x2DA58FC", VA = "0x2DA58FC")]
    public void Exit()
    {
    }
  }
}
