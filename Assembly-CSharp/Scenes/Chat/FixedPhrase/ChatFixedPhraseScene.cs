// Decompiled with JetBrains decompiler
// Type: Scenes.Chat.FixedPhrase.ChatFixedPhraseScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Chat.FixedPhrase
{
  [Token(Token = "0x20030C4")]
  public class ChatFixedPhraseScene : MonoBehaviour
  {
    [Token(Token = "0x400CF70")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400CF71")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button canclebtn;
    [Token(Token = "0x400CF72")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button sendbtn;
    [Token(Token = "0x400CF73")]
    [FieldOffset(Offset = "0x30")]
    private bool isLoadedAssetBundle;
    [Token(Token = "0x400CF74")]
    [FieldOffset(Offset = "0x38")]
    private List<ChatFixedPhraseListItem> phraseDefaultList;
    [Token(Token = "0x400CF75")]
    [FieldOffset(Offset = "0x40")]
    private ChatFixedPhraseSceneManager fixedPhraseScene;
    [Token(Token = "0x400CF76")]
    [FieldOffset(Offset = "0x48")]
    private GameObject chatFixedPhraseItem;
    [Token(Token = "0x400CF77")]
    [FieldOffset(Offset = "0x50")]
    private string currFixedPhraseContent;
    [Token(Token = "0x400CF78")]
    public const string SubSceneAssetBundleName = "page_chat_chatdialog";
    [Token(Token = "0x400CF79")]
    public const string LOAD_PREFAB_FIXED_PHRASE_LIST_ITEM = "ChatFixedPhraseListItem";

    [Token(Token = "0x60130C9")]
    [Address(RVA = "0x432EF44", Offset = "0x432EF44", VA = "0x432EF44")]
    public void Show(ChatFixedPhraseSceneManager mainScene)
    {
    }

    [Token(Token = "0x60130CA")]
    [Address(RVA = "0x432F00C", Offset = "0x432F00C", VA = "0x432F00C")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60130CB")]
    [Address(RVA = "0x432F270", Offset = "0x432F270", VA = "0x432F270")]
    public void SetPlayerFixedPhraseList()
    {
    }

    [Token(Token = "0x60130CC")]
    [Address(RVA = "0x432F074", Offset = "0x432F074", VA = "0x432F074")]
    private void RefreshPlayerFixedPhraseList()
    {
    }

    [Token(Token = "0x60130CD")]
    [Address(RVA = "0x432F5A0", Offset = "0x432F5A0", VA = "0x432F5A0")]
    public ChatFixedPhraseScene()
    {
    }
  }
}
