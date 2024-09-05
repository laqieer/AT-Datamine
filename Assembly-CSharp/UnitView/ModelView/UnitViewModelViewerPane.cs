// Decompiled with JetBrains decompiler
// Type: UnitView.ModelView.UnitViewModelViewerPane
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnitView.Camera;
using UnitView.ModelView.UI;
using UnityEngine;

#nullable disable
namespace UnitView.ModelView
{
  [Token(Token = "0x20003CA")]
  public class UnitViewModelViewerPane : MonoBehaviour, ICoroutineWorker
  {
    [Token(Token = "0x4001643")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SerializeData serializeData;
    [Token(Token = "0x4001644")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ViewerSettings viewerSettings;
    [Token(Token = "0x4001645")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ModelController unitModelController;
    [Token(Token = "0x4001646")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ModelController riddenModelController;
    [Token(Token = "0x4001647")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ModelController dotModelController;
    [Token(Token = "0x4001648")]
    [FieldOffset(Offset = "0x40")]
    private bool initialized;

    [Token(Token = "0x1700024C")]
    private GameObject bgGameObject
    {
      [Token(Token = "0x60015FA"), Address(RVA = "0x2485268", Offset = "0x2485268", VA = "0x2485268")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x1700024D")]
    private GameObject viewerBgGameObject
    {
      [Token(Token = "0x60015FB"), Address(RVA = "0x248528C", Offset = "0x248528C", VA = "0x248528C")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x1700024E")]
    public Controller CameraController
    {
      [Token(Token = "0x60015FC"), Address(RVA = "0x24852A8", Offset = "0x24852A8", VA = "0x24852A8")] get
      {
        return (Controller) null;
      }
    }

    [Token(Token = "0x1700024F")]
    public Background Background
    {
      [Token(Token = "0x60015FD"), Address(RVA = "0x24852C4", Offset = "0x24852C4", VA = "0x24852C4")] get
      {
        return (Background) null;
      }
    }

    [Token(Token = "0x17000250")]
    public Background ViewerBackground
    {
      [Token(Token = "0x60015FE"), Address(RVA = "0x24852E0", Offset = "0x24852E0", VA = "0x24852E0")] get
      {
        return (Background) null;
      }
    }

    [Token(Token = "0x17000251")]
    public Transform BGOrientationRoot
    {
      [Token(Token = "0x60015FF"), Address(RVA = "0x24852FC", Offset = "0x24852FC", VA = "0x24852FC")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17000252")]
    public ViewerSettings ViewerSettings
    {
      [Token(Token = "0x6001600"), Address(RVA = "0x2485318", Offset = "0x2485318", VA = "0x2485318")] get
      {
        return (ViewerSettings) null;
      }
    }

    [Token(Token = "0x17000253")]
    public AnimationBGMove AnimationBGMove
    {
      [Token(Token = "0x6001601"), Address(RVA = "0x2485320", Offset = "0x2485320", VA = "0x2485320")] get
      {
        return (AnimationBGMove) null;
      }
      [Token(Token = "0x6001602"), Address(RVA = "0x2485328", Offset = "0x2485328", VA = "0x2485328")] private set
      {
      }
    }

    [Token(Token = "0x17000254")]
    public ModelController UnitModelController
    {
      [Token(Token = "0x6001603"), Address(RVA = "0x2485330", Offset = "0x2485330", VA = "0x2485330")] get
      {
        return (ModelController) null;
      }
    }

    [Token(Token = "0x17000255")]
    public ModelController DotModelController
    {
      [Token(Token = "0x6001604"), Address(RVA = "0x2485338", Offset = "0x2485338", VA = "0x2485338")] get
      {
        return (ModelController) null;
      }
    }

    [Token(Token = "0x17000256")]
    public Vector2 CameraTextureSize
    {
      [Token(Token = "0x6001605"), Address(RVA = "0x2485340", Offset = "0x2485340", VA = "0x2485340")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x6001606")]
    [Address(RVA = "0x2485370", Offset = "0x2485370", VA = "0x2485370")]
    private void Awake()
    {
    }

    [Token(Token = "0x6001607")]
    [Address(RVA = "0x2485374", Offset = "0x2485374", VA = "0x2485374")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6001608")]
    [Address(RVA = "0x24854A0", Offset = "0x24854A0", VA = "0x24854A0")]
    public void ActivateModel()
    {
    }

    [Token(Token = "0x6001609")]
    [Address(RVA = "0x2485500", Offset = "0x2485500", VA = "0x2485500")]
    public void DeactivateModel()
    {
    }

    [Token(Token = "0x600160A")]
    [Address(RVA = "0x2485560", Offset = "0x2485560", VA = "0x2485560")]
    public void ActivateDotModel()
    {
    }

    [Token(Token = "0x600160B")]
    [Address(RVA = "0x2485594", Offset = "0x2485594", VA = "0x2485594")]
    public void DeactivateDotModel()
    {
    }

    [Token(Token = "0x600160C")]
    [Address(RVA = "0x24855C8", Offset = "0x24855C8", VA = "0x24855C8")]
    public void InstantiateModel(GameObject unitModelAsset, GameObject riddenUnitAsset)
    {
    }

    [Token(Token = "0x600160D")]
    [Address(RVA = "0x2485690", Offset = "0x2485690", VA = "0x2485690")]
    public void InstantiateModelDotModel(GameObject dotModelAsset)
    {
    }

    [Token(Token = "0x600160E")]
    [Address(RVA = "0x2485720", Offset = "0x2485720", VA = "0x2485720")]
    public void RotateModel(Vector2 direction)
    {
    }

    [Token(Token = "0x600160F")]
    [Address(RVA = "0x2485764", Offset = "0x2485764", VA = "0x2485764")]
    public void ClearModel()
    {
    }

    [Token(Token = "0x6001610")]
    [Address(RVA = "0x2485798", Offset = "0x2485798", VA = "0x2485798")]
    public void ActivateBG()
    {
    }

    [Token(Token = "0x6001611")]
    [Address(RVA = "0x24857B8", Offset = "0x24857B8", VA = "0x24857B8")]
    public void DeactivateBG()
    {
    }

    [Token(Token = "0x6001612")]
    [Address(RVA = "0x24857D8", Offset = "0x24857D8", VA = "0x24857D8")]
    public void ActivateViewerBG()
    {
    }

    [Token(Token = "0x6001613")]
    [Address(RVA = "0x2485800", Offset = "0x2485800", VA = "0x2485800")]
    public void DeactivateViewerBG()
    {
    }

    [Token(Token = "0x6001614")]
    [Address(RVA = "0x2485828", Offset = "0x2485828", VA = "0x2485828")]
    public void ActivateArImage(WebCamTexture webCamTexture)
    {
    }

    [Token(Token = "0x6001615")]
    [Address(RVA = "0x2485888", Offset = "0x2485888", VA = "0x2485888")]
    public void DeactivateArImage()
    {
    }

    [Token(Token = "0x6001616")]
    [Address(RVA = "0x24858BC", Offset = "0x24858BC", VA = "0x24858BC")]
    public UnitViewModelViewerPane()
    {
    }

    [Token(Token = "0x6001617")]
    [Address(RVA = "0x24858C4", Offset = "0x24858C4", VA = "0x24858C4", Slot = "4")]
    private Coroutine UnitView\u002EICoroutineWorker\u002EStartCoroutine(IEnumerator routine)
    {
      return (Coroutine) null;
    }

    [Token(Token = "0x6001618")]
    [Address(RVA = "0x24858CC", Offset = "0x24858CC", VA = "0x24858CC", Slot = "5")]
    private void UnitView\u002EICoroutineWorker\u002EStopCoroutine(Coroutine routine)
    {
    }
  }
}
