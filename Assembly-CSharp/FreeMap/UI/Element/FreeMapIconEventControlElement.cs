// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Element.FreeMapIconEventControlElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Adv;
using FreeMap.Loader;
using FreeMap.Parameter.UIParam;
using Il2CppDummyDll;
using System;

#nullable disable
namespace FreeMap.UI.Element
{
  [Token(Token = "0x20016A5")]
  public class FreeMapIconEventControlElement
  {
    [Token(Token = "0x170013C9")]
    public IFreeMapAdvControl AdvControllMethod
    {
      [Token(Token = "0x6008003"), Address(RVA = "0x41F15E4", Offset = "0x41F15E4", VA = "0x41F15E4")] get
      {
        return (IFreeMapAdvControl) null;
      }
      [Token(Token = "0x6008004"), Address(RVA = "0x41F15EC", Offset = "0x41F15EC", VA = "0x41F15EC")] set
      {
      }
    }

    [Token(Token = "0x170013CA")]
    public IFreeMapTemporarySceneLoader MapSceneHandler
    {
      [Token(Token = "0x6008005"), Address(RVA = "0x41F15F4", Offset = "0x41F15F4", VA = "0x41F15F4")] get
      {
        return (IFreeMapTemporarySceneLoader) null;
      }
      [Token(Token = "0x6008006"), Address(RVA = "0x41F15FC", Offset = "0x41F15FC", VA = "0x41F15FC")] set
      {
      }
    }

    [Token(Token = "0x170013CB")]
    public IFreeMapLocationControll LocationControllMethod
    {
      [Token(Token = "0x6008007"), Address(RVA = "0x41F1604", Offset = "0x41F1604", VA = "0x41F1604")] get
      {
        return (IFreeMapLocationControll) null;
      }
      [Token(Token = "0x6008008"), Address(RVA = "0x41F160C", Offset = "0x41F160C", VA = "0x41F160C")] set
      {
      }
    }

    [Token(Token = "0x170013CC")]
    public Action<int> NoticeNextSequenceMethod
    {
      [Token(Token = "0x6008009"), Address(RVA = "0x41F1614", Offset = "0x41F1614", VA = "0x41F1614")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x600800A"), Address(RVA = "0x41F161C", Offset = "0x41F161C", VA = "0x41F161C")] set
      {
      }
    }

    [Token(Token = "0x170013CD")]
    public Action<FreeMapUIParamBase> OnGotoTarget
    {
      [Token(Token = "0x600800B"), Address(RVA = "0x41F1624", Offset = "0x41F1624", VA = "0x41F1624")] get
      {
        return (Action<FreeMapUIParamBase>) null;
      }
      [Token(Token = "0x600800C"), Address(RVA = "0x41F162C", Offset = "0x41F162C", VA = "0x41F162C")] set
      {
      }
    }

    [Token(Token = "0x170013CE")]
    public Action OnShowMap
    {
      [Token(Token = "0x600800D"), Address(RVA = "0x41F1634", Offset = "0x41F1634", VA = "0x41F1634")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x600800E"), Address(RVA = "0x41F163C", Offset = "0x41F163C", VA = "0x41F163C")] set
      {
      }
    }

    [Token(Token = "0x170013CF")]
    public Action<int> OnSubQuestCancel
    {
      [Token(Token = "0x600800F"), Address(RVA = "0x41F1644", Offset = "0x41F1644", VA = "0x41F1644")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x6008010"), Address(RVA = "0x41F164C", Offset = "0x41F164C", VA = "0x41F164C")] set
      {
      }
    }

    [Token(Token = "0x6008011")]
    [Address(RVA = "0x41F1654", Offset = "0x41F1654", VA = "0x41F1654")]
    public void InvokeBeforeIconEvent()
    {
    }

    [Token(Token = "0x6008012")]
    [Address(RVA = "0x41F1658", Offset = "0x41F1658", VA = "0x41F1658")]
    public void InvokeAfterIconEvent()
    {
    }

    [Token(Token = "0x6008013")]
    [Address(RVA = "0x41F165C", Offset = "0x41F165C", VA = "0x41F165C")]
    public FreeMapIconEventControlElement()
    {
    }
  }
}
