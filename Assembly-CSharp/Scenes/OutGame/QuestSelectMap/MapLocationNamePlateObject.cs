// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.MapLocationNamePlateObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033BA")]
  public class MapLocationNamePlateObject
  {
    [Token(Token = "0x400E0CB")]
    [FieldOffset(Offset = "0x10")]
    private GameObject go;
    [Token(Token = "0x400E0CC")]
    [FieldOffset(Offset = "0x18")]
    private MapLocationNamePlateObjControl con;
    [Token(Token = "0x400E0CD")]
    [FieldOffset(Offset = "0x20")]
    private Canvas plateCanavas;
    [Token(Token = "0x400E0CE")]
    [FieldOffset(Offset = "0x28")]
    private MapLocationNamePlateObject.InOutType nowType;

    [Token(Token = "0x601456D")]
    [Address(RVA = "0x206E9A8", Offset = "0x206E9A8", VA = "0x206E9A8")]
    public void Init(
      GameObject prefab,
      Canvas plateCanvas,
      ILocationDataProvider.LocationData locData)
    {
    }

    [Token(Token = "0x601456E")]
    [Address(RVA = "0x206ED70", Offset = "0x206ED70", VA = "0x206ED70")]
    public void CameraUpdate(Camera targetObjectCamera, Vector3 targetObjectPosW)
    {
    }

    [Token(Token = "0x601456F")]
    [Address(RVA = "0x206F3AC", Offset = "0x206F3AC", VA = "0x206F3AC")]
    public void Destroy()
    {
    }

    [Token(Token = "0x6014570")]
    [Address(RVA = "0x206F514", Offset = "0x206F514", VA = "0x206F514")]
    public void InStart()
    {
    }

    [Token(Token = "0x6014571")]
    [Address(RVA = "0x206F6CC", Offset = "0x206F6CC", VA = "0x206F6CC")]
    public void OutStart()
    {
    }

    [Token(Token = "0x6014572")]
    [Address(RVA = "0x206EFEC", Offset = "0x206EFEC", VA = "0x206EFEC")]
    public bool IsStartEnded() => new bool();

    [Token(Token = "0x6014573")]
    [Address(RVA = "0x206E9A0", Offset = "0x206E9A0", VA = "0x206E9A0")]
    public MapLocationNamePlateObject()
    {
    }

    [Token(Token = "0x20033BB")]
    private enum InOutType
    {
      [Token(Token = "0x400E0D0")] None,
      [Token(Token = "0x400E0D1")] In,
      [Token(Token = "0x400E0D2")] Out,
    }
  }
}
