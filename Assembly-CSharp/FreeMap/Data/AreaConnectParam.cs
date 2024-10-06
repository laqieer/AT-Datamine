// Decompiled with JetBrains decompiler
// Type: FreeMap.Data.AreaConnectParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Parameter.UIParam;
using FreeMap.State;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Data
{
  [Token(Token = "0x2001933")]
  public struct AreaConnectParam : ITransitionEvent
  {
    [Token(Token = "0x170016FD")]
    public int ToAreaID
    {
      [Token(Token = "0x6008F45"), Address(RVA = "0x4B07940", Offset = "0x4B07940", VA = "0x4B07940", Slot = "4")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x6008F46"), Address(RVA = "0x4B07948", Offset = "0x4B07948", VA = "0x4B07948")] set
      {
      }
    }

    [Token(Token = "0x170016FE")]
    public string ToStartAnchor
    {
      [Token(Token = "0x6008F47"), Address(RVA = "0x4B07950", Offset = "0x4B07950", VA = "0x4B07950", Slot = "5")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x6008F48"), Address(RVA = "0x4B07958", Offset = "0x4B07958", VA = "0x4B07958")] set
      {
      }
    }

    [Token(Token = "0x170016FF")]
    public int FromAreaID
    {
      [Token(Token = "0x6008F49"), Address(RVA = "0x4B07960", Offset = "0x4B07960", VA = "0x4B07960")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x6008F4A"), Address(RVA = "0x4B07968", Offset = "0x4B07968", VA = "0x4B07968")] set
      {
      }
    }

    [Token(Token = "0x17001700")]
    public string FromPlacementAnchor
    {
      [Token(Token = "0x6008F4B"), Address(RVA = "0x4B07970", Offset = "0x4B07970", VA = "0x4B07970")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x6008F4C"), Address(RVA = "0x4B07978", Offset = "0x4B07978", VA = "0x4B07978")] set
      {
      }
    }

    [Token(Token = "0x17001701")]
    public Vector3 IconOffset
    {
      [Token(Token = "0x6008F4D"), Address(RVA = "0x4B07980", Offset = "0x4B07980", VA = "0x4B07980")] set
      {
      }
      [Token(Token = "0x6008F4E"), Address(RVA = "0x4B0798C", Offset = "0x4B0798C", VA = "0x4B0798C")] readonly get
      {
        return new Vector3();
      }
    }

    [Token(Token = "0x6008F4F")]
    [Address(RVA = "0x4B07998", Offset = "0x4B07998", VA = "0x4B07998")]
    public IFreeMapInstanceBuilder CreateBuilder() => (IFreeMapInstanceBuilder) null;

    [Token(Token = "0x6008F50")]
    [Address(RVA = "0x4B07AD8", Offset = "0x4B07AD8", VA = "0x4B07AD8")]
    public FreeMapTransitionEventUIParam GetDestinationParam()
    {
      return (FreeMapTransitionEventUIParam) null;
    }

    [Token(Token = "0x6008F51")]
    [Address(RVA = "0x4B07B80", Offset = "0x4B07B80", VA = "0x4B07B80")]
    public FreeMapTransitionEventUIParam GetTransitionParam()
    {
      return (FreeMapTransitionEventUIParam) null;
    }
  }
}
