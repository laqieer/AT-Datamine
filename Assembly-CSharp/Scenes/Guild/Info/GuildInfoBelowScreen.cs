// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Info.GuildInfoBelowScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Toaster;
using Il2CppDummyDll;
using Network;
using Network.API;
using Scenes.Guild.Data;
using Scenes.Guild.Search;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Info
{
  [Token(Token = "0x2002BE0")]
  public class GuildInfoBelowScreen : GuildBelowScreenBase
  {
    [Token(Token = "0x400BAAE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GuildSearchListItem infoDisplay;
    [Token(Token = "0x400BAAF")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton buttonSet;
    [Token(Token = "0x400BAB0")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton buttonRequest;
    [Token(Token = "0x400BAB1")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton buttonLevelDetail;
    [Token(Token = "0x400BAB2")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text policyText;
    [Token(Token = "0x400BAB3")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text conditionText;
    [Token(Token = "0x400BAB4")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text approveText;
    [Token(Token = "0x400BAB5")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text recruitText;
    [Token(Token = "0x400BAB6")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text boardText;
    [Token(Token = "0x400BAB7")]
    [FieldOffset(Offset = "0x80")]
    private GuildDetailInfo guildDetailInfo;
    [Token(Token = "0x400BAB8")]
    [FieldOffset(Offset = "0x88")]
    private bool isOwn;

    [Token(Token = "0x17003B14")]
    private ToasterManager toasterManager
    {
      [Token(Token = "0x601122E"), Address(RVA = "0x4A0AA60", Offset = "0x4A0AA60", VA = "0x4A0AA60")] get
      {
        return (ToasterManager) null;
      }
    }

    [Token(Token = "0x17003B15")]
    private GuildDataManager guildDataManager
    {
      [Token(Token = "0x601122F"), Address(RVA = "0x4A0AACC", Offset = "0x4A0AACC", VA = "0x4A0AACC")] get
      {
        return (GuildDataManager) null;
      }
    }

    [Token(Token = "0x6011230")]
    [Address(RVA = "0x4A0AB1C", Offset = "0x4A0AB1C", VA = "0x4A0AB1C", Slot = "4")]
    public override void Initialize(
      GuildSubScene guildSubScene,
      GuildAssetBundleParam.GuildScreenType? type,
      GuildBelowScreenParam param)
    {
    }

    [Token(Token = "0x6011231")]
    [Address(RVA = "0x4A0AE64", Offset = "0x4A0AE64", VA = "0x4A0AE64", Slot = "7")]
    public override void Open()
    {
    }

    [Token(Token = "0x6011232")]
    [Address(RVA = "0x4A0AE94", Offset = "0x4A0AE94", VA = "0x4A0AE94", Slot = "8")]
    public override void Close()
    {
    }

    [Token(Token = "0x6011233")]
    [Address(RVA = "0x4A0AC0C", Offset = "0x4A0AC0C", VA = "0x4A0AC0C")]
    private void OnUpdateDisplay()
    {
    }

    [Token(Token = "0x6011234")]
    [Address(RVA = "0x4A0AEBC", Offset = "0x4A0AEBC", VA = "0x4A0AEBC")]
    public void OnClickGuildDetail()
    {
    }

    [Token(Token = "0x6011235")]
    [Address(RVA = "0x4A0AF64", Offset = "0x4A0AF64", VA = "0x4A0AF64")]
    public void OnClickSet()
    {
    }

    [Token(Token = "0x6011236")]
    [Address(RVA = "0x4A0AFEC", Offset = "0x4A0AFEC", VA = "0x4A0AFEC")]
    public void OnClickGuildRequest()
    {
    }

    [Token(Token = "0x6011237")]
    [Address(RVA = "0x4A0B380", Offset = "0x4A0B380", VA = "0x4A0B380")]
    private IEnumerator RequestGuildJoinRequestAutoJoin() => (IEnumerator) null;

    [Token(Token = "0x6011238")]
    [Address(RVA = "0x4A0B410", Offset = "0x4A0B410", VA = "0x4A0B410")]
    private IEnumerator RequestGuildJoinRequest() => (IEnumerator) null;

    [Token(Token = "0x6011239")]
    [Address(RVA = "0x4A0B4A0", Offset = "0x4A0B4A0", VA = "0x4A0B4A0")]
    private void OnRequestComplete(APIGuildJoinRequestAutoJoinResponse response)
    {
    }

    [Token(Token = "0x601123A")]
    [Address(RVA = "0x4A0B8DC", Offset = "0x4A0B8DC", VA = "0x4A0B8DC")]
    private void OnRequestComplete(APIGuildJoinRequestSendResponse response)
    {
    }

    [Token(Token = "0x601123B")]
    [Address(RVA = "0x4A0BA64", Offset = "0x4A0BA64", VA = "0x4A0BA64")]
    private IEnumerator OnRequestFailed(NetworkErrorResult result) => (IEnumerator) null;

    [Token(Token = "0x601123C")]
    [Address(RVA = "0x4A0BAF4", Offset = "0x4A0BAF4", VA = "0x4A0BAF4")]
    public GuildInfoBelowScreen()
    {
    }
  }
}
