// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.ButtonEvent.EventHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Adv;
using FreeMap.Loader;
using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using Story.Adv;
using System;
using System.Collections;

#nullable disable
namespace FreeMap.UI.ButtonEvent
{
  [Token(Token = "0x20016F2")]
  public class EventHandler
  {
    [Token(Token = "0x4006678")]
    [FieldOffset(Offset = "0x10")]
    protected IFreeMapAdvControl advControlMethod;
    [Token(Token = "0x4006679")]
    [FieldOffset(Offset = "0x18")]
    protected IFreeMapTemporarySceneLoader sceneHandler;
    [Token(Token = "0x400667A")]
    [FieldOffset(Offset = "0x20")]
    public Action<IEnumerator> StartCoroutine;
    [Token(Token = "0x400667B")]
    [FieldOffset(Offset = "0x28")]
    private IEnumerator areaReload;

    [Token(Token = "0x60081D1")]
    [Address(RVA = "0x41FCA84", Offset = "0x41FCA84", VA = "0x41FCA84")]
    public EventHandler(
      IFreeMapAdvControl advControlMethod,
      IFreeMapTemporarySceneLoader sceneHandler)
    {
    }

    [Token(Token = "0x60081D2")]
    [Address(RVA = "0x41FCAB0", Offset = "0x41FCAB0", VA = "0x41FCAB0")]
    public AdvStageCommunication CreateCommunicationStage(int communication, int advID)
    {
      return (AdvStageCommunication) null;
    }

    [Token(Token = "0x60081D3")]
    [Address(RVA = "0x41FCD38", Offset = "0x41FCD38", VA = "0x41FCD38")]
    public AdvStageFacility CreateFacilityStage(FreeMapFacilityEventUIParam param)
    {
      return (AdvStageFacility) null;
    }

    [Token(Token = "0x60081D4")]
    [Address(RVA = "0x41FCFD8", Offset = "0x41FCFD8", VA = "0x41FCFD8")]
    public void OnChangeArea()
    {
    }

    [Token(Token = "0x60081D5")]
    [Address(RVA = "0x41FD038", Offset = "0x41FD038", VA = "0x41FD038")]
    public IEnumerator EventBegin(bool sceneChange) => (IEnumerator) null;

    [Token(Token = "0x60081D6")]
    [Address(RVA = "0x41FD0DC", Offset = "0x41FD0DC", VA = "0x41FD0DC")]
    public IEnumerator EventEnd() => (IEnumerator) null;

    [Token(Token = "0x60081D7")]
    [Address(RVA = "0x41FD16C", Offset = "0x41FD16C", VA = "0x41FD16C", Slot = "4")]
    public virtual IEnumerator AreaUnload() => (IEnumerator) null;

    [Token(Token = "0x60081D8")]
    [Address(RVA = "0x41FD1FC", Offset = "0x41FD1FC", VA = "0x41FD1FC", Slot = "5")]
    public virtual IEnumerator AreaReload() => (IEnumerator) null;
  }
}
