// Decompiled with JetBrains decompiler
// Type: staq.AdTrackingManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using com.adjust.sdk;
using GameCore.DesignPattern;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C17")]
  public class AdTrackingManager : SingletonMonoBehaviour<AdTrackingManager>
  {
    [Token(Token = "0x4010A38")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string adjust_AppToken;
    [Token(Token = "0x4010A39")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool adjust_EnabledTrackingDeviceId;
    [Token(Token = "0x4010A3A")]
    [FieldOffset(Offset = "0x29")]
    [SerializeField]
    private bool adjust_EnabledTrackingPlayerId;
    [Token(Token = "0x4010A3B")]
    [FieldOffset(Offset = "0x2A")]
    [SerializeField]
    private bool adjust_EnabledAppSecret;
    [Token(Token = "0x4010A3C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private long adjust_SecretKey_iOS;
    [Token(Token = "0x4010A3D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private long adjust_SecretKey_Android;
    [Token(Token = "0x4010A3E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private long[] adjust_SecretInfo_iOS;
    [Token(Token = "0x4010A3F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private long[] adjust_SecretInfo_Android;
    [Token(Token = "0x4010A40")]
    private const string SESSION_CALLBACK_PLAYER_ID = "player_id";
    [Token(Token = "0x4010A41")]
    private const string SESSION_CALLBACK_DEVICE_ID = "device_id";
    [Token(Token = "0x4010A42")]
    private const string EVENT_TOKEN_LOGIN = "f6jl49";
    [Token(Token = "0x4010A43")]
    public const string BG_DOWNLOAD_CONFIRMATION = "14nmhd";
    [Token(Token = "0x4010A44")]
    public const string CHARACTER_DECISION = "g4ykbs";
    [Token(Token = "0x4010A45")]
    public const string CHARACTER_INPUT = "3u4pot";
    [Token(Token = "0x4010A46")]
    public const string CHARACTER_SELECTION = "7bhdar";
    [Token(Token = "0x4010A47")]
    public const string DOWNLOADA_MOVIE = "xex8oz";
    [Token(Token = "0x4010A48")]
    public const string DOWNLOADA_START = "sv13x4";
    [Token(Token = "0x4010A49")]
    public const string DOWNLOADB_END = "c64dq1";
    [Token(Token = "0x4010A4A")]
    public const string DOWNLOADB_MOVIE = "bwst20";
    [Token(Token = "0x4010A4B")]
    public const string DOWNLOADB_START = "f3ux47";
    [Token(Token = "0x4010A4C")]
    public const string DOWNLOADC_END = "pc37o9";
    [Token(Token = "0x4010A4D")]
    public const string DOWNLOADC_MOVIE = "auic1p";
    [Token(Token = "0x4010A4E")]
    public const string DOWNLOADC_START = "jfk523";
    [Token(Token = "0x4010A4F")]
    public const string EXPEDITION = "y8wbtk";
    [Token(Token = "0x4010A50")]
    public const string GACHA_1 = "jzxgog";
    [Token(Token = "0x4010A51")]
    public const string GACHA_2 = "rhuxvk";
    [Token(Token = "0x4010A52")]
    public const string GACHA_3 = "da0rsg";
    [Token(Token = "0x4010A53")]
    public const string GRAPHIC_CONFIRMATION = "sticur";
    [Token(Token = "0x4010A54")]
    public const string HOME_COMPLETION = "jc6qf8";
    [Token(Token = "0x4010A55")]
    public const string HOME_END = "38l68o";
    [Token(Token = "0x4010A56")]
    public const string HOME_START = "jbny3i";
    [Token(Token = "0x4010A57")]
    public const string HOME_TUTORIAL_1 = "k53eh5";
    [Token(Token = "0x4010A58")]
    public const string HOME_TUTORIAL_2 = "t5j1on";
    [Token(Token = "0x4010A59")]
    public const string HOME_TUTORIAL_3 = "z4nj44";
    [Token(Token = "0x4010A5A")]
    public const string HOME_TUTORIAL_4 = "uwn2g4";
    [Token(Token = "0x4010A5B")]
    public const string HOME_TUTORIAL_5 = "6xh05r";
    [Token(Token = "0x4010A5C")]
    public const string HOME_TUTORIAL_6 = "7zwk2t";
    [Token(Token = "0x4010A5D")]
    public const string HOME_TUTORIAL_7 = "7xmdtg";
    [Token(Token = "0x4010A5E")]
    public const string HOME_TUTORIAL_8 = "lcp12i";
    [Token(Token = "0x4010A5F")]
    public const string HOME_TUTORIAL_9 = "vyk0ez";
    [Token(Token = "0x4010A60")]
    public const string LOGIN = "d0e91t";
    [Token(Token = "0x4010A61")]
    public const string LOGIN_BONUS_BEGINNER = "158olw";
    [Token(Token = "0x4010A62")]
    public const string LOGIN_BONUS_DAILY = "laq86o";
    [Token(Token = "0x4010A63")]
    public const string PARTA_END = "946hds";
    [Token(Token = "0x4010A64")]
    public const string PARTA_MOVIE_END = "n52wzq";
    [Token(Token = "0x4010A65")]
    public const string PARTA_MOVIE_START = "jo4ize";
    [Token(Token = "0x4010A66")]
    public const string PARTA_START = "tt784z";
    [Token(Token = "0x4010A67")]
    public const string PARTB_END = "fx9yxk";
    [Token(Token = "0x4010A68")]
    public const string PARTB_START = "8e97z0";
    [Token(Token = "0x4010A69")]
    public const string PARTC_END = "m0q5rj";
    [Token(Token = "0x4010A6A")]
    public const string PARTC_START = "2f3mae";
    [Token(Token = "0x4010A6B")]
    public const string PARTD_END = "virc07";
    [Token(Token = "0x4010A6C")]
    public const string PARTD_START = "riocqq";
    [Token(Token = "0x4010A6D")]
    public const string PARTE_END = "tlzhjs";
    [Token(Token = "0x4010A6E")]
    public const string PARTE_MOVIE_END = "cwo0wk";
    [Token(Token = "0x4010A6F")]
    public const string PARTE_MOVIE_START = "ulr7bf";
    [Token(Token = "0x4010A70")]
    public const string PARTE_START = "2v8j8z";
    [Token(Token = "0x4010A71")]
    public const string PARTF_BATTLE_END = "rx8ekh";
    [Token(Token = "0x4010A72")]
    public const string PARTF_BATTLE_START = "ljm96m";
    [Token(Token = "0x4010A73")]
    public const string PARTF_END = "jbw1u2";
    [Token(Token = "0x4010A74")]
    public const string PARTF_MOVIE_END = "uqno5j";
    [Token(Token = "0x4010A75")]
    public const string PARTF_MOVIE_START = "bkcxfo";
    [Token(Token = "0x4010A76")]
    public const string PARTF_START = "1jus62";
    [Token(Token = "0x4010A77")]
    public const string PARTG_END = "sj7d6s";
    [Token(Token = "0x4010A78")]
    public const string PARTG_START = "z44o1d";
    [Token(Token = "0x4010A79")]
    public const string PARTH_BATTLE_END = "qmg8wf";
    [Token(Token = "0x4010A7A")]
    public const string PARTH_BATTLE_START = "7s7qdn";
    [Token(Token = "0x4010A7B")]
    public const string PARTH_END = "sg8l3f";
    [Token(Token = "0x4010A7C")]
    public const string PARTH_MOVIE_END = "lmrxyf";
    [Token(Token = "0x4010A7D")]
    public const string PARTH_MOVIE_START = "e2fjxr";
    [Token(Token = "0x4010A7E")]
    public const string PARTH_START = "nldqhp";
    [Token(Token = "0x4010A7F")]
    public const string PARTI_BATTLE_END = "n43vts";
    [Token(Token = "0x4010A80")]
    public const string PARTI_BATTLE_START = "tsrbma";
    [Token(Token = "0x4010A81")]
    public const string PARTI_END = "iav0i5";
    [Token(Token = "0x4010A82")]
    public const string PARTI_MOVIE_END = "aro6og";
    [Token(Token = "0x4010A83")]
    public const string PARTI_MOVIE_START = "jqvm0h";
    [Token(Token = "0x4010A84")]
    public const string PARTI_START = "s77npv";
    [Token(Token = "0x4010A85")]
    public const string PARTJ_END = "30rcse";
    [Token(Token = "0x4010A86")]
    public const string PARTJ_START = "l3ihie";
    [Token(Token = "0x4010A87")]
    public const string PRESENT = "ju4ver";
    [Token(Token = "0x4010A88")]
    public const string PRESENT_REWARD = "i5ikf3";
    [Token(Token = "0x4010A89")]
    public const string QUEST_START = "1jus62";
    [Token(Token = "0x4010A8A")]
    public const string TITLE = "bh57sy";
    [Token(Token = "0x4010A8B")]
    public const string TRACKING_CONFIRM = "cx630g";
    [Token(Token = "0x4010A8C")]
    public const string TRACKING_EXPLAN = "x06lbp";
    [Token(Token = "0x4010A8D")]
    public const string TERMS_OF_SERVICE = "x9mur6";
    [Token(Token = "0x4010A8E")]
    public const string PURCHASE_SUCCEEDED = "6p8prg";
    [Token(Token = "0x4010A8F")]
    [FieldOffset(Offset = "0x50")]
    private string[] eventTokenTable;
    [Token(Token = "0x4010A90")]
    [FieldOffset(Offset = "0x58")]
    private bool isEnabledDeviceId;
    [Token(Token = "0x4010A91")]
    [FieldOffset(Offset = "0x59")]
    private bool isEnabledPlayerId;

    [Token(Token = "0x60179E7")]
    [Address(RVA = "0x2380044", Offset = "0x2380044", VA = "0x2380044", Slot = "5")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x60179E8")]
    [Address(RVA = "0x2380124", Offset = "0x2380124", VA = "0x2380124")]
    public IEnumerator RequestTrackingAuthorization() => (IEnumerator) null;

    [Token(Token = "0x60179E9")]
    [Address(RVA = "0x23801AC", Offset = "0x23801AC", VA = "0x23801AC")]
    public int GetAppTrackingAuthorizationStatus() => new int();

    [Token(Token = "0x60179EA")]
    [Address(RVA = "0x23801B4", Offset = "0x23801B4", VA = "0x23801B4")]
    private void EnableDeviceId()
    {
    }

    [Token(Token = "0x60179EB")]
    [Address(RVA = "0x23802E8", Offset = "0x23802E8", VA = "0x23802E8")]
    private void EnablePlayerId()
    {
    }

    [Token(Token = "0x60179EC")]
    [Address(RVA = "0x2380400", Offset = "0x2380400", VA = "0x2380400")]
    public void TrackEventLogin()
    {
    }

    [Token(Token = "0x60179ED")]
    [Address(RVA = "0x2380448", Offset = "0x2380448", VA = "0x2380448")]
    public void TrackEvent(string eventName)
    {
    }

    [Token(Token = "0x60179EE")]
    [Address(RVA = "0x23804CC", Offset = "0x23804CC", VA = "0x23804CC")]
    public void TrackEvent(AdjustEvent adjustEvent)
    {
    }

    [Token(Token = "0x60179EF")]
    [Address(RVA = "0x23804FC", Offset = "0x23804FC", VA = "0x23804FC")]
    public void TrackEventId(int id)
    {
    }

    [Token(Token = "0x60179F0")]
    [Address(RVA = "0x238052C", Offset = "0x238052C", VA = "0x238052C")]
    public AdTrackingManager()
    {
    }
  }
}
