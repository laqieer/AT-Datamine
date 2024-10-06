// Decompiled with JetBrains decompiler
// Type: DMM.Games.Client.Sdk.NetGameApiSdk
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using DMM.Games.Client.Sdk.Model;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace DMM.Games.Client.Sdk
{
  [Token(Token = "0x2003FC0")]
  public class NetGameApiSdk : MonoBehaviour
  {
    [Token(Token = "0x4011734")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string SdkVersion;
    [Token(Token = "0x4011739")]
    [FieldOffset(Offset = "0x38")]
    private bool isInitialized;

    [Token(Token = "0x170052A3")]
    public bool Sandbox
    {
      [Token(Token = "0x6019A34"), Address(RVA = "0x378750C", Offset = "0x378750C", VA = "0x378750C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6019A35"), Address(RVA = "0x3787514", Offset = "0x3787514", VA = "0x3787514")] protected set
      {
      }
    }

    [Token(Token = "0x170052A4")]
    public string AccessToken
    {
      [Token(Token = "0x6019A36"), Address(RVA = "0x3787520", Offset = "0x3787520", VA = "0x3787520")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019A37"), Address(RVA = "0x3787528", Offset = "0x3787528", VA = "0x3787528")] protected set
      {
      }
    }

    [Token(Token = "0x170052A5")]
    public string ViewerId
    {
      [Token(Token = "0x6019A38"), Address(RVA = "0x3787530", Offset = "0x3787530", VA = "0x3787530")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019A39"), Address(RVA = "0x3787538", Offset = "0x3787538", VA = "0x3787538")] protected set
      {
      }
    }

    [Token(Token = "0x170052A6")]
    public string OnetimeToken
    {
      [Token(Token = "0x6019A3A"), Address(RVA = "0x3787540", Offset = "0x3787540", VA = "0x3787540")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019A3B"), Address(RVA = "0x3787548", Offset = "0x3787548", VA = "0x3787548")] protected set
      {
      }
    }

    [Token(Token = "0x170052A7")]
    public bool IsInitialized
    {
      [Token(Token = "0x6019A3C"), Address(RVA = "0x3787550", Offset = "0x3787550", VA = "0x3787550")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6019A3D")]
    [Address(RVA = "0x3787558", Offset = "0x3787558", VA = "0x3787558")]
    public void Initialize(string accessToken, string viewerId, string onetimeToken, bool sandbox)
    {
    }

    [Token(Token = "0x6019A3E")]
    [Address(RVA = "0x378760C", Offset = "0x378760C", VA = "0x378760C")]
    public void UpdateToken(
      NetGameApiSdk.SuccessCallback success,
      NetGameApiSdk.FailureCallback failure)
    {
    }

    [Token(Token = "0x6019A3F")]
    [Address(RVA = "0x37879FC", Offset = "0x37879FC", VA = "0x37879FC")]
    public void CheckLogin(
      NetGameApiSdk.SuccessCallback success,
      NetGameApiSdk.FailureCallback failure)
    {
    }

    [Token(Token = "0x6019A40")]
    [Address(RVA = "0x3787C64", Offset = "0x3787C64", VA = "0x3787C64")]
    public void GetPoint(
      NetGameApiSdk.SuccessCallback success,
      NetGameApiSdk.FailureCallback failure)
    {
    }

    [Token(Token = "0x6019A41")]
    [Address(RVA = "0x3787CA0", Offset = "0x3787CA0", VA = "0x3787CA0")]
    public void GetChip(
      NetGameApiSdk.SuccessCallback success,
      NetGameApiSdk.FailureCallback failure)
    {
    }

    [Token(Token = "0x6019A42")]
    [Address(RVA = "0x3787CDC", Offset = "0x3787CDC", VA = "0x3787CDC")]
    public void GetProfile(
      NetGameApiSdk.SuccessCallback success,
      NetGameApiSdk.FailureCallback failure)
    {
    }

    [Token(Token = "0x6019A43")]
    [Address(RVA = "0x3787D18", Offset = "0x3787D18", VA = "0x3787D18")]
    public void Payment(
      string itemId,
      string itemName,
      int unitPrice,
      int quantity,
      string callbackurl,
      string finishurl,
      NetGameApiSdk.SuccessCallback success,
      NetGameApiSdk.FailureCallback failure)
    {
    }

    [Token(Token = "0x6019A44")]
    [Address(RVA = "0x3787A38", Offset = "0x3787A38", VA = "0x3787A38")]
    protected void Request(
      NetGameApiSdk.SuccessCallback success,
      NetGameApiSdk.FailureCallback failure,
      NetGameApiSdk.Kind kind,
      RequestModel request)
    {
    }

    [Token(Token = "0x6019A45")]
    [Address(RVA = "0x3787EFC", Offset = "0x3787EFC", VA = "0x3787EFC")]
    protected bool updateAccessToken(string newAccessToken) => new bool();

    [Token(Token = "0x6019A46")]
    [Address(RVA = "0x3787F38", Offset = "0x3787F38", VA = "0x3787F38")]
    protected bool updateOneTimeToken(string newOneTimeToken) => new bool();

    [Token(Token = "0x6019A47")]
    [Address(RVA = "0x378783C", Offset = "0x378783C", VA = "0x378783C")]
    protected RequestModel getRequestModel(NetGameApiSdk.Kind kind) => (RequestModel) null;

    [Token(Token = "0x6019A48")]
    [Address(RVA = "0x3788040", Offset = "0x3788040", VA = "0x3788040")]
    public NetGameApiSdk()
    {
    }

    [Token(Token = "0x6019A49")]
    [Address(RVA = "0x3788048", Offset = "0x3788048", VA = "0x3788048")]
    static NetGameApiSdk()
    {
    }

    [Token(Token = "0x2003FC1")]
    public enum ErrorCode
    {
      [Token(Token = "0x401173B")] Success = 0,
      [Token(Token = "0x401173C")] Error = 100, // 0x00000064
      [Token(Token = "0x401173D")] OneTimeTokenExpired = 101, // 0x00000065
      [Token(Token = "0x401173E")] RequiredLogin = 102, // 0x00000066
      [Token(Token = "0x401173F")] NetworkErrorAccessCallbackUrl = 103, // 0x00000067
      [Token(Token = "0x4011740")] UserInfoGetError = 104, // 0x00000068
      [Token(Token = "0x4011741")] AccessTokenParameterError = 110, // 0x0000006E
      [Token(Token = "0x4011742")] AccessTokenUpdateError = 111, // 0x0000006F
      [Token(Token = "0x4011743")] AccessTokenFatalError = 112, // 0x00000070
      [Token(Token = "0x4011744")] NetworkErrorAccessNetGameApi = 113, // 0x00000071
      [Token(Token = "0x4011745")] ParameterError = 200, // 0x000000C8
      [Token(Token = "0x4011746")] ApplicationIdentifierValidationError = 203, // 0x000000CB
      [Token(Token = "0x4011747")] OneTimeTokenValidationError = 204, // 0x000000CC
      [Token(Token = "0x4011748")] CallbackUrlValidationError = 205, // 0x000000CD
      [Token(Token = "0x4011749")] FinishUrlValidationError = 206, // 0x000000CE
      [Token(Token = "0x401174A")] OrderIdValidationError = 207, // 0x000000CF
      [Token(Token = "0x401174B")] ItemIdValidationError = 208, // 0x000000D0
      [Token(Token = "0x401174C")] ItemNameValidationError = 209, // 0x000000D1
      [Token(Token = "0x401174D")] ItemPriceValidationError = 210, // 0x000000D2
      [Token(Token = "0x401174E")] ItemQuantityValidationError = 211, // 0x000000D3
      [Token(Token = "0x401174F")] ItemValidationError = 212, // 0x000000D4
      [Token(Token = "0x4011750")] PointBalanceShortageError = 400, // 0x00000190
      [Token(Token = "0x4011751")] OrderIdentifierIssueError = 401, // 0x00000191
      [Token(Token = "0x4011752")] ItemInfoConfirmError = 402, // 0x00000192
      [Token(Token = "0x4011753")] CanNotCompletePointCharge = 403, // 0x00000193
      [Token(Token = "0x4011754")] CanNotGetPointBalance = 404, // 0x00000194
      [Token(Token = "0x4011755")] CanNotLaunchGamePlayer = 500, // 0x000001F4
      [Token(Token = "0x4011756")] DatabaseObstacleError = 900, // 0x00000384
      [Token(Token = "0x4011757")] Maintenance = 901, // 0x00000385
      [Token(Token = "0x4011758")] UnknownError = 999, // 0x000003E7
    }

    [Token(Token = "0x2003FC2")]
    public enum Kind
    {
      [Token(Token = "0x401175A")] Initialize = 1,
      [Token(Token = "0x401175B")] UpdateToken = 2,
      [Token(Token = "0x401175C")] CheckLogin = 3,
      [Token(Token = "0x401175D")] GetPoint = 4,
      [Token(Token = "0x401175E")] GetChip = 5,
      [Token(Token = "0x401175F")] GetProfile = 6,
      [Token(Token = "0x4011760")] Payment = 7,
    }

    [Token(Token = "0x2003FC3")]
    public delegate void SuccessCallback(
      NetGameApiSdk.Kind kind,
      NetGameApiSdk sender,
      NetGameApiResult result);

    [Token(Token = "0x2003FC4")]
    public delegate void FailureCallback(
      NetGameApiSdk.Kind kind,
      NetGameApiSdk sender,
      NetGameApiSdk.ErrorCode error);
  }
}
