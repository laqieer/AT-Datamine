// Decompiled with JetBrains decompiler
// Type: TeamOrganization.FormationItemSetView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000815")]
  public class FormationItemSetView : MonoBehaviour
  {
    [Token(Token = "0x4002646")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon[] itemIcon;

    [Token(Token = "0x6002E5B")]
    [Address(RVA = "0x3A93BAC", Offset = "0x3A93BAC", VA = "0x3A93BAC")]
    public void UpdateItemSet(OrganizationTeam team, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002E5C")]
    [Address(RVA = "0x3A940E0", Offset = "0x3A940E0", VA = "0x3A940E0")]
    private void UpdateItem(
      int index,
      ItemUtility.Parameter param,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002E5D")]
    [Address(RVA = "0x3A94098", Offset = "0x3A94098", VA = "0x3A94098")]
    private void UpdateEmpty(int index)
    {
    }

    [Token(Token = "0x6002E5E")]
    [Address(RVA = "0x3A941B0", Offset = "0x3A941B0", VA = "0x3A941B0")]
    public FormationItemSetView()
    {
    }
  }
}
