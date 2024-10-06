// Decompiled with JetBrains decompiler
// Type: DMM.Games.Client.Sdk.Sample.NetGameApiSdkSample
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace DMM.Games.Client.Sdk.Sample
{
  [Token(Token = "0x2003FCE")]
  [ExecuteInEditMode]
  public class NetGameApiSdkSample : MonoBehaviour
  {
    [Token(Token = "0x401178F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected NetGameApiSdk netgameApiSdk;
    [Token(Token = "0x4011790")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [TextArea(1, 2)]
    protected string viewerId;
    [Token(Token = "0x4011791")]
    [FieldOffset(Offset = "0x28")]
    [TextArea(2, 4)]
    [SerializeField]
    protected string onetimeToken;
    [Token(Token = "0x4011792")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [TextArea(5, 10)]
    protected string accessToken;
    [Token(Token = "0x4011793")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    protected bool isSandbox;
    [Token(Token = "0x4011794")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    protected string paymentItemId;
    [Token(Token = "0x4011795")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    protected string paymentItemName;
    [Token(Token = "0x4011796")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    protected int paymentUnitPrice;
    [Token(Token = "0x4011797")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    protected int paymentQuantity;
    [Token(Token = "0x4011798")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    protected string paymentCallbackurl;
    [Token(Token = "0x4011799")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    protected string paymentFinishurl;
    [Token(Token = "0x401179A")]
    [FieldOffset(Offset = "0x68")]
    protected string logger;

    [Token(Token = "0x6019A8E")]
    [Address(RVA = "0x37890F4", Offset = "0x37890F4", VA = "0x37890F4")]
    public void OnSuccessCallback(
      NetGameApiSdk.Kind kind,
      NetGameApiSdk sender,
      NetGameApiResult result)
    {
    }

    [Token(Token = "0x6019A8F")]
    [Address(RVA = "0x37894B0", Offset = "0x37894B0", VA = "0x37894B0")]
    public void OnFailureCallback(
      NetGameApiSdk.Kind kind,
      NetGameApiSdk sender,
      NetGameApiSdk.ErrorCode error)
    {
    }

    [Token(Token = "0x6019A90")]
    [Address(RVA = "0x3789628", Offset = "0x3789628", VA = "0x3789628")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x6019A91")]
    [Address(RVA = "0x37893CC", Offset = "0x37893CC", VA = "0x37893CC")]
    protected void clearLog()
    {
    }

    [Token(Token = "0x6019A92")]
    [Address(RVA = "0x378941C", Offset = "0x378941C", VA = "0x378941C")]
    protected void log(string message)
    {
    }

    [Token(Token = "0x6019A93")]
    [Address(RVA = "0x378B6F4", Offset = "0x378B6F4", VA = "0x378B6F4")]
    protected void logException(string message)
    {
    }

    [Token(Token = "0x6019A94")]
    [Address(RVA = "0x378B78C", Offset = "0x378B78C", VA = "0x378B78C")]
    public NetGameApiSdkSample()
    {
    }
  }
}
