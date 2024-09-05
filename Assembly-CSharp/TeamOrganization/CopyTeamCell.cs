// Decompiled with JetBrains decompiler
// Type: TeamOrganization.CopyTeamCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000812")]
  public class CopyTeamCell : MonoBehaviour
  {
    [Token(Token = "0x4002630")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TeamSelectionCell teamCell;
    [Token(Token = "0x4002631")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject[] partyDataObjects;
    [Token(Token = "0x4002632")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private StyleThumb[] styleThumbs;
    [Token(Token = "0x4002633")]
    [FieldOffset(Offset = "0x30")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6002E45")]
    [Address(RVA = "0x3A927E8", Offset = "0x3A927E8", VA = "0x3A927E8")]
    public void Initialize(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002E46")]
    [Address(RVA = "0x3A927F0", Offset = "0x3A927F0", VA = "0x3A927F0")]
    public void SetData(OrganizationTeam team)
    {
    }

    [Token(Token = "0x6002E47")]
    [Address(RVA = "0x3A92BD4", Offset = "0x3A92BD4", VA = "0x3A92BD4")]
    public CopyTeamCell()
    {
    }
  }
}
