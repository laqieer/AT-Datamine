-- このluaスクリプトは、PT2_01B_11_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115907)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("マーリン", "挨拶")
-- ▲直接出力

	--★★マーリン★★:ノワール様<br>少々よろしいでしょうか？
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0030005")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:マーリンさん？<br>珍しいですね、なんでしょう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0030006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:次の月曜日なのですが
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0030007")


	--★★マーリン★★:療養中のアーサー様へ荷物をお届けするため<br>グラストンベリーに行こうと思っています
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0030008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★マーリン★★:もしよろしければ<br>ノワール様もご一緒にいかがでしょうか？
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0030009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:どうして俺が<br>グラストンベリーに行こうとしていることを？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0030010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…ひょっとしてケイから？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0030011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力

	--★★マーリン★★:ええ。少し前にランスロット様が<br>お見舞いに行かれたのですが…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0030012")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ランスロットも行ってたのか<br>どうりで、ここ数日見かけなかったわけだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0030013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか…。ランスロットがいるなら<br>アーサーの身は安全ですね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0030014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マーリン", "否定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:いえ、それが…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0030015")


	--★★マーリン★★:アーサー様はランスロット様と<br>ともに過ごせるのが嬉しいようで
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0030016")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("マーリン", "落胆")
-- ▲直接出力

	--★★マーリン★★:療養そっちのけで騒いでいるそうなのです
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0030017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マーリン★★:それをケイ様は心配しておられます
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0030018")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:な、なるほど…<br>ランスロットの困り顔が目に浮かびます
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0030019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マーリン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マーリン★★:ふふっ<br>そうですね
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0030020")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:でも<br>ふたりがそんなに仲が良いとは思わなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0030021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マーリン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:アーサー様とランスロット様は<br>長い付き合いになりますから
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0030022")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そっか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0030023")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マーリン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マーリン★★:ふふっ…<br>妬けちゃいますか？
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","PT2_01B_11_0030024")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ええっ！？い、いや、その…<br>からかわないでくださいよ、マーリンさん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_11_0030025")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115907)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
