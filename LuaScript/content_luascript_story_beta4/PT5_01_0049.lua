-- このluaスクリプトは、PT5_01_0049.csvから自動生成されました --
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

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "挨拶")
-- ▲直接出力

	--★★クリスティーナ★★:今、この世界はバルバロイによる<br>被害に見舞われているけれど
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490002")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Sad")

	--★★クリスティーナ★★:他にも<br>私たちを苦しめる魔物の存在が確認されているわ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490003")

	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:まずは大きな牙をもつイノシシのような魔物
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★クリスティーナ★★:これらは一般的なイノシシよりもはるかに獰猛で<br>人間をエサと認識し、襲い掛かってくるそうよ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490005")

	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:昔は山や森の奥でしか<br>見られることはなかったけど
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490006")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Sad")

	--★★クリスティーナ★★:生態系に変化が生じたのか<br>最近では人里に下りてくることもあるみたい
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490007")

	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:次に獣とも猛禽類ともとれる<br>翼をもつ四つ足の魔物
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力

	--★★クリスティーナ★★:さっきのイノシシほどの<br>目撃情報があるわけではないけれど
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490009")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Sad")

	--★★クリスティーナ★★:相対した人間の話によれば<br>危険度はイノシシを凌ぐという話ね
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490010")

	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:空から急降下して獲物に襲い掛かり<br>鋭い爪でその息の根を止めると言われているわ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力

	--★★クリスティーナ★★:それから二足歩行するネズミのような魔物も<br>最近たまに見かけられるそうなんだけど
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490012")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:この子たちはあまり狂暴ではないみたい<br>見かけたとき優しくしてみてもいいかもね
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490013")

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
