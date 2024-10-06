-- このluaスクリプトは、MA_01106_36.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_014_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101070021)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101050","001","101050001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
change_weather_cloudy(true)
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	open_select_window_tag(Actor001,"Normal","MA_01106_360003","MA_01106_360004")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:…怪我は平気か、ブライアン将軍
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_360006")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Pain")

	--★★ブライアン将軍★★:これが平気に見えるかよ？<br>おめでてーな
	Talk(Actor002,"CHRNAME_BRIAN","speech","R","MA_01106_360007")

	change_face(Actor002,"Normal")

	--★★ブライアン将軍★★:おめえのつけた傷が一番痛ぇよ
	Talk(Actor002,"CHRNAME_BRIAN","speech","R","MA_01106_360008")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor002,"Normal")

	--★★ブライアン将軍★★:終わったのか？
	Talk(Actor002,"CHRNAME_BRIAN","speech","R","MA_01106_360010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ<br>モルガン先生は救出できたし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_360011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタンがひとまわり成長できた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_360012")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたの真意はまだわからないけど…<br>ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_360013")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Surprise")

	--★★ブライアン将軍★★:真意をわからずに礼を言うのか？<br>まったく、どうかしてるぜ
	Talk(Actor002,"CHRNAME_BRIAN","speech","R","MA_01106_360014")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★ブライアン将軍★★:相変わらず気の利かねえガキだ<br>こっちは大ケガしてるってのによ…
	Talk(Actor002,"CHRNAME_BRIAN","speech","R","MA_01106_360016")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:ディナタンの歌を聞けば<br>すぐに治るんじゃなかったっけ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_360017")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ブライアン将軍★★:口ばっかり達者でよォ<br>誰に似たんだか
	Talk(Actor002,"CHRNAME_BRIAN","speech","R","MA_01106_360018")


	--★★ノワール★★:誰だろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_360020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:もう置き去りにしない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_360021")

	change_face(Actor002,"Anger")

	--★★ブライアン将軍★★:…
	Talk(Actor002,"CHRNAME_BRIAN","speech","R","MA_01106_360022")


	--★★ノワール★★:あんたは「金でしか動かない」んだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_360023")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ブライアン将軍★★:…あんだよ、しっかり覚えていやがって
	Talk(Actor002,"CHRNAME_BRIAN","speech","R","MA_01106_360024")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:だから迎えに来たんだよ<br>金色コートが
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_360025")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101070021)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101050","001","101050001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
