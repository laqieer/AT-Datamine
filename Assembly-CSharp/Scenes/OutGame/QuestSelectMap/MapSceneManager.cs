// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.MapSceneManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033CB")]
  public class MapSceneManager : MonoBehaviour
  {
    [Token(Token = "0x400E107")]
    [FieldOffset(Offset = "0x18")]
    private MapViewLogic logic;
    [Token(Token = "0x400E108")]
    [FieldOffset(Offset = "0x20")]
    private MapSceneInitSettingsHolder initSettings;

    [Token(Token = "0x60145B6")]
    [Address(RVA = "0x207017C", Offset = "0x207017C", VA = "0x207017C")]
    private void Awake()
    {
    }

    [Token(Token = "0x60145B7")]
    [Address(RVA = "0x207020C", Offset = "0x207020C", VA = "0x207020C")]
    public void CheckCameraEnable()
    {
    }

    [Token(Token = "0x60145B8")]
    [Address(RVA = "0x2070234", Offset = "0x2070234", VA = "0x2070234")]
    public void SetSystemActive(bool active)
    {
    }

    [Token(Token = "0x60145B9")]
    [Address(RVA = "0x207025C", Offset = "0x207025C", VA = "0x207025C")]
    public IEnumerator Initialize(
      IGroundPrefabProvider groundAccess,
      IDotCharaModelPrefabProvider charaAccess,
      ILandmarkResourceDictProvider landDictAccess,
      ILocationDataProvider locDataAccess,
      int locHandleId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60145BA")]
    [Address(RVA = "0x2070324", Offset = "0x2070324", VA = "0x2070324")]
    public void MapStart()
    {
    }

    [Token(Token = "0x60145BB")]
    [Address(RVA = "0x20703A0", Offset = "0x20703A0", VA = "0x20703A0")]
    public void RequestChangeLocation(int locationHandleId)
    {
    }

    [Token(Token = "0x60145BC")]
    [Address(RVA = "0x2070518", Offset = "0x2070518", VA = "0x2070518")]
    public void Destroy()
    {
    }

    [Token(Token = "0x60145BD")]
    [Address(RVA = "0x20705C0", Offset = "0x20705C0", VA = "0x20705C0")]
    public MapSceneManager()
    {
    }
  }
}
