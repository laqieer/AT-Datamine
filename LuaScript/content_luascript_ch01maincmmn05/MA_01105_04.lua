-- このluaスクリプトは、MA_01105_04.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-160,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_008)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
set_pos(Actor001,{-0.95,0,3})
PlayActionDirect(Actor003,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
BgProp = setup_prop_object(10102009)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor006")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(1)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{-0.95,0,1.45},1)
wait_time(0.8)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.5)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.5)
PlayActionDirect(Actor002,"to  Std_Surp")
turn_chara(Actor002,-20,0.5)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:…に、兄さあん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_040002")

	open_select_window_tag(Actor001,"Normal","MA_01105_040004","MA_01105_040005","MA_01105_040006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to Greet_one")
	change_face(Actor001,"Normal")

	--★★ノワール★★:さがしたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_040008")

	change_face(Actor001,"Smile")

	--★★ノワール★★:せっかくだし<br>ふたりで祭を見て回らないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_040009")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-100,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:す、すみません皆さん…<br>あの、兄が心配するので──…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_040010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:モテモテだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_040012")

	change_face(Actor001,"Smile")

	--★★ノワール★★:ジャマ者は退散したほうがいいかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_040013")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ディナタン★★:もう！意地悪…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_040014")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-115.69,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:物珍しがられてるだけだよ…<br>すみません、あの、兄が来たので──…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_040015")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
lookat_delay_weight_reset(Actor001,1)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:俺の妹に手を出すな！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_040017")

	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Anger")

	--★★ノワール★★:これ以上やってみろ<br>…容赦はしないぞ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_040018")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:に、兄さん！違うのー！<br>少しお話してただけだから！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_040019")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
turn_chara(Actor002,-30,0)
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
PlayActionDirect(Actor002,"to Std_Loop")
setup_small_camera_start(RndCamera005)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…事前の合意が重要なんだって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_040021")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:じ、事前の合意…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_040022")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ディナタン★★:『五月女王になったとしたら、僕とどうですか』<br>って…、私なんか選ばれないのに、恥ずかしい…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_040023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Sad")

	--★★ノワール★★:ゆ、誘拐の予約…！<br>ディナタンは、その、受けたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_040024")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
wait_time(0.9)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★ディナタン★★:………受けたよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_040025")

-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_040026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ディナタン★★:って言ったらどうするの？兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01105_040028")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102009)
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor006")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
