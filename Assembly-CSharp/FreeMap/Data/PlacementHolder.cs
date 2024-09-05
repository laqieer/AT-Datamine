// Decompiled with JetBrains decompiler
// Type: FreeMap.Data.PlacementHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Loader;
using FreeMap.Scriptable;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.Data
{
  [Token(Token = "0x200194F")]
  public class PlacementHolder
  {
    [Token(Token = "0x4006CC4")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, FreeMapPlacementObject> table;

    [Token(Token = "0x6009034")]
    [Address(RVA = "0x4B171E8", Offset = "0x4B171E8", VA = "0x4B171E8")]
    public void Load(FreeMapResourceLoader resourceLoader, IEnumerable<LocationData> locations)
    {
    }

    [Token(Token = "0x6009035")]
    [Address(RVA = "0x4B17678", Offset = "0x4B17678", VA = "0x4B17678")]
    public FreeMapPlacementObject TryGet(int areaID) => (FreeMapPlacementObject) null;

    [Token(Token = "0x6009036")]
    [Address(RVA = "0x4B176F0", Offset = "0x4B176F0", VA = "0x4B176F0")]
    public void Release()
    {
    }

    [Token(Token = "0x6009037")]
    [Address(RVA = "0x4B17740", Offset = "0x4B17740", VA = "0x4B17740")]
    public PlacementHolder()
    {
    }
  }
}
