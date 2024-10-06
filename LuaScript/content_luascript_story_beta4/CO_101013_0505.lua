-- このluaスクリプトは、CO_101013_0505.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_03","112041_03_h")
Include("content_adv_advsmall_112041_03","Template112041_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112041_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112041_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112041_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_002)
	InitializeTemplateRandomCamera112041_03()
	InitializeTemplate112041_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:すんません！<br>先生からの依頼、失敗しちゃいました
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05050002")

	change_face(Actor002,"Serious")

	--★★ガウェイン★★:全部俺のせいです
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05050003")

	change_face(Actor002,"Sad")

	--★★ガウェイン★★:俺が調子に乗って後先考えずに行動したせいです<br>こいつらのことは叱らないでやってください
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05050004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラグネル★★:ガウェイン…
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_05050005")

-- ▼直接出力
PlayPartVoice("ガウェイン", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★ガウェイン★★:いつも世話になってるくせに<br>先生の期待を裏切るようなことしちまって
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05050006")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:恥ずかしいっつーか、みっともないっつーか…<br>本当にすみませんでした！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05050007")


	--★★ヴェルナルス★★:………
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","CO_101013_05050009")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力

	--★★ガウェイン★★:俺、これで失礼します！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05050010")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラグネル★★:あっ、ちょっと！<br>ガウェイン！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_05050012")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
Hide(Actor002)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ヴェルナルス先生<br>今回の件の埋め合わせについては俺も…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05050014")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:気にするな
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","CO_101013_05050015")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05050016")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ヴェルナルス★★:よくやった<br>と伝えてやってくれ
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","CO_101013_05050017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…はい！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05050018")

-- ▼直接出力
local trustParam = set_communication_rankup("ガウェイン_コミュランク", "ガウェイン_親密度")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
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
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
