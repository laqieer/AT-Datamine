-- このluaスクリプトは、MA_01A900_18.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110131_01","110131_01_h")
Include("content_adv_advsmall_110131_01","Template110131_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110131_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110131_01,CameraPos110131_01_003)
	Camera002 = SetTemplate("Actor002",-110,CharaPos110131_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110131_01,CameraPos110131_01_004)
	InitializeTemplateRandomCamera110131_01()
	InitializeTemplate110131_01()
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002, "J_Head", 0.8)
keep_delay_ik_lookat(Actor002,Actor001, "J_Head", 0.8)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110131)
	Actor001 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:その気の遠くなるような未来で<br>目覚めたとき…
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01A900_180002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★トリスタン★★:彼女にはまた武器としての<br>孤独な戦いが待ってる
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01A900_180003")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★トリスタン★★:想い人をひとりぼっちにできるかな<br>互いにそうだろうけど
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","MA_01A900_180005")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110131)
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110131_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
