-- このluaスクリプトは、PT2_01_06_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002,0.5,0.1,0.85,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:…これでよし、っと
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_06_0020008")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ディナタン、なにしてるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_06_0020009")

-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:今度の戦いに向けて<br>医療キットの中身を整理してたの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_06_0020010")


	--★★ディナタン★★:みんなたぶんケガしちゃうでしょ？<br>薬が足りないといけないから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_06_0020011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そっか<br>頼もしいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_06_0020012")


	--★★ディナタン★★:いつもより<br>うんと多めに用意しておいたんだ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_06_0020013")

-- ▼直接出力
PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:たぶん大ケガしちゃうでしょ？<br>…ブライアンさん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_06_0020014")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:たぶんじゃなくて…確実だな<br>ブライアン、いつもキズだらけだったし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_06_0020015")

-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:どんなに大ケガしても<br>私が絶対治してあげるんだ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_06_0020016")


	--★★ディナタン★★:モルガン先生に<br>いろいろ教わったんだから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_06_0020017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ディナタン★★:助けようね、ふたりとも
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_06_0020018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ<br>絶対に助けてみせる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_06_0020019")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
