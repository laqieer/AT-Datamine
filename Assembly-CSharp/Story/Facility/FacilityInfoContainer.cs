// Decompiled with JetBrains decompiler
// Type: Story.Facility.FacilityInfoContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.Story.PocketBook;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Story.Facility
{
  [Token(Token = "0x20006A2")]
  public class FacilityInfoContainer : MonoBehaviour
  {
    [Token(Token = "0x4001FC9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RadarChart radarChart;
    [Token(Token = "0x4001FCA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform useItemParent;
    [Token(Token = "0x4001FCB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RectTransform rewardItemParent;
    [Token(Token = "0x4001FCC")]
    [FieldOffset(Offset = "0x30")]
    private List<ItemIcon> createdItemIcon;

    [Token(Token = "0x60025AF")]
    [Address(RVA = "0x2F3C54C", Offset = "0x2F3C54C", VA = "0x2F3C54C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60025B0")]
    [Address(RVA = "0x2F3C550", Offset = "0x2F3C550", VA = "0x2F3C550")]
    private void Remove()
    {
    }

    [Token(Token = "0x60025B1")]
    [Address(RVA = "0x2F3C708", Offset = "0x2F3C708", VA = "0x2F3C708")]
    public void SetData(StoryFacilityAttachData attachData, GameObject itemIconPrefab)
    {
    }

    [Token(Token = "0x60025B2")]
    [Address(RVA = "0x2F3CEEC", Offset = "0x2F3CEEC", VA = "0x2F3CEEC")]
    public FacilityInfoContainer()
    {
    }
  }
}
