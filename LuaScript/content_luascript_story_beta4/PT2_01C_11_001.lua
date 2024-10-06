-- このluaスクリプトは、PT2_01C_11_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:ノワールくん、おはよう！
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT2_01C_11_0010007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:おはよう<br>朝から元気だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0010008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力

	--★★フレン★★:それが取り柄だからね～！
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT2_01C_11_0010009")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★フレン★★:元気といえば<br>あれからディナタンちゃんの様子はどう？
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT2_01C_11_0010010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:自分はもう大丈夫だからって<br>療養院から追い出されたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0010011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:…お互い気を使い合ってるんだね<br>きょうだい仲が良いのが一番だよ、うんうん！
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT2_01C_11_0010012")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0010013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:ローラになにかあったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0010014")

-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:えっ？
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT2_01C_11_0010015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ローマに付いてっちゃったけど<br>フレンはローラと連絡取り合ってんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0010016")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "悩む")
-- ▲直接出力

	--★★フレン★★:や、やだなー！突然なに？
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT2_01C_11_0010017")

	change_face(Actor002,"Normal")

	--★★フレン★★:なにもないよ？<br>さっきそこでラシアと
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT2_01C_11_0010018")


	--★★フレン★★:ローラがハロウィンの日までに<br>戻ってきたらいいねーって話してたくらい！
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT2_01C_11_0010019")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:…それならいいけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0010020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:なにかったら、いつでも言ってくれ<br>相談に乗るよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0010021")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:ありがと<br>ノワールくんは頼りになるね…
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT2_01C_11_0010022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:じゃ、私、これからクラスの子とお出かけだから<br>またね！
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT2_01C_11_0010023")

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
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
