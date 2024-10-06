-- このluaスクリプトは、PT5_01_0049_2.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
-- ▼直接出力
MobsNo = 2
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
-- ▼直接出力
hideobj01 =get_object("geo_desk_item_02")
hideobj02 =get_object("geo_desk_item_04")
hideobj03 =get_object("geo_desk_item_07")
hideobj04 =get_object("geo_desk_item_10")
hideobj05 =get_object("geo_desk_item_13")
set_pos(hideobj01,{0,-20,0})
set_pos(hideobj02,{0,-20,0})
set_pos(hideobj03,{0,-20,0})
set_pos(hideobj04,{0,-20,0})
set_pos(hideobj05,{0,-20,0})
hideobj06 =get_object("geo_desk_item_06")
hideobj07 =get_object("geo_desk_item_15")
hideobj08 =get_object("geo_desk_item_16")
hideobj09 =get_object("geo_desk_item_01")
set_pos(hideobj06,{0,-20,0})
set_pos(hideobj07,{0,-20,0})
set_pos(hideobj08,{0,-20,0})
set_pos(hideobj09,{0,-20,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "挨拶")
-- ▲直接出力

	--★★クリスティーナ★★:今、この世界はバルバロイによる<br>被害に見舞われているけれど
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:他にも<br>私たちを苦しめる魔物の存在が確認されているわ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490003")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:まずは大きな牙をもつイノシシのような魔物
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:これらは一般的なイノシシよりもはるかに獰猛で<br>人間をエサと認識し、襲い掛かってくるそうよ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490005")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:昔は山や森の奥でしか<br>見られることはなかったけど
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490006")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:生態系に変化が生じたのか<br>最近では人里に下りてくることもあるみたい
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490007")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:次に獣とも猛禽類ともとれる<br>翼をもつ四つ足の魔物
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力

	--★★クリスティーナ★★:さっきのイノシシほどの<br>目撃情報があるわけではないけれど
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:相対した人間の話によれば<br>危険度はイノシシを凌ぐという話ね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490010")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:空から急降下して獲物に襲い掛かり<br>鋭い爪でその息の根を止めると言われているわ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力

	--★★クリスティーナ★★:それから二足歩行するネズミのような魔物も<br>最近たまに見かけられるそうなんだけど
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:この子たちはあまり狂暴ではないみたい<br>見かけたとき優しくしてみてもいいかもね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT5_01_00490013")

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
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
