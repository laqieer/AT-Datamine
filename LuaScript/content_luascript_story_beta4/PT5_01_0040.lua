-- このluaスクリプトは、PT5_01_0040.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:前回の授業の反響が大きかったから<br>今回も妖精について話していこうかしら♪
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00400002")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:妖精と人間とが共生関係にあったっていう話は<br>覚えてるわよね？
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00400003")


	--★★クリスティーナ★★:妖精は不思議な力で人間に平穏を与え<br>代わりに人間は妖精を守っていたの
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00400004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力

	--★★クリスティーナ★★:コルベニック王国のお城は<br>まさに妖精を守るために築かれたという話だし
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00400005")


	--★★クリスティーナ★★:ブリテン島の東部には<br>妖精の守り手たちが住む地もあったそうよ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00400006")

	PlayAction(Actor005,"to  Std_Worry")

	--★★クリスティーナ★★:私も本で読んだり<br>人づてに聞いた話だから詳しくは知らないけど
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00400007")

	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:妖精は姿を消してしまったものの<br>妖精にまつわる者はまだ生き残りがいるみたい
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00400008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力

	--★★クリスティーナ★★:彼らとコンタクトをとることができれば<br>妖精が姿を消した理由が聞けるかもしれないわね
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00400009")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115020)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
