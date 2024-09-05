// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.CustomSkillEditSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using TeamOrganization;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x200328F")]
  public class CustomSkillEditSubScene : SubScene
  {
    [Token(Token = "0x400D875")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CustomSkillEditView customSkillEditView;
    [Token(Token = "0x400D876")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400D877")]
    protected const string CustomSkillEditAssetBundleName = "ui_page_partylist_customskilledit";
    [Token(Token = "0x400D878")]
    private const string ThumbBaseAssetbundleName = "ui_common_thumb";
    [Token(Token = "0x400D879")]
    [FieldOffset(Offset = "0x68")]
    private List<string> loadedAssetBundleNameList;
    [Token(Token = "0x400D87A")]
    [FieldOffset(Offset = "0x70")]
    private OrganizationTeam selectTeam;
    [Token(Token = "0x400D87B")]
    [FieldOffset(Offset = "0x78")]
    private int selectUnitIndex;
    [Token(Token = "0x400D87C")]
    [FieldOffset(Offset = "0x7C")]
    private bool isEquipSetOpen;
    [Token(Token = "0x400D87D")]
    [FieldOffset(Offset = "0x80")]
    private OrganizationPartySlot selectSlot;
    [Token(Token = "0x400D87E")]
    [FieldOffset(Offset = "0x88")]
    private int assetLoadRequestCount;

    [Token(Token = "0x6013B74")]
    [Address(RVA = "0x185D590", Offset = "0x185D590", VA = "0x185D590", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6013B75")]
    [Address(RVA = "0x185D640", Offset = "0x185D640", VA = "0x185D640", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6013B76")]
    [Address(RVA = "0x185D6D0", Offset = "0x185D6D0", VA = "0x185D6D0")]
    private void OnLoadComplete(List<string> succeedList, Dictionary<string, string> failedDic)
    {
    }

    [Token(Token = "0x6013B77")]
    [Address(RVA = "0x185D81C", Offset = "0x185D81C", VA = "0x185D81C", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x6013B78")]
    [Address(RVA = "0x185D820", Offset = "0x185D820", VA = "0x185D820", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6013B79")]
    [Address(RVA = "0x185D9CC", Offset = "0x185D9CC", VA = "0x185D9CC")]
    public void OnClickBack()
    {
    }

    [Token(Token = "0x6013B7A")]
    [Address(RVA = "0x185DA4C", Offset = "0x185DA4C", VA = "0x185DA4C")]
    private void AddLoadRequest()
    {
    }

    [Token(Token = "0x6013B7B")]
    [Address(RVA = "0x185DA5C", Offset = "0x185DA5C", VA = "0x185DA5C")]
    private void Update()
    {
    }

    [Token(Token = "0x6013B7C")]
    [Address(RVA = "0x185DA94", Offset = "0x185DA94", VA = "0x185DA94")]
    public CustomSkillEditSubScene()
    {
    }

    [Token(Token = "0x2003290")]
    public class CustomSkillEditSubSceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x1700417A")]
      public OrganizationTeam SelectTeam
      {
        [Token(Token = "0x6013B7D"), Address(RVA = "0x185DAA4", Offset = "0x185DAA4", VA = "0x185DAA4")] get
        {
          return (OrganizationTeam) null;
        }
        [Token(Token = "0x6013B7E"), Address(RVA = "0x185DAAC", Offset = "0x185DAAC", VA = "0x185DAAC")] private set
        {
        }
      }

      [Token(Token = "0x1700417B")]
      public int SelectUnitIndex
      {
        [Token(Token = "0x6013B7F"), Address(RVA = "0x185DAB4", Offset = "0x185DAB4", VA = "0x185DAB4")] get
        {
          return new int();
        }
        [Token(Token = "0x6013B80"), Address(RVA = "0x185DABC", Offset = "0x185DABC", VA = "0x185DABC")] private set
        {
        }
      }

      [Token(Token = "0x1700417C")]
      public bool IsEquipSetOpen
      {
        [Token(Token = "0x6013B81"), Address(RVA = "0x185DAC4", Offset = "0x185DAC4", VA = "0x185DAC4")] get
        {
          return new bool();
        }
        [Token(Token = "0x6013B82"), Address(RVA = "0x185DACC", Offset = "0x185DACC", VA = "0x185DACC")] private set
        {
        }
      }

      [Token(Token = "0x1700417D")]
      public OrganizationPartySlot SelectSlot
      {
        [Token(Token = "0x6013B83"), Address(RVA = "0x185DAD8", Offset = "0x185DAD8", VA = "0x185DAD8")] get
        {
          return (OrganizationPartySlot) null;
        }
        [Token(Token = "0x6013B84"), Address(RVA = "0x185DAE0", Offset = "0x185DAE0", VA = "0x185DAE0")] private set
        {
        }
      }

      [Token(Token = "0x6013B85")]
      [Address(RVA = "0x185DAE8", Offset = "0x185DAE8", VA = "0x185DAE8")]
      public CustomSkillEditSubSceneParam(OrganizationTeam team, int selectUnitIndex)
      {
      }

      [Token(Token = "0x6013B86")]
      [Address(RVA = "0x185DB20", Offset = "0x185DB20", VA = "0x185DB20")]
      public CustomSkillEditSubSceneParam(OrganizationPartySlot slot)
      {
      }
    }
  }
}
