// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.MapGroundObj
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033B4")]
  public class MapGroundObj
  {
    [Token(Token = "0x400E0AE")]
    [FieldOffset(Offset = "0x10")]
    private GameObject mapGruound;
    [Token(Token = "0x400E0AF")]
    [FieldOffset(Offset = "0x18")]
    private MapGroundData mapData;

    [Token(Token = "0x601454D")]
    [Address(RVA = "0x206D884", Offset = "0x206D884", VA = "0x206D884")]
    public IEnumerator Initialize(IGroundPrefabProvider groundAccess, GameObject parentGo)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601454E")]
    [Address(RVA = "0x206D928", Offset = "0x206D928", VA = "0x206D928")]
    public MapGroundData GetMapData() => (MapGroundData) null;

    [Token(Token = "0x601454F")]
    [Address(RVA = "0x206D930", Offset = "0x206D930", VA = "0x206D930")]
    public void Destory()
    {
    }

    [Token(Token = "0x6014550")]
    [Address(RVA = "0x206D9BC", Offset = "0x206D9BC", VA = "0x206D9BC")]
    public MapGroundObj()
    {
    }
  }
}
