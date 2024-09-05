// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.IFreeMapInstanceBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018F1")]
  public interface IFreeMapInstanceBuilder
  {
    [Token(Token = "0x170016B2")]
    InstanceID InstanceID { [Token(Token = "0x6008DAF")] get; }

    [Token(Token = "0x170016B3")]
    FreeMapBuildOrder BuildOrder { [Token(Token = "0x6008DB0")] get; }

    [Token(Token = "0x6008DB1")]
    bool CanCreate(int sequenceID);

    [Token(Token = "0x6008DB2")]
    void SetBuildCondition(IFreeMapBuildCondition buildCondition);

    [Token(Token = "0x6008DB3")]
    FreeMapInstance InitializeBuilder(Transform parent, IFreeMapResourceLoader loader);

    [Token(Token = "0x6008DB4")]
    FreeMapInstance Build(FreeMapCommonElement commonElement);

    [Token(Token = "0x6008DB5")]
    void FinalizeBuilder();
  }
}
