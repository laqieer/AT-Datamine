-- このluaスクリプトは、CO_101034_0502.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110101_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_001)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
DontChangeRandomCamera(true)
turn_lookat(Actor003,Actor001,0)
prop001=setup_prop_object(10106003)
prop001_offset={-0.169,-0.014,-0.006,-3.4,90,0}
off_active(prop001)
prop002=setup_prop_object(10106003)
prop002_offset={-0.18,-0.05,-0.03,-20,90,15}
off_active(prop002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:――以上がここ最近のバルバロイによる被害のまとめだ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101034_05020002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★ケイ★★:１度や２度ならそれほど深刻な被害ではないしかし、ここ最近のひん度はさすがに異常だ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101034_05020004")

-- ▼直接出力
setup_small_camera_start(Camera002)
PlayActionDirect(Actor003,"to LookFor")
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:報告させていただくわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05020005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
se_play("SE_ADV_MA_01105_28_Paper")
on_parent(prop001,Actor002, "J_Hand_R", prop001_offset)
on_active(prop001)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to Show")
on_parent(prop002,Actor003, "J_Hand_L", prop002_offset)
on_active(prop002)
-- ▲直接出力

	--★★エクセリア★★:この地図を見て
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05020006")

-- ▼直接出力
off_parent(prop001)
off_active(prop001)
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:これは？
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101034_05020008")


	--★★エクセリア★★:最近バルバロイが出現した地点を記した地図よ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05020009")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:こうして見てみるとかなり狭い範囲に密集しているな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_05020010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:そう。バルバロイはとある地点を中心に一定の範囲内に現れている
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05020011")


	--★★エクセリア★★:そこに魔女が作り出したバルバロイの発生源があるはずよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05020012")

-- ▼直接出力
setup_small_camera_start(Camera001)
PlayActionDirect(Actor002,"to  Std_Talk")
off_parent(prop002)
off_active(prop002)
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:とある地点…<br>この森は…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_05020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
PlayPartVoice("ケイ", "納得")
-- ▲直接出力

	--★★ケイ★★:報告は以上だろうか？
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101034_05020015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:ええ、以上よそしてそのうえでひとつ提案させて
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05020016")

-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:提案？
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101034_05020017")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力

	--★★エクセリア★★:バルバロイの襲撃に対する防備の強化そして発生源を叩くことよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05020018")


	--★★エクセリア★★:バルバロイが出現する地点はおおよそ見当がつくわけだから
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05020019")


	--★★エクセリア★★:そこを包囲するように兵士を配置し被害がこれ以上拡大することを防ぎつつ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05020020")


	--★★エクセリア★★:発生源の正確な場所を突き止めて一刻も早く叩いてしまうべきよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_05020021")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "肯定3")
-- ▲直接出力

	--★★ケイ★★:なるほど先手先手を打っていくわけだな
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101034_05020023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "納得")
-- ▲直接出力

	--★★トリスタン★★:発生源を探して叩くのはボクとイゾルデに任せてよ
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","CO_101034_05020024")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "納得")
-- ▲直接出力

	--★★ケイ★★:頼む、トリスタン
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101034_05020025")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_エクセリア_ランクアップ5_3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10106003)
prop001_offset={-0.169,-0.014,-0.006,-3.4,90,0}
setup_prop_object_preload(10106003)
prop002_offset={-0.18,-0.05,-0.03,-20,90,15}
	InitializeLoad_Preload()
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
