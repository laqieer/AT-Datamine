// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.IFreeMapInstance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Scriptable;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018F0")]
  public interface IFreeMapInstance
  {
    [Token(Token = "0x6008DAC")]
    void PlaceInMap(FreeMapPlacementObject placementObject);

    [Token(Token = "0x6008DAD")]
    void InstanceUpdate();

    [Token(Token = "0x6008DAE")]
    void ReleaseInstance();
  }
}
