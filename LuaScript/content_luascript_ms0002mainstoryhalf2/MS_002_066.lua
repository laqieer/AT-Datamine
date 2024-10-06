-- このluaスクリプトは、MS_002_066.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_02_ms0002_01_Controller","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_513_01_ms0002_01_Controller","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to MS002_066_Sit10_Loop")
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
RCUT_11 = set_camera({0,2.83,-19.09,0,0,0,28})
RndCamera001 = RCUT_11
-- ▲直接出力
-- ▼直接出力
CameraEx = set_camera({5.4,2.9,-6.59,-14,-13.76,0,40})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115074)
	Actor001 = InitializeCharacter_3D("101001","002","101001002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101068","002","101068002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101059","001","101059001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera006)
Appear(Actor001)
PlayActionDirect(Actor001,"to MS002_066_RunEnd_pose")
wait_time(1)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ティルフィング★★:ウレリー様
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0660004")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to MS002_066_RunEnd")
wait_time(1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to MS002_066_Sit10LookUp_Start")
PlayPartVoiceDirect("ウレリー","0085")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ウレリー★★:ティルフィングさん…？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0660006")

-- ▼直接出力
setup_small_camera_end(RndCamera006)
-- ▲直接出力
-- ▼直接出力
set_animationcontroller(Actor001, "Chr_521_01_StdController", "to Std_Loop")
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ティルフィング★★:お怪我は
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0660007")

-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0071")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ウレリー★★:…あはは、だいぶ、いろいろ痛いけど…<br>なんとか…大丈夫
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0660008")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ティルフィング","swim_0009")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ティルフィング★★:………よかった
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0660009")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(Camera001)
setup_small_camera_start()
PlayActionDirect(Actor002,"to MS002_066_Sit10_End")
wait_time(2.4)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アルハン","0033")
-- ▲直接出力

	--★★アルハン★★:本来であれば<br>ウレリーはディナタンを守り、死ぬはずであった
	Talk(Actor003,"NPCNAME_0313","speech","L","MS_002_0660011")

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Talk")
-- ▲直接出力

	--★★アルハン★★:…ディナタンは、ティルフィングからすれば<br>守るべき継承者の選択肢のひとり──
	Talk(Actor003,"NPCNAME_0313","speech","L","MS_002_0660012")


	--★★アルハン★★:それを自身で守れず、ウレリーという犠牲を<br>出してしまったという追い目があったのだろう
	Talk(Actor003,"NPCNAME_0313","speech","L","MS_002_0660013")

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Yes")
-- ▲直接出力

	--★★アルハン★★:そしてノワールも、誰にも打ち明けられぬ後悔を<br>一生抱えていく………はずだった
	Talk(Actor003,"NPCNAME_0313","speech","L","MS_002_0660014")


	--★★アルハン★★:その破滅の運命をキサマが変えたのだ<br><%player>
	Talk(Actor003,"NPCNAME_0313","speech","L","MS_002_0660015")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
setup_small_camera_end()
set_animationcontroller(Actor002, "Nbl_f_StdController", "to Std_Loop")
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ティルフィング","swim_0002")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ティルフィング★★:………ウレリー様<br>お伝え忘れていたことがありました
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0660016")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0064")
-- ▲直接出力

	--★★ウレリー★★:…なに？ティルフィングさん
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0660017")

-- ▼直接出力
PlayActionDirect(Actor001,"to Bow")
PlayPartVoiceDirect("ティルフィング","0036")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ティルフィング★★:一緒のクラスにしてくださり<br>ありがとうございます
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0660018")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0026")
-- ▲直接出力

	--★★ウレリー★★:………ううん<br>あんなのただのおせっかいだよ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0660019")

-- ▼直接出力
setup_small_camera_end(RndCamera008)
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ティルフィング★★:運命をなぞろうということに必死で<br>その日常を好ましく思う余裕がありませんでした
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0660020")

	PlayAction(Actor001,"to  Std_Joy")
	change_face(Actor001,"Laugh")

	--★★ティルフィング★★:ですが「この学園にいていいのだ」と思えました<br>アナタの言葉は、私にとって救いでした
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0660021")


	--★★ウレリー★★:そっ、か
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0660022")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayPartVoiceDirect("ティルフィング","swim_0019")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ティルフィング★★:私は──…いつか
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0660023")


	--★★ティルフィング★★:ここを離れることとなります<br>恐らくは、近いうちに
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0660024")

-- ▼直接出力
setup_small_camera_end(Camera001)
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayPartVoiceDirect("ウレリー","0085")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ウレリー★★:え？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0660025")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ティルフィング★★:ですが、それまではアナタに──
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0660026")

-- ▼直接出力
PlayPartVoiceDirect("ティルフィング","swim_0010")
-- ▲直接出力

	--★★ティルフィング★★:教えてほしいことが<br>たくさんあります
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0660027")


	--★★ウレリー★★:………！
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0660028")

-- ▼直接出力
setup_small_camera_end(Camera002)
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayPartVoiceDirect("ウレリー","0078")
-- ▲直接出力
	change_face(Actor002,"Special")

	--★★ウレリー★★:うん。うん、うん…っ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0660030")

-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0067")
-- ▲直接出力

	--★★ウレリー★★:まだまだ、教えてあげる 
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0660031")

-- ▼直接出力
CloseTalkWindow()
wait_time(2)
setup_small_camera_end(RndCamera005)
setup_small_camera_start(CameraEx)
wait_time(0.2)
turn(CameraEx,-16,-13.76,0,4)
wait_time(5.4)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115074)
	InitializeCharacter_3D_Preload("101001","002","101001002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101068","002","101068002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101059","001","101059001")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
