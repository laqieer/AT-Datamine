// Decompiled with JetBrains decompiler
// Type: TeamOrganization.FormationSlotCustomSkillCell
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
  [Token(Token = "0x2000816")]
  public class FormationSlotCustomSkillCell : MonoBehaviour
  {
    [Token(Token = "0x4002647")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SkillIconSub customSkillIcon;
    [Token(Token = "0x4002648")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject customSkillObj;
    [Token(Token = "0x4002649")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject customSkillLockObj;
    [Token(Token = "0x400264A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject customSkillNoneObj;

    [Token(Token = "0x6002E5F")]
    [Address(RVA = "0x3A941B8", Offset = "0x3A941B8", VA = "0x3A941B8")]
    public void UpdateCell(string iconName, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002E60")]
    [Address(RVA = "0x3A942F4", Offset = "0x3A942F4", VA = "0x3A942F4")]
    public void UpdateCellEmpty()
    {
    }

    [Token(Token = "0x6002E61")]
    [Address(RVA = "0x3A94340", Offset = "0x3A94340", VA = "0x3A94340")]
    public void UpdateCellLock()
    {
    }

    [Token(Token = "0x6002E62")]
    [Address(RVA = "0x3A9438C", Offset = "0x3A9438C", VA = "0x3A9438C")]
    public FormationSlotCustomSkillCell()
    {
    }
  }
}
