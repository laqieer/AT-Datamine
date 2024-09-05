// Decompiled with JetBrains decompiler
// Type: staq.EventSystemManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C41")]
  public class EventSystemManager : SingletonMonoBehaviour<EventSystemManager>
  {
    [Token(Token = "0x4010B6F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private EventSystem eventSystem;
    [Token(Token = "0x4010B70")]
    [FieldOffset(Offset = "0x28")]
    private List<EventSystemManager.RequestData> requests;
    [Token(Token = "0x4010B71")]
    [FieldOffset(Offset = "0x30")]
    private Coroutine coroutine;
    [Token(Token = "0x4010B72")]
    [FieldOffset(Offset = "0x38")]
    private bool IsEnable;

    [Token(Token = "0x17004D2B")]
    public bool IsEnabledEventSystem
    {
      [Token(Token = "0x6017B12"), Address(RVA = "0x238B754", Offset = "0x238B754", VA = "0x238B754")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004D2C")]
    public int CountRequests
    {
      [Token(Token = "0x6017B13"), Address(RVA = "0x238B75C", Offset = "0x238B75C", VA = "0x238B75C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6017B14")]
    [Address(RVA = "0x238B7A4", Offset = "0x238B7A4", VA = "0x238B7A4", Slot = "5")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x6017B15")]
    [Address(RVA = "0x238B818", Offset = "0x238B818", VA = "0x238B818")]
    public void RequestEnabled(bool isEnabled, float waitSeconds = 0.0f)
    {
    }

    [Token(Token = "0x6017B16")]
    [Address(RVA = "0x238B934", Offset = "0x238B934", VA = "0x238B934")]
    private IEnumerator DoRequest() => (IEnumerator) null;

    [Token(Token = "0x6017B17")]
    [Address(RVA = "0x238B9C4", Offset = "0x238B9C4", VA = "0x238B9C4")]
    public void ResetSelectedGameObjectIfMatch(GameObject target)
    {
    }

    [Token(Token = "0x6017B18")]
    [Address(RVA = "0x238BA58", Offset = "0x238BA58", VA = "0x238BA58")]
    public EventSystemManager()
    {
    }

    [Token(Token = "0x2003C42")]
    public class RequestData
    {
      [Token(Token = "0x4010B73")]
      [FieldOffset(Offset = "0x10")]
      public bool isEnabled;
      [Token(Token = "0x4010B74")]
      [FieldOffset(Offset = "0x14")]
      public float waitSeconds;

      [Token(Token = "0x6017B19")]
      [Address(RVA = "0x238B92C", Offset = "0x238B92C", VA = "0x238B92C")]
      public RequestData()
      {
      }
    }
  }
}
