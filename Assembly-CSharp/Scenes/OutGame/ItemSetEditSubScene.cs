// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ItemSetEditSubScene
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
  [Token(Token = "0x200327F")]
  public class ItemSetEditSubScene : SubScene
  {
    [Token(Token = "0x400D835")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private ItemSetEditView itemSetEditView;
    [Token(Token = "0x400D836")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400D837")]
    protected const string ItemEditAssetBundleName = "ui_page_partylist_itemedit";
    [Token(Token = "0x400D838")]
    private const string ThumbBaseAssetbundleName = "ui_common_thumb";
    [Token(Token = "0x400D839")]
    [FieldOffset(Offset = "0x68")]
    private List<string> loadedAssetBundleNameList;
    [Token(Token = "0x400D83A")]
    [FieldOffset(Offset = "0x70")]
    private int selectSetId;

    [Token(Token = "0x6013B28")]
    [Address(RVA = "0x1856690", Offset = "0x1856690", VA = "0x1856690", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6013B29")]
    [Address(RVA = "0x1856720", Offset = "0x1856720", VA = "0x1856720", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6013B2A")]
    [Address(RVA = "0x18567B0", Offset = "0x18567B0", VA = "0x18567B0")]
    private void OnLoadComplete(List<string> succeedList, Dictionary<string, string> failedDic)
    {
    }

    [Token(Token = "0x6013B2B")]
    [Address(RVA = "0x1856868", Offset = "0x1856868", VA = "0x1856868", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x6013B2C")]
    [Address(RVA = "0x1856904", Offset = "0x1856904", VA = "0x1856904", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6013B2D")]
    [Address(RVA = "0x1856AB0", Offset = "0x1856AB0", VA = "0x1856AB0")]
    public void OnClickBack()
    {
    }

    [Token(Token = "0x6013B2E")]
    [Address(RVA = "0x1856B30", Offset = "0x1856B30", VA = "0x1856B30")]
    public ItemSetEditSubScene()
    {
    }

    [Token(Token = "0x2003280")]
    public class ItemSetEditSubSceneParam : ChangeSceneParameter
    {
      [Token(Token = "0x1700416F")]
      public int SelectSetId
      {
        [Token(Token = "0x6013B2F"), Address(RVA = "0x1856B40", Offset = "0x1856B40", VA = "0x1856B40")] get
        {
          return new int();
        }
        [Token(Token = "0x6013B30"), Address(RVA = "0x1856B48", Offset = "0x1856B48", VA = "0x1856B48")] private set
        {
        }
      }

      [Token(Token = "0x6013B31")]
      [Address(RVA = "0x1856B50", Offset = "0x1856B50", VA = "0x1856B50")]
      public ItemSetEditSubSceneParam(int selectSetId)
      {
      }
    }
  }
}
