// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.Builder.FreeMapInstanceBuildHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.Instance.Builder
{
  [Token(Token = "0x2001925")]
  public class FreeMapInstanceBuildHandler
  {
    [Token(Token = "0x4006C72")]
    [FieldOffset(Offset = "0x18")]
    private List<IFreeMapInstanceBuilder> builders;

    [Token(Token = "0x170016E7")]
    public InstanceID InstanceID
    {
      [Token(Token = "0x6008EF8"), Address(RVA = "0x4B04BEC", Offset = "0x4B04BEC", VA = "0x4B04BEC")] get
      {
        return new InstanceID();
      }
    }

    [Token(Token = "0x170016E8")]
    public List<IFreeMapInstanceBuilder> Builders
    {
      [Token(Token = "0x6008EF9"), Address(RVA = "0x4B04BF4", Offset = "0x4B04BF4", VA = "0x4B04BF4")] get
      {
        return (List<IFreeMapInstanceBuilder>) null;
      }
    }

    [Token(Token = "0x6008EFA")]
    [Address(RVA = "0x4B04BFC", Offset = "0x4B04BFC", VA = "0x4B04BFC")]
    public FreeMapInstanceBuildHandler(InstanceID instanceID)
    {
    }

    [Token(Token = "0x6008EFB")]
    [Address(RVA = "0x4B04C8C", Offset = "0x4B04C8C", VA = "0x4B04C8C")]
    public void Add(IFreeMapInstanceBuilder builder)
    {
    }

    [Token(Token = "0x6008EFC")]
    [Address(RVA = "0x4B04D34", Offset = "0x4B04D34", VA = "0x4B04D34")]
    public bool IsArrive(int sequenceID) => new bool();
  }
}
