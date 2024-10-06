// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.PlacementObjectLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Scriptable;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.Story.PocketBook
{
  [Token(Token = "0x2002DB8")]
  public class PlacementObjectLoader
  {
    [Token(Token = "0x400C486")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, FreeMapPlacementObject> placements;

    [Token(Token = "0x6011E13")]
    [Address(RVA = "0x3FA69A4", Offset = "0x3FA69A4", VA = "0x3FA69A4")]
    public void Register(int areaID, FreeMapPlacementObject placement)
    {
    }

    [Token(Token = "0x6011E14")]
    [Address(RVA = "0x3FA6E44", Offset = "0x3FA6E44", VA = "0x3FA6E44")]
    public void Release()
    {
    }

    [Token(Token = "0x6011E15")]
    [Address(RVA = "0x3FA8A6C", Offset = "0x3FA8A6C", VA = "0x3FA8A6C")]
    public IEnumerator Load(PocketBookLoader loader, int areaSettingsID) => (IEnumerator) null;

    [Token(Token = "0x6011E16")]
    [Address(RVA = "0x3FA6B00", Offset = "0x3FA6B00", VA = "0x3FA6B00")]
    public FreeMapPlacementObject Get(int areaID) => (FreeMapPlacementObject) null;

    [Token(Token = "0x6011E17")]
    [Address(RVA = "0x3FA7328", Offset = "0x3FA7328", VA = "0x3FA7328")]
    public PlacementObjectLoader()
    {
    }
  }
}
