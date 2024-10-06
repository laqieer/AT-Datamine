-- このluaスクリプトは、PT2_01B_12_006.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:おはよー、ノワール！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","PT2_01B_12_0060002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マーリン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マーリン★★:降誕祭はご苦労様でした<br>子供たち、喜んでいましたね
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_12_0060003")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ギネヴィアにマーリンさん？<br>ふたりでここに来るなんて珍しいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0060004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:コルベニック城で助けてもらったのに<br>ちゃんとお礼を言ってなかったから
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","PT2_01B_12_0060005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マーリン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:あらためまして<br>ありがとうございました
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_12_0060006")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺は全然大したことはしてないよ<br>ランスロットやガラハッドの活躍のおかげさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0060007")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:謙遜しちゃって！<br>このこの～♪
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","PT2_01B_12_0060008")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:これで聖杯を巡る戦いは<br>一段落したといっていいのかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0060009")


	--★★ノワール★★:あとは聖杯を使って<br>バルバロイを殲滅するだけか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0060010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("マーリン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:そううまくいくと良いのですが…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_12_0060011")


	--★★ノワール★★:アーサーのこと…ですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0060012")

-- ▼直接出力
PlayPartVoice("マーリン", "落胆")
-- ▲直接出力

	--★★マーリン★★:………
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_12_0060013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:………
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","PT2_01B_12_0060014")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:ほ、ほらほら！<br>もうすぐ新年なんだから湿った顔はナシナシ！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","PT2_01B_12_0060015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そ、そうだな、ギネヴィアの言うとおり！<br>明るく年を越さないと！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_12_0060016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マーリン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マーリン★★:…はい、そうですね
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_12_0060017")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
