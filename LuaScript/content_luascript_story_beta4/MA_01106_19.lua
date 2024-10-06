-- このluaスクリプトは、MA_01106_19.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_03_SleepController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_mcfc_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110141_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_008)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
force_eyesync(Actor001,"Close")
reserve_eyesync(Actor001,"Close")
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
SetOffset(Actor002,-0.1,-0.1,0)
-- ▲直接出力
-- ▼直接出力
setup_huton_110141_02()
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101017","003","101017003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor003,"Sad")

	--★★ディナタン★★:ど、どうなんですか？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01106_190002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★イゾルデ★★:大丈夫<br>落ち着いたわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_190003")


	--★★トリスタン★★:モルガン先生には劣るかもしれないけど<br>イゾルデの薬学の知識は一級品だよ
	Talk(Actor005,"CHRNAME_TRISTAN","speech","L","MA_01106_190004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:あのとき、モルガン先生は<br>『狂忘症』と言っていたわよね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_190005")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:マルディサントの家族が患ったっていう…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01106_190006")

	PlayAction(Actor002,"to Sit01_Talk")
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:彼女にも病巣があったってこと
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_190007")


	--★★イゾルデ★★:魔女と名乗るバルバロイが彼女に近づき<br>病状が悪化したってわけね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_190008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★イゾルデ★★:あまり言いたくはないけれど<br>連れ出すべきではなかったわね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_190009")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★ディナタン★★:ど、どうすれば治るんですか！？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01106_190011")

	change_face(Actor002,"Sad")

	--★★イゾルデ★★:…わからないわ<br>でもモルガン先生なら、ひょっとして…
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_190012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:わ、わ、私…彼女にできることは
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01106_190013")

	change_face(Actor002,"Normal")

	--★★イゾルデ★★:ないわ<br>私たち誰にもね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01106_190014")

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
	InitializeCharacter_3D_Preload("101017","003","101017003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
