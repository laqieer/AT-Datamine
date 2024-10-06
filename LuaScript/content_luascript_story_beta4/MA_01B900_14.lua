-- このluaスクリプトは、MA_01B900_14.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_01","110141_01_h")
Include("content_adv_advsmall_110141_01","Template110141_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_005)
	InitializeTemplateRandomCamera110141_01()
	InitializeTemplate110141_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ガラハッド★★:どこへ…？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_140002")


	--★★ディナタン★★:戦況も落ち着いたし遠出したがってたから<br>私、病室番してますよって言ったの
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B900_140003")

	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:出て行った？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_140004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:ガウェインさんがね<br>モルガン先生にお願いされたら張り切っちゃって
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B900_140005")

	change_face(Actor001,"Smile")

	--★★ディナタン★★:ああ見えてサプライズとか<br>好きなんだね、モルガン先生
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B900_140006")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ディナタン★★:どうせなら賑やかなほうがって<br>笑ってた
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B900_140007")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:こっそりアーサー様についていこうかなって
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B900_140008")

-- ▼直接出力
se_play("SE_ADV_MA_01B900_06_HeartBeat")
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
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
